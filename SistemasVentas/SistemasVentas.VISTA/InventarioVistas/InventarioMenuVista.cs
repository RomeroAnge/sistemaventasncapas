
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemasVentas.VISTA.InventarioVistas
{
    public partial class InventarioMenuVista : Form
    {
        public static string user;
        public static string rol;
        public InventarioMenuVista(string a, string b)
        {
            user = a;
            rol = b;
            InitializeComponent();
        }
        private void abrirformulario(object formulario)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form th = formulario as Form;
            th.TopLevel = false;
            th.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(th);
            this.panel2.Tag = th;
            th.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
            panel2.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Enabled = true;
        }

        //Inicio
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Inicio";
            panel2.Enabled = true;
            panel4.Visible = false;
            abrirformulario(new InventarioInicioVista());
        }
        //Categorias
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Categorias";
            panel2.Enabled = true;
            panel4.Visible = false;
            abrirformulario(new InventarioCategoriasVista());
        }
        //Inventario
        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "Inventario";
            panel2.Enabled = true;
            panel4.Visible = false;
            abrirformulario(new InventarioInventarioVista());
        }


        //CerrarSesion
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrando...", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Program.loginuser.Show();
               
            }
        }

        private void InventarioMenuVista_Load(object sender, EventArgs e)
        {
            label1.Text = "Inicio";
            label4.Text = user;
            label5.Text = rol;

            abrirformulario(new InventarioInicioVista());

        }


    }
}
