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
        private static Random r;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void bt_comenzar_Click(object sender, EventArgs e)
        {
            Proceso Inicio = null;
            Proceso Actual = null;
            int ciclosVacios = 0;
            int procesosMaximos = 0;
            int procesosPendientes = 0;
            int ciclosPendientes = 0;
            int procesosTerminados = 0;

            for (int i = 0; i < 200; i++)
            {
                #region Agregar Proceso
                if (r.Next(0, 4) == 0)
                {
                    if (Inicio == null)
                    {
                        Inicio = new Proceso();
                        Inicio.Siguiente = Inicio;
                        Inicio.Anterior = Inicio;
                    }
                    else
                    {
                        Proceso temp = new Proceso();
                        temp.Anterior = Inicio.Anterior;
                        temp.Siguiente = Inicio;
                        temp.Siguiente.Anterior = temp;
                        temp.Anterior.Siguiente = temp;
                    }
                    procesosPendientes++;
                    ciclosPendientes += Inicio.Anterior.ciclosRestantes;
                    if (procesosMaximos < procesosPendientes)
                        procesosMaximos = procesosPendientes;
                }
                #endregion

                #region Atender Proceso
                if (Actual != null)
                {
                    Actual.ciclosRestantes--;
                    if (Actual.ciclosRestantes == 0)
                    {
                        Proceso temp = Actual;
                        Actual = Actual.Anterior;
                        if (temp == Inicio)
                            Inicio = temp.Siguiente;

                        temp.Siguiente.Anterior = temp.Anterior;
                        temp.Anterior.Siguiente = temp.Siguiente;
                        temp.Anterior = null;
                        temp.Siguiente = null;
                        temp = null;

                        if (Inicio.Siguiente == null && Inicio.Anterior == null)
                        {
                            Inicio = null;
                            Actual = null;
                        }

                        procesosTerminados++;
                        procesosPendientes--;
                    }
                    if (Actual != null) 
                        Actual = Actual.Siguiente;
                    ciclosPendientes--;
                }
                else
                {
                    Actual = Inicio;
                    ciclosVacios++;
                }
                #endregion
            }

            tb_vacio.Text = ciclosVacios.ToString();
            tb_maximo.Text = procesosMaximos.ToString();
            tb_procesos.Text = procesosPendientes.ToString();
            tb_ciclos.Text = ciclosPendientes.ToString();
            tb_totales.Text = procesosTerminados.ToString();
        }
    }
}
