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
using Newtonsoft.Json;
using MaterialSkin;
using MaterialSkin.Controls;

namespace fotomaster
{
    public partial class FormVenta : MaterialForm
    {
        List<DetalleVentaTemp> detallesVenta = new List<DetalleVentaTemp>();
        private DataTable dtClientes = new DataTable();
        private int idClienteSeleccionado = 0;
        int idSucursal = Sucursal.CargarSucursal();
        decimal valorDescuento = Descuento.CargarDescuento();
        private FaceEmbeddingService _faceService;
        public FormVenta()
        {
            InitializeComponent();
            CargarFormatos();
            CargarCalidades();
            CargarServicio();
            CargarTiempo();
            // 🔹 Cargar clientes en memoria
            CargarClientes();
            ActualizarGridDetalles();
            dgvDetallesVenta.RowHeadersVisible = false;

            dgvDetallesVenta.AutoGenerateColumns = false;
            dgvDetallesVenta.Columns.Clear();
            dgvDetallesVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Servicio",
                HeaderText = "Servicio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDetallesVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Formato",
                HeaderText = "Formato",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDetallesVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Calidad",
                HeaderText = "Calidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvDetallesVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "cantidad",
                HeaderText = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvDetallesVenta.DataSource = detallesVenta;
            // 🔹 Conectar eventos del buscador
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            listClientes.Click += listClientes_Click;
            // 🔹 Ocultar el ListBox al inicio
            listClientes.Visible = false;

            // Inicializa el servicio de IA al cargar el formulario
            string modelsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "models");
            try
            {
                _faceService = new FaceEmbeddingService(modelsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IA no inicializada: " + ex.Message, "Modelos Dlib", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _faceService = null;
            }


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




        private void CargarFormatos()
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "SELECT idFormato, descripcion FROM Formato";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbFormato.DataSource = dt;
                    cbFormato.DisplayMember = "descripcion"; // lo que verá el usuario
                    cbFormato.ValueMember = "idFormato";     // lo que se usará internamente
                    cbFormato.SelectedIndex = -1;            // para que no se seleccione nada al inicio
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar formatos: " + ex.Message);
                }
            }
        }
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                listClientes.DataSource = null;
                listClientes.Visible = false; // ocultar si no hay texto
                return;
            }

            DataView dv = dtClientes.DefaultView;
            dv.RowFilter = string.Format("nombreCompleto LIKE '%{0}%'", texto.Replace("'", "''"));

            if (dv.Count > 0)
            {
                listClientes.DataSource = dv;
                listClientes.DisplayMember = "nombreCompleto";
                listClientes.ValueMember = "idCliente";
                listClientes.Visible = true; // mostrar si hay resultados
            }
            else
            {
                listClientes.DataSource = null;
                listClientes.Visible = false; // ocultar si no hay coincidencias
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
            }
        }



        private void CargarCalidades()
        {
            try
            {
                using (MySqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT idCalidad, descripcion FROM calidad";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbCalidad.DataSource = dt;
                    cbCalidad.DisplayMember = "descripcion"; // Lo que ve el usuario
                    cbCalidad.ValueMember = "idCalidad";     // El valor interno (id)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar calidades: " + ex.Message);
            }
        }

        private void CargarServicio()
        {
            try
            {
                using (MySqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT idServicio, descripcion FROM servicio";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbServicio.DataSource = dt;
                    cbServicio.DisplayMember = "descripcion"; // Lo que ve el usuario
                    cbServicio.ValueMember = "idServicio";     // El valor interno (id)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar calidades: " + ex.Message);
            }
        }
        private void CargarTiempo()
        {
            try
            {
                using (MySqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT idTiempo, descripcion FROM tiempoentrega";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbTiempo.DataSource = dt;
                    cbTiempo.DisplayMember = "descripcion"; // Lo que ve el usuario
                    cbTiempo.ValueMember = "idTiempo";     // El valor interno (id)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar calidades: " + ex.Message);
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            // Crear el cuadro de diálogo para abrir archivo
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Seleccionar imagen";
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Mostrar la imagen seleccionada en el PictureBox
                pictureBoxFoto.Image = Image.FromFile(ofd.FileName);

                // (Opcional) Guardar la ruta en un TextBox si quieres ver la ruta
                // txtRutaImagen.Text = ofd.FileName;
            }
        }

       

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (cbServicio.SelectedIndex == -1 || cbFormato.SelectedIndex == -1 || cbCalidad.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar el detalle.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleVentaTemp detalle = new DetalleVentaTemp
            {
                idServicio = Convert.ToInt32(cbServicio.SelectedValue),
                idFormato = Convert.ToInt32(cbFormato.SelectedValue),
                idCalidad = Convert.ToInt32(cbCalidad.SelectedValue),
                cantidad = Convert.ToInt32(txtCantidad.Text),
                fotobinario = ObtenerImagenBinaria(),
                Servicio = cbServicio.Text,
                Formato = cbFormato.Text,
                Calidad = cbCalidad.Text

            };


           

            detallesVenta.Add(detalle);
            //ActualizarGridDetalles();

            dgvDetallesVenta.DataSource = null;
            dgvDetallesVenta.DataSource = detallesVenta;
          
            pictureBoxFoto.Image = null;
            txtCantidad.Clear();
            cbServicio.SelectedIndex = -1;
            cbFormato.SelectedIndex = -1;
            cbCalidad.SelectedIndex = -1;
        }

        private void ActualizarGridDetalles()
        {
            dgvDetallesVenta.DataSource = null;
            dgvDetallesVenta.DataSource = detallesVenta; // si detallesVenta es List<...> o BindingList<...>

            // Esperar a que existan columnas (ya existen tras asignar DataSource)
            // Ocultar solo si existen:
            if (dgvDetallesVenta.Columns.Contains("idServicio"))
                dgvDetallesVenta.Columns["idServicio"].Visible = false;

            if (dgvDetallesVenta.Columns.Contains("idFormato"))
                dgvDetallesVenta.Columns["idFormato"].Visible = false;

            if (dgvDetallesVenta.Columns.Contains("idCalidad"))
                dgvDetallesVenta.Columns["idCalidad"].Visible = false;

            if (dgvDetallesVenta.Columns.Contains("fotobinario"))
                dgvDetallesVenta.Columns["fotobinario"].Visible = false;

            // Ajuste de tamaño usando DataPropertyName (evita problemas de mayúsculas)
            foreach (DataGridViewColumn c in dgvDetallesVenta.Columns)
            {
                switch (c.DataPropertyName.ToLower())
                {
                    case "servicio":
                    case "formato":
                    case "calidad":
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                    case "cantidad":
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        break;
                }
            }
        }



        private byte[] ObtenerImagenBinaria()
        {
            if (pictureBoxFoto.Image == null) return null; // pbFoto = PictureBox

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // O PNG según tu necesidad
                return ms.ToArray();
            }
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            if (detallesVenta.Count == 0)
            {
                MessageBox.Show("Debe registrar al menos un detalle antes de vender.");
                return;
            }

            string jsonDetalles = JsonConvert.SerializeObject(detallesVenta);

            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                con.Open();

                int idCliente = idClienteSeleccionado;
                int idVenta = 0;

                // 1️⃣ Ejecutar SP registroventa
                using (MySqlCommand cmd = new MySqlCommand("registroventa", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pidCliente", idCliente);
                    cmd.Parameters.AddWithValue("pidUsuario", Sesion.idUsuario);
                    cmd.Parameters.AddWithValue("tidTiempo", Convert.ToInt32(cbTiempo.SelectedValue));
                    cmd.Parameters.AddWithValue("sidSucursal", idSucursal);
                    cmd.Parameters.AddWithValue("pDetalles", jsonDetalles);
                    cmd.Parameters.AddWithValue("pDescuento", valorDescuento);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            idVenta = dr.GetInt32("idVenta");
                            decimal totalPago = dr.GetDecimal("totalPago");
                            MessageBox.Show($"Venta registrada con éxito. ID: {idVenta}, Total: {totalPago}");
                        }
                    }
                }

                // 2️⃣ Guardar fotos en FotoDigital
                foreach (var detalle in detallesVenta)
                {
                    if (detalle.fotobinario != null)
                    {
                        byte[] embeddingBytes = null;

                        // Generar embedding usando IA
                        if (_faceService != null)
                        {
                            using (var ms = new MemoryStream(detalle.fotobinario))
                            using (var bmp = new Bitmap(ms))
                            {
                                double[] embedding = _faceService.GetEncodingFromBitmap(bmp);
                                if (embedding != null)
                                {
                                    embeddingBytes = FaceEmbeddingService.DoubleArrayToBytes(embedding);
                                }
                            }
                        }

                        using (MySqlCommand cmdFoto = new MySqlCommand(
                         @"INSERT INTO FotoDigital(idCliente, fotobinario, fecha, embedding) 
                          VALUES(@idCliente, @fotobinario, CURDATE(), @embedding)", con))
                        {
                            cmdFoto.Parameters.AddWithValue("@idCliente", idCliente);
                            cmdFoto.Parameters.AddWithValue("@fotobinario", detalle.fotobinario);
                            cmdFoto.Parameters.AddWithValue("@embedding", embeddingBytes != null ? (object)embeddingBytes : DBNull.Value);
                            cmdFoto.ExecuteNonQuery();
                        }
                    }
                }
            }

            // 3️⃣ Limpiar lista y grid
            detallesVenta.Clear();
            dgvDetallesVenta.DataSource = null;
        }
    }
}
