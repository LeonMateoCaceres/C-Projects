namespace Login_Singup
{
    partial class registroFRM
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
            this.registroGB = new System.Windows.Forms.GroupBox();
            this.telefonoTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edadTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signupBTN = new System.Windows.Forms.Button();
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.contraseniaLBL = new System.Windows.Forms.Label();
            this.nombreUsuarioSignupTXT = new System.Windows.Forms.TextBox();
            this.registrateGB = new System.Windows.Forms.GroupBox();
            this.registroLBL = new System.Windows.Forms.Label();
            this.iniciarSesionBTN = new System.Windows.Forms.Button();
            this.passwordCB = new System.Windows.Forms.CheckBox();
            this.registroGB.SuspendLayout();
            this.registrateGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // registroGB
            // 
            this.registroGB.Controls.Add(this.passwordCB);
            this.registroGB.Controls.Add(this.telefonoTXT);
            this.registroGB.Controls.Add(this.label4);
            this.registroGB.Controls.Add(this.edadTXT);
            this.registroGB.Controls.Add(this.label3);
            this.registroGB.Controls.Add(this.mailTXT);
            this.registroGB.Controls.Add(this.label2);
            this.registroGB.Controls.Add(this.nombreTXT);
            this.registroGB.Controls.Add(this.label1);
            this.registroGB.Controls.Add(this.signupBTN);
            this.registroGB.Controls.Add(this.usuarioLBL);
            this.registroGB.Controls.Add(this.passwordTXT);
            this.registroGB.Controls.Add(this.contraseniaLBL);
            this.registroGB.Controls.Add(this.nombreUsuarioSignupTXT);
            this.registroGB.Location = new System.Drawing.Point(12, 12);
            this.registroGB.Name = "registroGB";
            this.registroGB.Size = new System.Drawing.Size(346, 426);
            this.registroGB.TabIndex = 5;
            this.registroGB.TabStop = false;
            this.registroGB.Text = "Registro";
            // 
            // telefonoTXT
            // 
            this.telefonoTXT.Location = new System.Drawing.Point(149, 218);
            this.telefonoTXT.Name = "telefonoTXT";
            this.telefonoTXT.Size = new System.Drawing.Size(191, 26);
            this.telefonoTXT.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Teléfono";
            // 
            // edadTXT
            // 
            this.edadTXT.Location = new System.Drawing.Point(149, 172);
            this.edadTXT.Name = "edadTXT";
            this.edadTXT.Size = new System.Drawing.Size(191, 26);
            this.edadTXT.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edad";
            // 
            // mailTXT
            // 
            this.mailTXT.Location = new System.Drawing.Point(149, 136);
            this.mailTXT.Name = "mailTXT";
            this.mailTXT.Size = new System.Drawing.Size(191, 26);
            this.mailTXT.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mail";
            // 
            // nombreTXT
            // 
            this.nombreTXT.Location = new System.Drawing.Point(149, 98);
            this.nombreTXT.Name = "nombreTXT";
            this.nombreTXT.Size = new System.Drawing.Size(191, 26);
            this.nombreTXT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // signupBTN
            // 
            this.signupBTN.Location = new System.Drawing.Point(100, 360);
            this.signupBTN.Name = "signupBTN";
            this.signupBTN.Size = new System.Drawing.Size(124, 60);
            this.signupBTN.TabIndex = 4;
            this.signupBTN.Text = "Crear Cuenta";
            this.signupBTN.UseVisualStyleBackColor = true;
            this.signupBTN.Click += new System.EventHandler(this.signupBTN_Click);
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.Location = new System.Drawing.Point(0, 57);
            this.usuarioLBL.Name = "usuarioLBL";
            this.usuarioLBL.Size = new System.Drawing.Size(143, 20);
            this.usuarioLBL.TabIndex = 0;
            this.usuarioLBL.Text = "Nombre de usuario";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(149, 261);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.PasswordChar = '*';
            this.passwordTXT.Size = new System.Drawing.Size(191, 26);
            this.passwordTXT.TabIndex = 3;
            // 
            // contraseniaLBL
            // 
            this.contraseniaLBL.AutoSize = true;
            this.contraseniaLBL.Location = new System.Drawing.Point(6, 261);
            this.contraseniaLBL.Name = "contraseniaLBL";
            this.contraseniaLBL.Size = new System.Drawing.Size(92, 20);
            this.contraseniaLBL.TabIndex = 1;
            this.contraseniaLBL.Text = "Contraseña";
            // 
            // nombreUsuarioSignupTXT
            // 
            this.nombreUsuarioSignupTXT.Location = new System.Drawing.Point(149, 57);
            this.nombreUsuarioSignupTXT.Name = "nombreUsuarioSignupTXT";
            this.nombreUsuarioSignupTXT.Size = new System.Drawing.Size(191, 26);
            this.nombreUsuarioSignupTXT.TabIndex = 2;
            // 
            // registrateGB
            // 
            this.registrateGB.Controls.Add(this.registroLBL);
            this.registrateGB.Controls.Add(this.iniciarSesionBTN);
            this.registrateGB.Location = new System.Drawing.Point(556, 15);
            this.registrateGB.Name = "registrateGB";
            this.registrateGB.Size = new System.Drawing.Size(241, 195);
            this.registrateGB.TabIndex = 8;
            this.registrateGB.TabStop = false;
            this.registrateGB.Text = "Iniciar Sesión";
            // 
            // registroLBL
            // 
            this.registroLBL.AutoSize = true;
            this.registroLBL.Location = new System.Drawing.Point(6, 42);
            this.registroLBL.Name = "registroLBL";
            this.registroLBL.Size = new System.Drawing.Size(235, 20);
            this.registroLBL.TabIndex = 6;
            this.registroLBL.Text = "Si ya tenés cuenta, Inicia sesión";
            // 
            // iniciarSesionBTN
            // 
            this.iniciarSesionBTN.Location = new System.Drawing.Point(10, 90);
            this.iniciarSesionBTN.Name = "iniciarSesionBTN";
            this.iniciarSesionBTN.Size = new System.Drawing.Size(133, 56);
            this.iniciarSesionBTN.TabIndex = 5;
            this.iniciarSesionBTN.Text = "Iniciar sesión";
            this.iniciarSesionBTN.UseVisualStyleBackColor = true;
            this.iniciarSesionBTN.Click += new System.EventHandler(this.iniciarSesionBTN_Click);
            // 
            // passwordCB
            // 
            this.passwordCB.AutoSize = true;
            this.passwordCB.Location = new System.Drawing.Point(149, 293);
            this.passwordCB.Name = "passwordCB";
            this.passwordCB.Size = new System.Drawing.Size(173, 24);
            this.passwordCB.TabIndex = 13;
            this.passwordCB.Text = "Mostrar contraseña";
            this.passwordCB.UseVisualStyleBackColor = true;
            this.passwordCB.CheckedChanged += new System.EventHandler(this.passwordCB_CheckedChanged);
            // 
            // registroFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrateGB);
            this.Controls.Add(this.registroGB);
            this.Name = "registroFRM";
            this.Text = "Registro";
            this.registroGB.ResumeLayout(false);
            this.registroGB.PerformLayout();
            this.registrateGB.ResumeLayout(false);
            this.registrateGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registroGB;
        private System.Windows.Forms.Button signupBTN;
        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label contraseniaLBL;
        private System.Windows.Forms.TextBox nombreUsuarioSignupTXT;
        private System.Windows.Forms.GroupBox registrateGB;
        private System.Windows.Forms.Label registroLBL;
        private System.Windows.Forms.Button iniciarSesionBTN;
        private System.Windows.Forms.TextBox edadTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefonoTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox passwordCB;
    }
}