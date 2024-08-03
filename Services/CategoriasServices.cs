using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Services
{
    internal class CategoriasServices
    {
        public List<CategoriasVM> GetCategorias() 
        {
            List<CategoriasVM> categoriasVMs = new List<CategoriasVM>();
            using (var context = new SistemaDeVentasEntities())
            {
                
                var lista = context.Categorias.ToList();
                foreach(var l in lista)
                {
                    CategoriasVM categorias = new CategoriasVM();
                    categorias.Nombre= l.Nombre;
                    categorias.Id= l.Id;

                    categoriasVMs.Add(categorias);

                }
            }
            return categoriasVMs;
        }


        public bool GuardarCategoria(CategoriasVM categoriasVM)
        {
            try
            {
                using (var context = new SistemaDeVentasEntities())
                {
                    Categorias categorias = new Categorias();

                    categorias.Nombre = categoriasVM.Nombre;

                    context.Categorias.Add(categorias);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
