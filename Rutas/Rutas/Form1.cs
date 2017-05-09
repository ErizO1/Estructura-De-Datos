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
    public partial class Form1 : Form
    {
        Ruta r = new Ruta();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            Base temp = new Base(tb_Nombre.Text, Convert.ToInt32(tb_Minutos.Text));
            r.Agregar(temp);
            tb_Nombre.Text = "";
            tb_Minutos.Text = "";
            tb_Reporte.Text = temp.ToString();
        }

        private void bt_AgregarInicio_Click(object sender, EventArgs e)
        {
            Base temp = new Base(tb_Nombre.Text, Convert.ToInt32(tb_Minutos.Text));
            r.AgregarInicio(temp);
            tb_Nombre.Text = "";
            tb_Minutos.Text = "";
            tb_Reporte.Text = temp.ToString();
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            Base temp = r.Buscar(tb_Buscar.Text);
            if (temp != null)
                tb_Reporte.Text = temp.ToString();
            else
                tb_Reporte.Text = "Elemento no encontrado";
        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            if (r.Eliminar(tb_Buscar.Text))
                tb_Reporte.Text = "Elemento Eliminado";
            else
                tb_Reporte.Text = "Elemento no encontrado";
        }

        private void bt_InsertarDespuesDe_Click(object sender, EventArgs e)
        {
            Base temp = new Base(tb_Nombre.Text, Convert.ToInt32(tb_Minutos.Text));
            if (r.InsertarDespuesDe(tb_Buscar.Text, temp))
                tb_Reporte.Text = temp.ToString() + Environment.NewLine + "Elemento insertado después de " + tb_Buscar.Text;
            else
                tb_Reporte.Text = "El elemento " + tb_Reporte.Text + " no existe";
        }

        private void bt_Reporte_Click(object sender, EventArgs e)
        {
            tb_Reporte.Text = r.Reporte();
        }

        private void bt_Recorrido_Click(object sender, EventArgs e)
        {
            r.Recorrido(tb_inicio.Text, dtp_Inicio.Value, dtp_Fin.Value);
        }
    }
}

