using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.GerenteVistas
{
    public partial class GerenteInicioVista : Form
    {
        public GerenteInicioVista()
        {
            InitializeComponent();
        }
        VentaBss ventabss = new VentaBss();
        UsuarioRolBss usuariobss= new UsuarioRolBss();
        ProductoBss probss = new ProductoBss();
        TipoProdBss tipoprobss = new TipoProdBss();
        private void GerenteInicioVista_Load(object sender, EventArgs e)
        {
            label8.Text = ventabss.IngresosTotalBss();
            label4.Text = usuariobss.UsuariosActivosInactivosBss("Activo");
            label10.Text=usuariobss.UsuariosActivosInactivosBss("Inactivos");
            label6.Text=ventabss.VentasTotalBss();
            label5.Text = probss.DatosProductosBss();
            label12.Text = tipoprobss.CategoriaTotalBss();
        }
    }
}
