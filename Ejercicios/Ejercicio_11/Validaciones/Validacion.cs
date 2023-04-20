namespace Validaciones
{
    public class Validacion
    {
        /// <summary>
        /// Valida que el valor recibido por parametro este dentro del rango determinado
        /// </summary>
        /// <param name="valor"> Valor que se comparara </param>
        /// <param name="min"> Minimo posible </param>
        /// <param name="max"> Maximo posible </param>
        /// <returns>True si esta dentro del rango y false sino </returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool comprobante = false;

            if (valor > min && valor < max)
            {
                comprobante = true;
            }

            return comprobante;
        }
    }
}