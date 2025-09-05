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
            btnvolver = new Button();
            txtBuscarCliente = new TextBox();
            listClientes = new ListBox();
            cbFormato = new ComboBox();
            cbCalidad = new ComboBox();
            cbServicio = new ComboBox();
            cbTiempo = new ComboBox();
            txtCantidad = new TextBox();
            btnregistrar = new Button();
            pictureBoxFoto = new PictureBox();
            btnCargarFoto = new Button();
            btnventa = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            dgvDetallesVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).BeginInit();
            SuspendLayout();
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(12, 12);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(139, 62);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "volver";
            btnvolver.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(218, 83);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(321, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(220, 124);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(321, 34);
            listClientes.TabIndex = 2;
            // 
            // cbFormato
            // 
            cbFormato.FormattingEnabled = true;
            cbFormato.Location = new Point(115, 320);
            cbFormato.Name = "cbFormato";
            cbFormato.Size = new Size(185, 23);
            cbFormato.TabIndex = 3;
            // 
            // cbCalidad
            // 
            cbCalidad.FormattingEnabled = true;
            cbCalidad.Location = new Point(348, 320);
            cbCalidad.Name = "cbCalidad";
            cbCalidad.Size = new Size(157, 23);
            cbCalidad.TabIndex = 4;
            // 
            // cbServicio
            // 
            cbServicio.FormattingEnabled = true;
            cbServicio.Location = new Point(545, 320);
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(138, 23);
            cbServicio.TabIndex = 5;
            // 
            // cbTiempo
            // 
            cbTiempo.FormattingEnabled = true;
            cbTiempo.Location = new Point(716, 321);
            cbTiempo.Name = "cbTiempo";
            cbTiempo.Size = new Size(144, 23);
            cbTiempo.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(111, 393);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(179, 23);
            txtCantidad.TabIndex = 7;
            // 
            // btnregistrar
            // 
            btnregistrar.Location = new Point(115, 446);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(194, 49);
            btnregistrar.TabIndex = 8;
            btnregistrar.Text = "Registrar";
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(988, 43);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(362, 373);
            pictureBoxFoto.TabIndex = 9;
            pictureBoxFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            btnCargarFoto.Location = new Point(1224, 422);
            btnCargarFoto.Name = "btnCargarFoto";
            btnCargarFoto.Size = new Size(126, 37);
            btnCargarFoto.TabIndex = 10;
            btnCargarFoto.Text = "Cargar Foto";
            btnCargarFoto.UseVisualStyleBackColor = true;
            // 
            // btnventa
            // 
            btnventa.Location = new Point(1192, 538);
            btnventa.Name = "btnventa";
            btnventa.Size = new Size(145, 66);
            btnventa.TabIndex = 11;
            btnventa.Text = "Vender";
            btnventa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 289);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 13;
            label2.Text = "Formato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 289);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 15;
            label4.Text = "Servicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(716, 289);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 16;
            label5.Text = "Tiempo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 364);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 17;
            label6.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 289);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 18;
            label3.Text = "Calidad";
            // 
            // dgvDetallesVenta
            // 
            dgvDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesVenta.Location = new Point(169, 592);
            dgvDetallesVenta.Name = "dgvDetallesVenta";
            dgvDetallesVenta.Size = new Size(921, 115);
            dgvDetallesVenta.TabIndex = 19;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 737);
            Controls.Add(dgvDetallesVenta);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnventa);
            Controls.Add(btnCargarFoto);
            Controls.Add(pictureBoxFoto);
            Controls.Add(btnregistrar);
            Controls.Add(txtCantidad);
            Controls.Add(cbTiempo);
            Controls.Add(cbServicio);
            Controls.Add(cbCalidad);
            Controls.Add(cbFormato);
            Controls.Add(listClientes);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnvolver);
            Name = "FormVenta";
            Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver;
        private TextBox txtBuscarCliente;
        private ListBox listClientes;
        private ComboBox cbFormato;
        private ComboBox cbCalidad;
        private ComboBox cbServicio;
        private ComboBox cbTiempo;
        private TextBox txtCantidad;
        private Button btnregistrar;
        private PictureBox pictureBoxFoto;
        private Button btnCargarFoto;
        private Button btnventa;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private DataGridView dgvDetallesVenta;
    }
}