namespace fotomaster
{
    partial class FormReporte
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
            dtpFecha = new DateTimePicker();
            cmbServicio = new ComboBox();
            btnRefrescar = new MaterialSkin.Controls.MaterialFlatButton();
            lblTotalVentas = new MaterialSkin.Controls.MaterialLabel();
            lblTotalDescuentos = new MaterialSkin.Controls.MaterialLabel();
            btnvolver = new MaterialSkin.Controls.MaterialFlatButton();
            dtpMesAnioDescuento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(306, 134);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(675, 504);
            dgvVentas.TabIndex = 0;
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Location = new Point(1141, 143);
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.Size = new Size(685, 495);
            dgvDescuentos.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(306, 668);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(252, 23);
            dtpFecha.TabIndex = 2;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(71, 220);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(208, 23);
            cmbServicio.TabIndex = 3;
            // 
            // btnRefrescar
            // 
            btnRefrescar.AutoSize = true;
            btnRefrescar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefrescar.Depth = 0;
            btnRefrescar.Icon = null;
            btnRefrescar.Location = new Point(183, 134);
            btnRefrescar.Margin = new Padding(4, 6, 4, 6);
            btnRefrescar.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Primary = false;
            btnRefrescar.Size = new Size(96, 36);
            btnRefrescar.TabIndex = 6;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Depth = 0;
            lblTotalVentas.Font = new Font("Roboto", 11F);
            lblTotalVentas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTotalVentas.Location = new Point(306, 742);
            lblTotalVentas.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(108, 19);
            lblTotalVentas.TabIndex = 7;
            lblTotalVentas.Text = "materialLabel1";
            // 
            // lblTotalDescuentos
            // 
            lblTotalDescuentos.AutoSize = true;
            lblTotalDescuentos.Depth = 0;
            lblTotalDescuentos.Font = new Font("Roboto", 11F);
            lblTotalDescuentos.ForeColor = Color.FromArgb(222, 0, 0, 0);
            lblTotalDescuentos.Location = new Point(1153, 742);
            lblTotalDescuentos.MouseState = MaterialSkin.MouseState.HOVER;
            lblTotalDescuentos.Name = "lblTotalDescuentos";
            lblTotalDescuentos.Size = new Size(108, 19);
            lblTotalDescuentos.TabIndex = 8;
            lblTotalDescuentos.Text = "materialLabel2";
            // 
            // btnvolver
            // 
            btnvolver.AutoSize = true;
            btnvolver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnvolver.Depth = 0;
            btnvolver.Icon = null;
            btnvolver.Location = new Point(13, 73);
            btnvolver.Margin = new Padding(4, 6, 4, 6);
            btnvolver.MouseState = MaterialSkin.MouseState.HOVER;
            btnvolver.Name = "btnvolver";
            btnvolver.Primary = false;
            btnvolver.Size = new Size(72, 36);
            btnvolver.TabIndex = 9;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            btnvolver.Click += btnvolver_Click;
            // 
            // dtpMesAnioDescuento
            // 
            dtpMesAnioDescuento.Location = new Point(1141, 668);
            dtpMesAnioDescuento.Name = "dtpMesAnioDescuento";
            dtpMesAnioDescuento.Size = new Size(349, 23);
            dtpMesAnioDescuento.TabIndex = 10;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(dtpMesAnioDescuento);
            Controls.Add(btnvolver);
            Controls.Add(lblTotalDescuentos);
            Controls.Add(lblTotalVentas);
            Controls.Add(btnRefrescar);
            Controls.Add(cmbServicio);
            Controls.Add(dtpFecha);
            Controls.Add(dgvDescuentos);
            Controls.Add(dgvVentas);
            Name = "FormReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporte";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private DataGridView dgvDescuentos;
        private DateTimePicker dtpFecha;
        private ComboBox cmbServicio;
        private MaterialSkin.Controls.MaterialFlatButton btnRefrescar;
        private MaterialSkin.Controls.MaterialLabel lblTotalVentas;
        private MaterialSkin.Controls.MaterialLabel lblTotalDescuentos;
        private MaterialSkin.Controls.MaterialFlatButton btnvolver;
        private DateTimePicker dtpMesAnioDescuento;
    }
}