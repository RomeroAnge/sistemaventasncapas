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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolListarVista : Form
    {
        public RolListarVista()
        {
            InitializeComponent();
        }

        RolBss rolbss = new RolBss();
        private void button3_Click(object sender, EventArgs e)
        {
            RolAgregarVista fr = new RolAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = rolbss.ListarRolBss();
            }
        }

        private void RolListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rolbss.ListarRolBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioVistas.UsuarioAgregarVista.IdRolSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
