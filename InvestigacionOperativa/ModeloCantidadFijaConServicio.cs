using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestigacionOperativa
{
    
    public class ModeloCantidadFijaConServicio
    {
        public double Z { set; get; }//Z
        public double _cantidadOptimaQ { set; get; } //Q
        public double _costoAnualPedido { set; get; } //S
        public double _costoAnualMantennimiento { set; get; } //H
        public int _leadTime { set; get; } //L
        public double _demandaAnual { set; get; } //D
        public double _demandaDiaria { set; get; } //d
        public int _diasLaborales { set; get; }
        public double _costoTotal { set; get; } //TC
        public double _costoUnitario { set; get; } //C
        public double _puntoReorden { set; get; } //R
        public double _nroLotesAnual { set; get; }
        public double _tiempoEntreLotes { set; get; } //T
        public double _costoTotalAnualPedido { set; get; } //(D/Q).S
        public double _costoTotalAnualMantenimiento { set; get; } //(Q/2).H 
        public double _costoTotalAnualDeCompras { set; get; } // D*C
        public double _nivelServicioEsperado { set; get; } //
        public double _desviacionDeDemandaDiaria { set; get; } // sigma sub D - DATO
        public double _desviacionDeDemandaDuranteEntrega { set; get; } // sigma sub L

        public double CantidadOptimaQ() // igual que en Cantidad Fija
        {
            _cantidadOptimaQ = System.Math.Sqrt( (2 * _demandaAnual * _costoAnualPedido)/ _costoAnualMantennimiento);
            return _cantidadOptimaQ;
        }

        public double CostoTotalAnualPedido() // igual que en Cantidad Fija
        {
            _costoTotalAnualPedido = (_demandaAnual / _cantidadOptimaQ)* _costoAnualPedido;
            return _costoTotalAnualPedido;
        }

        public double CostoTotalAnualMantenimiento() // COMPLETAR CON Z!
        {
            _costoTotalAnualMantenimiento = (_cantidadOptimaQ * _costoAnualMantennimiento) / 2 + Z * _costoAnualMantennimiento * _desviacionDeDemandaDuranteEntrega; //Z;
            return _costoTotalAnualMantenimiento;
        }

        public double CostoTotalAnualDeCompras() // igual que en Cantidad Fija
        {
            _costoTotalAnualDeCompras = _demandaAnual * _costoUnitario;
            return _costoTotalAnualDeCompras;
        }

        public double CostoTotal()
        {
            _costoTotal = CostoTotalAnualDeCompras() + CostoTotalAnualMantenimiento() + CostoTotalAnualPedido();
            return _costoTotal;
        }

        public void DemandaDiaria()
        {
            if (_diasLaborales != null)
            _demandaDiaria = _demandaAnual / _diasLaborales ;
            else
            _demandaDiaria = _demandaAnual / 360;
        }

        public double PuntoDeReordenCantidadFijaConServicio() // COMPLETAR CON Z
        {
            DemandaDiaria();
            _puntoReorden = _demandaDiaria * _leadTime + _desviacionDeDemandaDuranteEntrega * Z;//Z;
            return _puntoReorden;
        }

        public double NroDeLotesAnual()
        {
            _nroLotesAnual = _demandaAnual / _cantidadOptimaQ;
            return _nroLotesAnual;
        }

        public double TiempoEntreLotes()
        {
            _tiempoEntreLotes = _diasLaborales / _nroLotesAnual;
            return _tiempoEntreLotes;
        }

        public double DesviacionEstandarDuranteEntrega() // sigma sub L - Cantidad Fija con Nivel de servicio
        {
            _desviacionDeDemandaDuranteEntrega = (System.Math.Sqrt( _leadTime))* _desviacionDeDemandaDiaria;
            return _desviacionDeDemandaDuranteEntrega;
        }

        public double EDeZetaCantidadFijaConServicio()
        {
            double ez = 0;
            ez = ((1 - _nivelServicioEsperado) * _cantidadOptimaQ)/ _desviacionDeDemandaDuranteEntrega;
            return ez;
        }

        public double CalcularZ(double ez)
        {
            TablaDistribucionNormal tabla = new TablaDistribucionNormal();
            Z = tabla.DevolverZ(ez);
            return Z;
        }

    /// FALTA METODO PARA CALCULAR Z EN FUNCION DE CalculoEDeZeta()
    }
}
