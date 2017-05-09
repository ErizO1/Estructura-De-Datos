using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rutas
{
    public partial class frm_Recorrido : Form
    {
        public frm_Recorrido(List<string> header, List<List<string>> data)
        {
            InitializeComponent();
            foreach(string h in header)
            {
                dgv_Datos.Columns.Add(h, h);
            }
            foreach(List<string> r in data)
            {
                dgv_Datos.Rows.Add(r.ToArray());
            }
        }
    }
}
