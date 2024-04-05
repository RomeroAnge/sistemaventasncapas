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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoEditarVista : Form
    {
        public static int idx;
        public ProductoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        ProductoBss productobss = new ProductoBss();
        Producto producto = new Producto();

        private void ProductoEditarVista_Load(object sender, EventArgs e)
        {
            producto = productobss.ObtenerProductoIdBss(idx);
            textBox2.Text = producto.Nombre;
            textBox3.Text = producto.CodigoBarra;
            textBox1.Text = (producto.Unidad).ToString();
            textBox5.Text = producto.Descripcion;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            producto.Nombre = textBox2.Text;

            producto.CodigoBarra = textBox3.Text;
            producto.Unidad = Convert.ToInt32(textBox1.Text);
            producto.Descripcion = textBox5.Text;
            productobss.EditarProductoXBss(producto);
            MessageBox.Show("Actualizado Exitosamente");

        }
    }
}
