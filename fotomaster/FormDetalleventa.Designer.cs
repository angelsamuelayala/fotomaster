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
            btnvolver = new Button();
            txtBuscarCliente = new TextBox();
            listClientes = new ListBox();
            btnRefrescar = new Button();
            dgvVenta = new DataGridView();
            dgvDetalle = new DataGridView();
            btnseleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(15, 22);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(132, 69);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(196, 105);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(286, 23);
            txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(198, 141);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(282, 124);
            listClientes.TabIndex = 2;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(635, 59);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(141, 69);
            btnRefrescar.TabIndex = 3;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(808, 70);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.Size = new Size(424, 403);
            dgvVenta.TabIndex = 4;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(97, 529);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.Size = new Size(1099, 163);
            dgvDetalle.TabIndex = 5;
            // 
            // btnseleccionar
            // 
            btnseleccionar.Location = new Point(648, 425);
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.Size = new Size(126, 64);
            btnseleccionar.TabIndex = 6;
            btnseleccionar.Text = "seleccionar";
            btnseleccionar.UseVisualStyleBackColor = true;
            // 
            // FormDetalleventa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 738);
            Controls.Add(btnseleccionar);
            Controls.Add(dgvDetalle);
            Controls.Add(dgvVenta);
            Controls.Add(btnRefrescar);
            Controls.Add(listClientes);
            Controls.Add(txtBuscarCliente);
            Controls.Add(btnvolver);
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
        private Button btnRefrescar;
        private DataGridView dgvVenta;
        private DataGridView dgvDetalle;
        private Button btnseleccionar;
    }
}