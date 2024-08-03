using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class CategoriasVM
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<ArticuloVM> ArticuloVM { get; set; }
    }
}
