/* Consigna Ej 16
 * A. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle nombre, apellido y legajo a cada uno de ellos.
 * B. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
 * C. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o iguales a 4, caso contrario 
 * la inicializará con -1. Para darle un valor a la nota final utilice el método de instancia Next de la clase Random.
 * D. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se mostrará sólo si es distinto de -1, caso 
 * contrario se mostrará la leyenda &quot;Alumno desaprobado.
 */
using Entidades;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno primerAlumno = new Alumno("Carlos", "Perez", 1001);
            Alumno segundoAlumno = new Alumno("Ana", "Garcia", 1002);
            Alumno tercerAlumno = new Alumno("Pablo", "Sánchez", 1003);

            primerAlumno.Estudiar(2, 2);
            primerAlumno.CalcularFinal();

            segundoAlumno.Estudiar(4, 4);
            segundoAlumno.CalcularFinal();

            tercerAlumno.Estudiar(6, 7);
            tercerAlumno.CalcularFinal();

            Console.WriteLine(primerAlumno.Mostrar());
            Console.WriteLine(segundoAlumno.Mostrar());
            Console.WriteLine(tercerAlumno.Mostrar());
        }
    }
}