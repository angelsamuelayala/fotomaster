namespace fotomaster
{
    partial class FormRegistrousuario
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
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtusuario = new TextBox();
            txtpassword = new TextBox();
            dataGridView1 = new DataGridView();
            btnvolverr = new MaterialSkin.Controls.MaterialFlatButton();
            btnregistror = new MaterialSkin.Controls.MaterialFlatButton();
            btnbuscarr = new MaterialSkin.Controls.MaterialFlatButton();
            rbAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            rbEmpleado = new MaterialSkin.Controls.MaterialRadioButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(304, 260);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(243, 23);
            txtnombre.TabIndex = 1;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(304, 315);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(243, 23);
            txtapellido.TabIndex = 2;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(304, 371);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(243, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(304, 423);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(243, 23);
            txtpassword.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(825, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(513, 811);
            dataGridView1.TabIndex = 9;
            // 
            // btnvolverr
            // 
            btnvolverr.AutoSize = true;
            btnvolverr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnvolverr.Depth = 0;
            btnvolverr.Icon = null;
            btnvolverr.Location = new Point(13, 78);
            btnvolverr.Margin = new Padding(4, 6, 4, 6);
            btnvolverr.MouseState = MaterialSkin.MouseState.HOVER;
            btnvolverr.Name = "btnvolverr";
            btnvolverr.Primary = false;
            btnvolverr.Size = new Size(72, 36);
            btnvolverr.TabIndex = 14;
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
            btnregistror.Location = new Point(245, 564);
            btnregistror.Margin = new Padding(4, 6, 4, 6);
            btnregistror.MouseState = MaterialSkin.MouseState.HOVER;
            btnregistror.Name = "btnregistror";
            btnregistror.Primary = false;
            btnregistror.Size = new Size(93, 36);
            btnregistror.TabIndex = 15;
            btnregistror.Text = "Registrar";
            btnregistror.UseVisualStyleBackColor = true;
            btnregistror.Click += btnregistro_Click;
            // 
            // btnbuscarr
            // 
            btnbuscarr.AutoSize = true;
            btnbuscarr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnbuscarr.Depth = 0;
            btnbuscarr.Icon = null;
            btnbuscarr.Location = new Point(443, 564);
            btnbuscarr.Margin = new Padding(4, 6, 4, 6);
            btnbuscarr.MouseState = MaterialSkin.MouseState.HOVER;
            btnbuscarr.Name = "btnbuscarr";
            btnbuscarr.Primary = false;
            btnbuscarr.Size = new Size(74, 36);
            btnbuscarr.TabIndex = 16;
            btnbuscarr.Text = "Buscar";
            btnbuscarr.UseVisualStyleBackColor = true;
            btnbuscarr.Click += btnbuscar_Click;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Depth = 0;
            rbAdmin.Font = new Font("Roboto", 10F);
            rbAdmin.Location = new Point(245, 488);
            rbAdmin.Margin = new Padding(0);
            rbAdmin.MouseLocation = new Point(-1, -1);
            rbAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Ripple = true;
            rbAdmin.Size = new Size(117, 30);
            rbAdmin.TabIndex = 17;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Administrador";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            rbEmpleado.AutoSize = true;
            rbEmpleado.Depth = 0;
            rbEmpleado.Font = new Font("Roboto", 10F);
            rbEmpleado.Location = new Point(427, 488);
            rbEmpleado.Margin = new Padding(0);
            rbEmpleado.MouseLocation = new Point(-1, -1);
            rbEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            rbEmpleado.Name = "rbEmpleado";
            rbEmpleado.Ripple = true;
            rbEmpleado.Size = new Size(90, 30);
            rbEmpleado.TabIndex = 18;
            rbEmpleado.TabStop = true;
            rbEmpleado.Text = "Empleado";
            rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(195, 264);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(67, 19);
            materialLabel1.TabIndex = 19;
            materialLabel1.Text = "Nombre:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 11F);
            materialLabel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel2.Location = new Point(195, 315);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(68, 19);
            materialLabel2.TabIndex = 20;
            materialLabel2.Text = "Apeliido:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 11F);
            materialLabel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel3.Location = new Point(195, 375);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(65, 19);
            materialLabel3.TabIndex = 21;
            materialLabel3.Text = "Usuario:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 11F);
            materialLabel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel4.Location = new Point(195, 427);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(90, 19);
            materialLabel4.TabIndex = 22;
            materialLabel4.Text = "Contraseña:";
            // 
            // FormRegistrousuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1041);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(rbEmpleado);
            Controls.Add(rbAdmin);
            Controls.Add(btnbuscarr);
            Controls.Add(btnregistror);
            Controls.Add(btnvolverr);
            Controls.Add(dataGridView1);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Name = "FormRegistrousuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistrousuario";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtusuario;
        private TextBox txtpassword;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btnvolverr;
        private MaterialSkin.Controls.MaterialFlatButton btnregistror;
        private MaterialSkin.Controls.MaterialFlatButton btnbuscarr;
        private MaterialSkin.Controls.MaterialRadioButton rbAdmin;
        private MaterialSkin.Controls.MaterialRadioButton rbEmpleado;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}