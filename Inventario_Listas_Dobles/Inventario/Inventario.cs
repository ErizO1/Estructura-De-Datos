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
        public EntradaInv Ultimo { get; private set; }

        public Inventario()
        {
            Primero = null;
            Ultimo = null;
        }

        /*
        public void Agregar(EntradaInv ent)
        {
            if (Primero == null)
                Primero = ent;
            else
            {
                EntradaInv temp = Primero;
                while (temp.Siguiente != null)
                    temp = temp.Siguiente;
                temp.Siguiente = ent;
            }
        }
        */

        public void Agregar(EntradaInv ent)
        {
            if (Ultimo == null)
            {
                Primero = ent;
                Ultimo = ent;
            }
            else
            {
                ent.Anterior = Ultimo;
                Ultimo = ent;
                ent.Anterior.Siguiente = ent;
            }
        }

        public void AgregarPrimero(EntradaInv ent)
        {
            if (Primero == null)
            {
                Primero = ent;
                Ultimo = ent;
            }
            else
            {
                ent.Siguiente = Primero;
                Primero = ent;
                ent.Siguiente.Anterior = ent;
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
            EntradaInv temp = Buscar(ID);
            if (temp == null)
                return false;
            if (temp.Anterior != null)
                temp.Anterior.Siguiente = temp.Siguiente;
            if (temp.Siguiente != null)
                temp.Siguiente.Anterior = temp.Anterior;
            temp.Siguiente = null;
            temp.Anterior = null;
            return true;
        }

        public bool BorrarPrimero()
        {
            if (Primero == null)
                return false;
            if (Primero.Siguiente == null)
            {
                Primero = null;
                Ultimo = null;
                return true;
            }
            EntradaInv temp = Primero;
            Primero = Primero.Siguiente;
            Primero.Anterior = null;
            temp.Siguiente = null;
            temp = null;
            return true;
        }

        public bool BorrarUltimo()
        {
            if (Ultimo == null)
                return false;
            if (Ultimo.Anterior == null)
            {
                Primero = null;
                Ultimo = null;
                return true;
            }
            EntradaInv temp = Ultimo;
            Ultimo = Ultimo.Anterior;   
            Ultimo.Siguiente = null;
            temp.Anterior = null;
            temp = null;
            return true;
        }

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

        public override string ToString()
        {
            string Reporte = "Comenza Reporte de inventario:" + Environment.NewLine;
            if (Primero == null)
            {
                Reporte += "No hay datos.";
                return Reporte;
            }
            EntradaInv temp = Primero;
            while (temp != null)
            {
                Reporte += temp.ToString() + Environment.NewLine;
                temp = temp.Siguiente;
            }
            Reporte += "Fin Reporte de Inventario.";
            return Reporte;
        }

        public string ReporteInverso()
        {
            string Reporte = "Comienza Reporte inverso de inventario:" + Environment.NewLine;
            if (Ultimo == null)
            {
                Reporte += "No hay datos.";
                return Reporte;
            }
            EntradaInv temp = Ultimo;
            while (temp != null)
            {
                Reporte += temp.ToString() + Environment.NewLine;
                temp = temp.Anterior;
            }
            Reporte += "Termina Reporte Inverso de Inventario.";
            return Reporte;
        }
    }

    public class EntradaInv
    {
        public EntradaInv Siguiente { get; set; }
        public EntradaInv Anterior { set; get; }
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
