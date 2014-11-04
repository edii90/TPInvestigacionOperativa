using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestigacionOperativa
{
    public class ModeloCantidadFijaConProduccion
    {
        private double _cantidadOptimaQ; //Q
        private double _costoAnualPedido; //S
        private double _costoAnualMantennimiento; //H
        private int _leadTime; //L
        private double _demandaAnual; //D
        private double _demandaDiaria; //d
        private int _diasLaborales;
        private double _costoTotal; //TC
        private double _costoUnitario; //C
        private double _puntoReorden; //R
        private double _nroLotesAnual;
        private double _tiempoEntreLotes; //T
        private double _costoTotalAnualPedido; //(D/Q).S
        private double _costoTotalAnualMantenimiento; //(Q/2).H 
        private double _costoTotalAnualDeCompras; // D*C
        private double _tasaProduccionDiaria;
        private double _tasaDemandaDiaria;

        public double CantidadOptimaQ()
        {
        _cantidadOptimaQ = System.Math.Sqrt( (2 * _demandaAnual * _costoAnualPedido * _tasaProduccionDiaria)/ _costoAnualMantennimiento *(_tasaProduccionDiaria - _tasaDemandaDiaria ));
        return _cantidadOptimaQ;
        }

        public double CostoTotalAnualPedido() // igual CantidadFija
        {
            _costoTotalAnualPedido = (_demandaAnual / _cantidadOptimaQ) * _costoAnualPedido;
            return _costoTotalAnualPedido;
        }

        public double CostoTotalAnualMantenimiento()
        {
            _costoTotalAnualMantenimiento = (_tasaProduccionDiaria - _tasaDemandaDiaria) * _cantidadOptimaQ * _costoAnualMantennimiento / 2 * _tasaProduccionDiaria;
            return _costoTotalAnualMantenimiento;
        }

        public double CostoTotalAnualDeCompras() // // igual CantidadFija
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

        public double PuntoDeReorden() // igual CantidadFija
        {
         DemandaDiaria();
        _puntoReorden = _demandaDiaria * _leadTime;
        return _puntoReorden;
        }

        public double NroDeLotesAnual() // igual CantidadFija
        {
            _nroLotesAnual = _demandaAnual / _cantidadOptimaQ;
            return _nroLotesAnual;
        }

        public double TiempoEntreLotes() // igual CantidadFija
        {
            _tiempoEntreLotes = _diasLaborales / _nroLotesAnual;
            return _tiempoEntreLotes;
        }
    }
}
