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
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            dataGridView1 = new DataGridView();
            btnvolverr = new MaterialSkin.Controls.MaterialFlatButton();
            btnregistror = new MaterialSkin.Controls.MaterialFlatButton();
            btnbuscarr = new MaterialSkin.Controls.MaterialFlatButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(287, 389);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(308, 23);
            txtapellido.TabIndex = 3;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(287, 321);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(304, 23);
            txtnombre.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(825, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 884);
            dataGridView1.TabIndex = 5;
            // 
            // btnvolverr
            // 
            btnvolverr.AutoSize = true;
            btnvolverr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnvolverr.Depth = 0;
            btnvolverr.Icon = null;
            btnvolverr.Location = new Point(13, 75);
            btnvolverr.Margin = new Padding(4, 6, 4, 6);
            btnvolverr.MouseState = MaterialSkin.MouseState.HOVER;
            btnvolverr.Name = "btnvolverr";
            btnvolverr.Primary = false;
            btnvolverr.Size = new Size(72, 36);
            btnvolverr.TabIndex = 6;
            btnvolverr.Text = "Volver";
            btnvolverr.UseVisualStyleBackColor = true;
            btnvolverr.Click += btnvolver_Click;
            // 
            // btnregistror
            // 
            btnregistror.AutoSize = true;
            btnregistror.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnregistror.Depth = 0;
            btnregistror.Icon = null;
            btnregistror.Location = new Point(287, 567);
            btnregistror.Margin = new Padding(4, 6, 4, 6);
            btnregistror.MouseState = MaterialSkin.MouseState.HOVER;
            btnregistror.Name = "btnregistror";
            btnregistror.Primary = false;
            btnregistror.Size = new Size(85, 36);
            btnregistror.TabIndex = 7;
            btnregistror.Text = "Registro";
            btnregistror.UseVisualStyleBackColor = true;
            btnregistror.Click += btnregistro_Click;
            // 
            // btnbuscarr
            // 
            btnbuscarr.AutoSize = true;
            btnbuscarr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnbuscarr.Depth = 0;
            btnbuscarr.Icon = null;
            btnbuscarr.Location = new Point(484, 567);
            btnbuscarr.Margin = new Padding(4, 6, 4, 6);
            btnbuscarr.MouseState = MaterialSkin.MouseState.HOVER;
            btnbuscarr.Name = "btnbuscarr";
            btnbuscarr.Primary = false;
            btnbuscarr.Size = new Size(74, 36);
            btnbuscarr.TabIndex = 8;
            btnbuscarr.Text = "Buscar";
            btnbuscarr.UseVisualStyleBackColor = true;
            btnbuscarr.Click += btnbuscar_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(195, 321);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(67, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Nombre:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(195, 389);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(76, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Apellidos:";
            // 
            // FormRegistrocliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1940, 1080);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(btnbuscarr);
            Controls.Add(btnregistror);
            Controls.Add(btnvolverr);
            Controls.Add(dataGridView1);
            Controls.Add(txtnombre);
            Controls.Add(txtapellido);
            Name = "FormRegistrocliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormRegistrocliente";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Btnvolver_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox txtapellido;
        private TextBox txtnombre;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnvolverr;
        private MaterialSkin.Controls.MaterialFlatButton btnregistror;
        private MaterialSkin.Controls.MaterialFlatButton btnbuscarr;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}