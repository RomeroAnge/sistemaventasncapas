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

namespace SistemasVentas.VISTA.VendedorVistas
{
    public partial class VendedorVentaVista : Form
    {
        public VendedorVentaVista()
        {
            InitializeComponent();
        }
        private decimal SumarColumna(string columna)
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[columna].Value != null)
                    suma += Convert.ToDecimal(row.Cells[columna].Value);
            }
            return suma;
        }
        private void MultiplicarFila()
        {
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                decimal xd = (Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value));
                dataGridView1["subtotal", i].Value = xd;
            }
        }

        ProductoBss productobss = new ProductoBss();
        DetalleIngBss detallebss = new DetalleIngBss();

        private void button1_Click(object sender, EventArgs e)
        {

            ProductoVistas.ListarProductoVista fr = new ProductoVistas.ListarProductoVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = productobss.ObtenerProductoIdBss(IdProductoSeleccionado);
                DetalleIng detalleing = detallebss.ObtenerDetalleIngIdBss(IdProductoSeleccionado);
                dataGridView1.Rows.Add(producto.IdProducto, producto.Nombre, 1, 1);
                MultiplicarFila();
                label8.Text = SumarColumna("subtotal").ToString();
                label6.Text = dataGridView1.Rows.Count.ToString();
                label7.Text = SumarColumna("cantidad").ToString();
            }
        }
        private void VendedorVentaVista_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("idproductos", "IdProductos");
            dataGridView1.Columns["idproductos"].ReadOnly = true;
            dataGridView1.Columns["idproductos"].Width = 100;
            dataGridView1.Columns.Add("productos", "Productos");
            dataGridView1.Columns["productos"].ReadOnly = true;
            dataGridView1.Columns.Add("cantidad", "Cantidad");
            dataGridView1.Columns["cantidad"].Width = 90;
            dataGridView1.Columns.Add("precioventa", "PrecioVenta");
            dataGridView1.Columns["precioventa"].Width = 90;
            dataGridView1.Columns.Add("subtotal", "SubTotal");
            dataGridView1.Columns["subtotal"].ReadOnly = true;
            dataGridView1.Columns["subtotal"].Width=90;
        }

        ClienteBss clientebss = new ClienteBss();
        PersonaBss personabss = new PersonaBss();
        public static int IdClienteSeleccionado = 0;
        public static int IdProductoSeleccionado = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está con Prisa?", "Procesando.....", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                InformacionDelClienteExistenteVista fr = new InformacionDelClienteExistenteVista();
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    Cliente cliente = clientebss.ObtenerClienteIdBss(IdClienteSeleccionado);
                    Persona persona = personabss.ObtenerPersonaIdBss(cliente.IdPersona);
                    textBox1.Text = persona.Nombre + " " + persona.Apellido;
                }
            }
            else
            {
                InformacionRapidaVista fr = new InformacionRapidaVista();
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    Cliente cliente = clientebss.ObtenerClienteIdBss(IdClienteSeleccionado);
                    Persona persona = personabss.ObtenerPersonaIdBss(cliente.IdPersona);
                    textBox1.Text = persona.Nombre + " " + persona.Apellido;
                }
            }

        }
        VentaBss ventabss = new VentaBss();
        DetalleVentaBss deventabss = new DetalleVentaBss();
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && IdClienteSeleccionado != 0)
            {
                Venta venta = new Venta();
                venta.IdCliente = IdClienteSeleccionado;
                venta.IdVendedor = VendedorMenuVista.IdVendedor;
                venta.Fecha = dateTimePicker1.Value;
                venta.Total = SumarColumna("subtotal");
                int VentaActual = ventabss.InsertarVentaBss(venta);

                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {

                    DetalleVent deventa = new DetalleVent();
                    deventa.IdVenta = VentaActual;
                    deventa.IdProducto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    deventa.Cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    deventa.PrecioVenta = Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                    deventa.SubTotal = Convert.ToDecimal(deventa.Cantidad * deventa.PrecioVenta);
                    deventabss.InsertarDetalleVentaBss(deventa);
                }
                MessageBox.Show("El Registro Fue un Exito");
                dataGridView1.Rows.Clear();
                label8.Text = string.Empty;
                label6.Text = dataGridView1.Rows.Count.ToString();
                IdClienteSeleccionado = 0;
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Ingrese Algunos Productos y/o Cliente");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = SumarColumna("subtotal").ToString();
            label6.Text = dataGridView1.Rows.Count.ToString();
            label7.Text = SumarColumna("cantidad").ToString();
            MultiplicarFila();
        }
    }
}
