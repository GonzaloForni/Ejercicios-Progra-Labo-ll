/* Consigna: 
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola. Validar que el dato ingresado por el usuario sea un número.
 * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir". Si ingresa "salir", cerrar la consola.
 * Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 * IMPORTANTE: Utilizar sentencias de iteración, selectivas y el operador módulo (%).
 */
namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? stringIngresado;
            int numeroValidado;
            bool esPrimo;

            do
            {
                Console.Write("Ingrese un numero o SALIR si desea finalizar el programa: ");
                stringIngresado = Console.ReadLine();

                while (!int.TryParse(stringIngresado, out numeroValidado) && stringIngresado != "SALIR")
                {
                    Console.Write("Error!!! Reingrese un numero o SALIR si desea finalizar el programa: ");
                    stringIngresado = Console.ReadLine();
                }

                if (stringIngresado != "SALIR")
                {
                    Console.WriteLine("La lista de numeros primos menores a {0} es:", numeroValidado);
                    for (int numero = 0; numero < numeroValidado; numero++)
                    {
                        esPrimo = true;

                        if (numero <= 1)
                        {
                            esPrimo = false;
                        }

                        for (int i = 2; i < numero - 1; i++)
                        {
                            if (numero % i == 0)
                            {
                                esPrimo = false;
                            }
                        }

                        if (esPrimo == true)
                        {
                            Console.WriteLine("-> {0}", numero);
                        }
                    } 
                }
            } while (stringIngresado != "SALIR");

            Console.WriteLine("Saliendo del programa...");
        }
    }
}