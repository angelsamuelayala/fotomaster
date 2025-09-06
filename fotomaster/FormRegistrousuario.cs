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
    public partial class FormRegistrousuario : MaterialForm
    {
        public FormRegistrousuario()
        {
            InitializeComponent();
            this.Load += FormRegistrousuario_Load;
        }

        private void FormRegistrousuario_Load(object sender, EventArgs e)
        {
            CargarUsuarios(); // Cargar usuarios al abrir el formulario
        }


        private void btnregistro_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string apellido = txtapellido.Text.Trim();
            string usuario = txtusuario.Text.Trim();
            string password = txtpassword.Text.Trim();

            int idRol = 0;
            if (rbAdmin.Checked) idRol = 1;
            else if (rbEmpleado.Checked) idRol = 2;

            if (nombre == "" || apellido == "" || usuario == "" || password == "" || idRol == 0)
            {
                MessageBox.Show("Por favor complete todos los campos y seleccione un rol.");
                return;
            }

            try
            {
                using (MySqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand("registrousuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@pNombre", nombre);
                        cmd.Parameters.AddWithValue("@pApellido", apellido);
                        cmd.Parameters.AddWithValue("@pUsuario", usuario);
                        cmd.Parameters.AddWithValue("@pPassword", password);
                        cmd.Parameters.AddWithValue("@pidRol", idRol);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario registrado correctamente ✅");

                    // limpiar campos
                    txtnombre.Text = "";
                    txtapellido.Text = "";
                    txtusuario.Text = "";
                    txtpassword.Text = "";
                    rbAdmin.Checked = false;
                    rbEmpleado.Checked = false;
                    CargarUsuarios();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                using (MySqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();

                    string query = "SELECT p.nombre AS Nombre, p.apellido AS Apellido, u.username AS Usuario " +
                                   "FROM persona p " +
                                   "INNER JOIN usuario u ON p.idPersona = u.idUsuario;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string apellido = txtapellido.Text.Trim();
            string username = txtusuario.Text.Trim(); // para buscar por username

            try
            {
                using (MySqlConnection con = Conexion.ObtenerConexion())
                {
                    con.Open();

                    string query = @"
                SELECT p.nombre AS Nombre, 
                       p.apellido AS Apellido, 
                       u.username AS Usuario
                FROM persona p
                INNER JOIN usuario u ON p.idPersona = u.idUsuario
                WHERE (@nombre = '' OR p.nombre LIKE CONCAT('%', @nombre, '%'))
                  AND (@apellido = '' OR p.apellido LIKE CONCAT('%', @apellido, '%'))
                  AND (@username = '' OR u.username LIKE CONCAT('%', @username, '%'))
                ORDER BY p.nombre, p.apellido;";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@username", username);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar usuarios: " + ex.Message);
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
