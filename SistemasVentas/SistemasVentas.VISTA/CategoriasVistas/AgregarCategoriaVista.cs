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
    public partial class AgregarCategoriaVista : Form
    {
        public AgregarCategoriaVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void button1_Click(object sender, EventArgs e)
        {
            TipoProd p = new TipoProd();
            p.Nombre = textBox1.Text;

            bss.InsertarTipoProdBss(p);
            MessageBox.Show("Se Guardó correctamente");
        }


    }
}
