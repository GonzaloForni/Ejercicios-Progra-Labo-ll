using System.ComponentModel.DataAnnotations;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
            // IMPORTANTE:  Utilizar el método Pow de la clase Math para calcular las potencias.
            string? numeroIngresado;
            int numeroValidado;
            int cuadradoDelNumero;
            int cuboDelNumero;

            Console.Write("Ingrese un numero: ");
            numeroIngresado = Console.ReadLine();

            while(!int.TryParse(numeroIngresado, out numeroValidado))
            {
                Console.Write("Error!!! Reingrese un numero: ");
                numeroIngresado = Console.ReadLine();
            }

            cuadradoDelNumero = (int)Math.Pow(numeroValidado, 2);
            cuboDelNumero = (int)Math.Pow(numeroValidado, 3);

            Console.WriteLine("El numero ingresado fue {0}, su cuadrado es {1} y su cubo es {2}", numeroValidado, cuadradoDelNumero, cuboDelNumero);
            Console.ReadKey();
        }
    }
}