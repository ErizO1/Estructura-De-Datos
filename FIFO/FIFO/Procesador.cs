﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Procesador
    {
        private FIFO f;
        private static Random r;

        public int ciclosVacios { get; private set; }
        public int procesosPendientes { get; private set; }
        public int ciclosPendientes { get; private set; }

        public Procesador()
        {
            r = new Random();
        }

        public void simular(int ciclos)
        {
            f = new FIFO();
            ciclosVacios = 0;
            ciclosPendientes = 0;
            procesosPendientes = 0;

            for (int i = 0; i < ciclos; i++)
            {
                if (r.Next(0, 4) == 0)
                {
                    Proceso temp = new Proceso();
                    f.enqueue(temp);
                    procesosPendientes++;
                    ciclosPendientes += temp.ciclosRestantes;
                }
                if (f.peek() != null)
                {
                    f.peek().ciclosRestantes--;
                    if (f.peek().ciclosRestantes == 0)
                    {
                        f.dequeue();
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
