using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizRespecto) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizRespecto;
        }

        public double GetCantidad() { return this.cantidad; }

        public static double GetCotizacion() { return Pesos.cotizRespectoDolar; }

        public static implicit operator Pesos(double pesos)
        {
            return new Pesos(pesos);
        }

        public static explicit operator Dolar(Pesos peso)
        {
            return new Dolar(peso.cantidad / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos peso)
        {
            return (Euro)((Dolar)peso);
        }

        public static explicit operator ==(Pesos p1, Pesos p2) 
        { 
            // Video min 2:48
        }

    }
}