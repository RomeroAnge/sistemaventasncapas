using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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
    public partial class EditarCategoriaVista : Form
    {
        int idx = 0;
        TipoProd p = new TipoProd();
        TipoProdBss bss = new TipoProdBss();
        public EditarCategoriaVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Estado = textBox2.Text;

            bss.EditarTipoProdBss(p);
            MessageBox.Show("Se Editó correctamente");
        }

        private void EditarCategoriaVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerTipoProdIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Estado;
        }
    }
}
