namespace Entidades
{
    public class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, char operacionMatematica)
        {
            double resultado = default(double);

            switch (operacionMatematica)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if(Validar(segundoNumero))
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(double segundoNumero)
        {
            bool validado = false;

            if(segundoNumero != 0)
            {
                validado = true;
            }

            return validado;
        }
    }
}