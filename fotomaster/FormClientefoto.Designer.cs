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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            listClientes.Size = new Size(295, 64);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 213);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1407, 530);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 15;
            label2.Text = "Fotografia Sistema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1407, 90);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 16;
            label3.Text = "Fotografia Cliente";
            // 
            // FormClientefoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}