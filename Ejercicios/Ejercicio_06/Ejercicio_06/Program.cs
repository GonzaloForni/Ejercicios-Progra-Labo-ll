/*
 * Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. 
 * Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no. 
 * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 */
namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroInicio;
            int numeroFinal;

            Console.Write("Ingrese en numero de inicio de años: ");
            while(!int.TryParse(Console.ReadLine(), out numeroInicio))
            {
                Console.Write("Error!!! Reingrese en numero de inicio de años: ");
            }

            Console.Write("Ingrese en numero de final de años: ");
            while (!int.TryParse(Console.ReadLine(), out numeroFinal))
            {
                Console.Write("Error!!! Reingrese en numero de final de años: ");
            }

            for(int anio = numeroInicio; anio < numeroFinal; anio++)
            {
                if(anio % 4 == 0)
                {
                    if (anio % 100 != 0 || anio % 400 == 0)
                    {
                        Console.WriteLine($"El año {anio} es bisiesto!!!");
                    }
                }
            }
        }
    }
}