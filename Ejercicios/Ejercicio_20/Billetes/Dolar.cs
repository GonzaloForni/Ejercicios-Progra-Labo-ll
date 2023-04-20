using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizRespecto) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespecto;
        }

        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Dolar.cotizRespectoDolar; }

        public static implicit operator Dolar(double dolar)
        {
            return new Dolar(dolar);
        }

        public static explicit operator Pesos(Dolar dolar) 
        {
            return new Pesos(Pesos.GetCotizacion() * dolar.cantidad);
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(Euro.GetCotizacion() * dolar.cantidad);
        }

    }
}
