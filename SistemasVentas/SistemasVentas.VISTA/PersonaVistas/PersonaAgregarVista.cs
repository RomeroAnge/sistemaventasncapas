﻿using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaAgregarVista : Form
    {
        public PersonaAgregarVista()
        {
            InitializeComponent();
        }
        PersonaBss personabss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Telefono = textBox3.Text;
            persona.Ci = textBox4.Text;
            persona.Correo= textBox5.Text;
            personabss.InsertarPersonaBss(persona);
            MessageBox.Show("Se guardó correctamente a Persona");
        }
    }
}
