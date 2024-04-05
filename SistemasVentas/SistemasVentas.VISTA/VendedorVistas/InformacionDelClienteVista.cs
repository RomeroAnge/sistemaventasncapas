using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class InformacionDelClienteVista : Form
    {
        public InformacionDelClienteVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss personabss = new PersonaBss();
        private void button2_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = personabss.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
                label5.Text = IdPersonaSeleccionada.ToString() + "-" + 12.ToString();
            }
        }
        ClienteBss clientebss = new ClienteBss();
        private void button4_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdPersona =IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoClie = label5.Text;

            clientebss.InsertarClienteBss(cliente);
            MessageBox.Show("Se guardó correctamente a Cliente");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void InformacionDelClienteVista_Load(object sender, EventArgs e)
        {

        }
    }
}
