/*
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales. 
 * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
 * El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
 * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
 */
namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? numeroIngresado;
            int numeroHasta;
            int acumuladorAnteriores;
            int acumuladorPosteriores;

            Console.Write("Ingrese un numero maximo con el que se buscaran centros numéricos: ");
            numeroIngresado = Console.ReadLine();
   
            while (!int.TryParse(numeroIngresado, out numeroHasta))
            {
                Console.Write("Ingrese un numero maximo con el que se buscaran centros numéricos: ");
                numeroIngresado = Console.ReadLine();
            }

            for(int n = 5; n < numeroHasta; n++)
            {
                for (int i = 1; i < n; i++)
                {
                    acumuladorAnteriores = 0;
                    acumuladorPosteriores = 0;

                    for (int j = i - 1; j > 0; j--)
                    {
                        acumuladorAnteriores += j;
                    }
                    for (int k = i + 1; k < n; k++)
                    {
                        acumuladorPosteriores += k;
                    }

                    if (acumuladorAnteriores == acumuladorPosteriores)
                    {
                        Console.WriteLine($"-> El numero {i} es un centro numérico!!!");
                    }
                }
            }
        }
    }
}