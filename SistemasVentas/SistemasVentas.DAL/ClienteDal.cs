using SistemasVentas.Modelos;
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
            string consulta = "select * from cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values("+ cliente.IdPersona +"," +
                                                                     "'" + cliente.TipoCliente + "'," +
                                                                     "'" + cliente.CodigoClie + "'," +
                                                                     "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
