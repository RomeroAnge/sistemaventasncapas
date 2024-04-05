using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarProductoDal(string buscar)
        {
            string consulta = "SELECT    PRODUCTO.IDPRODUCTO, (TIPOPROD.NOMBRE)TIPOPRODUCTO, PRODUCTO.NOMBRE, PRODUCTO.CODIGOBARRA, (MARCA.NOMBRE) MARCA, PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION, " +
                              "                     PRODUCTO.ESTADO  " +
                              "FROM         TIPOPROD INNER JOIN" +
                              "                    PRODUCTO ON TIPOPROD.IDTIPOPROD = PRODUCTO.IDTIPOPROD INNER JOIN" +
                              "                     MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA  WHERE PRODUCTO.NOMBRE LIKE '"+buscar+"%'";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public string DatosProductosDal()
        {
            string consulta = "SELECT    ((SUM (DETALLEING.CANTIDAD))-(SUM(DETALLEVENTA.CANTIDAD)))[CANTIDAD]\r\nFROM         DETALLEVENTA INNER JOIN\r\n                      PRODUCTO ON DETALLEVENTA.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\r\n                      DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO";
          
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            if (tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["cantidad"].ToString();
            }
            else
            {
                return "0";
            }
        }
        public DataTable ProductoDatosDal(string categoria, string producto)
        {
            string consulta = "SELECT    producto.idproducto,(PRODUCTO.NOMBRE)PRODUCTO, TIPOPROD.NOMBRE AS CATEGORIA, MARCA.NOMBRE AS MARCA, PRODUCTO.UNIDAD, PRODUCTO.CODIGOBARRA, PRODUCTO.DESCRIPCION\r\nFROM         TIPOPROD INNER JOIN\r\n                      PRODUCTO ON TIPOPROD.IDTIPOPROD = PRODUCTO.IDTIPOPROD INNER JOIN\r\n                      MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA  WHERE TIPOPROD.NOMBRE LIKE '" + categoria+ "%' AND PRODUCTO.NOMBRE LIKE '"+producto+"%' AND PRODUCTO.ESTADO = 'Activo'";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarProductosGeneralDal(DateTime a, DateTime b)
        {
            string consulta = "\r\nSELECT    PRODUCTO.NOMBRE AS PRODUCTOS, TIPOPROD.NOMBRE AS CATEGORIAS, MARCA.NOMBRE AS MARCAS, PRODUCTO.CODIGOBARRA, PROVEEDOR.NOMBRE AS PROVEEDOR, INGRESO.FECHAINGRESO, DETALLEING.PRECIOCOSTO, \r\n                      DETALLEING.PRECIOVENTA, DETALLEING.FECHAVENC\r\nFROM         TIPOPROD INNER JOIN\r\n                      PRODUCTO ON TIPOPROD.IDTIPOPROD = PRODUCTO.IDTIPOPROD INNER JOIN\r\n                      MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN\r\n                      PROVEE ON PRODUCTO.IDPRODUCTO = PROVEE.IDPRODUCTO INNER JOIN\r\n                      PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN\r\n                      DETALLEING ON PRODUCTO.IDPRODUCTO = DETALLEING.IDPRODUCTO INNER JOIN\r\n                      INGRESO ON PROVEEDOR.IDPROVEEDOR = INGRESO.IDPROVEEDOR AND DETALLEING.IDINGRESO = INGRESO.IDINGRESO  WHERE INGRESO.FECHAINGRESO BETWEEN '" + a+"'AND '"+b+"'";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values(" + producto.IdTipoProducto + "," +
                                                         + producto.IdMarca + "," +
                                                         "'" + producto.Nombre + "'," +
                                                         "'" + producto.CodigoBarra + "'," +
                                                         + producto.Unidad + "," +
                                                         "'" + producto.Descripcion + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }
        Producto p = new Producto();
        public Producto ObtenerProductoIdDal(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.IdTipoProducto = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.CodigoBarra = tabla.Rows[0]["codigobarra"].ToString();
                p.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                p.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;
        }
        public void EditarProductoDal(Producto p)
        {
            string consulta = "update producto set idtipoprod=" + p.IdTipoProducto + "," +
                                                        "idmarca=" + p.IdMarca + "," +
                                                        "nombre='" + p.Nombre + "'," +
                                                        "codigobarra='" + p.CodigoBarra + "'," +
                                                        "unidad=" + p.Unidad + "," +
                                                        "descripcion='" + p.Descripcion + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idproducto=" + p.IdProducto;
            conexion.Ejecutar(consulta);
        }
        public void EditarProductoXDal(Producto p)
        {
            string consulta = "update producto set nombre='" + p.Nombre + "'," +
                                                        "codigobarra='" + p.CodigoBarra + "'," +
                                                        "unidad=" + p.Unidad + "," +
                                                        "descripcion='" + p.Descripcion + "'," +
                                                        "estado='" + p.Estado + "' " +
                                                "where idproducto=" + p.IdProducto;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProductoDal(int id)
        {
            string consulta = "update producto set estado='Inactivo' " +
                                               "where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
