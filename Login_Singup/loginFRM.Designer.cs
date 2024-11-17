namespace Login_Singup
{
    partial class loginFRM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuarioLBL = new System.Windows.Forms.Label();
            this.contraseniaLBL = new System.Windows.Forms.Label();
            this.nombreUsuarioLoginTXT = new System.Windows.Forms.TextBox();
            this.passwordLoginTXT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingresarBTN = new System.Windows.Forms.Button();
            this.registrarseBTN = new System.Windows.Forms.Button();
            this.registroLBL = new System.Windows.Forms.Label();
            this.registrateGB = new System.Windows.Forms.GroupBox();
            this.passwordCB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.registrateGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioLBL
            // 
            this.usuarioLBL.AutoSize = true;
            this.usuarioLBL.Location = new System.Drawing.Point(6, 42);
            this.usuarioLBL.Name = "usuarioLBL";
            this.usuarioLBL.Size = new System.Drawing.Size(143, 20);
            this.usuarioLBL.TabIndex = 0;
            this.usuarioLBL.Text = "Nombre de usuario";
            // 
            // contraseniaLBL
            // 
            this.contraseniaLBL.AutoSize = true;
            this.contraseniaLBL.Location = new System.Drawing.Point(6, 102);
            this.contraseniaLBL.Name = "contraseniaLBL";
            this.contraseniaLBL.Size = new System.Drawing.Size(92, 20);
            this.contraseniaLBL.TabIndex = 1;
            this.contraseniaLBL.Text = "Contraseña";
            // 
            // nombreUsuarioLoginTXT
            // 
            this.nombreUsuarioLoginTXT.Location = new System.Drawing.Point(155, 42);
            this.nombreUsuarioLoginTXT.Name = "nombreUsuarioLoginTXT";
            this.nombreUsuarioLoginTXT.Size = new System.Drawing.Size(177, 26);
            this.nombreUsuarioLoginTXT.TabIndex = 2;
            // 
            // passwordLoginTXT
            // 
            this.passwordLoginTXT.Location = new System.Drawing.Point(155, 96);
            this.passwordLoginTXT.Name = "passwordLoginTXT";
            this.passwordLoginTXT.PasswordChar = '*';
            this.passwordLoginTXT.Size = new System.Drawing.Size(177, 26);
            this.passwordLoginTXT.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordCB);
            this.groupBox1.Controls.Add(this.ingresarBTN);
            this.groupBox1.Controls.Add(this.usuarioLBL);
            this.groupBox1.Controls.Add(this.passwordLoginTXT);
            this.groupBox1.Controls.Add(this.contraseniaLBL);
            this.groupBox1.Controls.Add(this.nombreUsuarioLoginTXT);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iniciar Sesión";
            // 
            // ingresarBTN
            // 
            this.ingresarBTN.Location = new System.Drawing.Point(155, 215);
            this.ingresarBTN.Name = "ingresarBTN";
            this.ingresarBTN.Size = new System.Drawing.Size(112, 39);
            this.ingresarBTN.TabIndex = 4;
            this.ingresarBTN.Text = "Ingresar";
            this.ingresarBTN.UseVisualStyleBackColor = true;
            this.ingresarBTN.Click += new System.EventHandler(this.ingresarBTN_Click);
            // 
            // registrarseBTN
            // 
            this.registrarseBTN.Location = new System.Drawing.Point(64, 90);
            this.registrarseBTN.Name = "registrarseBTN";
            this.registrarseBTN.Size = new System.Drawing.Size(110, 45);
            this.registrarseBTN.TabIndex = 5;
            this.registrarseBTN.Text = "Registrarse";
            this.registrarseBTN.UseVisualStyleBackColor = true;
            this.registrarseBTN.Click += new System.EventHandler(this.registrarseBTN_Click);
            // 
            // registroLBL
            // 
            this.registroLBL.AutoSize = true;
            this.registroLBL.Location = new System.Drawing.Point(15, 42);
            this.registroLBL.Name = "registroLBL";
            this.registroLBL.Size = new System.Drawing.Size(217, 20);
            this.registroLBL.TabIndex = 6;
            this.registroLBL.Text = "Si no tenés cuenta, registrate";
            // 
            // registrateGB
            // 
            this.registrateGB.Controls.Add(this.registroLBL);
            this.registrateGB.Controls.Add(this.registrarseBTN);
            this.registrateGB.Location = new System.Drawing.Point(390, 24);
            this.registrateGB.Name = "registrateGB";
            this.registrateGB.Size = new System.Drawing.Size(238, 288);
            this.registrateGB.TabIndex = 7;
            this.registrateGB.TabStop = false;
            this.registrateGB.Text = "Registrate";
            // 
            // passwordCB
            // 
            this.passwordCB.AutoSize = true;
            this.passwordCB.Location = new System.Drawing.Point(155, 148);
            this.passwordCB.Name = "passwordCB";
            this.passwordCB.Size = new System.Drawing.Size(173, 24);
            this.passwordCB.TabIndex = 14;
            this.passwordCB.Text = "Mostrar contraseña";
            this.passwordCB.UseVisualStyleBackColor = true;
            this.passwordCB.CheckedChanged += new System.EventHandler(this.passwordCB_CheckedChanged);
            // 
            // loginFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 324);
            this.Controls.Add(this.registrateGB);
            this.Controls.Add(this.groupBox1);
            this.Name = "loginFRM";
            this.Text = "Inicio de sesión";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.registrateGB.ResumeLayout(false);
            this.registrateGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usuarioLBL;
        private System.Windows.Forms.Label contraseniaLBL;
        private System.Windows.Forms.TextBox nombreUsuarioLoginTXT;
        private System.Windows.Forms.TextBox passwordLoginTXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ingresarBTN;
        private System.Windows.Forms.Button registrarseBTN;
        private System.Windows.Forms.Label registroLBL;
        private System.Windows.Forms.GroupBox registrateGB;
        private System.Windows.Forms.CheckBox passwordCB;
    }
}

