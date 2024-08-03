using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Services
{
    public class ReporteServices
    {
      
        public List<VentaVM> ListaVentas(DateTime fecha)
        {
            List<VentaVM> ventas = new List<VentaVM>();
            List<Detalle_ventaVM> detalle = new List<Detalle_ventaVM>();
            using (var context = new SistemaDeVentasEntities())
            {
                var venta = context.Venta.Where(v => v.fecha == fecha ).ToList();
                foreach(var v in venta)
                {
                    VentaVM ventaVM = new VentaVM();
                    ventaVM.idVenta = v.idVenta;
                    ventaVM.FechaHora = v.FechaHora;
                    ventaVM.total = v.total;
                    ventaVM.VentaCancel = v.VentaCancel;
                    
                    foreach(var dv in v.Detalle_venta)
                    {
                        Detalle_ventaVM detalle_VentaVM = new Detalle_ventaVM();
                        detalle_VentaVM.ArticuloVM.Nombre = dv.Articulo.Nombre;
                        detalle_VentaVM.cantidad = dv.cantidad;
                        detalle_VentaVM.precio = dv.precio;
                        

                        ventaVM.Detalle_ventaVM.Add(detalle_VentaVM);
                    }

                    ventas.Add(ventaVM);
                }
            }
            return ventas;
        }
    }
}
