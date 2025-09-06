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
            btnvolver = new Button();
            txtBuscarCliente = new TextBox();
            listClientes = new ListBox();
            btnRefrescar = new Button();
            dgvFotos = new DataGridView();
            pictureBoxConsulta = new PictureBox();
            pictureBox1 = new PictureBox();
            btndescargar = new Button();
            btnBuscarPorFoto = new Button();
            BtnCargarFoto = new Button();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dgvFotos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(25, 17);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(142, 63);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(175, 205);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(299, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(178, 240);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(295, 109);
            listClientes.TabIndex = 2;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(592, 111);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(106, 56);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
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
            // btndescargar
            // 
            btndescargar.Location = new Point(1223, 895);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(142, 38);
            btndescargar.TabIndex = 7;
            btndescargar.Text = "Descargar";
            btndescargar.UseVisualStyleBackColor = true;
            btndescargar.Click += btndescargar_Click;
            // 
            // btnBuscarPorFoto
            // 
            btnBuscarPorFoto.Location = new Point(381, 442);
            btnBuscarPorFoto.Name = "btnBuscarPorFoto";
            btnBuscarPorFoto.Size = new Size(155, 54);
            btnBuscarPorFoto.TabIndex = 11;
            btnBuscarPorFoto.Text = "Buscar por foto";
            btnBuscarPorFoto.UseVisualStyleBackColor = true;
            btnBuscarPorFoto.Click += btnBuscarPorFoto_Click;
            // 
            // BtnCargarFoto
            // 
            BtnCargarFoto.Location = new Point(178, 442);
            BtnCargarFoto.Name = "BtnCargarFoto";
            BtnCargarFoto.Size = new Size(155, 54);
            BtnCargarFoto.TabIndex = 13;
            BtnCargarFoto.Text = "Cargar Foto";
            BtnCargarFoto.UseVisualStyleBackColor = true;
            BtnCargarFoto.Click += BtnCargarFoto_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(97, 205);
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
            // FormClientefoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(BtnCargarFoto);
            Controls.Add(btnBuscarPorFoto);
            Controls.Add(btndescargar);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxConsulta);
            Controls.Add(dgvFotos);
            Controls.Add(btnRefrescar);
            Controls.Add(listClientes);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnvolver);
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

        private Button btnvolver;
        private TextBox txtBuscarCliente;
        private ListBox listClientes;
        private Button btnRefrescar;
        private DataGridView dgvFotos;
        private PictureBox pictureBoxConsulta;
        private PictureBox pictureBox1;
        private Button btndescargar;
        private Button btnBuscarPorFoto;
        private Button BtnCargarFoto;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}