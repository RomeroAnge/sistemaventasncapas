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

namespace SistemasVentas.VISTA.VendedorVistas
{
    public partial class VendedorHistorialVentasVista : Form
    {
        public VendedorHistorialVentasVista()
        {
            InitializeComponent();
        }
        VentaBss ventabss = new VentaBss();
        private void VendedorHistorialVentasVista_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ventabss.ListarVentaPorVendedorBss(dateTimePicker1.Value,dateTimePicker2.Value, VendedorMenuVista.IdVendedor);
        }
    }
}
