using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class Artículo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            string Reporte = "Comienza Artículo:" + Environment.NewLine;
            Reporte += "ID: " + ID.ToString() + Environment.NewLine;
            Reporte += "Nombre: " + Nombre + Environment.NewLine;
            Reporte += "Precio: " + Precio.ToString("c2") + Environment.NewLine;
            Reporte += "Termina Artículo.";
            return Reporte;
        }
    }
}
