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
        private Proceso Primero;
        private Proceso Ultimo;

        private static Random r;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void bt_Comenzar_Click(object sender, EventArgs e)
        {
            Primero = null;
            Ultimo = null;

            int ciclosVacios = 0;
            int procesosPendientes = 0;
            int ciclosPendientes = 0;

            for (int i = 0; i < 200; i++)
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
            tb_vacios.Text = ciclosVacios.ToString();
            tb_procesos.Text = procesosPendientes.ToString();
            tb_ciclos.Text = ciclosPendientes.ToString();
        }
    }
}
