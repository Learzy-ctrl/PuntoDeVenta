using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class DireccionesVM
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public int IdProveedor { get; set; }

        public ProveedorVM ProveedorVM { get; set; }
    }
}
