﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values (" + usuario.IdPersona + ",' "
                                                          + usuario.NombreUser + "',' "
                                                          + usuario.Contraseña + "','"
                                                          + usuario.FechaReg + "')";
            conexion.Ejecutar(consulta);
        }
    }
}
