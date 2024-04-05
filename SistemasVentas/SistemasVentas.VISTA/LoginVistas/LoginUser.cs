using Microsoft.VisualBasic.ApplicationServices;
using SistemasVentas.VISTA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;

namespace SistemasVentas.VISTA.LoginVistas
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }
        UsuarioBss usuariobss = new UsuarioBss();
        RolBss rolbss = new RolBss();
        Rol rol = new Rol();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuariobss.LoginUsuariosBss(textBox1.Text, textBox2.Text)=="Activo")
            {
                rol = rolbss.ObtenerRolBss(textBox1.Text, textBox2.Text);
                
                if (rol.Nombre == "Gerente")
                {
                    Program.loginuser.Hide();
                    
                    GerenteVistas.GerenteMenuVista fr = new GerenteVistas.GerenteMenuVista(textBox1.Text, "Gerente");
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    fr.Show();
                }
                else if (rol.Nombre == "Supervisor")
                {
                    Program.loginuser.Hide();
                    
                    InventarioVistas.InventarioMenuVista fr = new InventarioVistas.InventarioMenuVista(textBox1.Text, "Supervisor-Inventario");
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    fr.Show();
                }
                else if (rol.Nombre == "Vendedor")
                {
                    Program.loginuser.Hide();
                    
                    VendedorVistas.VendedorMenuVista fr = new VendedorVistas.VendedorMenuVista(textBox1.Text, "Cajero-Vendedor");
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    fr.Show();
                }

                else
                {
                    MessageBox.Show("Usted No Tiene Acceso", "⛔ Acceso Restringido");
                    textBox2.Clear();
                }
            }
            else if (usuariobss.LoginUsuariosBss(textBox1.Text, textBox2.Text) == "Inactivo")
            {
                MessageBox.Show("Usted Como Usuario Está Inactivo", "⚠️ Ha ocurrido un Problema!");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecta, Intentelo de nuevo", "⚠️ Ha ocurrido un Problema!");
                textBox2.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Image = Resources.icons8_ocultar_35;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Image = Resources.icons8_ojo_40__1_;
            }
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {

        }
    }
}
