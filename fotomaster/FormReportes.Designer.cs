namespace fotomaster
{
    partial class FormReportes
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
            dgvVentas = new DataGridView();
            dgvDescuentos = new DataGridView();
            cmbServicio = new ComboBox();
            cmbMes = new ComboBox();
            cmbAnio = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblTotalVentas = new Label();
            lblTotalDescuentos = new Label();
            btnRefrescar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(40, 48);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(334, 197);
            dgvVentas.TabIndex = 0;
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Location = new Point(451, 48);
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.Size = new Size(311, 197);
            dgvDescuentos.TabIndex = 1;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(76, 272);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(161, 23);
            cmbServicio.TabIndex = 2;
            // 
            // cmbMes
            // 
            cmbMes.FormattingEnabled = true;
            cmbMes.Location = new Point(467, 272);
            cmbMes.Name = "cmbMes";
            cmbMes.Size = new Size(168, 23);
            cmbMes.TabIndex = 3;
            // 
            // cmbAnio
            // 
            cmbAnio.FormattingEnabled = true;
            cmbAnio.Location = new Point(467, 318);
            cmbAnio.Name = "cmbAnio";
            cmbAnio.Size = new Size(168, 23);
            cmbAnio.TabIndex = 4;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(76, 315);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(239, 23);
            dtpFecha.TabIndex = 5;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Location = new Point(76, 384);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(38, 15);
            lblTotalVentas.TabIndex = 6;
            lblTotalVentas.Text = "label1";
            // 
            // lblTotalDescuentos
            // 
            lblTotalDescuentos.AutoSize = true;
            lblTotalDescuentos.Location = new Point(475, 361);
            lblTotalDescuentos.Name = "lblTotalDescuentos";
            lblTotalDescuentos.Size = new Size(38, 15);
            lblTotalDescuentos.TabIndex = 7;
            lblTotalDescuentos.Text = "label2";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(74, 349);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(109, 27);
            btnRefrescar.TabIndex = 8;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefrescar);
            Controls.Add(lblTotalDescuentos);
            Controls.Add(lblTotalVentas);
            Controls.Add(dtpFecha);
            Controls.Add(cmbAnio);
            Controls.Add(cmbMes);
            Controls.Add(cmbServicio);
            Controls.Add(dgvDescuentos);
            Controls.Add(dgvVentas);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridView dgvDescuentos;
        private ComboBox cmbServicio;
        private ComboBox cmbMes;
        private ComboBox cmbAnio;
        private DateTimePicker dtpFecha;
        private Label lblTotalVentas;
        private Label lblTotalDescuentos;
        private Button btnRefrescar;
    }
}