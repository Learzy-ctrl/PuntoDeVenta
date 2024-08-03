using PuntoDeVenta.Services;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Controllers
{
    internal class VentaController
    {
        private readonly VentasServices ventasServices = null;
        
        public VentaController()
        {
            ventasServices= new VentasServices();
        }

        public List<VentaVM> GetVentas()
        {
            var ventas = ventasServices.GetVentas();
            return ventas;
        }

        public bool guardarventa(VentaVM ventavm)
        {
            var validacion = ventasServices.GuardarVenta(ventavm);
            return validacion;
        }

        public List<VentaVM> ConsultaVentas (Consulta consulta)
        {
            var lista = ventasServices.VentaConsulta(consulta);
            return lista;
        }

        public List<VentaVM> ConsultaFecha (DateTime fecha)
        {
            var lista = ventasServices.FechaVentas(fecha);
            return lista;
        }
    }
}
