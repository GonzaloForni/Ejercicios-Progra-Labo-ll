/* Consigna Ej. 08
 * Escribir un programa que imprima por consola un triángulo como el siguiente:
 *      *
 *      ***
 *      *****
 *      *******
 *      *********
 *  El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
 */
namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alturaIngresada;
            string? triangulo = "";
            bool flagPuntaTriangulo = true;

            Console.Write("Ingrese la altura del triangulo: ");
            while (!int.TryParse(Console.ReadLine(), out alturaIngresada) || alturaIngresada < 1)
            {
                Console.Write("Error!!! Reingrese la altura del triangulo: ");
            }

            for(int i = 0; i < alturaIngresada; i++)
            {
                if(flagPuntaTriangulo)
                {
                    triangulo += "*";
                    flagPuntaTriangulo = false;
                }
                else
                {
                    triangulo += "**";
                }
                
                Console.WriteLine(triangulo);
            }
        }
    }
}