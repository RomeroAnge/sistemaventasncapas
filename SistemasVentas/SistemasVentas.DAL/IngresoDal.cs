﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into ingreso values (" + ingreso.IdProveedor + ", "+
                                                          "'" + ingreso.FechaIngreso + "',"
                                                          + ingreso.Total + ","
                                                           + "'"+ ingreso.Estado +"')";
            conexion.Ejecutar(consulta);
        }
    }
}