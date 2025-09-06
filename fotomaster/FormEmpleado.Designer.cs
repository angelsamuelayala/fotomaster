namespace fotomaster
{
    partial class FormEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            btnvolver = new MaterialSkin.Controls.MaterialFlatButton();
            btncliente = new Button();
            btnventa = new Button();
            btndetalle = new Button();
            btnclientefoto = new Button();
            btnreporte = new Button();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // btnvolver
            // 
            btnvolver.AutoSize = true;
            btnvolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnvolver.Depth = 0;
            btnvolver.Icon = null;
            btnvolver.Location = new Point(13, 80);
            btnvolver.Margin = new Padding(4, 6, 4, 6);
            btnvolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnvolver.Name = "btnvolver";
            btnvolver.Primary = false;
            btnvolver.Size = new Size(58, 36);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "Salir";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // btncliente
            // 
            btncliente.BackgroundImage = (Image)resources.GetObject("btncliente.BackgroundImage");
            btncliente.BackgroundImageLayout = ImageLayout.Stretch;
            btncliente.Location = new Point(541, 454);
            btncliente.Name = "btncliente";
            btncliente.Size = new Size(120, 120);
            btncliente.TabIndex = 1;
            btncliente.UseVisualStyleBackColor = true;
            btncliente.Click += btncliente_Click;
            // 
            // btnventa
            // 
            btnventa.BackgroundImage = (Image)resources.GetObject("btnventa.BackgroundImage");
            btnventa.BackgroundImageLayout = ImageLayout.Stretch;
            btnventa.Location = new Point(688, 454);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(120, 120);
            btnventa.TabIndex = 2;
            btnventa.UseVisualStyleBackColor = true;
            btnventa.Click += btnventa_Click;
            // 
            // btndetalle
            // 
            btndetalle.BackgroundImage = (Image)resources.GetObject("btndetalle.BackgroundImage");
            btndetalle.BackgroundImageLayout = ImageLayout.Stretch;
            btndetalle.Location = new Point(833, 454);
            btndetalle.Name = "btndetalle";
            btndetalle.Size = new Size(120, 120);
            btndetalle.TabIndex = 3;
            btndetalle.Text = "Detalle venta";
            btndetalle.UseVisualStyleBackColor = true;
            btndetalle.Click += btndetalle_Click;
            // 
            // btnclientefoto
            // 
            btnclientefoto.BackgroundImage = (Image)resources.GetObject("btnclientefoto.BackgroundImage");
            btnclientefoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnclientefoto.Location = new Point(992, 454);
            btnclientefoto.Name = "btnclientefoto";
            btnclientefoto.Size = new Size(120, 120);
            btnclientefoto.TabIndex = 4;
            btnclientefoto.UseVisualStyleBackColor = true;
            btnclientefoto.Click += btnclientefoto_Click;
            // 
            // btnreporte
            // 
            btnreporte.BackgroundImage = (Image)resources.GetObject("btnreporte.BackgroundImage");
            btnreporte.BackgroundImageLayout = ImageLayout.Stretch;
            btnreporte.Location = new Point(1134, 454);
            btnreporte.Name = "btnreporte";
            btnreporte.Size = new Size(120, 120);
            btnreporte.TabIndex = 5;
            btnreporte.Text = "Reportes";
            btnreporte.UseVisualStyleBackColor = true;
            btnreporte.Click += btnreporte_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(570, 577);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(64, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Clientes";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(728, 577);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(56, 19);
            materialLabel2.TabIndex = 7;
            materialLabel2.Text = "Ventas";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(845, 577);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(124, 19);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Detalle de ventas";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(992, 577);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(107, 19);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "Clientes Fotos";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 11F);
            materialLabel5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel5.Location = new Point(1151, 577);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(69, 19);
            materialLabel5.TabIndex = 10;
            materialLabel5.Text = "Reportes";
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1940, 1080);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(btnreporte);
            Controls.Add(btnclientefoto);
            Controls.Add(btndetalle);
            Controls.Add(btnventa);
            Controls.Add(btncliente);
            Controls.Add(btnvolver);
            Name = "FormEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmpleado";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnvolver;
        private Button btncliente;
        private Button btnventa;
        private Button btndetalle;
        private Button btnclientefoto;
        private Button btnreporte;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}