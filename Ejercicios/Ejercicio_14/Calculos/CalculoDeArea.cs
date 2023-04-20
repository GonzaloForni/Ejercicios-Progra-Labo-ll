namespace Calculos
{
    public class CalculoDeArea
    {
        /// <summary>
        /// Calcula el area de un cuadrado mediante sus lados
        /// </summary>
        /// <param name="lado">Lado del cuadrado</param>
        /// <returns>Area calculada</returns>
        public static double CalcularCuadrado(double lado)
        {
            double area;

            area = lado * lado;

            return area;
        }

        /// <summary>
        /// Calcula el area de un triangulo mediante su base y altura
        /// </summary>
        /// <param name="numeroBase">Base del triangulo</param>
        /// <param name="numeroAltura">Altura del triangulo</param>
        /// <returns>Area calculada</returns>
        public static double CalcularTriangulo(double numeroBase, double numeroAltura)
        {
            double area;

            area = (numeroBase * numeroAltura) / 2;

            return area;
        }

        /// <summary>
        /// Calcula el area de un circulo mediante su radio
        /// </summary>
        /// <param name="radio">Radio del circulo</param>
        /// <returns>Area calculada</returns>
        public static double CalcularCirculo(double radio)
        {
            double area;

            area = Math.PI * Math.Pow(radio, 2);

            return area;
        }

    }
}