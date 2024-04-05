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
    public class VentaBss
    {
        VentaDal dal = new VentaDal();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentaDal();
        }
        public DataTable ListarVentaPorVendedorBss(DateTime a, DateTime b, int Id)
        {
            return dal.ListarVentaPorVendedorDal(a,b,Id);
        }
        public DataTable ListarVentaGeneralBss(DateTime a, DateTime b)
        {
            return dal.ListarVentaGeneralDal(a, b);
        }
        public string IngresosTotalBss()
        {
            return dal.IngresoTotalDal();
        }
        public string VentasPorVendedorBss(int id)
        {
            return dal.VentasPorVendedorDal(id);
        }
        public string VentasTotalBss()
        {
            return dal.VentasTotalDal();
        }
        public int InsertarVentaBss(Venta venta)
        {
           return dal.InsertarVentaDal(venta);
        }

        public Venta ObtenerVentaIdBss(int id)
        {
            return dal.ObtenerVentaIdDal(id);
        }
        public void EditarVentaBss(Venta p)
        {
            dal.EditarVentaDal(p);
        }
        public void EliminarVentaBss(int id)
        {
            dal.EliminarVentaDal(id);
        }
    }
}
