using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos_LS
{
    public class ListaCircular
    {
        private Proceso Inicio = null;
        private Proceso Actual = null;

        public void enqueue(Proceso p)
        {
            if (Inicio == null)
            {
                Inicio = p;
                Inicio.Siguiente = Inicio;
                Inicio.Anterior = Inicio;
                Actual = Inicio;
            }
            else
            {
                p.Anterior = Inicio.Anterior;
                p.Siguiente = Inicio;
                p.Siguiente.Anterior = p;
                p.Anterior.Siguiente = p;
            }
        }

        public Proceso dequeue()
        {
            Proceso temp = Actual;
            Actual = Actual.Anterior;
            if (temp == Inicio)
                Inicio = temp.Siguiente;

            temp.Siguiente.Anterior = temp.Anterior;
            temp.Anterior.Siguiente = temp.Siguiente;
            temp.Anterior = null;
            temp.Siguiente = null;

            if (Inicio.Siguiente == null && Inicio.Anterior == null)
            {
                Inicio = null;
                Actual = null;
            }
            return temp;
        }

        public Proceso peek()
        {
            return Actual;
        }

        public void next()
        {
            if (Actual != null)
                Actual = Actual.Siguiente;
            else
                Actual = Inicio;
        }
    }
}
