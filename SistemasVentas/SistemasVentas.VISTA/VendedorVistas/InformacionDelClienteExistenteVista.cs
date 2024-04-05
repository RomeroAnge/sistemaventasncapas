using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class InformacionDelClienteExistenteVista : Form
    {
        public InformacionDelClienteExistenteVista()
        {
            InitializeComponent();
        }

        private void InformacionDelClienteExistenteVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clientebss.ListarClienteBss();
        }
        ClienteBss clientebss = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            InformacionDelClienteVista fr = new InformacionDelClienteVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = clientebss.ListarClienteBss();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendedorVentaVista.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
