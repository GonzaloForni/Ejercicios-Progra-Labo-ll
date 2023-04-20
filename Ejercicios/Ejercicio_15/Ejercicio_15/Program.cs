/*
 * Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división). 
 * Para ello se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (pulsando el caracter +, -, * o /).
 * El usuario decidirá cuándo finalizar el programa. Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
 *  a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la operación matemática. El método devolverá el resultado de la operación.
 *  b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
 *  Este método devolverá TRUE si el número es distinto de CERO.
 */
using Entidades;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primerNumero;
            double segundoNumero;
            char operacionIngresada;

            string? respuesta;

            do
            {
                Console.WriteLine("<<-------- CALCULADORA -------->>");

                Console.Write("Ingrese el primer numero: ");
                while (!double.TryParse(Console.ReadLine(), out primerNumero))
                {
                    Console.Write("Reingrese el primer numero: ");
                }

                Console.Write("Ingrese el segundo numero: ");
                while (!double.TryParse(Console.ReadLine(), out segundoNumero))
                {
                    Console.Write("Reingrese el segundo numero: ");
                }

                Console.Write("Ingrese la operacion [ + | - | * | / ] ");
                operacionIngresada = char.Parse(Console.ReadLine());
                while (operacionIngresada != '+' && operacionIngresada != '-' && operacionIngresada != '*' && operacionIngresada != '/')
                {
                    Console.Write("Ingrese la operacion [ + | - | * | / ] ");
                    operacionIngresada = char.Parse(Console.ReadLine());
                }

                Console.WriteLine($"El resultado de la operacion ({primerNumero} {operacionIngresada} {segundoNumero}) es {Calculadora.Calcular(primerNumero, segundoNumero, operacionIngresada)}");

                Console.Write("Desea seguir ingresando operaciones? ");
                respuesta = Console.ReadLine().ToUpper();
                while (respuesta != "SI" && respuesta != "NO")
                {
                    Console.Write("Desea seguir ingresando operaciones? ");
                    respuesta = Console.ReadLine().ToUpper();
                }

            } while(respuesta == "SI");

            Console.WriteLine("Fin del programa...");
        }
    }
}