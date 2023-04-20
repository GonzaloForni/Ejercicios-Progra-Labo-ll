/* Consigna: Ej 11
 *  Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la
 *  siguiente firma: bool Validar(int valor, int min, int max):
 *      a. valor: dato a validar
 *      b. min y max: rango en el cual deberá estar la variable valor.
 *  Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
 *  anteriormente que estén dentro del rango -100 y 100. Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
 *  Nota: Utilizar variables escalares, NO utilizar vectores. 
 */
using Validaciones;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int maximo = 100;
            int minimo = -100;

            bool flagPrimerIngreso = true;
            int minimoIngresado = int.MinValue;
            int maximoIngresado = int.MaxValue;

            float promedio;
            int contador = 0;
            int acumulador = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                while(!int.TryParse(Console.ReadLine(), out numeroIngresado) || !(Validacion.Validar(numeroIngresado, minimo, maximo)))
                {
                    Console.Write("Error!!! Reingrese un numero: ");
                }

                if (numeroIngresado > maximoIngresado || flagPrimerIngreso == true)
                {
                    maximoIngresado = numeroIngresado;
                }
                
                if (numeroIngresado < minimoIngresado || flagPrimerIngreso == true)
                {
                    minimoIngresado = numeroIngresado;
                    flagPrimerIngreso = false;
                }
                
                contador++;
                acumulador += numeroIngresado;
            }

            Console.WriteLine($"El valor minimo ingresado fue {minimoIngresado}, el valor maximo ingresado fue {maximoIngresado}");
            if (contador > 0)
            {
                promedio = acumulador / contador;
                Console.WriteLine($"El promedio es {promedio}");
            }
        }
    }
}