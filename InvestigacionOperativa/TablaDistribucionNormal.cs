using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestigacionOperativa
{
    public class TablaDistribucionNormal
    {
        private List<ClaseZ> listaDistribucionNormal = new List<ClaseZ>();

        public TablaDistribucionNormal()
        {
            CargarTabla();
        }

        private void AgregarZ(double entrada, double salida)
        {
            ClaseZ z = new ClaseZ(entrada, salida);
            listaDistribucionNormal.Add(z);
        }

        public double DevolverZ(double entrada)
        {
            ClaseZ mayor = null;
            double valor = 0;
            foreach (ClaseZ aux in listaDistribucionNormal)
            {
                if (aux.Entrada == entrada)
                {
                    valor = aux.Salida;
                    break;
                }
                else
                {
                    if (aux.Entrada > entrada)
                    {
                        mayor = aux;
                    }
                    else
                    {
                        double mayorValor = mayor.Entrada - entrada;
                        double menorValor = entrada - aux.Entrada;
                        if (mayorValor > menorValor)
                        {
                            valor = menorValor;
                            break;
                        }
                        else if (mayorValor < menorValor)
                        {
                            valor = mayorValor;
                            break;
                        }
                        else if (mayorValor == menorValor)
                        {
                            valor = mayorValor;
                            break;
                        }
                    }
                }
            }
            return valor;
        }

        private void CargarTabla()
        {
            AgregarZ(4.500, (-4.5));
            AgregarZ(4.400, (-4.40));
            AgregarZ(4.300, (-4.30));
            AgregarZ(4.200, (-4.20));
            AgregarZ(4.100, (-4.10));
            AgregarZ(4.000, (-4.00));
            AgregarZ(3.900, (-3.90));
            AgregarZ(3.800, (-3.80));
            AgregarZ(3.700, (-3.70));
            AgregarZ(3.600, (-3.60));
            AgregarZ(3.500, (-3.50));
            AgregarZ(3.400, (-3.40));
            AgregarZ(3.300, (-3.30));
            AgregarZ(3.200, (-3.20));
            AgregarZ(3.100, (-3.10));
            AgregarZ(3.000, (-3.00));
            AgregarZ(2.901, (-2.90));
            AgregarZ(2.801, (-2.80));
            AgregarZ(2.701, (-2.70));
            AgregarZ(2.601, (-2.60));
            AgregarZ(2.502, (-2.50));
            AgregarZ(2.403, (-2.40));
            AgregarZ(2.303, (-2.30));
            AgregarZ(2.205, (-2.20));
            AgregarZ(2.106, (-2.10));
            AgregarZ(2.008, (-2.00));
            AgregarZ(1.911, (-1.90));
            AgregarZ(1.814, (-1.80));
            AgregarZ(1.718, (-1.70));
            AgregarZ(1.623, (-1.60));
            AgregarZ(1.529, (-1.70));
            AgregarZ(1.437, (-1.40));
            AgregarZ(1.346, (-1.30));
            AgregarZ(1.256, (-1.20));
            AgregarZ(1.169, (-1.10));
            AgregarZ(1.083, (-1.00));
            AgregarZ(1.000, (-0.90));
            AgregarZ(0.920, (-0.80));
            AgregarZ(0.843, (-0.70));
            AgregarZ(0.769, (-0.60));
            AgregarZ(0.698, (-0.50));
            AgregarZ(0.630, (-0.40));
            AgregarZ(0.567, (-0.30));
            AgregarZ(0.507, (-0.20));
            AgregarZ(0.451, (-0.10));
            AgregarZ(0.399, 0.00);
            AgregarZ(0.351, 0.10);
            AgregarZ(0.307, 0.20);
            AgregarZ(0.267, 0.30);
            AgregarZ(0.230, 0.40);
            AgregarZ(0.198, 0.50);
            AgregarZ(0.169, 0.60);
            AgregarZ(0.143, 0.70);
            AgregarZ(0.120, 0.80);
            AgregarZ(0.100, 0.90);
            AgregarZ(0.083, 1.00);
            AgregarZ(0.069, 1.10);
            AgregarZ(0.056, 1.20);
            AgregarZ(0.046, 1.30);
            AgregarZ(0.037, 1.40);
            AgregarZ(0.029, 1.50);
            AgregarZ(0.023, 1.60);
            AgregarZ(0.018, 1.70);
            AgregarZ(0.014, 1.80);
            AgregarZ(0.011, 1.90);
            AgregarZ(0.008, 2.00);
            AgregarZ(0.006, 2.10);
            AgregarZ(0.005, 2.20);
            AgregarZ(0.004, 2.30);
            AgregarZ(0.003, 2.40);
            AgregarZ(0.002, 2.50);
            AgregarZ(0.001, 2.60);
            AgregarZ(0.000, 3.00);
        }

    }
}
