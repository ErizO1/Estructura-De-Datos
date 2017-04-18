using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        public EntradaInv Primero { get; private set; }

        public Inventario()
        {
            Primero = null;
        }

        public void Agregar(EntradaInv ent)
        {
            if (Primero == null)
                Primero = ent;
            else
            {
                if (ent.Articulo.ID < Primero.Articulo.ID)
                {
                    ent.Siguiente = Primero;
                    Primero = ent;
                }
                else
                {
                    EntradaInv temp = Primero;
                    /*
                    while (temp.Siguiente != null)
                    temp = temp.Siguiente;
                    temp.Siguiente = ent;
                    */
                    while (temp.Siguiente != null && temp.Siguiente.Articulo.ID < ent.Articulo.ID)
                        temp = temp.Siguiente;
                    ent.Siguiente = temp.Siguiente;
                    temp.Siguiente = ent;
                    // a -> c -> d
                    // b -> c -> d
                    //
                }
            }
        }

        public EntradaInv Buscar(int ID)
        {
            EntradaInv temp = Primero;
            while (temp != null && temp.Articulo.ID != ID)
                temp = temp.Siguiente;
            return temp;
        }

        public bool Borrar(int ID)
        {
            EntradaInv temp = Primero;
            while (temp != null && temp.Siguiente != null && temp.Siguiente.Articulo.ID != ID)
                temp = temp.Siguiente;
            if (temp == null)
                return false;
            if (temp.Siguiente == null)
            {
                Primero = null;
                return true;
            }
            temp.Siguiente = temp.Siguiente.Siguiente;
            return true;
        }
        /*
        public bool Insertar(EntradaInv ent, int pos)
        {
            if (pos == 1)
            {
                ent.Siguiente = Primero;
                Primero = ent;
                return true;
            }
            EntradaInv temp = Primero;
            int i = 1;
            while (temp != null && temp.Siguiente != null && i < pos - 1)
            {
                temp = temp.Siguiente;
                i++;
            }
            if (temp == null)
                return false;
            ent.Siguiente = temp.Siguiente;
            temp.Siguiente = ent;
            return true;
            // a -> b -> c -> d
            //
        }
        */
        public override string ToString()
        {
            string Reporte = "Comenza Reporte de inventario:" + Environment.NewLine;
            EntradaInv temp = Primero;
            int i = 1;
            while (temp != null)
            {
                Reporte += "Registro " + i.ToString() + ": " + Environment.NewLine;
                Reporte += temp.ToString() + Environment.NewLine;
                temp = temp.Siguiente;
                i++;
            }
            Reporte += "Fin Reporte de Inventario.";
            return Reporte;
        }
    }

    public class EntradaInv
    {
        public EntradaInv Siguiente { get; set; }
        public Artículo Articulo { get; set; }
        public int Cantidad { get; set; }

        public override string ToString()
        {
            string Reporte = "Comienza Registro de Artículo: " + Environment.NewLine;
            Reporte += Articulo.ToString() + Environment.NewLine;
            Reporte += "Catidad: " + Cantidad.ToString() + Environment.NewLine;
            Reporte += "Termina Registro de Artículo.";
            return Reporte;
        }
    }
}
