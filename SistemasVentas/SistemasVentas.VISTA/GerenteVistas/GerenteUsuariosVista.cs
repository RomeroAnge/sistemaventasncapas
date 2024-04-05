using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.GerenteVistas
{
    public partial class GerenteUsuariosVista : Form
    {
        public GerenteUsuariosVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss usuariorolbss = new UsuarioRolBss();
        private void GerenteUsuariosVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuariorolbss.ListarUsuarioRolXBss(textBox2.Text, textBox1.Text);
            int n = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["Eliminar"].DisplayIndex = n;
            dataGridView1.Columns["Editar"].DisplayIndex = n;
            dataGridView1.Columns["Eliminar"].Width = 70;
            dataGridView1.Columns["Editar"].Width = 70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioVistas.UsuarioAgregarVista fr = new UsuarioVistas.UsuarioAgregarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = usuariorolbss.ListarUsuarioRolXBss(textBox2.Text, textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuariorolbss.ListarUsuarioRolXBss(textBox2.Text, textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuariorolbss.ListarUsuarioRolXBss(textBox2.Text, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = usuariorolbss.ListarUsuarioRolXBss(textBox2.Text, textBox1.Text);
        }
        UsuarioBss usuariobss = new UsuarioBss();


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idusuario"].Value.ToString());
                UsuarioVistas.UsuarioEditarVista fr = new UsuarioVistas.UsuarioEditarVista(IdSeleccionada);
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource = usuariorolbss.ListarUsuarioRolXBss(textBox2.Text, textBox1.Text);

                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idusuario"].Value);
                int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idusuariorol"].Value);
                DialogResult result = MessageBox.Show("¿Desea Eliminar este Producto?", "Eliminando", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    usuariorolbss.EliminarUsuarioRolBss(IdSeleccionado);
                    usuariobss.EliminarUsuarioBss(IdSeleccionada);
                    dataGridView1.DataSource = usuariorolbss.ListarUsuarioRolXBss(textBox2.Text, textBox1.Text);

                }
            }
        }
    }
}
