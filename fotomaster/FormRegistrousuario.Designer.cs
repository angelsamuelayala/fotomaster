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
            btnvolver = new Button();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtusuario = new TextBox();
            txtpassword = new TextBox();
            rbAdmin = new RadioButton();
            rbEmpleado = new RadioButton();
            btnregistro = new Button();
            btnbuscar = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnvolver
            // 
            btnvolver.Location = new Point(26, 29);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(130, 41);
            btnvolver.TabIndex = 0;
            btnvolver.Text = "Volver";
            btnvolver.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(181, 106);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(243, 23);
            txtnombre.TabIndex = 1;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(181, 161);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(243, 23);
            txtapellido.TabIndex = 2;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(181, 217);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(243, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(181, 269);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(243, 23);
            txtpassword.TabIndex = 4;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(181, 336);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(101, 19);
            rbAdmin.TabIndex = 5;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Administrador";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            rbEmpleado.AutoSize = true;
            rbEmpleado.Location = new Point(315, 336);
            rbEmpleado.Name = "rbEmpleado";
            rbEmpleado.Size = new Size(78, 19);
            rbEmpleado.TabIndex = 6;
            rbEmpleado.TabStop = true;
            rbEmpleado.Text = "Empleado";
            rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnregistro
            // 
            btnregistro.Location = new Point(102, 400);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(152, 49);
            btnregistro.TabIndex = 7;
            btnregistro.Text = "Registrar";
            btnregistro.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(321, 400);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(147, 49);
            btnbuscar.TabIndex = 8;
            btnbuscar.Text = "Busqueda";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(515, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(349, 363);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 114);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 169);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 225);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 12;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 277);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 13;
            label4.Text = "Contraseña:";
            // 
            // FormRegistrousuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 501);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnbuscar);
            Controls.Add(btnregistro);
            Controls.Add(rbEmpleado);
            Controls.Add(rbAdmin);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(btnvolver);
            Name = "FormRegistrousuario";
            Text = "FormRegistrousuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnvolver;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtusuario;
        private TextBox txtpassword;
        private RadioButton rbAdmin;
        private RadioButton rbEmpleado;
        private Button btnregistro;
        private Button btnbuscar;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}