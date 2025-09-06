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
using MaterialSkin;
using MaterialSkin.Controls;

namespace fotomaster
{
    public partial class FormClientefoto : MaterialForm
    {
        private DataTable dtClientes = new DataTable();
        private int idClienteSeleccionado = 0;


        private FaceEmbeddingService _faceService;
        private string _modelsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "models");
        private const double MATCH_THRESHOLD = 0.60; 
        private Bitmap queryBitmap;

        public FormClientefoto()
        {
            InitializeComponent();
            CargarClientes();

            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            listClientes.Click += listClientes_Click;

            listClientes.Visible = false;
            dgvFotos.CellClick += dgvFotos_CellClick;
            dgvFotos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvFotos.RowHeadersVisible = false;     
            dgvFotos.AllowUserToAddRows = false;


            try
            {
                _faceService = new FaceEmbeddingService(_modelsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IA no inicializada: " + ex.Message, "Modelos Dlib", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            btnBuscarPorFotor.Click += btnBuscarPorFoto_Click;

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

            dgvFotos.DataSource = null;
            dgvFotos.Columns.Clear();

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
                dgvFotos.RowTemplate.Height = 150;
                dgvFotos.Columns["Foto"].Width = 150;
                ((DataGridViewImageColumn)dgvFotos.Columns["Foto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvFotos.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvFotos.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

                txtBuscarCliente.Text = listClientes.Text;

                listClientes.Visible = false;

                CargarFotosCliente(idClienteSeleccionado);
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
                    pictureBoxConsulta.Image = (System.Drawing.Image)row.Cells["Foto"].Value;
                }
            }
        }

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

            byte[] imgBytes;
            using (var ms = new MemoryStream())
            {
                foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imgBytes = ms.ToArray();
            }

            double[] enc = _faceService.GetEncodingFromBitmap(foto);
            byte[] encBytes = enc != null ? FaceEmbeddingService.DoubleArrayToBytes(enc) : new byte[0];
            if (enc == null)
            {
                MessageBox.Show("No se detectó rostro en la foto. No se guardará embedding.");
            }

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
                string query = @"
            SELECT 
                fd.idFoto, 
                fd.idCliente, 
                fd.fotobinario, 
                fd.fecha, 
                fd.embedding,
                p.nombre,
                p.apellido
            FROM 
                fotodigital fd
            JOIN 
                Cliente c ON fd.idCliente = c.idCliente
            JOIN 
                Persona p ON c.idCliente = p.idPersona";
                MySqlCommand cmd = new MySqlCommand(query, con);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] fotoBytes = (byte[])reader["fotobinario"];
                        byte[] embeddingBytes = reader["embedding"] != DBNull.Value ? (byte[])reader["embedding"] : null;
                        string nombre = reader["nombre"].ToString();
                        string apellido = reader["apellido"].ToString();

                        lista.Add(new FotoRegistro
                        {
                            IdFoto = Convert.ToInt32(reader["idFoto"]),
                            IdCliente = Convert.ToInt32(reader["idCliente"]),
                            NombreCompleto = $"{nombre} {apellido}",
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
            dgvFotos.DataSource = null;
            dgvFotos.Columns.Clear();

            DataTable dt = new DataTable();
            dt.Columns.Add("Foto", typeof(System.Drawing.Image));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Fecha", typeof(DateTime));

            foreach (var r in resultados)
            {
                using (MemoryStream ms = new MemoryStream(r.FotoBytes))
                {
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    dt.Rows.Add(img, r.NombreCompleto, r.Fecha);
                }
            }

            dgvFotos.DataSource = dt;
            dgvFotos.RowTemplate.Height = 130;
            dgvFotos.Columns["Foto"].Width = 150;
            ((DataGridViewImageColumn)dgvFotos.Columns["Foto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvFotos.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

          
            dgvFotos.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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





        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {

            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                  
                    using (var temp = new Bitmap(ofd.FileName))
                    {
                        pictureBox1.Image = new Bitmap(temp);
                        queryBitmap = new Bitmap(temp); 
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

                reg.Distancia = FaceEmbeddingService.Euclidean(queryEmbedding, reg.Embedding);

                if (!double.IsNaN(reg.Distancia) && reg.Distancia <= MATCH_THRESHOLD)
                    resultados.Add(reg);
            }

            MostrarResultados(resultados);

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            if (Sesion.idRol == 1)
            {
                FormAdmin frm = new FormAdmin();
                frm.Show();
                this.Close();
            }
            else if (Sesion.idRol == 2)
            {
                FormEmpleado frm = new FormEmpleado();
                frm.Show();
                this.Close();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
       
            txtBuscarCliente.Clear();

            listClientes.Visible = false;
            listClientes.DataSource = null;

            
            dgvFotos.DataSource = null;

       
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            if (pictureBoxConsulta.Image != null)
            {
                pictureBoxConsulta.Image.Dispose();
                pictureBoxConsulta.Image = null;
            }

   
            if (queryBitmap != null)
            {
                queryBitmap.Dispose();
                queryBitmap = null;
            }


            idClienteSeleccionado = 0;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (pictureBoxConsulta.Image != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    sfd.Title = "Guardar imagen";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                       
                        using (Bitmap bmp = new Bitmap(pictureBoxConsulta.Image))
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
    }
}
