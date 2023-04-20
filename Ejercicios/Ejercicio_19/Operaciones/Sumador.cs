using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;

namespace Operaciones
{
    public class Sumador
    {
        private int cantidadSumas;

        // A - Crear dos constructores:
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) {}

        // B - El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
        public long Sumar(long primerNumero, long segundoNumero)
        {
            long resultado;

            resultado = primerNumero + segundoNumero;
            this.cantidadSumas++;

            return resultado;
        }

        public string Sumar(string primerNumero, string segundoNumero)
        {
            string resultado;

            resultado = primerNumero + segundoNumero;
            this.cantidadSumas++;

            return resultado;
        }

        // C - Generar una conversión explícita que retorne cantidadSumas.
        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        // D - Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor.
        public static long operator +(Sumador sumadorUno, Sumador sumadorDos)
        {
            return (long)(sumadorUno.cantidadSumas + sumadorDos.cantidadSumas);
        }

        // E - Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas.
        public static bool operator |(Sumador sumadorUno, Sumador sumadorDos)
        {
            bool comprobante = false;

            if(sumadorUno.cantidadSumas == sumadorDos.cantidadSumas)
            {
                comprobante = true;
            }

            return comprobante;
        }
    }
}