/* Consigna Ej 12
 * Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje ¿Continuar? (S/N).
 * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
 * El método devolverá un valor de tipo booleano, TRUE si se ingresó una S y FALSE si se ingresó cualquier otro valor.
 */
using Validaciones;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool respuesta = true;
            char respuestaIngresada;

            while (respuesta)
            {
                Console.Write("Ingrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.Write("Reingrese un numero: ");
                }

                Console.Write("¿Continuar? (S/N): ");
                respuestaIngresada = Console.ReadLine().ToCharArray()[0];

                respuesta = ValidarRespuesta.ValidaS_N(respuestaIngresada);
            }

            Console.WriteLine("Fin del programa...");
        }
    }
}