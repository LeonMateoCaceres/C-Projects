namespace Conversor_De_Moneda
{
    partial class Form1
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
            this.monedaEURUSDGB = new System.Windows.Forms.GroupBox();
            this.EUR_O_USD_TXT = new System.Windows.Forms.TextBox();
            this.ingresarLBL = new System.Windows.Forms.Label();
            this.calcular_USD_EUR_BTN = new System.Windows.Forms.Button();
            this.EUR_A_ARS_CB = new System.Windows.Forms.CheckBox();
            this.USD_A_ARS_CB = new System.Windows.Forms.CheckBox();
            this.conversion_USD_EUR_GB = new System.Windows.Forms.GroupBox();
            this.resultado_USD_EUR_LBL = new System.Windows.Forms.Label();
            this.monedaEURUSDGB.SuspendLayout();
            this.conversion_USD_EUR_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // monedaEURUSDGB
            // 
            this.monedaEURUSDGB.Controls.Add(this.EUR_O_USD_TXT);
            this.monedaEURUSDGB.Controls.Add(this.ingresarLBL);
            this.monedaEURUSDGB.Controls.Add(this.calcular_USD_EUR_BTN);
            this.monedaEURUSDGB.Controls.Add(this.EUR_A_ARS_CB);
            this.monedaEURUSDGB.Controls.Add(this.USD_A_ARS_CB);
            this.monedaEURUSDGB.Location = new System.Drawing.Point(12, 12);
            this.monedaEURUSDGB.Name = "monedaEURUSDGB";
            this.monedaEURUSDGB.Size = new System.Drawing.Size(416, 261);
            this.monedaEURUSDGB.TabIndex = 7;
            this.monedaEURUSDGB.TabStop = false;
            this.monedaEURUSDGB.Text = "Ingrese moneda (USD/EUR)";
            // 
            // EUR_O_USD_TXT
            // 
            this.EUR_O_USD_TXT.Location = new System.Drawing.Point(263, 62);
            this.EUR_O_USD_TXT.Name = "EUR_O_USD_TXT";
            this.EUR_O_USD_TXT.Size = new System.Drawing.Size(128, 26);
            this.EUR_O_USD_TXT.TabIndex = 5;
            // 
            // ingresarLBL
            // 
            this.ingresarLBL.AutoSize = true;
            this.ingresarLBL.Location = new System.Drawing.Point(6, 62);
            this.ingresarLBL.Name = "ingresarLBL";
            this.ingresarLBL.Size = new System.Drawing.Size(251, 20);
            this.ingresarLBL.TabIndex = 2;
            this.ingresarLBL.Text = "Ingrese el valor en USD o en EUR";
            // 
            // calcular_USD_EUR_BTN
            // 
            this.calcular_USD_EUR_BTN.Location = new System.Drawing.Point(173, 188);
            this.calcular_USD_EUR_BTN.Name = "calcular_USD_EUR_BTN";
            this.calcular_USD_EUR_BTN.Size = new System.Drawing.Size(84, 29);
            this.calcular_USD_EUR_BTN.TabIndex = 0;
            this.calcular_USD_EUR_BTN.Text = "Calcular";
            this.calcular_USD_EUR_BTN.UseVisualStyleBackColor = true;
            this.calcular_USD_EUR_BTN.Click += new System.EventHandler(this.calcular_USD_EUR_BTN_Click);
            // 
            // EUR_A_ARS_CB
            // 
            this.EUR_A_ARS_CB.AutoSize = true;
            this.EUR_A_ARS_CB.Location = new System.Drawing.Point(24, 149);
            this.EUR_A_ARS_CB.Name = "EUR_A_ARS_CB";
            this.EUR_A_ARS_CB.Size = new System.Drawing.Size(188, 24);
            this.EUR_A_ARS_CB.TabIndex = 1;
            this.EUR_A_ARS_CB.Text = "Convertir EUR a ARS";
            this.EUR_A_ARS_CB.UseVisualStyleBackColor = true;
            // 
            // USD_A_ARS_CB
            // 
            this.USD_A_ARS_CB.AutoSize = true;
            this.USD_A_ARS_CB.Location = new System.Drawing.Point(24, 101);
            this.USD_A_ARS_CB.Name = "USD_A_ARS_CB";
            this.USD_A_ARS_CB.Size = new System.Drawing.Size(188, 24);
            this.USD_A_ARS_CB.TabIndex = 0;
            this.USD_A_ARS_CB.Text = "Convertir USD a ARS";
            this.USD_A_ARS_CB.UseVisualStyleBackColor = true;
            // 
            // conversion_USD_EUR_GB
            // 
            this.conversion_USD_EUR_GB.Controls.Add(this.resultado_USD_EUR_LBL);
            this.conversion_USD_EUR_GB.Location = new System.Drawing.Point(575, 12);
            this.conversion_USD_EUR_GB.Name = "conversion_USD_EUR_GB";
            this.conversion_USD_EUR_GB.Size = new System.Drawing.Size(233, 261);
            this.conversion_USD_EUR_GB.TabIndex = 8;
            this.conversion_USD_EUR_GB.TabStop = false;
            this.conversion_USD_EUR_GB.Text = "Conversión";
            // 
            // resultado_USD_EUR_LBL
            // 
            this.resultado_USD_EUR_LBL.AutoSize = true;
            this.resultado_USD_EUR_LBL.Location = new System.Drawing.Point(6, 46);
            this.resultado_USD_EUR_LBL.Name = "resultado_USD_EUR_LBL";
            this.resultado_USD_EUR_LBL.Size = new System.Drawing.Size(86, 20);
            this.resultado_USD_EUR_LBL.TabIndex = 3;
            this.resultado_USD_EUR_LBL.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 288);
            this.Controls.Add(this.conversion_USD_EUR_GB);
            this.Controls.Add(this.monedaEURUSDGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.monedaEURUSDGB.ResumeLayout(false);
            this.monedaEURUSDGB.PerformLayout();
            this.conversion_USD_EUR_GB.ResumeLayout(false);
            this.conversion_USD_EUR_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox monedaEURUSDGB;
        private System.Windows.Forms.TextBox EUR_O_USD_TXT;
        private System.Windows.Forms.Label ingresarLBL;
        private System.Windows.Forms.Button calcular_USD_EUR_BTN;
        private System.Windows.Forms.CheckBox EUR_A_ARS_CB;
        private System.Windows.Forms.CheckBox USD_A_ARS_CB;
        private System.Windows.Forms.GroupBox conversion_USD_EUR_GB;
        private System.Windows.Forms.Label resultado_USD_EUR_LBL;
    }
}

