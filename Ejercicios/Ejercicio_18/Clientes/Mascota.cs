using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    public class Mascota
    {
        public string especie;
        public string nombre;
        public Fecha? fechaNacimiento;
        public List<string> historialVacunacion = new List<string>();

        public Mascota(string especie, string nombre, Fecha? fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void AgregarVacuna(string nuevaVacuna) { this.historialVacunacion.Add(nuevaVacuna); }

        public string MostrarMascota() 
        { 
            string mensaje = $"   · Mascota: {this.nombre} - Especie: {this.especie} - Fecha de Nacimiento: {this.fechaNacimiento.GetFecha()}\n";

            if (this.historialVacunacion.Count > 0)
            {
                mensaje += "   · Historial Vacunacion:\n";
                foreach (var vacuna in historialVacunacion)
                {
                    mensaje += $"\t - {vacuna}\n";
                }
            }

            return mensaje;
        }
    }
}
