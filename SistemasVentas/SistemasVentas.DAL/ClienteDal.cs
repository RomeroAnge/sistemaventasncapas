﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "SELECT    CLIENTE.IDCLIENTE, (PERSONA.NOMBRE+' '+ PERSONA.APELLIDO)NOMBRECOMPLETO, CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, CLIENTE.ESTADO " +
                "FROM         CLIENTE INNER JOIN" +
                "                      PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public int InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values("+ cliente.IdPersona +"," +
                                                                     "'" + cliente.TipoCliente + "'," +
                                                                     "'" + cliente.CodigoClie + "'," +
                                                                     "'Activo')";
            conexion.Ejecutar(consulta);
            string consulta2 = "select max(idcliente) from cliente";
            return conexion.EjecutarEscalar(consulta2);
        }
        Cliente p = new Cliente();
        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                p.CodigoClie = tabla.Rows[0]["codigocliente"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();

            }
            return p;
        }
        public void EditarClienteDal(Cliente p)
        {
            string consulta = "update cliente set idpersona=" + p.IdPersona + "," +
                                                        "tipocliente='" + p.TipoCliente + "'," +
                                                        "codigocliente='" + p.CodigoClie + "'" +
                                                "where idcliente=" + p.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
