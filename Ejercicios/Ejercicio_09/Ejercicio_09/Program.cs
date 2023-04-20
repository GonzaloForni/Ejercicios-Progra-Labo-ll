/* Consigna Ej. 09
 * Escribir un programa que imprima por consola un triángulo como el siguiente:
 *      *
 *     ***
 *    *****
 *   *******
 *  *********
 * El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
 */
namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alturaIngresada;
            string? triangulo = "";
            bool flagPuntaTriangulo = true;
            int cantidadEspacioActual;
            string? espaciado;

            Console.Write("Ingrese la altura del triangulo: ");
            while (!int.TryParse(Console.ReadLine(), out alturaIngresada) || alturaIngresada < 1)
            {
                Console.Write("Error!!! Reingrese la altura del triangulo: ");
            }

            cantidadEspacioActual = alturaIngresada;

            for (int i = 0; i < alturaIngresada; i++)
            {
                espaciado = "";
                cantidadEspacioActual--;

                if (flagPuntaTriangulo)
                {
                    triangulo += "*";
                    flagPuntaTriangulo = false;
                }
                else
                {
                    triangulo += "**";
                }

                for(int j = 0; j < cantidadEspacioActual; j++)
                {
                    espaciado += " ";
                }

                Console.WriteLine(espaciado + triangulo);
            }
        }
    }
}