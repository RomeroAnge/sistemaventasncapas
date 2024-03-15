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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVista : Form
    {
        public VentaInsertarVista()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta p = new Venta();
            p.IdCliente = Convert.ToInt32(textBox1.Text);
            p.IdVendedor = Convert.ToInt32(textBox2.Text);
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox3.Text);
            p.Estado = textBox4.Text;

            bss.InsertarVentaBss(p);
            MessageBox.Show("Se guardó correctamente a Venta");
        }
    }
}
