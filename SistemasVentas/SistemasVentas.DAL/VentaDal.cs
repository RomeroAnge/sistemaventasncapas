using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDal
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values (" + venta.IdCliente + ", "
                                                          + venta.IdVendedor + ", " +
                                                          "'" + venta.Fecha + "',"
                                                           + venta.Total+ ",'"
                                                           + venta.Estado + "')";
            conexion.Ejecutar(consulta);
        }
    }
}
