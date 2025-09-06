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
    public partial class FormEmpleado : MaterialForm
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            FormRegistrocliente rcliente = new FormRegistrocliente();
            rcliente.Show();
            this.Close();
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            FormVenta venta = new FormVenta();
            venta.Show();
            this.Close();
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            FormDetalleventa detalleventa = new FormDetalleventa();
            detalleventa.Show();
            this.Close();
        }

        private void btnclientefoto_Click(object sender, EventArgs e)
        {
            FormClientefoto clientefoto = new FormClientefoto();
            clientefoto.Show();
            this.Close();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            FormReporte reportesForm = new FormReporte();
            reportesForm.Show();
            this.Close();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}
