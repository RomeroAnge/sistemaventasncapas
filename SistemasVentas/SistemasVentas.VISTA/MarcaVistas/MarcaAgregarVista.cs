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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaAgregarVista : Form
    {
        public MarcaAgregarVista()
        {
            InitializeComponent();
        }
        MarcaBss marcabss = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nombre = textBox1.Text;
            marcabss.InsertarMarcaBss(marca);
        }
    }
}
