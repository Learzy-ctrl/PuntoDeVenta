using PuntoDeVenta.Services;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Controllers
{

    public class ReportesController
    {
        private readonly ReporteServices reporteServices = null;

        public ReportesController()
        {
            reporteServices = new ReporteServices();
        }

        public List<VentaVM> ListaVentas(DateTime fecha)
        {
            return reporteServices.ListaVentas(fecha);
        }
    }
}
