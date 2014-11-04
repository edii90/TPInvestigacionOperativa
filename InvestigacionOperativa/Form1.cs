using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvestigacionOperativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioCantFija.Checked == true)
            {
                Form form1 = new formCantidadFijaPedido();
                form1.Show();
            }
        if (radioCantFijaProd.Checked == true)
        {
            Form form1 = new formCantidadFijoPedidoDuranteProduccion();
            form1.Show();
            }
        if (radioButton1.Checked == true)
        {
            Form form1 = new formCantidadFijaPedidoNiverlServicio();
            form1.Show();
            }
        if (radioButton3.Checked == true)
        {
            Form form1 = new formPeriodoTiempoFijoNiverlServicio();
            form1.Show();
            }
        }
    }
}
