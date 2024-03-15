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

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVista : Form
    {
        public UsuarioInsertarVista()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario p = new Usuario();
            p.IdPersona = Convert.ToInt32(textBox1.Text);
            p.NombreUser = textBox2.Text;
            p.Contraseña = textBox1.Text;
            p.FechaReg = dateTimePicker1.Value;

            bss.InsertarUsuarioBss(p);
            MessageBox.Show("Se guardó correctamente a Usuario");
        }
    }
}
