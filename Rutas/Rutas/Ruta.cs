using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas
{
    public class Ruta
    {
        private Base Inicio = null;

        public void Agregar(Base b)
        {
            if (Inicio == null)
            {
                Inicio = b;
                b.Siguiente = Inicio;
                b.Anterior = Inicio;
            }

            else
            {
                b.Anterior = Inicio.Anterior;
                Inicio.Anterior = b;
                b.Anterior.Siguiente = b;
                b.Siguiente = Inicio;
            }
        }

        public void AgregarInicio(Base b)
        {
            Agregar(b);
            Inicio = b;
        }

        public Base Buscar(string nombre)
        {
            Base temp = Inicio;
            if (temp == null)
                return null;
            do
            {
                if (temp.Nombre == nombre)
                    return temp;
                temp = temp.Siguiente;
            }
            while (temp != Inicio);
            return null;
        }

        public bool InsertarDespuesDe(string nombre, Base b)
        {
            Base temp = Buscar(nombre);
            if (temp != null)
            {
                b.Siguiente = temp.Siguiente;
                b.Anterior = temp;
                b.Siguiente.Anterior = b;
                b.Anterior.Siguiente = b;
                return true;
            }
            return false;
        }

        public bool Eliminar(string nombre)
        {
            Base temp = Buscar(nombre);
            if (temp != null)
            {
                temp.Anterior.Siguiente = temp.Siguiente;
                temp.Siguiente.Anterior = temp.Anterior;
                temp.Anterior = null;
                temp.Siguiente = null;
                if (temp == Inicio)
                    Inicio = null;
                return true;
            }
            return false;
        }

        public string Reporte()
        {
            string rep = "Comienza Reporte:" + Environment.NewLine + "-----------------------" + Environment.NewLine;
            Base temp = Inicio;
            if (temp == null)
            {
                rep += "No hay datos";
            }
            else
                do
                {
                    rep += temp.ToString();
                    rep += Environment.NewLine + Environment.NewLine;
                    temp = temp.Siguiente;
                }
                while (temp != Inicio);
            return rep;
        }

        public void Recorrido(string nombre, DateTime dt_inicio, DateTime dt_fin)
        {
            Base inicioTemp = Buscar(nombre);
            Base temp = inicioTemp;
            if (inicioTemp == null)
            {
                System.Windows.Forms.MessageBox.Show("La base no existe");
                return;
            }
            List<string> header = new List<string>();
            do
            {
                header.Add(temp.Nombre);
                temp = temp.Siguiente;
            }
            while (temp != inicioTemp);

            List<List<string>> data = new List<List<string>>();

            do
            {
                data.Add(new List<string>());
                do
                {
                    data[data.Count - 1].Add(dt_inicio.ToShortTimeString());
                    temp = temp.Siguiente;
                    dt_inicio = dt_inicio.AddMinutes(temp.Minutos);
                }
                while (temp != inicioTemp && DateTime.Compare(dt_inicio, dt_fin) < 0);
            }
            while (DateTime.Compare(dt_inicio, dt_fin) < 0);

            frm_Recorrido r = new frm_Recorrido(header, data);
            r.ShowDialog();
        }
    }
}
