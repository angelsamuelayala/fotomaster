namespace fotomaster
{
    partial class FormClientefoto
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
            dgvFotos = new DataGridView();
            pictureBoxConsulta = new PictureBox();
            pictureBox1 = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            btnvolverr = new MaterialSkin.Controls.MaterialFlatButton();
            btnRefrescarr = new MaterialSkin.Controls.MaterialFlatButton();
            BtnCargarFotor = new MaterialSkin.Controls.MaterialFlatButton();
            btnBuscarPorFotor = new MaterialSkin.Controls.MaterialFlatButton();
            btndescargarr = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)dgvFotos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(229, 267);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(299, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(232, 302);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(295, 109);
            listClientes.TabIndex = 2;
            // 
            // dgvFotos
            // 
            dgvFotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFotos.Location = new Point(716, 111);
            dgvFotos.Name = "dgvFotos";
            dgvFotos.Size = new Size(469, 825);
            dgvFotos.TabIndex = 4;
            // 
            // pictureBoxConsulta
            // 
            pictureBoxConsulta.Location = new Point(1407, 548);
            pictureBoxConsulta.Name = "pictureBoxConsulta";
            pictureBoxConsulta.Size = new Size(396, 388);
            pictureBoxConsulta.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxConsulta.TabIndex = 5;
            pictureBoxConsulta.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1407, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(151, 267);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(56, 19);
            materialLabel1.TabIndex = 17;
            materialLabel1.Text = "Cliente";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(1407, 76);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(127, 19);
            materialLabel2.TabIndex = 18;
            materialLabel2.Text = "Fotografia cliente";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(1407, 516);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(136, 19);
            materialLabel3.TabIndex = 19;
            materialLabel3.Text = "Fotografia sistema";
            // 
            // btnvolverr
            // 
            btnvolverr.AutoSize = true;
            btnvolverr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnvolverr.Depth = 0;
            btnvolverr.Icon = null;
            btnvolverr.Location = new Point(13, 76);
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
            // btnRefrescarr
            // 
            btnRefrescarr.AutoSize = true;
            btnRefrescarr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefrescarr.Depth = 0;
            btnRefrescarr.Icon = null;
            btnRefrescarr.Location = new Point(597, 120);
            btnRefrescarr.Margin = new Padding(4, 6, 4, 6);
            btnRefrescarr.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefrescarr.Name = "btnRefrescarr";
            btnRefrescarr.Primary = false;
            btnRefrescarr.Size = new Size(96, 36);
            btnRefrescarr.TabIndex = 21;
            btnRefrescarr.Text = "Refrescar";
            btnRefrescarr.UseVisualStyleBackColor = true;
            btnRefrescarr.Click += btndescargar_Click;
            // 
            // BtnCargarFotor
            // 
            BtnCargarFotor.AutoSize = true;
            BtnCargarFotor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCargarFotor.Depth = 0;
            BtnCargarFotor.Icon = null;
            BtnCargarFotor.Location = new Point(229, 516);
            BtnCargarFotor.Margin = new Padding(4, 6, 4, 6);
            BtnCargarFotor.MouseState = MaterialSkin.MouseState.HOVER;
            BtnCargarFotor.Name = "BtnCargarFotor";
            BtnCargarFotor.Primary = false;
            BtnCargarFotor.Size = new Size(113, 36);
            BtnCargarFotor.TabIndex = 22;
            BtnCargarFotor.Text = "Cargar Foto";
            BtnCargarFotor.UseVisualStyleBackColor = true;
            BtnCargarFotor.Click += BtnCargarFoto_Click;
            // 
            // btnBuscarPorFotor
            // 
            btnBuscarPorFotor.AutoSize = true;
            btnBuscarPorFotor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBuscarPorFotor.Depth = 0;
            btnBuscarPorFotor.Icon = null;
            btnBuscarPorFotor.Location = new Point(412, 516);
            btnBuscarPorFotor.Margin = new Padding(4, 6, 4, 6);
            btnBuscarPorFotor.MouseState = MaterialSkin.MouseState.HOVER;
            btnBuscarPorFotor.Name = "btnBuscarPorFotor";
            btnBuscarPorFotor.Primary = false;
            btnBuscarPorFotor.Size = new Size(142, 36);
            btnBuscarPorFotor.TabIndex = 23;
            btnBuscarPorFotor.Text = "Buscar por foto";
            btnBuscarPorFotor.UseVisualStyleBackColor = true;
            btnBuscarPorFotor.Click += btnBuscarPorFoto_Click;
            // 
            // btndescargarr
            // 
            btndescargarr.AutoSize = true;
            btndescargarr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btndescargarr.Depth = 0;
            btndescargarr.Icon = null;
            btndescargarr.Location = new Point(1407, 957);
            btndescargarr.Margin = new Padding(4, 6, 4, 6);
            btndescargarr.MouseState = MaterialSkin.MouseState.HOVER;
            btndescargarr.Name = "btndescargarr";
            btndescargarr.Primary = false;
            btndescargarr.Size = new Size(100, 36);
            btndescargarr.TabIndex = 24;
            btndescargarr.Text = "Descargar";
            btndescargarr.UseVisualStyleBackColor = true;
            btndescargarr.Click += btndescargar_Click;
            // 
            // FormClientefoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(btndescargarr);
            Controls.Add(btnBuscarPorFotor);
            Controls.Add(BtnCargarFotor);
            Controls.Add(btnRefrescarr);
            Controls.Add(btnvolverr);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxConsulta);
            Controls.Add(dgvFotos);
            Controls.Add(listClientes);
            Controls.Add(txtBuscarCliente);
            Name = "FormClientefoto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormClientefoto";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvFotos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBuscarCliente;
        private ListBox listClientes;
        private DataGridView dgvFotos;
        private PictureBox pictureBoxConsulta;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton btnvolverr;
        private MaterialSkin.Controls.MaterialFlatButton btnRefrescarr;
        private MaterialSkin.Controls.MaterialFlatButton BtnCargarFotor;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarPorFotor;
        private MaterialSkin.Controls.MaterialFlatButton btndescargarr;
    }
}