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

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentasInsertarVista : Form
    {
        public DetalleVentasInsertarVista()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVent p = new DetalleVent();
            p.IdVenta = Convert.ToInt32(textBox1.Text);
            p.IdProducto = Convert.ToInt32(textBox2.Text);
            p.Cantidad = Convert.ToInt32(textBox3.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox4.Text);
            p.SubTotal = Convert.ToDecimal(textBox5.Text);
            bss.InsertarDetalleVentaBss(p);
            MessageBox.Show("Se guardó correctamente a Detalle Venta");
        }

    }
}
