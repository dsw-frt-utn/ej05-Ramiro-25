using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoElectrico : Vehiculo
{
    private double kwhBase;

    public VehiculoElectrico(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kwhBase) : base(VehiculoTipo.Electrico, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kwhBase = kwhBase;
    }

    public double GetKwhBase()
    {
        return kwhBase;
    }

    
        public override double CalcularConsumo(double km)
    {
        double consumoPromedio = 16; 

        double consumo = (km * consumoPromedio) / 100;

        if (GetCapacidadCarga() > 1200)
        {
            consumo = consumo * 1.15;
        }

        return consumo;
    }
}

