using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO
{
    public partial class Form1 : Form
    {
        private Procesador p;

        public Form1()
        {
            InitializeComponent();
            p = new Procesador();
        }

        private void bt_Comenzar_Click(object sender, EventArgs e)
        {
            p.simular(200);
            tb_vacios.Text = p.ciclosVacios.ToString();
            tb_procesos.Text = p.procesosPendientes.ToString();
            tb_ciclos.Text = p.ciclosPendientes.ToString();
        }
    }
}
