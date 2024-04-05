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
    public partial class GerenteMenuVista : Form
    {
        public static string user;
        public static string rol;
        public GerenteMenuVista(string a, string b)
        {
            user = a;
            rol = b;
            InitializeComponent();
        }
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
        private void GerenteMenuVista_Load(object sender, EventArgs e)
        {
            label1.Text = "Inicio";
            
            abrirformulario(new GerenteInicioVista());
            label4.Text = user;
            label5.Text = rol;
        }
        //Aparecer
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            panel3.Enabled = false;
        }
        //Desaparecer
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            panel3.Enabled=true;
        }
        //Inicio
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Inicio";
            panel1.Visible =false;   
            panel3.Enabled=true;
            abrirformulario(new GerenteInicioVista());

        }
        //Usuarios
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Usuarios";
            panel1.Visible = false;
            panel3.Enabled = true;
            abrirformulario(new GerenteUsuariosVista());
        }
        //ReporteVentas
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Reporte Ventas";
            panel1.Visible = false;
            panel3.Enabled = true;
            abrirformulario(new GerenteReporteVentasVista());
        }
        //ReporteInventario
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Reporte Inventario";
            panel1.Visible = false;
            panel3.Enabled = true;
            abrirformulario(new GerenteReporteInventarioVista());
        }
        //CerrarSesion
        private void button5_Click(object sender, EventArgs e)
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
