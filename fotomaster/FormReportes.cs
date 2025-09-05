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

namespace fotomaster
{
    public partial class FormReportes : Form
    {

        private MySqlConnection conn;
        public FormReportes()
        {
            InitializeComponent();
            InitializeComponent1();//revisarrrr

            InitializeDatabaseConnection();
            // Cargar los tipos de servicio al iniciar el formulario.
            CargarTiposServicio();
            // Cargar el reporte inicial al iniciar el formulario.
            CargarReporteDiario();
            // Cargar los ComboBox para el reporte de descuentos
            CargarFiltrosDescuentos();
        }

        // Configura la conexión a la base de datos.
        private void InitializeDatabaseConnection()
        {
            string connStr = "Server=127.0.0.1;Database=fotomaster;Uid=root;Pwd=;";
            conn = new MySqlConnection(connStr);
        }

        // Carga los tipos de servicio en el ComboBox.
        private void CargarTiposServicio()
        {
            try
            {
                conn.Open();
                string query = "SELECT idServicio, descripcion FROM Servicio;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Agregar una opción para "Todos los servicios".
                DataRow defaultRow = dt.NewRow();
                defaultRow["idServicio"] = 0;
                defaultRow["descripcion"] = "Todos los servicios";
                dt.Rows.InsertAt(defaultRow, 0);

                cmbServicio.DataSource = dt;
                cmbServicio.DisplayMember = "descripcion";
                cmbServicio.ValueMember = "idServicio";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de servicio: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Carga el DataGridView con los datos de las ventas diarias.
        private void CargarReporteDiario()
        {
            try
            {
                string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
                int idServicio = (cmbServicio.SelectedValue != null) ? (int)cmbServicio.SelectedValue : 0;

                conn.Open();

                string query = @"
                    SELECT
                        v.idVenta,
                        p.nombre AS NombreCliente,
                        p.apellido AS ApellidoCliente,
                        s.descripcion AS TipoServicio,
                        dv.cantidad AS Cantidad,
                        dv.subtotal AS PrecioUnitario,
                        (dv.cantidad * dv.subtotal) AS Subtotal
                    FROM Venta v
                    JOIN Cliente c ON v.idCliente = c.idCliente
                    JOIN Persona p ON c.idCliente = p.idPersona
                    JOIN DetalleVenta dv ON v.idVenta = dv.idVenta
                    JOIN DetalleServicio ds ON dv.idDetalleServicio = ds.idDetalleServicio
                    JOIN Servicio s ON ds.idServicio = s.idServicio
                    WHERE DATE(v.fecha) = @fecha
                ";

                if (idServicio > 0)
                {
                    query += " AND s.idServicio = @idServicio;";
                }
                else
                {
                    query += ";";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                if (idServicio > 0)
                {
                    cmd.Parameters.AddWithValue("@idServicio", idServicio);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvVentas.DataSource = dt;

                decimal totalVentas = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalVentas += Convert.ToDecimal(row["Subtotal"]);
                }
                lblTotalVentas.Text = "Total de ventas del día: " + totalVentas.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // Carga los ComboBox de meses y años para el reporte de descuentos.
        private void CargarFiltrosDescuentos()
        {
            DataTable dtMeses = new DataTable();
            dtMeses.Columns.Add("idMes", typeof(int));
            dtMeses.Columns.Add("nombreMes", typeof(string));
            dtMeses.Rows.Add(0, "Todos los meses");
            for (int i = 1; i <= 12; i++)
            {
                dtMeses.Rows.Add(i, new DateTime(2000, i, 1).ToString("MMMM"));
            }
            cmbMes.DataSource = dtMeses;
            cmbMes.DisplayMember = "nombreMes";
            cmbMes.ValueMember = "idMes";

            DataTable dtAnios = new DataTable();
            dtAnios.Columns.Add("anio", typeof(int));
            int anioActual = DateTime.Now.Year;
            for (int i = anioActual; i >= 2020; i--)
            {
                dtAnios.Rows.Add(i);
            }
            cmbAnio.DataSource = dtAnios;
            cmbAnio.DisplayMember = "anio";
            cmbAnio.ValueMember = "anio";
        }

        // Carga el DataGridView con los descuentos a clientes antiguos.
        private void CargarReporteDescuentos()
        {
            try
            {
                int mes = (cmbMes.SelectedValue != null) ? (int)cmbMes.SelectedValue : 0;
                int anio = (cmbAnio.SelectedValue != null) ? (int)cmbAnio.SelectedValue : DateTime.Now.Year;

                conn.Open();

                string query = @"
                    SELECT
                        p.nombre AS NombreCliente,
                        p.apellido AS ApellidoCliente,
                        s.descripcion AS TipoServicio,
                        dv.subtotal AS DescuentoAplicado,
                        v.fecha AS Fecha
                    FROM Venta v
                    JOIN Cliente c ON v.idCliente = c.idCliente
                    JOIN Persona p ON c.idCliente = p.idPersona
                    JOIN DetalleVenta dv ON v.idVenta = dv.idVenta
                    JOIN DetalleServicio ds ON dv.idDetalleServicio = ds.idDetalleServicio
                    JOIN Servicio s ON ds.idServicio = s.idServicio
                    WHERE v.pago < (SELECT SUM(dv2.subtotal * dv2.cantidad) FROM DetalleVenta dv2 WHERE dv2.idVenta = v.idVenta)
                    AND (v.pago < (SELECT SUM(dv2.subtotal * dv2.cantidad) FROM DetalleVenta dv2 WHERE dv2.idVenta = v.idVenta) AND YEAR(v.fecha) = @anio";

                if (mes > 0)
                {
                    query += " AND MONTH(v.fecha) = @mes";
                }
                query += ");";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@anio", anio);
                if (mes > 0)
                {
                    cmd.Parameters.AddWithValue("@mes", mes);
                }

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDescuentos.DataSource = dt;

                decimal totalDescuentos = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalDescuentos += Convert.ToDecimal(row["DescuentoAplicado"]);
                }
                lblTotalDescuentos.Text = "Total de descuentos en el periodo: " + totalDescuentos.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de descuentos: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        // Eventos del primer reporte
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cmbServicio.SelectedIndex = 0;
            CargarReporteDiario();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarReporteDiario();
        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedValue is int || cmbServicio.SelectedValue is null)
            {
                CargarReporteDiario();
            }
        }

        // Eventos del segundo reporte
        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarReporteDescuentos();
        }

        private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarReporteDescuentos();
        }

        private void InitializeComponent1()
        {
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.lblTotalDescuentos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(76, 60);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(240, 150);
            this.dgvVentas.TabIndex = 0;
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(76, 239);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 24);
            this.cmbServicio.TabIndex = 1;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(76, 270);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(76, 299);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "button1";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(73, 334);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(44, 16);
            this.lblTotalVentas.TabIndex = 4;
            this.lblTotalVentas.Text = "label1";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(398, 60);
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.RowHeadersWidth = 51;
            this.dgvDescuentos.RowTemplate.Height = 24;
            this.dgvDescuentos.Size = new System.Drawing.Size(240, 150);
            this.dgvDescuentos.TabIndex = 5;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(424, 239);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 24);
            this.cmbMes.TabIndex = 6;
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(424, 267);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 24);
            this.cmbAnio.TabIndex = 7;
            // 
            // lblTotalDescuentos
            // 
            this.lblTotalDescuentos.AutoSize = true;
            this.lblTotalDescuentos.Location = new System.Drawing.Point(424, 298);
            this.lblTotalDescuentos.Name = "lblTotalDescuentos";
            this.lblTotalDescuentos.Size = new System.Drawing.Size(44, 16);
            this.lblTotalDescuentos.TabIndex = 8;
            this.lblTotalDescuentos.Text = "label1";
            // 
            // FormReportes
            // 
            this.ClientSize = new System.Drawing.Size(660, 402);
            this.Controls.Add(this.lblTotalDescuentos);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.dgvDescuentos);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.dgvVentas);
            this.Name = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

