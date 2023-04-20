using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizRespecto) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespecto;
        }

        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Euro.cotizRespectoDolar; }

        public static implicit operator Euro(double euro)
        {
            return new Euro(euro);
        }

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Euro euro)
        {
            return (Pesos)((Dolar)euro);
        }

    }
}
