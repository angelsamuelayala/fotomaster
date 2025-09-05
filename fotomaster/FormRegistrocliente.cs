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
    public partial class FormRegistrocliente : Form
    {
        string conexion = "Server=127.0.0.1;Database=fotomaster;Uid=root;Pwd=;";
        public FormRegistrocliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string apellido = txtapellido.Text.Trim();

            if (nombre == "" || apellido == "")
            {
                MessageBox.Show("Por favor ingrese nombre y apellido del cliente.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    // 1️⃣ Definir la variable de sesión @idUsuario para el trigger


                    using (MySqlCommand cmd = new MySqlCommand("registrocliente", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Pasar parámetros al procedimiento almacenado
                        cmd.Parameters.AddWithValue("@pnombre", nombre);
                        cmd.Parameters.AddWithValue("@papellido", apellido);
                        cmd.Parameters.AddWithValue("@pidUsuario", Sesion.idUsuario); // Usando la sesión

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cliente registrado correctamente ✅");

                    // Limpiar campos
                    txtnombre.Text = "";
                    txtapellido.Text = "";
                    txtnombre.Focus();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    string query = @"
                        SELECT p.nombre AS Nombre, 
                               p.apellido AS Apellido
                        FROM Cliente c
                        INNER JOIN Persona p ON c.idCliente = p.idPersona
                        ORDER BY p.nombre, p.apellido;";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string apellido = txtapellido.Text.Trim();

            try
            {
                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    // consulta con filtros opcionales
                    string query = @"
                SELECT p.nombre AS Nombre, 
                       p.apellido AS Apellido
                FROM Cliente c
                INNER JOIN Persona p ON c.idCliente = p.idPersona
                WHERE (@nombre = '' OR p.nombre LIKE CONCAT('%', @nombre, '%'))
                  AND (@apellido = '' OR p.apellido LIKE CONCAT('%', @apellido, '%'))
                ORDER BY p.nombre, p.apellido;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // pasar parámetros
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message);
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            this.Close();
        }
    }
}
