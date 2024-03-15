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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class IngresoInsertarVista : Form
    {
        public IngresoInsertarVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso p = new Ingreso();
            p.IdProveedor = Convert.ToInt32(textBox1.Text);
            p.FechaIngreso = dateTimePicker1.Value; 
            p.Total = Convert.ToDecimal(textBox2.Text);
            p.Estado = textBox3.Text;

            bss.InsertarIngresoBss(p);
            MessageBox.Show("Se guardó correctamente a Ingreso");
        }
    }
}
