/* Consigna Ej 19 Sumador
 * A. Crear dos constructores:
 *      i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
 *      ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
 * B. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
 *      i. En el caso de Sumar(long, long) sumará los valores numéricos
 *      ii. En el de Sumar(string, string) concatenará las cadenas de texto. Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
 * C. Generar una conversión explícita que retorne cantidadSumas.
 * D. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor.
 * E. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas.
 * Agregar un segundo objeto del tipo Sumador en el Main y probar el código.
 */
using Operaciones;

namespace Ejercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador(10);
            Sumador sumadorTres = new Sumador(20);

            Console.WriteLine($"El metodo sumar con long devuelve: {sumadorUno.Sumar(100, 100)}");                      // <- B
            Console.WriteLine($"El metodo sumar con string devuelve: {sumadorUno.Sumar("100", "100")}");                // <- B
            Console.WriteLine($"Suma mediante sobrecarga del operador [+]: {sumadorDos + sumadorTres}");                // <- C
            Console.WriteLine($"Comparacion mediante sobrecarga del operador [|]: {sumadorDos | sumadorTres}");         // <- D
            Console.WriteLine($"Conversion a entero mediante sobrecarga de la conversion a [int]: {(int)sumadorUno}");  // <- E
        }
    }
}