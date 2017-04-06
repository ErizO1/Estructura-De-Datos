using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        public EntradaInv[] _inventario { get; private set; }

        public Inventario(int lim)
        {
            _inventario = new EntradaInv[lim];
        }

        public bool Agregar(EntradaInv ent)
        {
            for (int i = 0; i < _inventario.Length; i++)
            {
                if (_inventario[i] == null)
                {
                    _inventario[i] = ent;
                    return true;
                }
            }
            return false;
        }

        public EntradaInv Buscar(int ID)
        {
            foreach(EntradaInv e in _inventario)
            {
                if ( e != null && e.Articulo.ID == ID)
                    return e;
            }
            return null;
        }

        public bool Borrar(int ID)
        {
            for (int i = 0; i < _inventario.Length; i++)
            {
                if (_inventario[i] != null && _inventario[i].Articulo.ID == ID)
                {
                    _inventario[i] = null;
                    return true;
                }
            }
            return false;
        }

        public bool Insertar(EntradaInv ent, int pos)
        {
            pos--;
            if (pos >= _inventario.Length)
                return false;
            int i = pos;
            while (_inventario[i] != null && i < _inventario.Length)
                i++;
            if (i == _inventario.Length)
                return false;
            for (; i > pos; i--)
                _inventario[i] = _inventario[i - 1];
            _inventario[pos] = ent;
            return true;
        }

        public override string ToString()
        {
            string Reporte = "Comenza Reporte de inventario:" + Environment.NewLine;
            for (int i = 0; i < _inventario.Length; i++)
            {
                Reporte += "Registro " + (i + 1).ToString() + ": ";
                if (_inventario[i] == null)
                    Reporte += "No hay ningún registro en esta posición.";
                else
                    Reporte += Environment.NewLine + _inventario[i].ToString();
                Reporte += Environment.NewLine;
            }
            Reporte += "Fin Reporte de Inventario.";
            return Reporte;
        }
    }

    public class EntradaInv
    {
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
