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

namespace SistemasVentas.VISTA.InventarioVistas
{
    public partial class InventarioInicioVista : Form
    {
        public InventarioInicioVista()
        {
            InitializeComponent();
        }
        ProductoBss probss = new ProductoBss();
        TipoProdBss tipoprobss = new TipoProdBss(); 
        private void InventarioInicioVista_Load(object sender, EventArgs e)
        {
            label5.Text = probss.DatosProductosBss();
            label4.Text = tipoprobss.CategoriaTotalBss();
        }
    }
}
