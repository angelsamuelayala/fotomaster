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
            btnsalir = new Button();
            btnregistrocliente = new Button();
            btnregistrousuario = new Button();
            btnreportes = new Button();
            btnventa = new Button();
            btnclientefoto = new Button();
            btnservicios = new Button();
            btndetalleventa = new Button();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(32, 23);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(102, 52);
            btnsalir.TabIndex = 0;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnregistrocliente
            // 
            btnregistrocliente.Location = new Point(42, 106);
            btnregistrocliente.Name = "btnregistrocliente";
            btnregistrocliente.Size = new Size(138, 64);
            btnregistrocliente.TabIndex = 1;
            btnregistrocliente.Text = "Cliente";
            btnregistrocliente.UseVisualStyleBackColor = true;
            // 
            // btnregistrousuario
            // 
            btnregistrousuario.Location = new Point(43, 190);
            btnregistrousuario.Name = "btnregistrousuario";
            btnregistrousuario.Size = new Size(143, 54);
            btnregistrousuario.TabIndex = 2;
            btnregistrousuario.Text = "Usuarios";
            btnregistrousuario.UseVisualStyleBackColor = true;
            // 
            // btnreportes
            // 
            btnreportes.Location = new Point(32, 268);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(157, 66);
            btnreportes.TabIndex = 3;
            btnreportes.Text = "Reportes";
            btnreportes.UseVisualStyleBackColor = true;
            // 
            // btnventa
            // 
            btnventa.Location = new Point(28, 355);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(168, 65);
            btnventa.TabIndex = 4;
            btnventa.Text = "Venta";
            btnventa.UseVisualStyleBackColor = true;
            // 
            // btnclientefoto
            // 
            btnclientefoto.Location = new Point(38, 426);
            btnclientefoto.Name = "btnclientefoto";
            btnclientefoto.Size = new Size(154, 90);
            btnclientefoto.TabIndex = 5;
            btnclientefoto.Text = "Clientes Fotos";
            btnclientefoto.UseVisualStyleBackColor = true;
            btnclientefoto.Click += btnclientefoto_Click;
            // 
            // btnservicios
            // 
            btnservicios.Location = new Point(38, 543);
            btnservicios.Name = "btnservicios";
            btnservicios.Size = new Size(158, 72);
            btnservicios.TabIndex = 6;
            btnservicios.Text = "Servicios";
            btnservicios.UseVisualStyleBackColor = true;
            btnservicios.Click += btnservicios_Click;
            // 
            // btndetalleventa
            // 
            btndetalleventa.Location = new Point(36, 630);
            btndetalleventa.Name = "btndetalleventa";
            btndetalleventa.Size = new Size(159, 69);
            btndetalleventa.TabIndex = 7;
            btndetalleventa.Text = "Detalle de venta";
            btndetalleventa.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 716);
            Controls.Add(btndetalleventa);
            Controls.Add(btnservicios);
            Controls.Add(btnclientefoto);
            Controls.Add(btnventa);
            Controls.Add(btnreportes);
            Controls.Add(btnregistrousuario);
            Controls.Add(btnregistrocliente);
            Controls.Add(btnsalir);
            Name = "FormAdmin";
            Text = "FormAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnsalir;
        private Button btnregistrocliente;
        private Button btnregistrousuario;
        private Button btnreportes;
        private Button btnventa;
        private Button btnclientefoto;
        private Button btnservicios;
        private Button btndetalleventa;
    }
}