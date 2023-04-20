/*
 * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 * Escribir una aplicación que encuentre los 4 primeros números perfectos.
 * Nota: Utilizar estructuras repetitivas y selectivas. 
 */
namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? prueba;
            int cantidadPerfectos;
            bool comprobante;
            int cantidadEncontrados = 0;
            int sumaDivisores;
            int numeroActual = 1;

            Console.Write("Ingrese la cantidad de numeros perfectos que quiere encontrar: ");
            prueba = Console.ReadLine();
            comprobante = int.TryParse(prueba, out cantidadPerfectos);
            while (comprobante == false)
            {
                Console.Write("Error!!! Reingrese la cantidad de numeros perfectos que quiere encontrar: ");
                prueba = Console.ReadLine();
                comprobante = int.TryParse(prueba, out cantidadPerfectos);
            }

            while (cantidadEncontrados < cantidadPerfectos)
            {
                numeroActual++;
                sumaDivisores = 0;

                for (int i = 1; i < numeroActual; i++)
                {
                    if (numeroActual % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }

                if (sumaDivisores == numeroActual)
                {
                    Console.WriteLine($"El numero {numeroActual} es perfecto!!!");
                    cantidadEncontrados++;
                }
            }

            Console.WriteLine("Saliendo del programa... ");
        }
    }
}