using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVent detallevent)
        {
            string consulta = "insert into detalleventa values (" + detallevent.IdVenta + ", "
                                                          + detallevent.IdProducto + ", " 
                                                          + detallevent.Cantidad + ","
                                                           + detallevent.PrecioVenta + ", "
                                                           + detallevent.SubTotal + ", "+
                                                            "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
    }
}
