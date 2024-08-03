using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class ProveedorVM
    {
        

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Descripcion { get; set; }

        public List<DireccionesVM> DireccionesVM { get; set; }
        public List<EmailVM> EmailVM { get; set; }
        public List<ArticuloVM> ArticuloVM { get; set; }
        public List<TelefonosVM> TelefonosVM { get; set; }

        public ProveedorVM()
        {
            DireccionesVM = new List<DireccionesVM>();
            EmailVM = new List<EmailVM>();
            ArticuloVM= new List<ArticuloVM>();
            TelefonosVM = new List<TelefonosVM>();
        }
    }
}
