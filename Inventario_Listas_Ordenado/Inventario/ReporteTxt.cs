using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ReporteTxt : Form
    {
        private string Reporte;

        public ReporteTxt(string r)
        {
            Reporte = r;
            InitializeComponent();
        }

        private void ReporteTxt_Load(object sender, EventArgs e)
        {
            tb_Reporte.Text = Reporte;
        }
    }
}
