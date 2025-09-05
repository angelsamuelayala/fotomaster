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
    public partial class FormLogin : Form
    {
        string conexion = "Server=127.0.0.1;Database=fotomaster;Uid=root;Pwd=;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string user = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text.Trim();

            if (user == "" || pass == "")
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    string query = "SELECT idUsuario, idRol, username FROM usuario WHERE username=@user AND contraseña=@pass";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Guardar datos en la sesión
                        Sesion.idUsuario = reader.GetInt32("idUsuario");
                        Sesion.idRol = reader.GetInt32("idRol");
                        Sesion.Username = reader.GetString("username");

                        if (Sesion.idRol == 1)
                        {
                            FormAdmin frm = new FormAdmin();
                            frm.Show();
                            this.Hide();
                        }
                        else if (Sesion.idRol == 2)
                        {
                            FormEmpleado frm = new FormEmpleado();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Rol no reconocido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}
