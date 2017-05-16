using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    public class FIFO
    {
        private Proceso Primero;
        private Proceso Ultimo;

        public void enqueue(Proceso p)
        {
            if (Primero == null)
            {
                Primero = p;
                Ultimo = Primero;
            }
            else if (Primero.Siguiente == null)
            {
                Primero.Siguiente = p;
                Primero.Siguiente.Anterior = Primero;
                Ultimo = Primero.Siguiente;

            }
            else
            {
                p.Anterior = Ultimo.Anterior.Siguiente;
                p.Anterior.Siguiente = p;
                Ultimo = p;
            }
        }

        public Proceso dequeue()
        {
            Proceso temp = Primero;
            Primero = Primero.Siguiente;
            return temp;
        }

        public Proceso peek()
        {
            return Primero;
        }
    }
}
