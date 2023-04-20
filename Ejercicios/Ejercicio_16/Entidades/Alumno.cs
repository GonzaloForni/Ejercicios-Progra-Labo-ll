namespace Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombreIngresado, string apellidoIngresado, int legajoIngresado)
        {
            this.nombre = nombreIngresado;
            this.apellido = apellidoIngresado;
            this.legajo = legajoIngresado;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random random = new Random();

                this.notaFinal = random.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            string mensaje;

            if (this.notaFinal != -1)
            {
                mensaje = $"El alumno {this.nombre} {this.apellido}, legajo {this.legajo} se saco un {this.nota1} y un {this.nota2}, su nota final fue {this.notaFinal}";
            }
            else
            {
                mensaje = $"El alumno {this.nombre} {this.apellido}, legajo {this.legajo} se saco un {this.nota1} y un {this.nota2}, el alumno fue desaprobado";
            }

            return mensaje;
        }
    }
}