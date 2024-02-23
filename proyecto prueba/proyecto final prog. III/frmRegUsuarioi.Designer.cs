namespace proyecto_final_prog._III
{
    partial class frmRegUsuarioi
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtCi = new TextBox();
            txtConfContrasena = new TextBox();
            txtContrasena = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnRegistrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 50);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 117);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "CI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtCi
            // 
            txtCi.Location = new Point(67, 135);
            txtCi.Name = "txtCi";
            txtCi.Size = new Size(100, 23);
            txtCi.TabIndex = 3;
            // 
            // txtConfContrasena
            // 
            txtConfContrasena.Location = new Point(67, 266);
            txtConfContrasena.Name = "txtConfContrasena";
            txtConfContrasena.Size = new Size(100, 23);
            txtConfContrasena.TabIndex = 7;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(67, 199);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 248);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 5;
            label3.Text = "CONFIRMA CONTRASEÑA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 181);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 4;
            label4.Text = "CONTRASEÑA";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(329, 307);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 45);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(649, 307);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 45);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmRegUsuarioi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtConfContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtCi);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegUsuarioi";
            Text = "frmRegUsuarioi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtCi;
        private TextBox txtConfContrasena;
        private TextBox txtContrasena;
        private Label label3;
        private Label label4;
        private Button btnRegistrar;
        private Button btnSalir;
    }
}