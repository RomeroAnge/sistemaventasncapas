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
    public partial class GerenteReporteInventarioVista : Form
    {
        public GerenteReporteInventarioVista()
        {
            InitializeComponent();
        }
        ProductoBss productosbss = new ProductoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productosbss.ListarProductosGeneralBss(dateTimePicker1.Value, dateTimePicker2.Value);
        }
    }
}
