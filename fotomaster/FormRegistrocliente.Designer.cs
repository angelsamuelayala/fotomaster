namespace fotomaster
{
    partial class FormRegistrocliente
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
            btnregistro = new Button();
            btnbuscar = new Button();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(12, 22);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(146, 63);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            // 
            // btnregistro
            // 
            btnregistro.Location = new Point(184, 388);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(150, 70);
            btnregistro.TabIndex = 1;
            btnregistro.Text = "Registrar";
            btnregistro.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(434, 388);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(162, 67);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(200, 241);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(308, 23);
            txtapellido.TabIndex = 3;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(200, 173);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(304, 23);
            txtnombre.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(706, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 453);
            dataGridView1.TabIndex = 5;
            // 
            // FormRegistrocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 546);
            Controls.Add(dataGridView1);
            Controls.Add(txtnombre);
            Controls.Add(txtapellido);
            Controls.Add(btnbuscar);
            Controls.Add(btnregistro);
            Controls.Add(btnvolver);
            Name = "FormRegistrocliente";
            Text = "FormRegistrocliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver;
        private Button btnregistro;
        private Button btnbuscar;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private DataGridView dataGridView1;
    }
}