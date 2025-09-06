namespace fotomaster
{
    partial class FormVenta
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
            txtBuscarCliente = new TextBox();
            listClientes = new ListBox();
            cbFormato = new ComboBox();
            cbCalidad = new ComboBox();
            cbServicio = new ComboBox();
            cbTiempo = new ComboBox();
            txtCantidad = new TextBox();
            pictureBoxFoto = new PictureBox();
            dgvDetallesVenta = new DataGridView();
            btnvolverr = new MaterialSkin.Controls.MaterialFlatButton();
            btnregistrarr = new MaterialSkin.Controls.MaterialFlatButton();
            btnCargarFotor = new MaterialSkin.Controls.MaterialFlatButton();
            btnventar = new MaterialSkin.Controls.MaterialFlatButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(382, 200);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(321, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(382, 229);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(321, 79);
            listClientes.TabIndex = 2;
            // 
            // cbFormato
            // 
            cbFormato.FormattingEnabled = true;
            cbFormato.Location = new Point(223, 399);
            cbFormato.Name = "cbFormato";
            cbFormato.Size = new Size(185, 23);
            cbFormato.TabIndex = 3;
            // 
            // cbCalidad
            // 
            cbCalidad.FormattingEnabled = true;
            cbCalidad.Location = new Point(456, 399);
            cbCalidad.Name = "cbCalidad";
            cbCalidad.Size = new Size(157, 23);
            cbCalidad.TabIndex = 4;
            // 
            // cbServicio
            // 
            cbServicio.FormattingEnabled = true;
            cbServicio.Location = new Point(653, 399);
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(138, 23);
            cbServicio.TabIndex = 5;
            // 
            // cbTiempo
            // 
            cbTiempo.FormattingEnabled = true;
            cbTiempo.Location = new Point(824, 400);
            cbTiempo.Name = "cbTiempo";
            cbTiempo.Size = new Size(144, 23);
            cbTiempo.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(1047, 397);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(179, 23);
            txtCantidad.TabIndex = 7;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(1374, 157);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(438, 403);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFoto.TabIndex = 9;
            pictureBoxFoto.TabStop = false;
            // 
            // dgvDetallesVenta
            // 
            dgvDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesVenta.Location = new Point(223, 581);
            dgvDetallesVenta.Name = "dgvDetallesVenta";
            dgvDetallesVenta.Size = new Size(1148, 346);
            dgvDetallesVenta.TabIndex = 19;
            // 
            // btnvolverr
            // 
            btnvolverr.AutoSize = true;
            btnvolverr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnvolverr.Depth = 0;
            btnvolverr.Icon = null;
            btnvolverr.Location = new Point(22, 80);
            btnvolverr.Margin = new Padding(4, 6, 4, 6);
            btnvolverr.MouseState = MaterialSkin.MouseState.HOVER;
            btnvolverr.Name = "btnvolverr";
            btnvolverr.Primary = false;
            btnvolverr.Size = new Size(72, 36);
            btnvolverr.TabIndex = 20;
            btnvolverr.Text = "Volver";
            btnvolverr.UseVisualStyleBackColor = true;
            btnvolverr.Click += btnvolver_Click;
            // 
            // btnregistrarr
            // 
            btnregistrarr.AutoSize = true;
            btnregistrarr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnregistrarr.Depth = 0;
            btnregistrarr.Icon = null;
            btnregistrarr.Location = new Point(221, 539);
            btnregistrarr.Margin = new Padding(4, 6, 4, 6);
            btnregistrarr.MouseState = MaterialSkin.MouseState.HOVER;
            btnregistrarr.Name = "btnregistrarr";
            btnregistrarr.Primary = false;
            btnregistrarr.Size = new Size(93, 36);
            btnregistrarr.TabIndex = 21;
            btnregistrarr.Text = "Registrar";
            btnregistrarr.UseVisualStyleBackColor = true;
            btnregistrarr.Click += btnregistrar_Click;
            // 
            // btnCargarFotor
            // 
            btnCargarFotor.AutoSize = true;
            btnCargarFotor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCargarFotor.Depth = 0;
            btnCargarFotor.Icon = null;
            btnCargarFotor.Location = new Point(1699, 581);
            btnCargarFotor.Margin = new Padding(4, 6, 4, 6);
            btnCargarFotor.MouseState = MaterialSkin.MouseState.HOVER;
            btnCargarFotor.Name = "btnCargarFotor";
            btnCargarFotor.Primary = false;
            btnCargarFotor.Size = new Size(113, 36);
            btnCargarFotor.TabIndex = 22;
            btnCargarFotor.Text = "Cargar foto";
            btnCargarFotor.UseVisualStyleBackColor = true;
            btnCargarFotor.Click += btnCargarFoto_Click;
            // 
            // btnventar
            // 
            btnventar.AutoSize = true;
            btnventar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnventar.Depth = 0;
            btnventar.Icon = null;
            btnventar.Location = new Point(1739, 651);
            btnventar.Margin = new Padding(4, 6, 4, 6);
            btnventar.MouseState = MaterialSkin.MouseState.HOVER;
            btnventar.Name = "btnventar";
            btnventar.Primary = false;
            btnventar.Size = new Size(73, 36);
            btnventar.TabIndex = 23;
            btnventar.Text = "Vender";
            btnventar.UseVisualStyleBackColor = true;
            btnventar.Click += btnventa_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(223, 200);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(138, 19);
            materialLabel1.TabIndex = 24;
            materialLabel1.Text = "Nombre del Cliente";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(223, 377);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(66, 19);
            materialLabel2.TabIndex = 25;
            materialLabel2.Text = "Formato";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(456, 377);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(59, 19);
            materialLabel3.TabIndex = 26;
            materialLabel3.Text = "Calidad";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(653, 377);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(63, 19);
            materialLabel4.TabIndex = 27;
            materialLabel4.Text = "Servicio";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 11F);
            materialLabel5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel5.Location = new Point(824, 378);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(60, 19);
            materialLabel5.TabIndex = 28;
            materialLabel5.Text = "Tiempo";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 11F);
            materialLabel6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel6.Location = new Point(1047, 377);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(68, 19);
            materialLabel6.TabIndex = 29;
            materialLabel6.Text = "Cantidad";
            // 
            // FormVenta
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
            Controls.Add(btnventar);
            Controls.Add(btnCargarFotor);
            Controls.Add(btnregistrarr);
            Controls.Add(btnvolverr);
            Controls.Add(dgvDetallesVenta);
            Controls.Add(pictureBoxFoto);
            Controls.Add(txtCantidad);
            Controls.Add(cbTiempo);
            Controls.Add(cbServicio);
            Controls.Add(cbCalidad);
            Controls.Add(cbFormato);
            Controls.Add(listClientes);
            Controls.Add(txtBuscarCliente);
            Name = "FormVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVenta";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscarCliente;
        private ListBox listClientes;
        private ComboBox cbFormato;
        private ComboBox cbCalidad;
        private ComboBox cbServicio;
        private ComboBox cbTiempo;
        private TextBox txtCantidad;
        private PictureBox pictureBoxFoto;
        private DataGridView dgvDetallesVenta;
        private MaterialSkin.Controls.MaterialFlatButton btnvolverr;
        private MaterialSkin.Controls.MaterialFlatButton btnregistrarr;
        private MaterialSkin.Controls.MaterialFlatButton btnCargarFotor;
        private MaterialSkin.Controls.MaterialFlatButton btnventar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}