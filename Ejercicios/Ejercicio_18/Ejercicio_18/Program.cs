/*
 * Requerimiento
 * El dueño de una veterinaria nos contrató para que desarrollemos una aplicación donde pueda consultar la lista de clientes y sus mascotas.
 * De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.
 * De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último 
 * arrancará vacío y se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.
 * Consigna
 * Crear una aplicación de consola. 
 * Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
 * Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
 * Instanciar los siguientes objetos:
 *      Un cliente con un perro sin vacunar.
 *      Un cliente con un gato con la vacuna "Triple Felina".
 *      Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
 * Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.
 */
using Clientes;

namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duenio primerCliente = new Duenio("Carlos", "Perez", "AAA", 1184638465);
            Duenio segundoCliente = new Duenio("Juan", "Corto", "BBB", 1136294651);
            Duenio tercerCliente = new Duenio("Pedro", "Casas", "CCC", 1164936284);

            primerCliente.AgregarMascota("Perro", "Firulais", 1, 6, 2017);

            segundoCliente.AgregarMascota("Gato", "Larry", 18, 2, 2020);
            segundoCliente.mascotas[0].AgregarVacuna("Triple Felina");

            tercerCliente.AgregarMascota("Gato", "Storto", 24, 9, 2022);
            tercerCliente.AgregarMascota("Perro", "Corcho", 7, 4, 2000);
            tercerCliente.mascotas[1].AgregarVacuna("AntiRabica");

            Console.WriteLine(primerCliente.MostrarCliente());
            Console.WriteLine(segundoCliente.MostrarCliente());
            Console.WriteLine(tercerCliente.MostrarCliente());
        }
    }
}