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
    public partial class Form1 : Form
    {
        private static Inventario inv;

        public Form1()
        {
            InitializeComponent();
            inv = new Inventario(15);
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            EntradaInv ent = new EntradaInv()
            {
                Articulo = new Artículo()
                {
                    ID = Convert.ToInt32(tb_ID.Text),
                    Nombre = tb_Nombre.Text,
                    Precio = Convert.ToDouble(tb_Precio.Text)
                },
                Cantidad = Convert.ToInt32(tb_Cantidad.Text)
            };
            if (inv.Agregar(ent))
            {
                MessageBox.Show("Artículo Agregado con éxito");
                tb_ID.Text = "";
                tb_Nombre.Text = "";
                tb_Precio.Text = "";
                tb_Cantidad.Text = "";
            }
            else
                MessageBox.Show("La lista de artículos está llena");
        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            if (inv.Borrar(Convert.ToInt32(tb_ID.Text)))
            {
                MessageBox.Show("El artículo se eliminó correctamente");
                tb_ID.Text = "";
            }
            else
                MessageBox.Show("El artículo con el ID " + tb_ID.Text + " no existe.");
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            EntradaInv ent = inv.Buscar(Convert.ToInt32(tb_ID.Text));
            if (ent != null)
            {
                MessageBox.Show("Producto Encontrado");
                tb_Nombre.Text = ent.Articulo.Nombre;
                tb_Precio.Text = ent.Articulo.Precio.ToString();
                tb_Cantidad.Text = ent.Cantidad.ToString();
            }
            else
                MessageBox.Show("El producto con el Código " + tb_ID.Text + " no existe");
        }

        private void bt_Insertar_Click(object sender, EventArgs e)
        {
            EntradaInv ent = new EntradaInv()
            {
                Articulo = new Artículo()
                {
                    ID = Convert.ToInt32(tb_ID.Text),
                    Nombre = tb_Nombre.Text,
                    Precio = Convert.ToDouble(tb_Precio.Text)
                },
                Cantidad = Convert.ToInt32(tb_Cantidad.Text)
            };

            if (inv.Insertar(ent, Convert.ToInt32(tb_Pos.Text)))
            {
                MessageBox.Show("Artículo Insertado con éxito");
                tb_ID.Text = "";
                tb_Nombre.Text = "";
                tb_Precio.Text = "";
                tb_Cantidad.Text = "";
                tb_Pos.Text = "";
            }
            else
                MessageBox.Show("La posición donde se desea insertae el artículo ya está ocupada");
        }

        private void bt_Reporte_Click(object sender, EventArgs e)
        {
            ReporteTxt r = new ReporteTxt(inv.ToString());
            r.ShowDialog();

            string[] row = new string[4];
            dgv_Reporte.Rows.Clear();

            for (int i = 0; i < inv._inventario.Length; i++)
            {
                if (inv._inventario[i] != null)
                {
                    row[0] = inv._inventario[i].Articulo.ID.ToString();
                    row[1] = inv._inventario[i].Articulo.Nombre;
                    row[2] = inv._inventario[i].Cantidad.ToString();
                    row[3] = inv._inventario[i].Articulo.Precio.ToString("c2");
                }
                else
                {
                    row[0] = "";
                    row[1] = "";
                    row[2] = "";
                    row[3] = "";
                }
                dgv_Reporte.Rows.Add(row);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < inv._inventario.Length; i++)
            {
                dgv_Reporte.Rows.Add(new string[4] { "", "", "", "" });
            }
        }
    }
}
