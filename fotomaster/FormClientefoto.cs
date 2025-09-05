using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Emgu.CV;
using Emgu.CV.Structure;

namespace fotomaster
{
    public partial class FormClientefoto : Form
    {
        private DataTable dtClientes = new DataTable();
        private int idClienteSeleccionado = 0;

        // IA
        private FaceEmbeddingService _faceService;
        private string _modelsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "models");
        private const double MATCH_THRESHOLD = 0.60; // Ajustable (0.6 ~ estándar FR)
        private Bitmap queryBitmap;

        public FormClientefoto()
        {
            InitializeComponent();
            CargarClientes();

            // 🔹 Conectar eventos del buscador
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            listClientes.Click += listClientes_Click;
            // 🔹 Ocultar el ListBox al inicio
            listClientes.Visible = false;
            dgvFotos.CellClick += dgvFotos_CellClick;
            // this.btndescargar.Click += new EventHandler(this.btndescargar_Click);

            // === Inicializa IA ===
            try
            {
                _faceService = new FaceEmbeddingService(_modelsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IA no inicializada: " + ex.Message, "Modelos Dlib", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        
            btnBuscarPorFoto.Click += btnBuscarPorFoto_Click;
            BtnIndexarEmbeddings.Click += BtnIndexarEmbeddings_Click;

            // === Botones de diagnóstico ===
            btnCheckEmbeddings.Click += btnCheckEmbeddings_Click; // contar embeddings faltantes
            btnTestSelf.Click += btnTestSelf_Click;
        }






        private void btnvolver_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            this.Close();
        }

        private void CargarClientes()
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT c.idCliente, CONCAT(p.nombre, ' ', p.apellido) AS nombreCompleto
                FROM Cliente c
                JOIN Persona p ON c.idCliente = p.idPersona";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    dtClientes.Clear();
                    da.Fill(dtClientes);

                    // Al inicio no mostramos nada en el ListBox
                    listClientes.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }

        private void CargarFotosCliente(int idCliente)
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "SELECT idFoto, fotobinario, fecha FROM fotodigital WHERE idCliente=@idCliente";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtFotos = new DataTable();
                da.Fill(dtFotos);

                DataTable dtConImagen = new DataTable();
                dtConImagen.Columns.Add("Foto", typeof(System.Drawing.Image));
                dtConImagen.Columns.Add("Fecha", typeof(DateTime));

                foreach (DataRow row in dtFotos.Rows)
                {
                    byte[] bytesImagen = (byte[])row["fotobinario"];
                    using (MemoryStream ms = new MemoryStream(bytesImagen))
                    {
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        dtConImagen.Rows.Add(img, row["fecha"]);
                    }
                }

                dgvFotos.DataSource = dtConImagen;
                dgvFotos.RowTemplate.Height = 100;
                dgvFotos.Columns["Foto"].Width = 100;
                ((DataGridViewImageColumn)dgvFotos.Columns["Foto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarCliente.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                listClientes.DataSource = null;
                listClientes.Visible = false;
                return;
            }

            DataView dv = dtClientes.DefaultView;
            dv.RowFilter = string.Format("nombreCompleto LIKE '%{0}%'", texto.Replace("'", "''"));
            if (dv.Count > 0)
            {
                listClientes.DataSource = dv;
                listClientes.DisplayMember = "nombreCompleto";
                listClientes.ValueMember = "idCliente";
                listClientes.Visible = true;
            }
            else
            {
                listClientes.DataSource = null;
                listClientes.Visible = false;
            }
        }

