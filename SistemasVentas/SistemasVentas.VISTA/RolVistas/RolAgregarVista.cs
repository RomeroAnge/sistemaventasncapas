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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolAgregarVista : Form
    {
        public RolAgregarVista()
        {
            InitializeComponent();
        }

        RolBss rolbss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.Nombre = textBox1.Text;
            rolbss.InsertarRolBss(rol);
            MessageBox.Show("Se guardó correctamente a Rol");
        }
    }
}
