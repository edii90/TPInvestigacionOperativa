using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestigacionOperativa
{
    public class ModeloPeriodoFijo
    {
        private double Z;//Z
        private double _cantidadOptimaQ; //Q
        private double _costoAnualPedido; //S
        private double _costoAnualMantennimiento; //H
        private int _leadTime; //L
        private int _demandaAnual; //D
        private double _demandaPromedio; //d
        private int _diasLaborales;
        private double _costoTotal; //TC
        private double _costoUnitario; //C
        private double _puntoReorden; //R
        private double _nroLotesAnual;
        private double _tiempoEntreRevisiones; //T
        private double _costoTotalAnualPedido; //(D/Q).S
        private double _costoTotalAnualMantenimiento; //(Q/2).H 
        private double _costoTotalAnualDeCompras; // D*C
        private double _nivelActualInvenario; // I 
        private double _desviacionDeDemandaDiaria; // sigma sub D - DATO
        private double _desviacionDeDemandaDuranteEntrega; // sigma sub L
        private double _nivelDeServicio; // P

        public double DemandaPromedioPeriodoVulnerable() // d*(T+L) MODELO PERIODO FIJO
        {
            double d = 0;
            d = _demandaPromedio * (_leadTime * _tiempoEntreRevisiones);
            return d;
        }

        public double DesviacionTyL() // sigma de T+L - MODELO PERIODO FIJO
        {
            double tl = 0;
            tl = (System.Math.Sqrt(_leadTime + _tiempoEntreRevisiones)) * _desviacionDeDemandaDiaria;
            return tl;
        }

        public double ExistenciaDeSeguridad() //FALTA REMPLAZAR Z - MODELO PERIODO FIJO
        {
            double rs = 0;
            rs = Z * DesviacionTyL();
            return rs;
        }

        public double CantidadOptimaQ()
        {
            _cantidadOptimaQ = DemandaPromedioPeriodoVulnerable() + ExistenciaDeSeguridad() - _nivelActualInvenario;
            return _cantidadOptimaQ;
        }

        public double CalculoEDeZ() // con nivel de servicio
        {
            double ez = 0;
            ez = (_demandaPromedio * _tiempoEntreRevisiones * (1 - _nivelDeServicio)) / DesviacionTyL();
            return ez;
        }

        public double CalcularZ(double ez)
        {
            TablaDistribucionNormal tabla = new TablaDistribucionNormal();
            Z = tabla.DevolverZ(ez);
            return Z;
        }
    }
}
