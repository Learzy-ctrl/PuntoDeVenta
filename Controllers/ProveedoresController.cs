using PuntoDeVenta.Services;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Controllers
{
    internal class ProveedoresController
    {
        private readonly ProveedoresServices proveedoresServices = null;

        public ProveedoresController()
        {
            proveedoresServices = new ProveedoresServices();
        }



        public bool AddProveedor(ProveedorVM proveedorVM)
        {
            var exito = proveedoresServices.GuardarProveedores(proveedorVM);
            return exito;
        }

        public List<ProveedorVM> GetProveedores()
        {
            return proveedoresServices.ListaProveedores();
        }
    }
}
