using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class TelefonosVM
    {
        public int Id { get; set; }
        public string Num_tel { get; set; }
        public int IdProveedor { get; set; }

        public ProveedorVM ProveedorVM { get; set; }
    }
}
