/* Consigna Ej. 07
 * Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
 * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
 * hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
 * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
 */
namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nombreIngresado;
            int valorHoraIngresada;
            int antiguedadIngresada;
            int cantidadHorasTrabajadas;
            string? respuesta;

            float importeBruto;
            float descuento;
            float importeFinal;

            float acumuladorCobroEmpleados = 0;
            string mensaje = "\n-> Lista Empleados: ";

            do
            {
                // -> Ingreso de datos
                Console.Write("Ingrese el nombre del empleado: ");
                nombreIngresado = Console.ReadLine();

                Console.Write("Ingrese el valor por hora de trabajo: ");
                while (!int.TryParse(Console.ReadLine(), out valorHoraIngresada) || valorHoraIngresada < 0)
                {
                    Console.Write("Error!!! Reingrese el valor por hora de trabajo: ");
                }

                Console.Write("Ingrese la antigüedad del empleado: ");
                while (!int.TryParse(Console.ReadLine(), out antiguedadIngresada) || antiguedadIngresada < 0)
                {
                    Console.Write("Error!!! Reingrese la antigüedad del empleado: ");
                }

                Console.Write("Ingrese la cantidad de horas de trabajo: ");
                while (!int.TryParse(Console.ReadLine(), out cantidadHorasTrabajadas) || cantidadHorasTrabajadas < 0)
                {
                    Console.Write("Error!!! Reingrese la cantidad de horas de trabajo: ");
                }

                // -> Operaciones
                importeBruto = valorHoraIngresada * cantidadHorasTrabajadas;
                importeBruto += (antiguedadIngresada * 150);
                acumuladorCobroEmpleados += importeBruto;

                descuento = importeBruto * 13 / 100;
                importeFinal = importeBruto - descuento;

                // Mostrar Datos
                // el recibo correspondiente
                mensaje += $"\n\n Empleado: {nombreIngresado} - Antiguedad: {antiguedadIngresada} - Valor x Hora: {valorHoraIngresada} \n Total Cobro Bruto: {importeBruto} - Total Cobro Final: {importeFinal} - Total Cobro Bruto Empleados: {acumuladorCobroEmpleados}";

                // -> Respuesta
                Console.Write("Desea seguir ingresando datos? ( si | no ) ");
                respuesta = Console.ReadLine();

            } while (respuesta == "si");

            Console.Write($"{mensaje}\n\n");
        }
    }
}