using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.RolVistas;
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

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioAgregarVista : Form
    {
        public UsuarioAgregarVista()
        {
            InitializeComponent();
        }

        public static int IdPersonaSeleccionada = 0;
        PersonaBss personabss = new PersonaBss();
        private void button4_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = personabss.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox2.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
        UsuarioBss usuariobss = new UsuarioBss();
        Usuario usuario = new Usuario();
        UsuarioRol usuariorol = new UsuarioRol();
        UsuarioRolBss usuariorolbss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox4.Text;
            usuario.Contraseña = textBox7.Text;
            usuario.FechaReg = DateTime.Now;
            int idusuario = usuariobss.InsertarUsuarioBss(usuario);

            usuariorol.IdUsuario = idusuario;
            usuariorol.IdRol = IdRolSeleccionado;
            usuariorol.FechaAsigna = DateTime.Now;

            usuariorolbss.InsertarUsuarioRolBss(usuariorol);
            MessageBox.Show("Fueron Correctamente Añadidos");
        }

        public static int IdRolSeleccionado = 0;
        RolBss rolbss = new RolBss();
        Rol rol = new Rol();
        private void button6_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                rol = rolbss.ObtenerRolIdBss(IdRolSeleccionado);
                textBox5.Text = rol.Nombre;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IdRolSeleccionado = 5;
            panel1.Visible=false;
        }
    }
}
