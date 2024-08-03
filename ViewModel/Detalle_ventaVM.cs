using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class Detalle_ventaVM
    {
        public int idDetalle_venta { get; set; }
        public int idVenta { get; set; }
        public int idArticulo { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }

        public ArticuloVM ArticuloVM { get; set; }
        public VentaVM VentaVM { get; set; }

        public Detalle_ventaVM()
        {
            ArticuloVM= new ArticuloVM();
        }
    }
}
