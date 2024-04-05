using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
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
    public partial class ProductoAgregarVista : Form
    {
        public ProductoAgregarVista()
        {
            InitializeComponent();
        }
        public static int IdMarcaSeleccionada = 0;
        public static int IdTipoProdSeleccionado = 0;
        private void button5_Click(object sender, EventArgs e)
        {

        }
        ProductoBss productobss = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.IdTipoProducto = IdTipoProdSeleccionado;
            producto.Nombre = textBox2.Text;
            producto.IdMarca = IdMarcaSeleccionada;
            producto.CodigoBarra = textBox3.Text;
            producto.Unidad = Convert.ToInt32(textBox1.Text);
            producto.Descripcion = textBox5.Text;
            productobss.InsertarProductoBss(producto);
            MessageBox.Show("Registrado Exitosamente");
        }
        TipoProdBss tprodbss = new TipoProdBss();
        private void button5_Click_1(object sender, EventArgs e)
        {
            CategoriasVistas.ListarCategoriasVista fr = new CategoriasVistas.ListarCategoriasVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = tprodbss.ObtenerTipoProdIdBss(IdTipoProdSeleccionado);
                textBox4.Text = tipoprod.Nombre;
            }
        }
        MarcaBss marcabss = new MarcaBss();
        private void button4_Click(object sender, EventArgs e)
        {
            MarcaListarVista fr = new MarcaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = marcabss.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox7.Text = marca.Nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarcaAgregarVista fr = new MarcaAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void ProductoAgregarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
