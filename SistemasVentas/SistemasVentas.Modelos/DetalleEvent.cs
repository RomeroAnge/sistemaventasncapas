using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class DetalleEvent
    {
        public int IdDetalleEvent { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioVenta { get; set; }
        public float SubTotal { get; set; }
        public string Estado { get; set; }
    }
}
