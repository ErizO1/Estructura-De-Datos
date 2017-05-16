using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesos_LS
{
    public partial class Form1 : Form
    {
        private Procesador p = new Procesador();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_comenzar_Click(object sender, EventArgs e)
        {
            p.simular(200);
            tb_vacio.Text = p.ciclosVacios.ToString();
            tb_maximo.Text = p.procesosMaximos.ToString();
            tb_procesos.Text = p.procesosPendientes.ToString();
            tb_ciclos.Text = p.ciclosPendientes.ToString();
            tb_totales.Text = p.procesosTerminados.ToString();
        }
    }
}
