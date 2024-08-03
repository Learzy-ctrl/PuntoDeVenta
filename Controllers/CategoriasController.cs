using PuntoDeVenta.Services;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Controllers
{

    internal class CategoriasController
    {
        private readonly CategoriasServices categoriasServices = null;

        public CategoriasController()
        {
            categoriasServices = new CategoriasServices();
        }

        public bool GuardarCategoria(CategoriasVM categoriasVM)
        {
            var categorias = categoriasServices.GuardarCategoria(categoriasVM);

            return categorias;
        }
    }
}
