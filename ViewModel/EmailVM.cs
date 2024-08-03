using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class EmailVM
    {
        public int Id { get; set; }
        public string email1 { get; set; }
        public int IdProveedor { get; set; }

        public ProveedorVM ProveedorVM { get; set; }
    }
}
