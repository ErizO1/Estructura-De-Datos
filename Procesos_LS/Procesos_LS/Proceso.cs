using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos_LS
{
    public class Proceso
    {
        private static Random _r;

        public int ciclosRestantes { get; set; }
        public Proceso Siguiente { get; set; }
        public Proceso Anterior { get; set; }

        public Proceso()
        {
            if (_r == null)
                _r = new Random();
            ciclosRestantes = _r.Next(4, 15);
        }
    }
}
