using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    public class Fecha
    {
        public int dia;
        public int mes;
        public int anio;

        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public string GetFecha() { return $"{this.dia}/{this.mes}/{this.anio}"; }

    }
}
