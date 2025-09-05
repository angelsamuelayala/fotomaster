using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotomaster
{
    public partial class FormAdmin : Form
    {
        string conexion = "Server=127.0.0.1;Database=fotomaster;Uid=root;Pwd=;";
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnregistrocliente_Click(object sender, EventArgs e)
        {
            FormRegistrocliente formcliente = new FormRegistrocliente();
            formcliente.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btnregistrousuario_Click(object sender, EventArgs e)
        {
            FormRegistrousuario usuario = new FormRegistrousuario();
            usuario.Show();
            this.Close();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            FormVenta venta = new FormVenta();
            venta.Show();
            this.Close();
        }



        private void btnservicios_Click(object sender, EventArgs e)
        {
            FormServicios servicio = new FormServicios();
            servicio.Show();
            this.Close();
        }

        private void btndetalleventa_Click(object sender, EventArgs e)
        {
            FormDetalleventa detalleventa = new FormDetalleventa();
            detalleventa.Show();
            this.Close();
        }


        private void btnReportes_Click(object sender, EventArgs e)
        {

            FormReportes reportesForm = new FormReportes();
            reportesForm.Show();
        }

        private void btnclientefoto_Click(object sender, EventArgs e)
        {
            FormClientefoto clientefoto = new FormClientefoto();
            clientefoto.Show();
            this.Close();
        
        }
    }
}
