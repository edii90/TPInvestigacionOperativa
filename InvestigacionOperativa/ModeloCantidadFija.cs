using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestigacionOperativa
{
    public class ModeloCantidadFija
    {
        public double _cantidadOptimaQ {set;get;} //Q
        public double _costoAnualPedido {set;get;}  //S
        public double _costoAnualMantennimiento { set; get; }  //H
        public int _leadTime { set; get; }  //L
        public int _demandaAnual { set; get; }  //D
        public double _demandaDiaria { set; get; }  //d
        public int _diasLaborales { set; get; }
        public double _costoTotal { set; get; }  //TC
        public double _costoUnitario { set; get; }  //C
        public double _puntoReorden { set; get; }  //R
        public double _nroLotesAnual { set; get; }
        public double _tiempoEntreLotes { set; get; }  //T
        public double _costoTotalAnualPedido { set; get; }  //(D/Q).S
        public double _costoTotalAnualMantenimiento { set; get; }  //(Q/2).H 
        public double _costoTotalAnualDeCompras { set; get; }  // D*C

        public double CantidadOptimaQ()
        {
            _cantidadOptimaQ = System.Math.Sqrt((2 * _demandaAnual * _costoAnualPedido) / _costoAnualMantennimiento);
            return _cantidadOptimaQ;
        }

        public double CostoTotalAnualPedido()
        {
            _costoTotalAnualPedido = (_demandaAnual / _cantidadOptimaQ) * _costoAnualPedido;
            return _costoTotalAnualPedido;
        }

        public double CostoTotalAnualMantenimiento()
        {
            _costoTotalAnualMantenimiento = (_cantidadOptimaQ / 2) * _costoAnualMantennimiento;
            return _costoTotalAnualMantenimiento;
        }

        public double CostoTotalAnualDeCompras()
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
                _demandaDiaria = _demandaAnual / _diasLaborales;
            else
                _demandaDiaria = _demandaAnual / 360;
        }

        public double PuntoDeReorden()
        {
         DemandaDiaria();
        _puntoReorden = _demandaDiaria * _leadTime;
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
    }
}
