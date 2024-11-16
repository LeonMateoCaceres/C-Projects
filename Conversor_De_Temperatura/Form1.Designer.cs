namespace Conversor_De_Temperatura
{
    partial class conversorDeTemperaturaForm
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
            this.convertirBTN = new System.Windows.Forms.Button();
            this.temperaturasGB = new System.Windows.Forms.GroupBox();
            this.ingresarTemperaturaLBL = new System.Windows.Forms.Label();
            this.temperaturaTXT = new System.Windows.Forms.TextBox();
            this.celsiusRB = new System.Windows.Forms.RadioButton();
            this.fahrenheitRB = new System.Windows.Forms.RadioButton();
            this.resultadoLBL = new System.Windows.Forms.Label();
            this.temperaturasGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertirBTN
            // 
            this.convertirBTN.Location = new System.Drawing.Point(175, 173);
            this.convertirBTN.Name = "convertirBTN";
            this.convertirBTN.Size = new System.Drawing.Size(115, 34);
            this.convertirBTN.TabIndex = 0;
            this.convertirBTN.Text = "Convertir";
            this.convertirBTN.UseVisualStyleBackColor = true;
            this.convertirBTN.Click += new System.EventHandler(this.convertirBTN_Click);
            // 
            // temperaturasGB
            // 
            this.temperaturasGB.Controls.Add(this.resultadoLBL);
            this.temperaturasGB.Controls.Add(this.celsiusRB);
            this.temperaturasGB.Controls.Add(this.convertirBTN);
            this.temperaturasGB.Controls.Add(this.fahrenheitRB);
            this.temperaturasGB.Controls.Add(this.ingresarTemperaturaLBL);
            this.temperaturasGB.Controls.Add(this.temperaturaTXT);
            this.temperaturasGB.Location = new System.Drawing.Point(13, 12);
            this.temperaturasGB.Name = "temperaturasGB";
            this.temperaturasGB.Size = new System.Drawing.Size(622, 255);
            this.temperaturasGB.TabIndex = 1;
            this.temperaturasGB.TabStop = false;
            this.temperaturasGB.Text = "Temperaturas";
            // 
            // ingresarTemperaturaLBL
            // 
            this.ingresarTemperaturaLBL.AutoSize = true;
            this.ingresarTemperaturaLBL.Location = new System.Drawing.Point(-1, 50);
            this.ingresarTemperaturaLBL.Name = "ingresarTemperaturaLBL";
            this.ingresarTemperaturaLBL.Size = new System.Drawing.Size(170, 20);
            this.ingresarTemperaturaLBL.TabIndex = 0;
            this.ingresarTemperaturaLBL.Text = "Ingrese la temperatura";
            // 
            // temperaturaTXT
            // 
            this.temperaturaTXT.Location = new System.Drawing.Point(175, 44);
            this.temperaturaTXT.Name = "temperaturaTXT";
            this.temperaturaTXT.Size = new System.Drawing.Size(126, 26);
            this.temperaturaTXT.TabIndex = 2;
            // 
            // celsiusRB
            // 
            this.celsiusRB.AutoSize = true;
            this.celsiusRB.Location = new System.Drawing.Point(175, 91);
            this.celsiusRB.Name = "celsiusRB";
            this.celsiusRB.Size = new System.Drawing.Size(85, 24);
            this.celsiusRB.TabIndex = 3;
            this.celsiusRB.TabStop = true;
            this.celsiusRB.Text = "Celsius";
            this.celsiusRB.UseVisualStyleBackColor = true;
            // 
            // fahrenheitRB
            // 
            this.fahrenheitRB.AutoSize = true;
            this.fahrenheitRB.Location = new System.Drawing.Point(175, 121);
            this.fahrenheitRB.Name = "fahrenheitRB";
            this.fahrenheitRB.Size = new System.Drawing.Size(111, 24);
            this.fahrenheitRB.TabIndex = 4;
            this.fahrenheitRB.TabStop = true;
            this.fahrenheitRB.Text = "Fahrenheit";
            this.fahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // resultadoLBL
            // 
            this.resultadoLBL.AutoSize = true;
            this.resultadoLBL.Location = new System.Drawing.Point(451, 47);
            this.resultadoLBL.Name = "resultadoLBL";
            this.resultadoLBL.Size = new System.Drawing.Size(90, 20);
            this.resultadoLBL.TabIndex = 5;
            this.resultadoLBL.Text = "Resultado: ";
            // 
            // conversorDeTemperaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temperaturasGB);
            this.Name = "conversorDeTemperaturaForm";
            this.Text = "Conversor de Temperatura";
            this.temperaturasGB.ResumeLayout(false);
            this.temperaturasGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button convertirBTN;
        private System.Windows.Forms.GroupBox temperaturasGB;
        private System.Windows.Forms.RadioButton celsiusRB;
        private System.Windows.Forms.RadioButton fahrenheitRB;
        private System.Windows.Forms.Label ingresarTemperaturaLBL;
        private System.Windows.Forms.TextBox temperaturaTXT;
        private System.Windows.Forms.Label resultadoLBL;
    }
}

