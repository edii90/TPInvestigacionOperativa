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
    public partial class formCantidadFijaPedidoNiverlServicio : Form
    {
        ModeloCantidadFijaConServicio modelo;

        public formCantidadFijaPedidoNiverlServicio()
        {
            InitializeComponent();
        }


        private void cargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDemandaAnual.Text != "")
                    modelo._demandaAnual = Convert.ToInt32(txtDemandaAnual.Text);
                if (txtDemandaPromedioDiaria.Text != "")
                    modelo._demandaDiaria = Convert.ToDouble(txtDemandaPromedioDiaria.Text);
                if (txtCostoPorUnidad.Text != "")
                    modelo._costoUnitario = Convert.ToDouble(txtCostoPorUnidad.Text);
                if (txtCostoDeColocacionDeUnPedido.Text != "")
                    modelo._costoTotalAnualPedido = Convert.ToDouble(txtCostoDeColocacionDeUnPedido.Text);
                if (txtDiasLaborales.Text != "")
                    modelo._diasLaborales = Convert.ToInt32(txtDiasLaborales.Text);
                if (txtLeadTime.Text != "")
                    modelo._leadTime = Convert.ToInt32(txtLeadTime.Text);
                if (txtCostoAnualDeAlmacenamientoPorUnidad.Text != "")
                    modelo._costoTotalAnualMantenimiento = Convert.ToDouble(txtCostoAnualDeAlmacenamientoPorUnidad.Text);
                if (txtNivelDeServicio.Text != "")
                    modelo._nivelServicioEsperado = Convert.ToDouble(txtNivelDeServicio.Text) / 100;
                if (txtDesviacionStandarDeLaDemanda.Text != "")
                    modelo._desviacionDeDemandaDiaria = Convert.ToDouble(txtDesviacionStandarDeLaDemanda.Text);
                if (txtDiasLaborales.Text != "")
                    modelo._diasLaborales = Convert.ToInt32(txtDiasLaborales.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void formCantidadFijaPedidoNiverlServicio_Load(object sender, EventArgs e)
        {
            modelo = new ModeloCantidadFijaConServicio();
        }
    }
}
