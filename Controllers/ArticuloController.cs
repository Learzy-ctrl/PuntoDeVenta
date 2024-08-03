using PuntoDeVenta.Models;
using PuntoDeVenta.Services;
using PuntoDeVenta.ViewModel;
using PuntoDeVenta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Controllers
{
    internal class ArticuloController
    {
        private readonly ArticuloServices Articuloservices = null;
        private readonly CategoriasServices categoriasServices = null;
        private readonly ProveedoresServices proveedoresServices = null;
        
        public ArticuloController() 
        {
            Articuloservices = new ArticuloServices();
            categoriasServices= new CategoriasServices();
            proveedoresServices = new ProveedoresServices();
        }
        public bool Añadir_Articulo(ArticuloVM articuloVM)
        {
             var Validacion = Articuloservices.AddArticulo(articuloVM);
             return Validacion;
        }

        public List<CategoriasVM> GetCategoria()
        {
            var Categorias = categoriasServices.GetCategorias();

            return Categorias;
        }

        public List<ProveedorVM> GetProveedores()
        {
            
            var proveedores = proveedoresServices.GetProveedorId();
            return proveedores;
        }

        public List<ArticuloVM> GetArticulos()
        {
            var articulos = Articuloservices.GetArticulos();

            return articulos;
        }

        public bool Actualizar(ArticuloVM articuloVM)
        {
            return Articuloservices.Actualizar(articuloVM);
        }

        public bool Delete(int id)
        {
            return Articuloservices.Delete(id);
        }

        public List<ArticuloVM> DatosConsulta(Consulta consulta)
        {
            return Articuloservices.RegresarDatosConsulta(consulta);
        }

        public ArticuloVM GetArticulo(string codbarras)
        {
            var articulo = Articuloservices.GetArticulo(codbarras);
            return articulo;
        }


    }
}
