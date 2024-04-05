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
            string consulta = "SELECT    VENTA.IDVENTA, (PERSONA.NOMBRE+' '+ PERSONA.APELLIDO)NOMBRECOMPLETO, VENTA.FECHA, VENTA.TOTAL " +
                                "FROM         PERSONA INNER JOIN" +
                                "                      CLIENTE ON PERSONA.IDPERSONA = CLIENTE.IDPERSONA INNER JOIN" +
                                "                      VENTA ON CLIENTE.IDCLIENTE = VENTA.IDCLIENTE";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarVentaPorVendedorDal(DateTime a, DateTime b, int IdVendedor)
        {
            string consulta = "SELECT    VENTA.IDVENTA, (PERSONA.NOMBRE+PERSONA.APELLIDO)CLIENTE, SUM(DETALLEVENTA.CANTIDAD)CANTIDAD, AVG(DETALLEVENTA.PRECIOVENTA)PRECIOVENTA, AVG(DETALLEVENTA.SUBTOTAL)SUBTOTAL,SUM(DETALLEVENTA.SUBTOTAL)TOTAL, VENTA.ESTADO, VENTA.FECHA\r\nFROM         PERSONA INNER JOIN\r\n                      CLIENTE ON PERSONA.IDPERSONA = CLIENTE.IDPERSONA INNER JOIN\r\n                      VENTA ON CLIENTE.IDCLIENTE = VENTA.IDCLIENTE INNER JOIN\r\n                      DETALLEVENTA ON VENTA.IDVENTA = DETALLEVENTA.IDVENTA INNER JOIN\r\n                      PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO\r\nWHERE VENTA.FECHA BETWEEN '"+a+"'AND '"+b+"' AND VENTA.IDVENDEDOR = "+IdVendedor+"\r\nGROUP BY VENTA.IDVENTA,(PERSONA.NOMBRE+PERSONA.APELLIDO), VENTA.ESTADO, VENTA.FECHA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarVentaGeneralDal(DateTime a, DateTime b)
        {
            string consulta = "SELECT    (PERSONA.NOMBRE + PERSONA.APELLIDO)VENDEDOR, VENTA.IDCLIENTE, DETALLEVENTA.CANTIDAD, VENTA.TOTAL, VENTA.FECHA\r\nFROM         PERSONA INNER JOIN\r\n                      USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN\r\n                      VENTA ON USUARIO.IDUSUARIO = VENTA.IDVENDEDOR INNER JOIN\r\n                      DETALLEVENTA ON VENTA.IDVENTA = DETALLEVENTA.IDVENTA   WHERE VENTA.FECHA BETWEEN '"+a+"'AND '"+b+"'";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public string IngresoTotalDal()
        {
            string consulta = "SELECT    SUM(DETALLEING.PRECIOVENTA - DETALLEING.PRECIOCOSTO) [INGRESO]\r\nFROM         CLIENTE INNER JOIN\r\nVENTA ON CLIENTE.IDCLIENTE = VENTA.IDCLIENTE INNER JOIN\r\nDETALLEVENTA ON VENTA.IDVENTA = DETALLEVENTA.IDVENTA INNER JOIN\r\nPRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\r\nDETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO;";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["INGRESO"].ToString();
            }
            else
            {
                return "0";
            }
        }
        public string VentasTotalDal()
        {
            string consulta = "SELECT COUNT (IDVENTA)TOTAL FROM VENTA";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["total"].ToString();
            }
            else
            {
                return "0";
            }
        }
        public string VentasPorVendedorDal(int id)
        {
            string consulta = "SELECT    count (VENTA.IDVENTA)total\r\nFROM         USUARIO INNER JOIN\r\n                      VENTA ON USUARIO.IDUSUARIO = VENTA.IDVENDEDOR\r\nWHERE USUARIO.IDUSUARIO="+id+"";
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["total"].ToString();
            }
            else
            {
                return "0";
            }
        }
        public int InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into venta values (" + venta.IdCliente + ", "
                                                          + venta.IdVendedor + ", " +
                                                          "'" + venta.Fecha + "',"
                                                           + venta.Total+ ",'Activo')";
            conexion.Ejecutar(consulta);
            string consulta2 = "select max(idventa) from venta";
            return conexion.EjecutarEscalar(consulta2);
        }
        Venta p = new Venta();
        public Venta ObtenerVentaIdDal(int id)
        {
            string consulta = "select * from venta where idventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                p.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                p.IdVendedor = Convert.ToInt32(tabla.Rows[0]["idvendedor"]);
                p.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                p.Total = Convert.ToDecimal(tabla.Rows[0]["total"]);
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarVentaDal(Venta p)
        {
            string consulta = "update venta set idcliente=" + p.IdCliente + "," +
                                                        "idvendedor=" + p.IdVendedor + "," +
                                                        "fecha='" + p.Fecha + "', " +
                                                        "total=" + p.Total + "," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idventa=" + p.IdVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarVentaDal(int id)
        {
            string consulta = "delete from venta where idventa=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
