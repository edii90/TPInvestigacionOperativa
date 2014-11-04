namespace InvestigacionOperativa
{
    partial class formCantidadFijaPedidoNiverlServicio
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
            this.cargar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDesviacionStandarDeLaDemanda = new System.Windows.Forms.TextBox();
            this.txtNivelDeServicio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCostoDeColocacionDeUnPedido = new System.Windows.Forms.TextBox();
            this.txtCostoAnualDeAlmacenamientoPorUnidad = new System.Windows.Forms.TextBox();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoPorUnidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDemandaPromedioDiaria = new System.Windows.Forms.TextBox();
            this.txtDemandaAnual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCostoAnualDeMantenimiento = new System.Windows.Forms.TextBox();
            this.txtCostoAnualDeLosPedidos = new System.Windows.Forms.TextBox();
            this.txtCostoAnualDeCompras = new System.Windows.Forms.TextBox();
            this.txtMontoOptimo = new System.Windows.Forms.TextBox();
            this.txtCostoAnualTotal = new System.Windows.Forms.TextBox();
            this.txtNmeroDeLotesAnuales = new System.Windows.Forms.TextBox();
            this.txtPuntoDeReorden = new System.Windows.Forms.TextBox();
            this.txtTiempoEntrePedidos = new System.Windows.Forms.TextBox();
            this.txtTiempoEntreLotes = new System.Windows.Forms.TextBox();
            this.txtDiasLaborales = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(170, 171);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(305, 20);
            this.cargar.TabIndex = 11;
            this.cargar.Text = "Cargar";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiasLaborales);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtDesviacionStandarDeLaDemanda);
            this.groupBox1.Controls.Add(this.cargar);
            this.groupBox1.Controls.Add(this.txtNivelDeServicio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCostoDeColocacionDeUnPedido);
            this.groupBox1.Controls.Add(this.txtCostoAnualDeAlmacenamientoPorUnidad);
            this.groupBox1.Controls.Add(this.txtLeadTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCostoPorUnidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDemandaPromedioDiaria);
            this.groupBox1.Controls.Add(this.txtDemandaAnual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 197);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los valores que posea";
            // 
            // txtDesviacionStandarDeLaDemanda
            // 
            this.txtDesviacionStandarDeLaDemanda.Location = new System.Drawing.Point(552, 103);
            this.txtDesviacionStandarDeLaDemanda.Name = "txtDesviacionStandarDeLaDemanda";
            this.txtDesviacionStandarDeLaDemanda.Size = new System.Drawing.Size(73, 20);
            this.txtDesviacionStandarDeLaDemanda.TabIndex = 26;
            // 
            // txtNivelDeServicio
            // 
            this.txtNivelDeServicio.Location = new System.Drawing.Point(552, 77);
            this.txtNivelDeServicio.Name = "txtNivelDeServicio";
            this.txtNivelDeServicio.Size = new System.Drawing.Size(73, 20);
            this.txtNivelDeServicio.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nivel de servicio deseado (%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Costo anual de almacenamiento por unidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Demanda Anual:";
            // 
            // txtCostoDeColocacionDeUnPedido
            // 
            this.txtCostoDeColocacionDeUnPedido.Location = new System.Drawing.Point(210, 109);
            this.txtCostoDeColocacionDeUnPedido.Name = "txtCostoDeColocacionDeUnPedido";
            this.txtCostoDeColocacionDeUnPedido.Size = new System.Drawing.Size(73, 20);
            this.txtCostoDeColocacionDeUnPedido.TabIndex = 19;
            // 
            // txtCostoAnualDeAlmacenamientoPorUnidad
            // 
            this.txtCostoAnualDeAlmacenamientoPorUnidad.Location = new System.Drawing.Point(552, 49);
            this.txtCostoAnualDeAlmacenamientoPorUnidad.Name = "txtCostoAnualDeAlmacenamientoPorUnidad";
            this.txtCostoAnualDeAlmacenamientoPorUnidad.Size = new System.Drawing.Size(73, 20);
            this.txtCostoAnualDeAlmacenamientoPorUnidad.TabIndex = 14;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Location = new System.Drawing.Point(552, 24);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.Size = new System.Drawing.Size(73, 20);
            this.txtLeadTime.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Plazo de reposicion (lead time):";
            // 
            // txtCostoPorUnidad
            // 
            this.txtCostoPorUnidad.Location = new System.Drawing.Point(210, 82);
            this.txtCostoPorUnidad.Name = "txtCostoPorUnidad";
            this.txtCostoPorUnidad.Size = new System.Drawing.Size(73, 20);
            this.txtCostoPorUnidad.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Desviacion Standar de la demanda:";
            // 
            // txtDemandaPromedioDiaria
            // 
            this.txtDemandaPromedioDiaria.Location = new System.Drawing.Point(210, 56);
            this.txtDemandaPromedioDiaria.Name = "txtDemandaPromedioDiaria";
            this.txtDemandaPromedioDiaria.Size = new System.Drawing.Size(73, 20);
            this.txtDemandaPromedioDiaria.TabIndex = 20;
            // 
            // txtDemandaAnual
            // 
            this.txtDemandaAnual.Location = new System.Drawing.Point(210, 24);
            this.txtDemandaAnual.Name = "txtDemandaAnual";
            this.txtDemandaAnual.Size = new System.Drawing.Size(73, 20);
            this.txtDemandaAnual.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Costo de colocacion de un Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Costo por unidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Demanda promedio Diaria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Monto Optimo que se debe ordenar por pedido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Costo anual de compras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Costo anual de los pedidos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Costo anual de mantenimiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Costo anual total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Numero de lotes anual";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(436, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Punto de reorden";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(436, 309);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Tiempo entre pedidos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(435, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Tiempo entre Lotes";
            // 
            // txtCostoAnualDeMantenimiento
            // 
            this.txtCostoAnualDeMantenimiento.Enabled = false;
            this.txtCostoAnualDeMantenimiento.Location = new System.Drawing.Point(292, 347);
            this.txtCostoAnualDeMantenimiento.Name = "txtCostoAnualDeMantenimiento";
            this.txtCostoAnualDeMantenimiento.Size = new System.Drawing.Size(73, 20);
            this.txtCostoAnualDeMantenimiento.TabIndex = 24;
            // 
            // txtCostoAnualDeLosPedidos
            // 
            this.txtCostoAnualDeLosPedidos.Enabled = false;
            this.txtCostoAnualDeLosPedidos.Location = new System.Drawing.Point(292, 310);
            this.txtCostoAnualDeLosPedidos.Name = "txtCostoAnualDeLosPedidos";
            this.txtCostoAnualDeLosPedidos.Size = new System.Drawing.Size(73, 20);
            this.txtCostoAnualDeLosPedidos.TabIndex = 23;
            // 
            // txtCostoAnualDeCompras
            // 
            this.txtCostoAnualDeCompras.Enabled = false;
            this.txtCostoAnualDeCompras.Location = new System.Drawing.Point(292, 276);
            this.txtCostoAnualDeCompras.Name = "txtCostoAnualDeCompras";
            this.txtCostoAnualDeCompras.Size = new System.Drawing.Size(73, 20);
            this.txtCostoAnualDeCompras.TabIndex = 25;
            // 
            // txtMontoOptimo
            // 
            this.txtMontoOptimo.Enabled = false;
            this.txtMontoOptimo.Location = new System.Drawing.Point(292, 235);
            this.txtMontoOptimo.Name = "txtMontoOptimo";
            this.txtMontoOptimo.Size = new System.Drawing.Size(73, 20);
            this.txtMontoOptimo.TabIndex = 22;
            // 
            // txtCostoAnualTotal
            // 
            this.txtCostoAnualTotal.Enabled = false;
            this.txtCostoAnualTotal.Location = new System.Drawing.Point(292, 383);
            this.txtCostoAnualTotal.Name = "txtCostoAnualTotal";
            this.txtCostoAnualTotal.Size = new System.Drawing.Size(73, 20);
            this.txtCostoAnualTotal.TabIndex = 26;
            // 
            // txtNmeroDeLotesAnuales
            // 
            this.txtNmeroDeLotesAnuales.Enabled = false;
            this.txtNmeroDeLotesAnuales.Location = new System.Drawing.Point(583, 228);
            this.txtNmeroDeLotesAnuales.Name = "txtNmeroDeLotesAnuales";
            this.txtNmeroDeLotesAnuales.Size = new System.Drawing.Size(73, 20);
            this.txtNmeroDeLotesAnuales.TabIndex = 27;
            // 
            // txtPuntoDeReorden
            // 
            this.txtPuntoDeReorden.Enabled = false;
            this.txtPuntoDeReorden.Location = new System.Drawing.Point(583, 269);
            this.txtPuntoDeReorden.Name = "txtPuntoDeReorden";
            this.txtPuntoDeReorden.Size = new System.Drawing.Size(73, 20);
            this.txtPuntoDeReorden.TabIndex = 28;
            // 
            // txtTiempoEntrePedidos
            // 
            this.txtTiempoEntrePedidos.Enabled = false;
            this.txtTiempoEntrePedidos.Location = new System.Drawing.Point(583, 306);
            this.txtTiempoEntrePedidos.Name = "txtTiempoEntrePedidos";
            this.txtTiempoEntrePedidos.Size = new System.Drawing.Size(73, 20);
            this.txtTiempoEntrePedidos.TabIndex = 29;
            // 
            // txtTiempoEntreLotes
            // 
            this.txtTiempoEntreLotes.Enabled = false;
            this.txtTiempoEntreLotes.Location = new System.Drawing.Point(583, 343);
            this.txtTiempoEntreLotes.Name = "txtTiempoEntreLotes";
            this.txtTiempoEntreLotes.Size = new System.Drawing.Size(73, 20);
            this.txtTiempoEntreLotes.TabIndex = 30;
            // 
            // txtDiasLaborales
            // 
            this.txtDiasLaborales.Location = new System.Drawing.Point(210, 136);
            this.txtDiasLaborales.Name = "txtDiasLaborales";
            this.txtDiasLaborales.Size = new System.Drawing.Size(73, 20);
            this.txtDiasLaborales.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Dias laborales:";
            // 
            // formCantidadFijaPedidoNiverlServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 438);
            this.Controls.Add(this.txtTiempoEntreLotes);
            this.Controls.Add(this.txtTiempoEntrePedidos);
            this.Controls.Add(this.txtPuntoDeReorden);
            this.Controls.Add(this.txtNmeroDeLotesAnuales);
            this.Controls.Add(this.txtCostoAnualTotal);
            this.Controls.Add(this.txtCostoAnualDeMantenimiento);
            this.Controls.Add(this.txtCostoAnualDeLosPedidos);
            this.Controls.Add(this.txtCostoAnualDeCompras);
            this.Controls.Add(this.txtMontoOptimo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Name = "formCantidadFijaPedidoNiverlServicio";
            this.Text = "formCantidadFijaPedidoNiverlServicio";
            this.Load += new System.EventHandler(this.formCantidadFijaPedidoNiverlServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesviacionStandarDeLaDemanda;
        private System.Windows.Forms.TextBox txtNivelDeServicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCostoDeColocacionDeUnPedido;
        private System.Windows.Forms.TextBox txtCostoAnualDeAlmacenamientoPorUnidad;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostoPorUnidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDemandaPromedioDiaria;
        private System.Windows.Forms.TextBox txtDemandaAnual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCostoAnualDeMantenimiento;
        private System.Windows.Forms.TextBox txtCostoAnualDeLosPedidos;
        private System.Windows.Forms.TextBox txtCostoAnualDeCompras;
        private System.Windows.Forms.TextBox txtMontoOptimo;
        private System.Windows.Forms.TextBox txtCostoAnualTotal;
        private System.Windows.Forms.TextBox txtNmeroDeLotesAnuales;
        private System.Windows.Forms.TextBox txtPuntoDeReorden;
        private System.Windows.Forms.TextBox txtTiempoEntrePedidos;
        private System.Windows.Forms.TextBox txtTiempoEntreLotes;
        private System.Windows.Forms.TextBox txtDiasLaborales;
        private System.Windows.Forms.Label label18;

    }
}