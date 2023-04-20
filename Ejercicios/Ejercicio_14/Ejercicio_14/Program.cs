/* Consigna Ej 14
 * Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
 * a. double CalcularCuadrado(double)
 * b. double CalcularTriangulo(double, double)
 * c. double CalcularCirculo(double)
 * El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */
using Calculos;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoIngresado;
            double baseIngresada;
            double alturaIngresada;
            double radioIngresado;

            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;

            Console.Write("Ingrese el lado del cuadrado: ");
            while (!double.TryParse(Console.ReadLine(), out ladoIngresado))
            {
                Console.Write("Error: Ingrese el lado del cuadrado: ");
            }

            areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoIngresado);
            Console.WriteLine($"El area del cuadrado es: {areaCuadrado}\n");

            // ---------------------------------------------------------------------

            Console.Write("Ingrese la base del triangulo: ");
            while (!double.TryParse(Console.ReadLine(), out baseIngresada))
            {
                Console.Write("Error: Ingrese la base del triangulo: ");
            }

            Console.Write("Ingrese la altura del triangulo: ");
            while (!double.TryParse(Console.ReadLine(), out alturaIngresada))
            {
                Console.Write("Error: Ingrese la altura del triangulo: ");
            }

            areaTriangulo = CalculoDeArea.CalcularTriangulo(baseIngresada, alturaIngresada);
            Console.WriteLine($"El area del triangulo es: {areaTriangulo}\n");

            // ---------------------------------------------------------------------

            Console.Write("Ingrese el radio del circulo: ");
            while (!double.TryParse(Console.ReadLine(), out radioIngresado))
            {
                Console.Write("Error: Ingrese el radio del circulo: ");
            }
            areaCirculo = CalculoDeArea.CalcularCirculo(radioIngresado);
            Console.WriteLine($"El area del circulo es: {areaCirculo}\n");

        }
    }
}