using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss(string x)
        {
            return dal.ListarProductoDal(x);
        }
        public string DatosProductosBss()
        {
            return dal.DatosProductosDal();
        }
        public DataTable ProductoDatosBss(string a,string b)
        {
            return dal.ProductoDatosDal(a,b);
        }

        public DataTable ListarProductosGeneralBss(DateTime a, DateTime b)
        {
            return dal.ListarProductosGeneralDal(a, b);
        }
        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductoDal(producto);
        }
        public Producto ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductoIdDal(id);
        }
        public void EditarProductoBss(Producto p)
        {
            dal.EditarProductoDal(p);
        }
        public void EditarProductoXBss(Producto p)
        {
            dal.EditarProductoXDal(p);
        }
        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductoDal(id);
        }
    }
}
