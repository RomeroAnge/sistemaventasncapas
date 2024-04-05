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
    public partial class UsuarioEditarVista : Form
    {
        public static int ids;
        public UsuarioEditarVista(int id)
        {
            ids = id;
            InitializeComponent();
        }
        Usuario usuario = new Usuario();
        UsuarioBss usuariobss = new UsuarioBss();
        private void UsuarioEditarVista_Load(object sender, EventArgs e)
        {
            usuario = usuariobss.ObtenerUsuarioIdBss(ids);
            textBox4.Text = usuario.NombreUser;
            textBox7.Text = usuario.Contraseña;

        }
  

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.NombreUser = textBox4.Text;
            usuario.Contraseña = textBox7.Text;
            usuario.FechaReg = DateTime.Now;
            usuariobss.EditarUsuarioBss(usuario);
            MessageBox.Show("Se Actualizo correctamente");
        }

        
    }
}
