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
using SistemasVentas.VISTA.VendedorVistas;

namespace SistemasVentas.VISTA.VendedorVistas
{
    public partial class VendedorInicioVista : Form
    {
        public VendedorInicioVista()
        {
            InitializeComponent();
        }
        VentaBss ventabss   = new VentaBss();
        ProductoBss probss = new ProductoBss();
        private void VendedorInicioVista_Load(object sender, EventArgs e)
        {
            label4.Text = ventabss.VentasPorVendedorBss(VendedorMenuVista.IdVendedor);
            label5.Text = probss.DatosProductosBss();
        }
    }
}
