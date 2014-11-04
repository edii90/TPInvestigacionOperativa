namespace InvestigacionOperativa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioCantFijaProd = new System.Windows.Forms.RadioButton();
            this.radioCantFija = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioCantFijaProd);
            this.groupBox2.Controls.Add(this.radioCantFija);
            this.groupBox2.Location = new System.Drawing.Point(33, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(496, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion el modelo ";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(52, 142);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(372, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Modelo de Periodo de tiempo fijo con Nivel de Servicio";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(52, 107);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(385, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Modelo de Cantidad Fija de Pedido con Nivel de Servicio";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioCantFijaProd
            // 
            this.radioCantFijaProd.AutoSize = true;
            this.radioCantFijaProd.Location = new System.Drawing.Point(52, 73);
            this.radioCantFijaProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCantFijaProd.Name = "radioCantFijaProd";
            this.radioCantFijaProd.Size = new System.Drawing.Size(376, 21);
            this.radioCantFijaProd.TabIndex = 1;
            this.radioCantFijaProd.TabStop = true;
            this.radioCantFijaProd.Text = "Modelo de Cantidad Fija de Pedido durante producción";
            this.radioCantFijaProd.UseVisualStyleBackColor = true;
            // 
            // radioCantFija
            // 
            this.radioCantFija.AutoSize = true;
            this.radioCantFija.Location = new System.Drawing.Point(52, 37);
            this.radioCantFija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCantFija.Name = "radioCantFija";
            this.radioCantFija.Size = new System.Drawing.Size(249, 21);
            this.radioCantFija.TabIndex = 0;
            this.radioCantFija.TabStop = true;
            this.radioCantFija.Text = "Modelo de Cantidad Fija de Pedido";
            this.radioCantFija.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioCantFijaProd;
        private System.Windows.Forms.RadioButton radioCantFija;
        private System.Windows.Forms.Button button1;
    }
}

