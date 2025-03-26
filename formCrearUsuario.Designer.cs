namespace ProyectoA_CrearUsuarioLocal_CSharp
{
    partial class formCrearUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtGrupo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtContrasena = new TextBox();
            label5 = new Label();
            btCrearUsuario = new Button();
            btDeshabilitarUsuario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 36);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(176, 33);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(176, 115);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(311, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 118);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(176, 156);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(155, 23);
            txtGrupo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 159);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 4;
            label3.Text = "Grupo de seguridad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 159);
            label4.Name = "label4";
            label4.Size = new Size(271, 15);
            label4.TabIndex = 6;
            label4.Text = "<< El grupo de seguridad debe existir en el equipo";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(176, 71);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(155, 23);
            txtContrasena.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 74);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "Contraseña";
            // 
            // btCrearUsuario
            // 
            btCrearUsuario.Location = new Point(270, 222);
            btCrearUsuario.Name = "btCrearUsuario";
            btCrearUsuario.Size = new Size(133, 44);
            btCrearUsuario.TabIndex = 4;
            btCrearUsuario.Text = "Crear usuario";
            btCrearUsuario.UseVisualStyleBackColor = true;
            btCrearUsuario.Click += btCrearUsuario_Click;
            // 
            // btDeshabilitarUsuario
            // 
            btDeshabilitarUsuario.Location = new Point(354, 21);
            btDeshabilitarUsuario.Name = "btDeshabilitarUsuario";
            btDeshabilitarUsuario.Size = new Size(133, 44);
            btDeshabilitarUsuario.TabIndex = 5;
            btDeshabilitarUsuario.Text = "Deshabilitar usuario";
            btDeshabilitarUsuario.UseVisualStyleBackColor = true;
            btDeshabilitarUsuario.Click += btDeshabilitarUsuario_Click;
            // 
            // formCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 294);
            Controls.Add(btDeshabilitarUsuario);
            Controls.Add(btCrearUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtGrupo);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "formCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProyectoA - Crear usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtGrupo;
        private Label label3;
        private Label label4;
        private TextBox txtContrasena;
        private Label label5;
        private Button btCrearUsuario;
        private Button btDeshabilitarUsuario;
    }
}
