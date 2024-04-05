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

namespace SistemasVentas.VISTA.VendedorVistas
{
    public partial class InformacionRapidaVista : Form
    {
        public InformacionRapidaVista()
        {
            InitializeComponent();
        }
        PersonaBss personabss = new PersonaBss();
        ClienteBss clientebs = new ClienteBss();
        private void button4_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Telefono = string.Empty;
            persona.Correo = string.Empty;
            persona.Ci = string.Empty ;
            int idpersona = personabss.InsertarPersonaBss(persona);
            
            Cliente cliente = new Cliente();
            cliente.IdPersona = idpersona;
            cliente.TipoCliente = string.Empty;
            cliente.CodigoClie = string.Empty;
            VendedorVentaVista.IdClienteSeleccionado= clientebs.InsertarClienteBss(cliente);

        }
    }
}
