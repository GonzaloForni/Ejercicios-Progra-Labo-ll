namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            string? stringIngresado;
            int numeroIngresado;
            bool flagPrimerNumero = true;
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;
            int acumulador = 0;
            int contador = 0;
            float promedio;

            for (int i = 0 ; i < 5 ; i++)
            {
                Console.Write("Ingrese un numero: ");
                stringIngresado = Console.ReadLine();
                
                if(int.TryParse(stringIngresado, out numeroIngresado)) // Me atajo de que el usuario ingrese cualquier cosa, si no logra hacer la conversion devuelve False
                {
                    acumulador += numeroIngresado;
                    
                    if (flagPrimerNumero || numeroIngresado > valorMaximo)
                    {
                        valorMaximo = numeroIngresado;
                        flagPrimerNumero = false;
                    }
                    if(flagPrimerNumero || numeroIngresado < valorMinimo)
                    {
                        valorMinimo = numeroIngresado;
                        flagPrimerNumero = false;
                    }
                    contador++;
                }
                else
                {
                    Console.WriteLine("Error!!! No ingreso los datos correctamente...");
                }
            }

            if(contador > 0)
            {
                promedio = acumulador / contador;
                Console.WriteLine("El promedio es: {0}", promedio);
            }

            Console.WriteLine("El numero maximo ingresado fue {0} y el valor minimo ingresado fue {1}", valorMaximo, valorMinimo);
            Console.ReadKey();
        }
    }
}