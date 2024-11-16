namespace Tarea_1_SumasYRestas
{
    partial class Calculadora_Basica_Form
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
            this.SumarBTN = new System.Windows.Forms.Button();
            this.RestarBTN = new System.Windows.Forms.Button();
            this.Numero2LBL = new System.Windows.Forms.Label();
            this.Numero1LBL = new System.Windows.Forms.Label();
            this.Numero2TXT = new System.Windows.Forms.TextBox();
            this.Numero1TXT = new System.Windows.Forms.TextBox();
            this.ResultadoGB = new System.Windows.Forms.GroupBox();
            this.OperacionesGB = new System.Windows.Forms.GroupBox();
            this.ResultadoLBL = new System.Windows.Forms.Label();
            this.ResultadoGB.SuspendLayout();
            this.OperacionesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SumarBTN
            // 
            this.SumarBTN.Location = new System.Drawing.Point(10, 155);
            this.SumarBTN.Name = "SumarBTN";
            this.SumarBTN.Size = new System.Drawing.Size(102, 37);
            this.SumarBTN.TabIndex = 0;
            this.SumarBTN.Text = "Sumar";
            this.SumarBTN.UseVisualStyleBackColor = true;
            this.SumarBTN.Click += new System.EventHandler(this.SumarBTN_Click);
            // 
            // RestarBTN
            // 
            this.RestarBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RestarBTN.Location = new System.Drawing.Point(237, 155);
            this.RestarBTN.Name = "RestarBTN";
            this.RestarBTN.Size = new System.Drawing.Size(103, 41);
            this.RestarBTN.TabIndex = 1;
            this.RestarBTN.Text = "Restar";
            this.RestarBTN.UseVisualStyleBackColor = true;
            this.RestarBTN.Click += new System.EventHandler(this.RestarBTN_Click);
            // 
            // Numero2LBL
            // 
            this.Numero2LBL.AutoSize = true;
            this.Numero2LBL.Location = new System.Drawing.Point(262, 39);
            this.Numero2LBL.Name = "Numero2LBL";
            this.Numero2LBL.Size = new System.Drawing.Size(78, 20);
            this.Numero2LBL.TabIndex = 2;
            this.Numero2LBL.Text = "Número 2";
            // 
            // Numero1LBL
            // 
            this.Numero1LBL.AutoSize = true;
            this.Numero1LBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Numero1LBL.Location = new System.Drawing.Point(6, 39);
            this.Numero1LBL.Name = "Numero1LBL";
            this.Numero1LBL.Size = new System.Drawing.Size(78, 20);
            this.Numero1LBL.TabIndex = 3;
            this.Numero1LBL.Text = "Número 1";
            // 
            // Numero2TXT
            // 
            this.Numero2TXT.Location = new System.Drawing.Point(240, 76);
            this.Numero2TXT.Name = "Numero2TXT";
            this.Numero2TXT.Size = new System.Drawing.Size(100, 26);
            this.Numero2TXT.TabIndex = 4;
            // 
            // Numero1TXT
            // 
            this.Numero1TXT.Location = new System.Drawing.Point(10, 76);
            this.Numero1TXT.Name = "Numero1TXT";
            this.Numero1TXT.Size = new System.Drawing.Size(100, 26);
            this.Numero1TXT.TabIndex = 5;
            this.Numero1TXT.TextChanged += new System.EventHandler(this.Numero1TXT_TextChanged);
            // 
            // ResultadoGB
            // 
            this.ResultadoGB.Controls.Add(this.ResultadoLBL);
            this.ResultadoGB.Location = new System.Drawing.Point(413, 23);
            this.ResultadoGB.Name = "ResultadoGB";
            this.ResultadoGB.Size = new System.Drawing.Size(200, 223);
            this.ResultadoGB.TabIndex = 6;
            this.ResultadoGB.TabStop = false;
            this.ResultadoGB.Text = "Resultado";
            // 
            // OperacionesGB
            // 
            this.OperacionesGB.Controls.Add(this.Numero1TXT);
            this.OperacionesGB.Controls.Add(this.Numero2TXT);
            this.OperacionesGB.Controls.Add(this.SumarBTN);
            this.OperacionesGB.Controls.Add(this.RestarBTN);
            this.OperacionesGB.Controls.Add(this.Numero2LBL);
            this.OperacionesGB.Controls.Add(this.Numero1LBL);
            this.OperacionesGB.Location = new System.Drawing.Point(12, 23);
            this.OperacionesGB.Name = "OperacionesGB";
            this.OperacionesGB.Size = new System.Drawing.Size(346, 214);
            this.OperacionesGB.TabIndex = 0;
            this.OperacionesGB.TabStop = false;
            this.OperacionesGB.Text = "Ingrese Aquí";
            // 
            // ResultadoLBL
            // 
            this.ResultadoLBL.AutoSize = true;
            this.ResultadoLBL.Location = new System.Drawing.Point(16, 39);
            this.ResultadoLBL.Name = "ResultadoLBL";
            this.ResultadoLBL.Size = new System.Drawing.Size(82, 20);
            this.ResultadoLBL.TabIndex = 7;
            this.ResultadoLBL.Text = "Resultado";
            this.ResultadoLBL.Click += new System.EventHandler(this.ResultadoLBL_Click);
            // 
            // Calculadora_Basica_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OperacionesGB);
            this.Controls.Add(this.ResultadoGB);
            this.Name = "Calculadora_Basica_Form";
            this.Text = "Calculadora Básica";
            this.ResultadoGB.ResumeLayout(false);
            this.ResultadoGB.PerformLayout();
            this.OperacionesGB.ResumeLayout(false);
            this.OperacionesGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SumarBTN;
        private System.Windows.Forms.Button RestarBTN;
        private System.Windows.Forms.Label Numero2LBL;
        private System.Windows.Forms.Label Numero1LBL;
        private System.Windows.Forms.TextBox Numero2TXT;
        private System.Windows.Forms.TextBox Numero1TXT;
        private System.Windows.Forms.GroupBox ResultadoGB;
        private System.Windows.Forms.GroupBox OperacionesGB;
        private System.Windows.Forms.Label ResultadoLBL;
    }
}

