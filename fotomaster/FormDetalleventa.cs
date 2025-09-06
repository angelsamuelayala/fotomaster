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
using MaterialSkin;
using MaterialSkin.Controls;

namespace fotomaster
{
    public partial class FormDetalleventa : MaterialForm
    {
        private DataTable dtClientes = new DataTable();
        private int idClienteSeleccionado = 0;
        public FormDetalleventa()
        {
            InitializeComponent();
            CargarClientes();
            CargarVentas();
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            listClientes.Click += listClientes_Click;
            // 🔹 Ocultar el ListBox al inicio
            listClientes.Visible = false;
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.RowHeadersVisible = false;
            dgvVenta.AllowUserToAddRows = false;   // quita la última fila vacía
            dgvDetalle.AllowUserToAddRows = false; // igual para el detalle
            if (dgvVenta.Columns["idVenta"] != null)
                dgvVenta.Columns["idVenta"].Visible = false;

            if (dgvVenta.Columns["idCliente"] != null)
                dgvVenta.Columns["idCliente"].Visible = false;

            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


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

                    listClientes.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }




        private void CargarVentas(int? idCliente = null)
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT 
                    v.idVenta,
                    u.username AS Usuario,
                    CONCAT(p.nombre, ' ', p.apellido) AS Cliente,
                    t.descripcion AS TiempoEntrega,
                    v.fecha,
                    CONCAT(v.pago, ' Bs') AS Pago
                FROM Venta v
                JOIN Usuario u ON v.idUsuario = u.idUsuario
                JOIN Cliente c ON v.idCliente = c.idCliente
                JOIN Persona p on c.idCliente = p.idPersona
                JOIN TiempoEntrega t ON v.idTiempo = t.idTiempo";

                    if (idCliente.HasValue)
                    {
                        query += " WHERE v.idCliente = @idCliente";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    if (idCliente.HasValue)
                        cmd.Parameters.AddWithValue("@idCliente", idCliente.Value);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dtVentas = new DataTable();
                    da.Fill(dtVentas);

                    dgvVenta.DataSource = dtVentas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar ventas: " + ex.Message);
                }
            }
        }

        private void CargarVentasCliente(int idCliente)
        {
            CargarVentas(idCliente);
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

                // 🔹 Cargar las ventas de ese cliente
                CargarVentasCliente(idClienteSeleccionado);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            listClientes.Visible = false;
            dgvDetalle.DataSource = null;
            CargarVentas();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.CurrentRow != null && dgvVenta.CurrentRow.Cells["idVenta"].Value != DBNull.Value)
            {
                int idVenta = Convert.ToInt32(dgvVenta.CurrentRow.Cells["idVenta"].Value);
                CargarDetalleVenta(idVenta);
            }
            else
            {
                MessageBox.Show("Seleccione una venta válida.");
            }
        }
        private void CargarDetalleVenta(int idVenta)
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT 
                    d.idDetalleServicio, 
                    s.descripcion AS Servicio,
                    f.descripcion AS Formato,
                    c.descripcion AS Calidad,
                    d.cantidad,
                    d.subtotal
                FROM Detalleventa d
                JOIN detalleservicio ds ON ds.idDetalleservicio = d.idDetalleservicio
                JOIN servicio s ON ds.idServicio = s.idServicio
                JOIN Formato f ON ds.idFormato = f.idFormato
                JOIN Calidad c ON ds.idCalidad = c.idCalidad
                WHERE d.idVenta = @idVenta";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dtDetalle = new DataTable();
                    da.Fill(dtDetalle);

                    dgvDetalle.DataSource = dtDetalle;
                    dgvDetalle.RowHeadersVisible = false;
                    if (dgvDetalle.Columns["idDetalleServicio"] != null)
                        dgvDetalle.Columns["idDetalleServicio"].Visible = false;

                    // Ajustar ancho de columnas
                    dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar detalle de venta: " + ex.Message);
                }
            }
        }
    }
}
