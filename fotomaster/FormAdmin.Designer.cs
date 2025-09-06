namespace fotomaster
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnregistrocliente = new Button();
            btnregistrousuario = new Button();
            btnreportes = new Button();
            btnventa = new Button();
            btnclientefoto = new Button();
            btnservicios = new Button();
            btndetalleventa = new Button();
            btnsalirr = new MaterialSkin.Controls.MaterialFlatButton();
            SuspendLayout();
            // 
            // btnregistrocliente
            // 
            btnregistrocliente.Location = new Point(593, 382);
            btnregistrocliente.Name = "btnregistrocliente";
            btnregistrocliente.Size = new Size(169, 64);
            btnregistrocliente.TabIndex = 1;
            btnregistrocliente.Text = "Cliente";
            btnregistrocliente.UseVisualStyleBackColor = true;
            btnregistrocliente.Click += btnregistrocliente_Click_1;
            // 
            // btnregistrousuario
            // 
            btnregistrousuario.Location = new Point(819, 382);
            btnregistrousuario.Name = "btnregistrousuario";
            btnregistrousuario.Size = new Size(183, 64);
            btnregistrousuario.TabIndex = 2;
            btnregistrousuario.Text = "Usuarios";
            btnregistrousuario.UseVisualStyleBackColor = true;
            btnregistrousuario.Click += btnregistrousuario_Click_1;
            // 
            // btnreportes
            // 
            btnreportes.Location = new Point(1049, 382);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(168, 64);
            btnreportes.TabIndex = 3;
            btnreportes.Text = "Reportes";
            btnreportes.UseVisualStyleBackColor = true;
            btnreportes.Click += btnreportes_Click_1;
            // 
            // btnventa
            // 
            btnventa.Location = new Point(593, 507);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(168, 65);
            btnventa.TabIndex = 4;
            btnventa.Text = "Venta";
            btnventa.UseVisualStyleBackColor = true;
            btnventa.Click += btnventa_Click_1;
            // 
            // btnclientefoto
            // 
            btnclientefoto.Location = new Point(1049, 511);
            btnclientefoto.Name = "btnclientefoto";
            btnclientefoto.Size = new Size(168, 65);
            btnclientefoto.TabIndex = 5;
            btnclientefoto.Text = "Clientes Fotos";
            btnclientefoto.UseVisualStyleBackColor = true;
            btnclientefoto.Click += btnclientefoto_Click;
            // 
            // btnservicios
            // 
            btnservicios.Location = new Point(1493, 821);
            btnservicios.Name = "btnservicios";
            btnservicios.Size = new Size(169, 72);
            btnservicios.TabIndex = 6;
            btnservicios.Text = "Servicios";
            btnservicios.UseVisualStyleBackColor = true;
            btnservicios.Click += btnservicios_Click;
            // 
            // btndetalleventa
            // 
            btndetalleventa.Location = new Point(820, 507);
            btndetalleventa.Name = "btndetalleventa";
            btndetalleventa.Size = new Size(168, 69);
            btndetalleventa.TabIndex = 7;
            btndetalleventa.Text = "Detalle de venta";
            btndetalleventa.UseVisualStyleBackColor = true;
            btndetalleventa.Click += btndetalleventa_Click_1;
            // 
            // btnsalirr
            // 
            btnsalirr.AutoSize = true;
            btnsalirr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnsalirr.Depth = 0;
            btnsalirr.Icon = null;
            btnsalirr.Location = new Point(13, 81);
            btnsalirr.Margin = new Padding(4, 6, 4, 6);
            btnsalirr.MouseState = MaterialSkin.MouseState.HOVER;
            btnsalirr.Name = "btnsalirr";
            btnsalirr.Primary = false;
            btnsalirr.Size = new Size(58, 36);
            btnsalirr.TabIndex = 8;
            btnsalirr.Text = "Salir";
            btnsalirr.UseVisualStyleBackColor = true;
            btnsalirr.Click += btnsalir_Click_1;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(btnsalirr);
            Controls.Add(btndetalleventa);
            Controls.Add(btnservicios);
            Controls.Add(btnclientefoto);
            Controls.Add(btnventa);
            Controls.Add(btnreportes);
            Controls.Add(btnregistrousuario);
            Controls.Add(btnregistrocliente);
            Name = "FormAdmin";
            Text = "FormAdmin";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnregistrocliente;
        private Button btnregistrousuario;
        private Button btnreportes;
        private Button btnventa;
        private Button btnclientefoto;
        private Button btnservicios;
        private Button btndetalleventa;
        private MaterialSkin.Controls.MaterialFlatButton btnsalirr;
    }
}