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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVista : Form
    {
        public UsuarioRolInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol p = new UsuarioRol();
            p.IdUsuario = Convert.ToInt32(textBox1.Text);
            p.IdRol= Convert.ToInt32(textBox2.Text);
            p.FechaAsigna = dateTimePicker1.Value;
            p.Estado = textBox3.Text;

            bss.InsertarUsuarioRolBss(p);
            MessageBox.Show("Se guardó correctamente a UsuarioRol");
        }
    }
}
