namespace Clientes
{
    public class Duenio
    {
        public string nombre;
        public string apellido;
        public string domicilio;
        public double telefono;
        public List<Mascota> mascotas = new List<Mascota>();

        public Duenio(string nombre, string apellido, string domicilio, double telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }

        public void AgregarMascota(string especie, string nombreMascota, int dia, int mes, int anio) 
        {
            Fecha nuevaFecha = new Fecha(dia, mes, anio);
            Mascota nuevaMascota = new Mascota(especie, nombreMascota, nuevaFecha);

            this.mascotas.Add(nuevaMascota); 
        }

        public string MostrarCliente() 
        {
            string mensaje = $"·> Cliente: {this.nombre} {this.apellido} - Domicilio: {this.domicilio} - Telefono: {this.telefono}\n";

            foreach(var mascota in this.mascotas) 
            {
                mensaje += mascota.MostrarMascota();
            }

            return mensaje; 
        }
    }
}