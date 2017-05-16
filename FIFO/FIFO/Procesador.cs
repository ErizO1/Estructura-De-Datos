using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Procesador
    {
        private static Random r;
        private Proceso Primero;
        private Proceso Ultimo;

        public int ciclosVacios { get; private set; }
        public int procesosPendientes { get; private set; }
        public int ciclosPendientes { get; private set; }

        public Procesador()
        {
            r = new Random();
        }

        public void simular(int ciclos)
        {
            for (int i = 0; i < ciclos; i++)
            {
                if (r.Next(0, 4) == 0)
                {
                    if (Primero == null)
                    {
                        Primero = new Proceso();
                        Ultimo = Primero;
                    }
                    else if (Primero.Siguiente == null)
                    {
                        Primero.Siguiente = new Proceso();
                        Primero.Siguiente.Anterior = Primero;
                        Ultimo = Primero.Siguiente;

                    }
                    else
                    {
                        Proceso temp = new Proceso();
                        temp.Anterior = Ultimo.Anterior.Siguiente;
                        temp.Anterior.Siguiente = temp;
                        Ultimo = temp;
                    }
                    procesosPendientes++;
                    ciclosPendientes += Ultimo.ciclosRestantes;
                }
                if (Primero != null)
                {
                    Primero.ciclosRestantes--;
                    if (Primero.ciclosRestantes == 0)
                    {
                        Primero = Primero.Siguiente;
                        procesosPendientes--;
                    }
                    ciclosPendientes--;
                }
                else
                    ciclosVacios++;
            }
        }
    }
}
