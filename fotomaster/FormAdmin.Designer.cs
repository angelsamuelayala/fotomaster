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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            btnregistrocliente = new Button();
            btnregistrousuario = new Button();
            btnreportes = new Button();
            btnventa = new Button();
            btnclientefoto = new Button();
            btnservicios = new Button();
            btndetalleventa = new Button();
            btnsalirr = new MaterialSkin.Controls.MaterialFlatButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // btnregistrocliente
            // 
            btnregistrocliente.BackgroundImage = (Image)resources.GetObject("btnregistrocliente.BackgroundImage");
            btnregistrocliente.BackgroundImageLayout = ImageLayout.Stretch;
            btnregistrocliente.Location = new Point(593, 361);
            btnregistrocliente.Name = "btnregistrocliente";
            btnregistrocliente.Size = new Size(120, 120);
            btnregistrocliente.TabIndex = 1;
            btnregistrocliente.UseVisualStyleBackColor = true;
            btnregistrocliente.Click += btnregistrocliente_Click_1;
            // 
            // btnregistrousuario
            // 
            btnregistrousuario.BackgroundImage = (Image)resources.GetObject("btnregistrousuario.BackgroundImage");
            btnregistrousuario.BackgroundImageLayout = ImageLayout.Stretch;
            btnregistrousuario.Location = new Point(768, 361);
            btnregistrousuario.Name = "btnregistrousuario";
            btnregistrousuario.Size = new Size(120, 120);
            btnregistrousuario.TabIndex = 2;
            btnregistrousuario.UseVisualStyleBackColor = true;
            btnregistrousuario.Click += btnregistrousuario_Click_1;
            // 
            // btnreportes
            // 
            btnreportes.BackgroundImage = (Image)resources.GetObject("btnreportes.BackgroundImage");
            btnreportes.BackgroundImageLayout = ImageLayout.Stretch;
            btnreportes.Location = new Point(941, 361);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(120, 120);
            btnreportes.TabIndex = 3;
            btnreportes.UseVisualStyleBackColor = true;
            btnreportes.Click += btnreportes_Click_1;
            // 
            // btnventa
            // 
            btnventa.BackgroundImage = (Image)resources.GetObject("btnventa.BackgroundImage");
            btnventa.BackgroundImageLayout = ImageLayout.Stretch;
            btnventa.Location = new Point(593, 543);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(120, 120);
            btnventa.TabIndex = 4;
            btnventa.UseVisualStyleBackColor = true;
            btnventa.Click += btnventa_Click_1;
            // 
            // btnclientefoto
            // 
            btnclientefoto.BackgroundImage = (Image)resources.GetObject("btnclientefoto.BackgroundImage");
            btnclientefoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnclientefoto.Location = new Point(941, 543);
            btnclientefoto.Name = "btnclientefoto";
            btnclientefoto.Size = new Size(120, 120);
            btnclientefoto.TabIndex = 5;
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
            btndetalleventa.BackgroundImage = (Image)resources.GetObject("btndetalleventa.BackgroundImage");
            btndetalleventa.BackgroundImageLayout = ImageLayout.Stretch;
            btndetalleventa.Location = new Point(768, 543);
            btndetalleventa.Name = "btndetalleventa";
            btndetalleventa.Size = new Size(120, 120);
            btndetalleventa.TabIndex = 7;
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(618, 484);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(64, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Clientes";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(785, 484);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(69, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Usuarios";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(960, 484);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(69, 19);
            materialLabel3.TabIndex = 11;
            materialLabel3.Text = "Reportes";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(634, 666);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(56, 19);
            materialLabel4.TabIndex = 12;
            materialLabel4.Text = "Ventas";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 11F);
            materialLabel5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel5.Location = new Point(768, 666);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(124, 19);
            materialLabel5.TabIndex = 13;
            materialLabel5.Text = "Detalle de ventas";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 11F);
            materialLabel6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel6.Location = new Point(941, 666);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(104, 19);
            materialLabel6.TabIndex = 14;
            materialLabel6.Text = "Clientes fotos";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}