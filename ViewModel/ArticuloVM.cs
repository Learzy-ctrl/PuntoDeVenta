using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.ViewModel
{
    public class ArticuloVM
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Cod_Barras { get; set; }
        public int Stock { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }
        public byte[] Imagen { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategorias { get; set; }

        public string Descripcion { get; set; }

        public CategoriasVM CategoriasVM { get; set; }
        public ProveedorVM ProveedorVM { get; set; }
    }
}
