using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.GerenteVistas
{
    public partial class GerenteReporteVentasVista : Form
    {
        public GerenteReporteVentasVista()
        {
            InitializeComponent();
        }

        private void díaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            díaToolStripMenuItem.Checked = true;
            mesToolStripMenuItem.Checked = false;
            añoToolStripMenuItem.Checked = false;
        }

        private void mesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mesToolStripMenuItem.Checked = true;
            díaToolStripMenuItem.Checked = false;
            añoToolStripMenuItem.Checked = false;
        }

        private void añoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añoToolStripMenuItem.Checked = true;
            díaToolStripMenuItem.Checked = false;
            mesToolStripMenuItem.Checked = false;
        }
        VentaBss ventabss = new VentaBss();
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ventabss.ListarVentaGeneralBss(dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
