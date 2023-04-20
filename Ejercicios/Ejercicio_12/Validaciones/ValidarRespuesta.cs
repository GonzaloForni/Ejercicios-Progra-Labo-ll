namespace Validaciones
{
    public class ValidarRespuesta
    {
        /// <summary>
        /// Valida el caracter que recibe por parametro
        /// </summary>
        /// <param name="c">Caracter que comparara</param>
        /// <returns>True si es 'S' y False sino</returns>
        public static bool ValidaS_N(char c)
        {
            bool comprobante = false;

            if(c == 'S')
            {
                comprobante = true;
            }

            return comprobante;
        }
    }
}