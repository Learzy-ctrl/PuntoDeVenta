using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class VentaVM
    {
        public int idVenta { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }
        public string VentaCancel { get; set; }
        public DateTime FechaHora { get; set; }
        public  List<Detalle_ventaVM> Detalle_ventaVM { get; set; }

        public ReportesVM reportesVM { get; set; }
        public VentaVM() 
        {
            Detalle_ventaVM = new List<Detalle_ventaVM>();
        }

    }
}
