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
            btnCheckEmbeddings = new Button();
            btnTestSelf = new Button();
            btnBuscarPorFoto = new Button();
            BtnIndexarEmbeddings = new Button();
            BtnCargarFoto = new Button();
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
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(211, 100);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(299, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(214, 135);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(295, 64);
            listClientes.TabIndex = 2;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(704, 82);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(106, 56);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // dgvFotos
            // 
            dgvFotos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFotos.Location = new Point(703, 154);
            dgvFotos.Name = "dgvFotos";
            dgvFotos.Size = new Size(352, 388);
            dgvFotos.TabIndex = 4;
            // 
            // pictureBoxConsulta
            // 
            pictureBoxConsulta.Location = new Point(1157, 44);
            pictureBoxConsulta.Name = "pictureBoxConsulta";
            pictureBoxConsulta.Size = new Size(289, 300);
            pictureBoxConsulta.TabIndex = 5;
            pictureBoxConsulta.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1138, 365);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 292);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btndescargar
            // 
            btndescargar.Location = new Point(1157, 695);
            btndescargar.Name = "btndescargar";
            btndescargar.Size = new Size(142, 38);
            btndescargar.TabIndex = 7;
            btndescargar.Text = "Descargar";
            btndescargar.UseVisualStyleBackColor = true;
            // 
            // btnCheckEmbeddings
            // 
            btnCheckEmbeddings.Location = new Point(768, 598);
            btnCheckEmbeddings.Name = "btnCheckEmbeddings";
            btnCheckEmbeddings.Size = new Size(156, 42);
            btnCheckEmbeddings.TabIndex = 8;
            btnCheckEmbeddings.Text = "CheckEmbedding";
            btnCheckEmbeddings.UseVisualStyleBackColor = true;
            // 
            // btnTestSelf
            // 
            btnTestSelf.Location = new Point(768, 675);
            btnTestSelf.Name = "btnTestSelf";
            btnTestSelf.Size = new Size(156, 36);
            btnTestSelf.TabIndex = 9;
            btnTestSelf.Text = "TestSelf";
            btnTestSelf.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPorFoto
            // 
            btnBuscarPorFoto.Location = new Point(234, 683);
            btnBuscarPorFoto.Name = "btnBuscarPorFoto";
            btnBuscarPorFoto.Size = new Size(148, 59);
            btnBuscarPorFoto.TabIndex = 11;
            btnBuscarPorFoto.Text = "Buscar por foto";
            btnBuscarPorFoto.UseVisualStyleBackColor = true;
            btnBuscarPorFoto.Click += btnBuscarPorFoto_Click;
            // 
            // BtnIndexarEmbeddings
            // 
            BtnIndexarEmbeddings.Location = new Point(502, 676);
            BtnIndexarEmbeddings.Name = "BtnIndexarEmbeddings";
            BtnIndexarEmbeddings.Size = new Size(195, 52);
            BtnIndexarEmbeddings.TabIndex = 12;
            BtnIndexarEmbeddings.Text = "IndexarEmbeddings";
            BtnIndexarEmbeddings.UseVisualStyleBackColor = true;
            // 
            // BtnCargarFoto
            // 
            BtnCargarFoto.Location = new Point(120, 550);
            BtnCargarFoto.Name = "BtnCargarFoto";
            BtnCargarFoto.Size = new Size(155, 49);
            BtnCargarFoto.TabIndex = 13;
            BtnCargarFoto.Text = "button1";
            BtnCargarFoto.UseVisualStyleBackColor = true;
            BtnCargarFoto.Click += BtnCargarFoto_Click;
            // 
            // FormClientefoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1544, 781);
            Controls.Add(BtnCargarFoto);
            Controls.Add(BtnIndexarEmbeddings);
            Controls.Add(btnBuscarPorFoto);
            Controls.Add(btnTestSelf);
            Controls.Add(btnCheckEmbeddings);
            Controls.Add(btndescargar);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxConsulta);
            Controls.Add(dgvFotos);
            Controls.Add(btnRefrescar);
            Controls.Add(listClientes);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnvolver);
            Name = "FormClientefoto";
            Text = "FormClientefoto";
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
        private Button btnCheckEmbeddings;
        private Button btnTestSelf;
        private Button btnBuscarPorFoto;
        private Button BtnIndexarEmbeddings;
        private Button BtnCargarFoto;
    }
}