using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.CategoriasVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.InventarioVistas
{
    public partial class InventarioCategoriasVista : Form
    {
        public InventarioCategoriasVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCategoriaVista fr = new AgregarCategoriaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarTipoProdBss(textBox1.Text);
            }
        }

        private void InventarioCategoriasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss("");
            int n = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["Eliminar"].DisplayIndex = n;
            dataGridView1.Columns["Editar"].DisplayIndex = n;
            dataGridView1.Columns["Eliminar"].Width =70;
            dataGridView1.Columns["Editar"].Width = 70;

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDTIPOPROD"].Value.ToString());
                EditarCategoriaVista fr = new EditarCategoriaVista(IdSeleccionada);
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource = bss.ListarTipoProdBss(textBox1.Text);
                    textBox1.Text = string.Empty;
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDTIPOPROD"].Value);
                DialogResult result = MessageBox.Show("¿Desea Eliminar esta Categoria?", "Eliminando", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bss.EliminarTipoProdBss(IdSeleccionada);
                    textBox1.Text = string.Empty;
                    dataGridView1.DataSource = bss.ListarTipoProdBss(textBox1.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss(textBox1.Text);
        }
    }
}
