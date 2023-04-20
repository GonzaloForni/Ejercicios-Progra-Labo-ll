namespace Conversor
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un numero decimal a binario
        /// </summary>
        /// <param name="numeroDecimal">Numero decimal que se va a convertir</param>
        /// <returns>Numero binario convertido</returns>
        public static string DecimalBinario(int numeroDecimal)
        {
            string? numeroBinario = "";

            while (numeroDecimal > 0)
            {
                if (numeroDecimal > 0)
                {
                    if (numeroDecimal % 2 == 0)
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                }

                numeroDecimal /= 2;
            }
            
            return numeroBinario;
        }

        /// <summary>
        /// Convierte un numero binario en decimal
        /// </summary>
        /// <param name="numeroBinario">cadena binaria que se convertira</param>
        /// <returns>numero decimal convertido</returns>
        public static int BinarioDecimal(string numeroBinario)
        {
            int numeroDecimal = 0;
            int exponente = 0;

            for (int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                int digito = Convert.ToInt32(numeroBinario[i].ToString());

                if (digito == 1)
                {
                    numeroDecimal += (int)Math.Pow(2, exponente);
                }

                exponente++;
            }

            return numeroDecimal;
        }
    }
}