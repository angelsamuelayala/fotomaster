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

namespace fotomaster
{
    public partial class FormAdmin : MaterialForm
    {
        string conexion = "Server=127.0.0.1;Database=fotomaster;Uid=root;Pwd=;";
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnregistrocliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrousuario_Click(object sender, EventArgs e)
        {

        }

        private void btnventa_Click(object sender, EventArgs e)
        {

        }



        private void btnservicios_Click(object sender, EventArgs e)
        {
            FormServicios servicio = new FormServicios();
            servicio.Show();
            this.Close();
        }

        private void btndetalleventa_Click(object sender, EventArgs e)
        {
           
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
        //---------------------------------------------------------------------------------------------

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btnregistrocliente_Click_1(object sender, EventArgs e)
        {
            FormRegistrocliente rcliente = new FormRegistrocliente();
            rcliente.Show();
            this.Close();
        }

        private void btnregistrousuario_Click_1(object sender, EventArgs e)
        {
            FormRegistrousuario usuario = new FormRegistrousuario();
            usuario.Show();
            this.Close();
        }

        private void btnreportes_Click_1(object sender, EventArgs e)
        {
            FormReporte reportesForm = new FormReporte();
            reportesForm.Show();
            this.Close();
        }

        private void btnventa_Click_1(object sender, EventArgs e)
        {
            FormVenta venta = new FormVenta();
            venta.Show();
            this.Close();
        }

        private void btndetalleventa_Click_1(object sender, EventArgs e)
        {
            FormDetalleventa detalleventa = new FormDetalleventa();
            detalleventa.Show();
            this.Close();
        }
    }
}
