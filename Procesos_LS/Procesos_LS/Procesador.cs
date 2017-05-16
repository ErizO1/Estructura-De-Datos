using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos_LS
{
    public class Procesador
    {
        ListaCircular lc;
        private static Random r;

        public int ciclosVacios { get; private set; }
        public int procesosMaximos { get; private set; }
        public int procesosPendientes { get; private set; }
        public int ciclosPendientes { get; private set; }
        public int procesosTerminados { get; private set; }

        public Procesador()
        {
            r = new Random();
        }

        public void simular(int ciclos)
        {
            lc = new ListaCircular();
            ciclosVacios = 0;
            procesosMaximos = 0;
            procesosPendientes = 0;
            ciclosPendientes = 0;
            procesosPendientes = 0;
            procesosTerminados = 0;

            for (int i = 0; i < ciclos; i++)
            {
                #region Agregar Proceso
                if (r.Next(0, 4) == 0)
                {
                    Proceso temp = new Proceso();
                    lc.enqueue(temp);
                    procesosPendientes++;
                    ciclosPendientes += temp.Anterior.ciclosRestantes;
                    if (procesosMaximos < procesosPendientes)
                        procesosMaximos = procesosPendientes;
                }
                #endregion

                #region Atender Proceso
                if (lc.peek() != null)
                {
                    lc.peek().ciclosRestantes--;
                    if (lc.peek().ciclosRestantes == 0)
                    {
                        lc.dequeue();
                        procesosTerminados++;
                        procesosPendientes--;
                    }
                    ciclosPendientes--;
                }
                else
                {
                    ciclosVacios++;
                }
                #endregion
            }
        }
    }
}