        private void listClientes_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedIndex != -1)
            {
                idClienteSeleccionado = Convert.ToInt32(
                    ((DataRowView)listClientes.SelectedItem)["idCliente"]
                );

                // Mostrar el nombre en el TextBox
                txtBuscarCliente.Text = listClientes.Text;

                // Ocultar la lista
                listClientes.Visible = false;

                // 🔹 Cargar fotos de este cliente en el DataGridView
                CargarFotosCliente(idClienteSeleccionado);
            }
        }

        private void dgvFotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // evitar cabecera
            {
                DataGridViewRow row = dgvFotos.Rows[e.RowIndex];

                if (row.Cells["Foto"].Value != null && row.Cells["Foto"].Value is System.Drawing.Image)
                {
                    pictureBox1.Image = (System.Drawing.Image)row.Cells["Foto"].Value;
                }
            }
        }


        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    sfd.Title = "Guardar imagen";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // 🔹 Clonar la imagen para evitar bloqueo de GDI+
                        using (Bitmap bmp = new Bitmap(pictureBox1.Image))
                        {
                            bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        MessageBox.Show("Imagen guardada correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen en el PictureBox");
            }
        }

        /* private void btnIndexarEmbeddings_Click(object sender, EventArgs e)
         {
             if (_faceService == null)
             {
                 MessageBox.Show("No se inicializó el servicio de IA. Verifica carpeta 'models'.");
                 return;
             }

             using (var con = Conexion.ObtenerConexion())
             {
                 con.Open();

                 string selectSql = @"SELECT idFoto, fotobinario FROM fotodigital WHERE embedding IS NULL OR OCTET_LENGTH(embedding)=0";
                 using (var sel = new MySqlCommand(selectSql, con))
                 using (var reader = sel.ExecuteReader())
                 {
                     var pendientes = new List<FotoRegistro>();
                     while (reader.Read())
                     {
                         pendientes.Add(new FotoRegistro
                         {
                             IdFoto = reader.GetInt32("idFoto"),
                             FotoBytes = (byte[])reader["fotobinario"]
                         });
                     }
                     reader.Close();

                     foreach (var item in pendientes)
                     {
                         using (var ms = new MemoryStream(item.FotoBytes))
                         using (var bmp = new Bitmap(ms))
                         {
                             var enc = _faceService.GetEncodingFromBitmap(bmp);
                             if (enc == null)
                                 continue; // No rostro encontrado

                             var encBytes = FaceEmbeddingService.DoubleArrayToBytes(enc);
                             string updSql = "UPDATE fotodigital SET embedding=@emb WHERE idFoto=@id";
                             using (var upd = new MySqlCommand(updSql, con))
                             {
                                 upd.Parameters.Add("@emb", MySqlDbType.VarBinary).Value = encBytes;
                                 upd.Parameters.Add("@id", MySqlDbType.Int32).Value = item.IdFoto;
                                 upd.ExecuteNonQuery();
                             }
                         }
                     }
                 }
             }

             MessageBox.Show("Indexación de embeddings finalizada.");
         }    */

        // ========================================================
        // IA: Buscar por foto (desde archivo)
        // ========================================================



        private void BtnIndexarEmbeddings_Click_1(object sender, EventArgs e)
        {
            List<FotoRegistro> registros = CargarFotosConEmbeddings();
            int count = 0;

            foreach (var reg in registros)
            {
                if (reg.Embedding == null)
                {
                    Bitmap bmp = ByteArrayToBitmap(reg.FotoBytes);
                    reg.Embedding = _faceService.GetEncodingFromBitmap(bmp);

                    if (reg.Embedding != null)
                    {
                        ActualizarEmbeddingBD(reg.IdFoto, reg.Embedding);
                        count++;
                    }
                }
            }

            MessageBox.Show($"Embeddings generados/actualizados: {count}");
        }



        public void InsertarFotoConEmbedding(int idCliente, Bitmap foto)
        {
            if (_faceService == null)
                throw new InvalidOperationException("Servicio IA no inicializado.");

            // 1) Serializar imagen a bytes
            byte[] imgBytes;
            using (var ms = new MemoryStream())
            {
                foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imgBytes = ms.ToArray();
            }

            // 2) Calcular embedding
            double[] enc = _faceService.GetEncodingFromBitmap(foto);
            byte[] encBytes = enc != null ? FaceEmbeddingService.DoubleArrayToBytes(enc) : new byte[0];
            if (enc == null)
            {
                MessageBox.Show("No se detectó rostro en la foto. No se guardará embedding.");
            }
            // 3) Insertar en BD
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO fotodigital(idCliente, fotobinario, fecha, embedding) VALUES(@c, @f, NOW(), @e)";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@c", MySqlDbType.Int32).Value = idCliente;
                    cmd.Parameters.Add("@f", MySqlDbType.LongBlob).Value = imgBytes;
                    cmd.Parameters.Add("@e", MySqlDbType.VarBinary).Value = (object)encBytes ?? DBNull.Value;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ========================================================
        // Limpieza
        // ========================================================
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _faceService?.Dispose();
            _faceService = null;
        }

        private List<FotoRegistro> CargarFotosConEmbeddings()
        {
            var lista = new List<FotoRegistro>();

            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "SELECT idFoto, idCliente, fotobinario, fecha, embedding FROM fotodigital";
                MySqlCommand cmd = new MySqlCommand(query, con);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] fotoBytes = (byte[])reader["fotobinario"];
                        byte[] embeddingBytes = reader["embedding"] != DBNull.Value ? (byte[])reader["embedding"] : null;

                        lista.Add(new FotoRegistro
                        {
                            IdFoto = Convert.ToInt32(reader["idFoto"]),
                            IdCliente = Convert.ToInt32(reader["idCliente"]),
                            Fecha = Convert.ToDateTime(reader["fecha"]),
                            FotoBytes = fotoBytes,
                            Embedding = embeddingBytes != null ? FaceEmbeddingService.BytesToDoubleArray(embeddingBytes) : null
                        });
                    }
                }
            }

            return lista;
        }

        private void MostrarResultados(List<FotoRegistro> resultados)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Foto", typeof(System.Drawing.Image));
            dt.Columns.Add("Fecha", typeof(DateTime));

            foreach (var r in resultados)
            {
                using (MemoryStream ms = new MemoryStream(r.FotoBytes))
                {
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    dt.Rows.Add(img, r.Fecha);
                }
            }

            dgvFotos.DataSource = dt;
            dgvFotos.RowTemplate.Height = 100;
            dgvFotos.Columns["Foto"].Width = 100;
            ((DataGridViewImageColumn)dgvFotos.Columns["Foto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private Bitmap ByteArrayToBitmap(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Bitmap(ms);
            }
        }

        private void ActualizarEmbeddingBD(int idFoto, double[] embedding)
        {
            byte[] bytes = FaceEmbeddingService.DoubleArrayToBytes(embedding);
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE fotodigital SET embedding=@embedding WHERE idFoto=@idFoto";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@embedding", bytes);
                cmd.Parameters.AddWithValue("@idFoto", idFoto);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnTestSelf_Click(object sender, EventArgs e)
        {
            var regs = CargarFotosConEmbeddings();
            var uno = regs.FirstOrDefault(r => r.Embedding != null);
            if (uno != null)
            {
                using (var ms = new MemoryStream(uno.FotoBytes))
                using (var bmp = new Bitmap(ms))
                {
                    var again = _faceService.GetEncodingFromBitmap(bmp);
                    if (again == null)
                    {
                        MessageBox.Show("No se detectó rostro o el embedding fue inválido.");
                    }
                    else
                    {
                        double d = FaceEmbeddingService.Euclidean(again, uno.Embedding);
                        MessageBox.Show($"Distancia foto vs. sí misma: {d:0.000}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registros con embedding en la BD.");
            }
        }

        private void btnCheckEmbeddings_Click(object sender, EventArgs e)
        {
            var regs = CargarFotosConEmbeddings();
            int sinEmb = regs.Count(r => r.Embedding == null);
            MessageBox.Show($"Fotos cargadas: {regs.Count}\nSin embedding: {sinEmb}");
        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {

            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Cargar imagen consulta en pictureBox1 y en queryBitmap
                    using (var temp = new Bitmap(ofd.FileName))
                    {
                        pictureBox1.Image = new Bitmap(temp);
                        queryBitmap = new Bitmap(temp); // muy importante, se usará luego en la búsqueda
                    }
                }
            }

        }

        private void ForzarReindexacionCompleta()
        {
            List<FotoRegistro> registros = CargarFotosConEmbeddings();
            int count = 0;

            foreach (var reg in registros)
            {
                Bitmap bmp = ByteArrayToBitmap(reg.FotoBytes);
                double[] nuevoEmbedding = _faceService.GetEncodingFromBitmap(bmp);

                if (nuevoEmbedding != null)
                {
                    ActualizarEmbeddingBD(reg.IdFoto, nuevoEmbedding);
                    count++;
                }
            }
        }

        private void btnBuscarPorFoto_Click(object sender, EventArgs e)
        {
            if (queryBitmap == null)
            {
                MessageBox.Show("Cargar primero una foto de consulta.");
                return;
            }

            ForzarReindexacionCompleta();

            double[] queryEmbedding = _faceService.GetEncodingFromBitmap(queryBitmap);
            if (queryEmbedding == null)
            {
                MessageBox.Show("No se detectó rostro en la foto de consulta.");
                return;
            }

            // 🔹 Aquí añadimos validaciones antes de comparar
            if (queryEmbedding.Any(x => double.IsNaN(x)))
            {
                MessageBox.Show("El embedding de la foto consulta contiene valores inválidos (NaN).");
                return;
            }

            List<FotoRegistro> registros = CargarFotosConEmbeddings();
            var resultados = new List<FotoRegistro>();

            foreach (var reg in registros)
            {
                if (reg.Embedding == null)
                {
                    Console.WriteLine($"⚠️ Embedding NULL en idFoto {reg.IdFoto}");
                    continue;
                }

                if (reg.Embedding.Length != queryEmbedding.Length)
                {
                    Console.WriteLine($"⚠️ Embedding con longitud incorrecta en idFoto {reg.IdFoto}");
                    continue;
                }

                if (reg.Embedding.Any(x => double.IsNaN(x)))
                {
                    Console.WriteLine($"⚠️ Embedding con NaN en idFoto {reg.IdFoto}");
                    continue;
                }

                // ✅ Aquí ya es seguro calcular la distancia
                reg.Distancia = FaceEmbeddingService.Euclidean(queryEmbedding, reg.Embedding);

                if (!double.IsNaN(reg.Distancia) && reg.Distancia <= MATCH_THRESHOLD)
                    resultados.Add(reg);
            }

            MostrarResultados(resultados);

        }

        private void BtnIndexarEmbeddings_Click(object sender, EventArgs e)
        {
            // Muestra una advertencia al usuario
            var confirmResult = MessageBox.Show(
                "Esto recalculará el embedding para TODAS las fotos de la base de datos. ¿Estás seguro? El proceso puede tardar.",
                "Confirmar Re-Indexación Completa",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
            {
                return;
            }

            List<FotoRegistro> registros = CargarFotosConEmbeddings();
            int count = 0;

            foreach (var reg in registros)
            {
                // Hemos quitado el 'if' para que procese todas las fotos
                Bitmap bmp = ByteArrayToBitmap(reg.FotoBytes);
                double[] nuevoEmbedding = _faceService.GetEncodingFromBitmap(bmp); // Lo guardamos en una nueva variable

                // Solo actualizamos si el nuevo embedding es válido
                if (nuevoEmbedding != null)
                {
                    ActualizarEmbeddingBD(reg.IdFoto, nuevoEmbedding);
                    count++;
                }
            }

            MessageBox.Show($"Embeddings actualizados para {count} fotos.");
        }
    }
}
