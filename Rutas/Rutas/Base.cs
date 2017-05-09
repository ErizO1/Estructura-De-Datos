using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas
{
    public class Base
    {
        public string Nombre { get; private set; }
        public int Minutos { get; private set; }
        public Base Siguiente { get; set; }
        public Base Anterior { get; set; }

        public Base(string nombre, int minutos)
        {
            Nombre = nombre;
            Minutos = minutos;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + Environment.NewLine +
                   "Minutos: " + Minutos.ToString();
        }
    }
}
