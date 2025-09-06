using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace fotomaster
{
    public partial class FormReporte : MaterialForm
    {
        public FormReporte()
        {
            InitializeComponent();

            // Cargar los filtros y el reporte inicial al abrir la ventana.
            CargarFiltrosServicio();
            CargarReporteDiario();
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.AllowUserToAddRows = false;
            dgvDescuentos.RowHeadersVisible = false;
            dgvDescuentos.AllowUserToAddRows = false;


            dgvVentas.Columns["ID Venta"].Visible = false;

            // Conectar los eventos para que el reporte se actualice automáticamente.
            dtpFecha.ValueChanged += (s, e) => CargarReporteDiario();
            cmbServicio.SelectedIndexChanged += (s, e) => CargarReporteDiario();

            dtpMesAnioDescuento.Format = DateTimePickerFormat.Custom;
            dtpMesAnioDescuento.CustomFormat = "MMMM yyyy";
            dtpMesAnioDescuento.ShowUpDown = true; // Opcional: facilita cambiar mes/año

            CargarReporteDescuentos();
            dtpMesAnioDescuento.ValueChanged += (s, e) => CargarReporteDescuentos();
        }

        /// <summary>
        /// Carga el ComboBox de Servicios desde la base de datos.
        /// </summary>
        private void CargarFiltrosServicio()
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = "SELECT idServicio, descripcion FROM Servicio;";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Añadir la opción "Todos" al principio de la lista.
                    DataRow todosRow = dt.NewRow();
                    todosRow["idServicio"] = 0; // Usamos 0 como identificador para "Todos"
                    todosRow["descripcion"] = "Todos los servicios";
                    dt.Rows.InsertAt(todosRow, 0);

                    cmbServicio.DataSource = dt;
                    cmbServicio.DisplayMember = "descripcion";
                    cmbServicio.ValueMember = "idServicio";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los filtros de servicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Carga el DataGridView y el Label con los datos de ventas, aplicando los filtros de fecha y servicio.
        /// </summary>
        private void CargarReporteDiario()
        {
            // Evita que se ejecute antes de que los filtros estén listos.
            if (cmbServicio.SelectedValue == null) return;

            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string fechaSeleccionada = dtpFecha.Value.ToString("yyyy-MM-dd");
                    int idServicioSeleccionado = Convert.ToInt32(cmbServicio.SelectedValue);

                    // --- 1. Cargar los datos en el DataGridView ---
                    string queryVentas = @"
                        SELECT 
                            v.idVenta AS 'ID Venta',
                            CONCAT(p.nombre, ' ', p.apellido) AS Cliente,
                            s.nombre AS Sucursal,
                            t.descripcion AS 'Tiempo de Entrega',
                            v.fecha AS Fecha,
                            v.pago AS Pago
                        FROM Venta v
                        JOIN Cliente c ON v.idCliente = c.idCliente
                        JOIN Persona p ON c.idCliente = p.idPersona
                        JOIN Sucursal s ON v.idSucursal = s.idSucursal
                        JOIN TiempoEntrega t ON v.idTiempo = t.idTiempo
                        WHERE DATE(v.fecha) = @fecha";

                    // Añadimos el filtro de servicio solo si no es "Todos".
                    if (idServicioSeleccionado > 0)
                    {
                        // Usamos una subconsulta para encontrar las ventas que contienen ese servicio.
                        queryVentas += @" AND v.idVenta IN (
                                           SELECT dv.idVenta FROM DetalleVenta dv
                                           JOIN DetalleServicio ds ON dv.idDetalleServicio = ds.idDetalleServicio
                                           WHERE ds.idServicio = @idServicio
                                       )";
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(queryVentas, con);
                    da.SelectCommand.Parameters.AddWithValue("@fecha", fechaSeleccionada);
                    if (idServicioSeleccionado > 0)
                    {
                        da.SelectCommand.Parameters.AddWithValue("@idServicio", idServicioSeleccionado);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVentas.DataSource = dt;

                    // --- 2. Calcular y mostrar el total usando la función SQL ---
                    string queryTotal = "SELECT TotalVentasPorServicioDia(@fecha, @idServicio);";
                    MySqlCommand cmdTotal = new MySqlCommand(queryTotal, con);
                    cmdTotal.Parameters.AddWithValue("@fecha", fechaSeleccionada);
                    cmdTotal.Parameters.AddWithValue("@idServicio", idServicioSeleccionado);

                    object resultado = cmdTotal.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        decimal totalVentas = Convert.ToDecimal(resultado);
                        lblTotalVentas.Text = "Total de Ventas (Filtro Aplicado): " + totalVentas.ToString("C");
                    }
                    else
                    {
                        lblTotalVentas.Text = "Total de Ventas (Filtro Aplicado): Bs 0.00";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el reporte: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarReporteDescuentos()
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    // Extraemos el mes y el año del control DateTimePicker.
                    int mesSeleccionado = dtpMesAnioDescuento.Value.Month;
                    int anioSeleccionado = dtpMesAnioDescuento.Value.Year;

                    // --- 1. Cargar la tabla de descuentos con la nueva consulta ---
                    string queryDescuentos = @"
                        SELECT 
                            v.idVenta AS 'ID Venta',
                            CONCAT(p.nombre, ' ', p.apellido) AS Cliente,
                            s.nombre AS Sucursal,
                            t.descripcion AS 'Tiempo de Entrega',
                            v.fecha AS 'Fecha Venta',
                            p.fecha AS 'Fecha Registro Cliente',
                            v.pago AS Pago
                        FROM Venta v
                        JOIN Cliente c ON v.idCliente = c.idCliente
                        JOIN Persona p ON c.idCliente = p.idPersona
                        JOIN Sucursal s ON v.idSucursal = s.idSucursal
                        JOIN TiempoEntrega t ON v.idTiempo = t.idTiempo
                        WHERE 
                            MONTH(v.fecha) = @mes
                            AND YEAR(v.fecha) = @anio
                            AND DATE(v.fecha) >= DATE_ADD(p.fecha, INTERVAL 2 YEAR);";

                    MySqlDataAdapter da = new MySqlDataAdapter(queryDescuentos, con);
                    da.SelectCommand.Parameters.AddWithValue("@mes", mesSeleccionado);
                    da.SelectCommand.Parameters.AddWithValue("@anio", anioSeleccionado);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDescuentos.DataSource = dt;
                    dgvDescuentos.Columns["ID Venta"].Visible = false;
                    // --- 2. Calcular y mostrar el total de los pagos ---
                    decimal totalPagos = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        totalPagos += Convert.ToDecimal(row["Pago"]);
                    }
                    lblTotalDescuentos.Text = "Total en Ventas con Descuento: " + totalPagos.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el reporte de descuentos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            // Poner el ComboBox de servicio en la primera opción ("Todos los servicios")
            if (cmbServicio.Items.Count > 0)
            {
                cmbServicio.SelectedIndex = 0;
            }

            // Poner el selector de fecha en el día de hoy
            dtpFecha.Value = DateTime.Today;
            if (this.Controls.ContainsKey("dtpMesAnioDescuento"))
            {
                (this.Controls["dtpMesAnioDescuento"] as DateTimePicker).Value = DateTime.Today;
            }
            CargarReporteDiario();
            CargarReporteDescuentos();
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
    }
}
