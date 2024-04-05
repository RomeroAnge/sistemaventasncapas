using SistemasVentas.BSS;
using SistemasVentas.VISTA.CategoriasVistas;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.VendedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.InventarioVistas
{
    public partial class InventarioInventarioVista : Form
    {
        public InventarioInventarioVista()
        {
            InitializeComponent();
        }
        ProductoBss bsspro = new ProductoBss();

        private void InventarioInventarioVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsspro.ProductoDatosBss(textBox2.Text, textBox1.Text);
            int n = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["Eliminar"].DisplayIndex = n;
            dataGridView1.Columns["Editar"].DisplayIndex = n;
            dataGridView1.Columns["Eliminar"].Width = 70;
            dataGridView1.Columns["Editar"].Width = 70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoVistas.ProductoAgregarVista fr = new ProductoVistas.ProductoAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bsspro.ProductoDatosBss(textBox2.Text, textBox1.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsspro.ProductoDatosBss(textBox2.Text, textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsspro.ProductoDatosBss(textBox2.Text, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsspro.ProductoDatosBss(textBox2.Text, textBox1.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idproducto"].Value.ToString());
                ProductoEditarVista fr = new ProductoEditarVista(IdSeleccionada);
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource = bsspro.ProductoDatosBss(textBox2.Text, textBox1.Text);

                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idproducto"].Value);
                DialogResult result = MessageBox.Show("¿Desea Eliminar este Producto?", "Eliminando", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bsspro.EliminarProductoBss(IdSeleccionada);

                    dataGridView1.DataSource = bsspro.ProductoDatosBss(textBox2.Text, textBox1.Text);
                }
            }
        }
    }
}
