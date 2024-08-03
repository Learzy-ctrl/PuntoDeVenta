using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Services
{
    internal class VentasServices
    {
        public List<VentaVM> GetVentas()
        {
            List<VentaVM> ventasVM = new List<VentaVM>();
            using(var context = new SistemaDeVentasEntities())
            {
                var ventas = context.Venta.ToList();

                foreach(var v in ventas)
                { 
                    VentaVM ventaVM = new VentaVM();
                    ventaVM.idVenta = v.idVenta;
                    ventaVM.fecha = v.fecha;
                    ventaVM.FechaHora= v.FechaHora;
                    ventaVM.total = v.total;
                    ventaVM.VentaCancel = v.VentaCancel;
                    ventasVM.Add(ventaVM);
                }
            }
            return ventasVM;
        }

        public bool GuardarVenta(VentaVM ventaVM)
        {
            using (var context = new SistemaDeVentasEntities())
            {
                using (var dbTransaccion = context.Database.BeginTransaction())
                {
                    try
                    {
                        Venta venta = new Venta();
                        venta.FechaHora = ventaVM.FechaHora;
                        venta.fecha = ventaVM.fecha;
                        venta.total = ventaVM.total;
                        venta.VentaCancel = ventaVM.VentaCancel;
                        context.Venta.Add(venta);
                        context.SaveChanges();

                        foreach (var t in ventaVM.Detalle_ventaVM)
                        {

                            Detalle_venta detalle_Venta = new Detalle_venta();
                            var articulo = context.Articulo.Find(t.idArticulo);

                            detalle_Venta.idArticulo = t.idArticulo;
                            detalle_Venta.cantidad = t.cantidad;
                            detalle_Venta.precio = t.precio;
                            detalle_Venta.idVenta = venta.idVenta;

                            if(ventaVM.VentaCancel == "no")
                            {
                                articulo.Stock -= detalle_Venta.cantidad;
                                context.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                            }
                            context.Detalle_venta.Add(detalle_Venta);
                        }

                        context.SaveChanges();

                        dbTransaccion.Commit();

                        if (ventaVM.VentaCancel == "no")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (Exception)
                    {
                        dbTransaccion.Rollback();
                        return false;
                    }
                }
            }
        }

        public List<VentaVM> VentaConsulta(Consulta consulta)
        {
            List<VentaVM> list = new List<VentaVM>();
            using(var context = new SistemaDeVentasEntities())
            {
                switch (consulta.id)
                {
                    case 1:
                        decimal total = decimal.Parse(consulta.Nombre);
                        var mayor = context.Venta.Where(v => v.total >= total);
                        foreach(var m in mayor)
                        {
                            VentaVM venta = new VentaVM();
                            venta.idVenta = m.idVenta;
                            venta.FechaHora = m.FechaHora;
                            venta.total= m.total;
                            venta.VentaCancel= m.VentaCancel;
                            list.Add(venta);
                        }
                        break;
                    case 2:
                        decimal total1 = decimal.Parse(consulta.Nombre);
                        var menor = context.Venta.Where(v => v.total <= total1);
                        foreach (var m in menor)
                        {
                            VentaVM venta = new VentaVM();
                            venta.idVenta = m.idVenta;
                            venta.FechaHora = m.FechaHora;
                            venta.total = m.total;
                            venta.VentaCancel = m.VentaCancel;
                            list.Add(venta);
                        }
                        break;
                    case 3:
                        
                        var cancelada = context.Venta.Where(v => v.VentaCancel == "si");
                        foreach (var m in cancelada)
                        {
                            VentaVM venta = new VentaVM();
                            venta.idVenta = m.idVenta;
                            venta.FechaHora = m.FechaHora;
                            venta.total = m.total;
                            venta.VentaCancel = m.VentaCancel;
                            list.Add(venta);
                        }
                        break;
                    case 4:
                        var nocancelada = context.Venta.Where(v => v.VentaCancel == "no");
                        foreach (var m in nocancelada)
                        {
                            VentaVM venta = new VentaVM();
                            venta.idVenta = m.idVenta;
                            venta.FechaHora = m.FechaHora;
                            venta.total = m.total;
                            venta.VentaCancel = m.VentaCancel;
                            list.Add(venta);
                        }
                        break;
                }
            }

            return list;
            
        }

        public List<VentaVM> FechaVentas(DateTime fecha)
        {
            List<VentaVM> lista = new List<VentaVM>();
            using(var context = new SistemaDeVentasEntities())
            {
                var ventas = context.Venta.Where(v => v.fecha == fecha);
                foreach (var m in ventas)
                {
                    VentaVM venta = new VentaVM();
                    venta.idVenta = m.idVenta;
                    venta.FechaHora = m.FechaHora;
                    venta.total = m.total;
                    venta.VentaCancel = m.VentaCancel;
                    lista.Add(venta);
                }

            }
            return lista;
        }
    }
}
