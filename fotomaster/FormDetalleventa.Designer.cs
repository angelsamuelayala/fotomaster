namespace fotomaster
{
    partial class FormDetalleventa
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
            dgvVenta = new DataGridView();
            dgvDetalle = new DataGridView();
            btnvolverr = new MaterialSkin.Controls.MaterialFlatButton();
            btnseleccionarr = new MaterialSkin.Controls.MaterialFlatButton();
            btnRefrescarr = new MaterialSkin.Controls.MaterialFlatButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(447, 172);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(321, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(447, 208);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(319, 124);
            listClientes.TabIndex = 2;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(990, 160);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.Size = new Size(830, 522);
            dgvVenta.TabIndex = 4;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(447, 730);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(1373, 277);
            dgvDetalle.TabIndex = 5;
            // 
            // btnvolverr
            // 
            btnvolverr.AutoSize = true;
            btnvolverr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnvolverr.Depth = 0;
            btnvolverr.Icon = null;
            btnvolverr.Location = new Point(13, 81);
            btnvolverr.Margin = new Padding(4, 6, 4, 6);
            btnvolverr.MouseState = MaterialSkin.MouseState.HOVER;
            btnvolverr.Name = "btnvolverr";
            btnvolverr.Primary = false;
            btnvolverr.Size = new Size(72, 36);
            btnvolverr.TabIndex = 7;
            btnvolverr.Text = "Volver";
            btnvolverr.UseVisualStyleBackColor = true;
            btnvolverr.Click += btnvolver_Click;
            // 
            // btnseleccionarr
            // 
            btnseleccionarr.AutoSize = true;
            btnseleccionarr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnseleccionarr.Depth = 0;
            btnseleccionarr.Icon = null;
            btnseleccionarr.Location = new Point(447, 674);
            btnseleccionarr.Margin = new Padding(4, 6, 4, 6);
            btnseleccionarr.MouseState = MaterialSkin.MouseState.HOVER;
            btnseleccionarr.Name = "btnseleccionarr";
            btnseleccionarr.Primary = false;
            btnseleccionarr.Size = new Size(111, 36);
            btnseleccionarr.TabIndex = 9;
            btnseleccionarr.Text = "Seleccionar";
            btnseleccionarr.UseVisualStyleBackColor = true;
            btnseleccionarr.Click += btnseleccionar_Click;
            // 
            // btnRefrescarr
            // 
            btnRefrescarr.AutoSize = true;
            btnRefrescarr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefrescarr.Depth = 0;
            btnRefrescarr.Icon = null;
            btnRefrescarr.Location = new Point(862, 160);
            btnRefrescarr.Margin = new Padding(4, 6, 4, 6);
            btnRefrescarr.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefrescarr.Name = "btnRefrescarr";
            btnRefrescarr.Primary = false;
            btnRefrescarr.Size = new Size(96, 36);
            btnRefrescarr.TabIndex = 10;
            btnRefrescarr.Text = "Refrescar";
            btnRefrescarr.UseVisualStyleBackColor = true;
            btnRefrescarr.Click += btnRefrescar_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(284, 176);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(142, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Nombre del Cliente:";
            // 
            // FormDetalleventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1940, 1080);
            Controls.Add(materialLabel1);
            Controls.Add(btnRefrescarr);
            Controls.Add(btnseleccionarr);
            Controls.Add(btnvolverr);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvVenta);
            Controls.Add(listClientes);
            Controls.Add(txtBuscarCliente);
            Name = "FormDetalleventa";
            Text = "FormDetalleventa";
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver;
        private TextBox txtBuscarCliente;
        private ListBox listClientes;
        private DataGridView dgvVenta;
        private DataGridView dgvDetalle;
        private MaterialSkin.Controls.MaterialFlatButton btnvolverr;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton btnseleccionarr;
        private MaterialSkin.Controls.MaterialFlatButton btnRefrescarr;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}