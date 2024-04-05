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

namespace SistemasVentas.VISTA.CategoriasVistas
{
    public partial class ListarCategoriasVista : Form
    {
        public ListarCategoriasVista()
        {
            InitializeComponent();
        }
        TipoProdBss tipoprod = new TipoProdBss();
        private void button3_Click(object sender, EventArgs e)
        {
            AgregarCategoriaVista fr = new AgregarCategoriaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = tipoprod.ListarTipoProdBss("");
            }
        }

        private void ListarCategoriasVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipoprod.ListarTipoProdBss("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductoVistas.ProductoAgregarVista.IdTipoProdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
