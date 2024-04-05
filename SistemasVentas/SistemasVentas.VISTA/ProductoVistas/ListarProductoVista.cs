using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ListarProductoVista : Form
    {
        public ListarProductoVista()
        {
            InitializeComponent();
        }
        ProductoBss productobss = new ProductoBss();
        private void ListarProductoVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productobss.ListarProductoBss("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendedorVistas.VendedorVentaVista.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productobss.ListarProductoBss(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productobss.ListarProductoBss(textBox1.Text);
        }
    }
}
