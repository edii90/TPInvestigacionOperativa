using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestigacionOperativa
{
    public class ClaseZ
    {
        private double entrada;
        private double salida;

        public ClaseZ(double entrada, double salida)
        {
            this.entrada = entrada;
            this.salida = salida;
        }

        public double Entrada
        {
            get { return entrada; }
            set { entrada = value; }
        }

        public double Salida
        {
            get { return salida; }
            set { salida = value; }
        }
    }
}
