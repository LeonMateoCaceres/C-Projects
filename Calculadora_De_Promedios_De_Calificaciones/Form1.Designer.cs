namespace Calculadora_De_Promedios_De_Calificaciones
{
    partial class CalculadoraDePromediosForm
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
            this.notasLISTB = new System.Windows.Forms.ListBox();
            this.altoLBL = new System.Windows.Forms.Label();
            this.promedioLBL = new System.Windows.Forms.Label();
            this.bajoLBL = new System.Windows.Forms.Label();
            this.agregarBTN = new System.Windows.Forms.Button();
            this.calcularBTN = new System.Windows.Forms.Button();
            this.notasTXT = new System.Windows.Forms.TextBox();
            this.notasLBL = new System.Windows.Forms.Label();
            this.ingresoGB = new System.Windows.Forms.GroupBox();
            this.resultadosGB = new System.Windows.Forms.GroupBox();
            this.ingresoGB.SuspendLayout();
            this.resultadosGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // notasLISTB
            // 
            this.notasLISTB.FormattingEnabled = true;
            this.notasLISTB.ItemHeight = 20;
            this.notasLISTB.Location = new System.Drawing.Point(19, 236);
            this.notasLISTB.Name = "notasLISTB";
            this.notasLISTB.Size = new System.Drawing.Size(227, 164);
            this.notasLISTB.TabIndex = 0;
            // 
            // altoLBL
            // 
            this.altoLBL.AutoSize = true;
            this.altoLBL.Location = new System.Drawing.Point(6, 89);
            this.altoLBL.Name = "altoLBL";
            this.altoLBL.Size = new System.Drawing.Size(157, 20);
            this.altoLBL.TabIndex = 1;
            this.altoLBL.Text = "Calificación más alta:";
            // 
            // promedioLBL
            // 
            this.promedioLBL.AutoSize = true;
            this.promedioLBL.Location = new System.Drawing.Point(10, 35);
            this.promedioLBL.Name = "promedioLBL";
            this.promedioLBL.Size = new System.Drawing.Size(80, 20);
            this.promedioLBL.TabIndex = 2;
            this.promedioLBL.Text = "Promedio:";
            // 
            // bajoLBL
            // 
            this.bajoLBL.AutoSize = true;
            this.bajoLBL.Location = new System.Drawing.Point(6, 143);
            this.bajoLBL.Name = "bajoLBL";
            this.bajoLBL.Size = new System.Drawing.Size(161, 20);
            this.bajoLBL.TabIndex = 3;
            this.bajoLBL.Text = "Calificación más baja:";
            // 
            // agregarBTN
            // 
            this.agregarBTN.Location = new System.Drawing.Point(19, 172);
            this.agregarBTN.Name = "agregarBTN";
            this.agregarBTN.Size = new System.Drawing.Size(97, 34);
            this.agregarBTN.TabIndex = 4;
            this.agregarBTN.Text = "Agregar";
            this.agregarBTN.UseVisualStyleBackColor = true;
            this.agregarBTN.Click += new System.EventHandler(this.agregarBTN_Click);
            // 
            // calcularBTN
            // 
            this.calcularBTN.Location = new System.Drawing.Point(149, 172);
            this.calcularBTN.Name = "calcularBTN";
            this.calcularBTN.Size = new System.Drawing.Size(97, 34);
            this.calcularBTN.TabIndex = 5;
            this.calcularBTN.Text = "Calcular";
            this.calcularBTN.UseVisualStyleBackColor = true;
            this.calcularBTN.Click += new System.EventHandler(this.calcularBTN_Click);
            // 
            // notasTXT
            // 
            this.notasTXT.Location = new System.Drawing.Point(19, 105);
            this.notasTXT.Name = "notasTXT";
            this.notasTXT.Size = new System.Drawing.Size(227, 26);
            this.notasTXT.TabIndex = 6;
            // 
            // notasLBL
            // 
            this.notasLBL.AutoSize = true;
            this.notasLBL.Location = new System.Drawing.Point(15, 71);
            this.notasLBL.Name = "notasLBL";
            this.notasLBL.Size = new System.Drawing.Size(131, 20);
            this.notasLBL.TabIndex = 7;
            this.notasLBL.Text = "Ingrese las notas";
            // 
            // ingresoGB
            // 
            this.ingresoGB.Controls.Add(this.agregarBTN);
            this.ingresoGB.Controls.Add(this.notasLISTB);
            this.ingresoGB.Controls.Add(this.notasLBL);
            this.ingresoGB.Controls.Add(this.calcularBTN);
            this.ingresoGB.Controls.Add(this.notasTXT);
            this.ingresoGB.Location = new System.Drawing.Point(12, 12);
            this.ingresoGB.Name = "ingresoGB";
            this.ingresoGB.Size = new System.Drawing.Size(268, 430);
            this.ingresoGB.TabIndex = 8;
            this.ingresoGB.TabStop = false;
            this.ingresoGB.Text = "Ingreso";
            // 
            // resultadosGB
            // 
            this.resultadosGB.Controls.Add(this.altoLBL);
            this.resultadosGB.Controls.Add(this.promedioLBL);
            this.resultadosGB.Controls.Add(this.bajoLBL);
            this.resultadosGB.Location = new System.Drawing.Point(339, 12);
            this.resultadosGB.Name = "resultadosGB";
            this.resultadosGB.Size = new System.Drawing.Size(307, 196);
            this.resultadosGB.TabIndex = 0;
            this.resultadosGB.TabStop = false;
            this.resultadosGB.Text = "Resultados";
            // 
            // CalculadoraDePromediosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 498);
            this.Controls.Add(this.resultadosGB);
            this.Controls.Add(this.ingresoGB);
            this.Name = "CalculadoraDePromediosForm";
            this.Text = "Calculadora de Promedios de Notas";
            this.ingresoGB.ResumeLayout(false);
            this.ingresoGB.PerformLayout();
            this.resultadosGB.ResumeLayout(false);
            this.resultadosGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox notasLISTB;
        private System.Windows.Forms.Label altoLBL;
        private System.Windows.Forms.Label promedioLBL;
        private System.Windows.Forms.Label bajoLBL;
        private System.Windows.Forms.Button agregarBTN;
        private System.Windows.Forms.Button calcularBTN;
        private System.Windows.Forms.TextBox notasTXT;
        private System.Windows.Forms.Label notasLBL;
        private System.Windows.Forms.GroupBox ingresoGB;
        private System.Windows.Forms.GroupBox resultadosGB;
    }
}

