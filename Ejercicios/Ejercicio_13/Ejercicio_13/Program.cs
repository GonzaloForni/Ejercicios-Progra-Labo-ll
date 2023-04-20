/* Consigna Ej 13
 * Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): 
 * string DecimalBinario(int). Convierte un número de entero a binario.
 * int BinarioDecimal(string). Convierte un número binario a entero.
 * NOTA: no utilizar los atajos del lenguaje, hacerlo mediante estructuras repetitivas y de control.
 */
using Conversor;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string conversionBinario;
            int conversionDecimal;
            
            Console.Write("Ingrese un numero decimal para pasarlo a binario: ");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.Write("Error!!! Reingrese un numero decimal para pasarlo a binario: ");
            }

            conversionBinario = Conversor.Conversor.DecimalBinario(numeroIngresado);
            Console.WriteLine($"El numero decimal {numeroIngresado} en binario es: {conversionBinario}");
            
            conversionDecimal = Conversor.Conversor.BinarioDecimal(conversionBinario);
            Console.WriteLine($"El numero binario {conversionBinario} en decimal es: {conversionDecimal}");
        }
    }
}