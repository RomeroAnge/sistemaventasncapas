
using Microsoft.VisualBasic.ApplicationServices;
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

namespace SistemasVentas.VISTA.VendedorVistas
{
    public partial class VendedorMenuVista : Form
    {
        public static string user;
        public static string rol;
        public VendedorMenuVista(string a, string b)
        {
            user = a;
            rol = b;
            InitializeComponent();
        }
        UsuarioBss userbss = new UsuarioBss();
        public static int IdVendedor = 1;
        private void abrirformulario(object formulario)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form th = formulario as Form;
            th.TopLevel = false;
            th.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(th);
            this.panel3.Tag = th;
            th.Show();
        }
        private void VendedorMenuVista_Load(object sender, EventArgs e)
        {
            label1.Text = "Inicio";
            label4.Text = user;
            label5.Text = rol;
            IdVendedor = userbss.ObtenerUsuarioIdPorNombreBss(user);
            abrirformulario(new VendedorInicioVista());
            
        }
        //Aparecer
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            panel3.Enabled = false;
        }
        //Desaparecer
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Enabled = true;
        }
        //Inicio
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Inicio";
            panel1.Visible = false;
            panel3.Enabled = true;
            abrirformulario(new VendedorInicioVista());
        }
        //Venta
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Usuarios";
            panel1.Visible = false;
            panel3.Enabled = true;
            abrirformulario(new VendedorVentaVista());
        }
        //Historial Ventas
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Reporte Ventas";
            panel1.Visible = false;
            panel3.Enabled = true;
            abrirformulario(new VendedorHistorialVentasVista());
        }
        //Cerrar Sesion
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Cerrar Sesión?", "Cerrando...", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Program.loginuser.Show();

            }
        }

       
    }
}
