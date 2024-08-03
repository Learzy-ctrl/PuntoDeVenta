using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Services
{
    internal class ProveedoresServices
    {
        public bool GuardarProveedores(ProveedorVM proveedorVM)
        {
            using (var context = new SistemaDeVentasEntities())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Nombre = proveedorVM.Nombre;
                proveedor.Descripcion = proveedorVM.Descripcion;
                proveedor.Fecha_Registro = DateTime.Now;

                foreach (var e in proveedorVM.EmailVM)
                {
                    Email email = new Email();
                    email.email1 = e.email1;

                    proveedor.Email.Add(email);

                }

                foreach (var t in proveedorVM.TelefonosVM)
                {
                    Telefonos telefonos = new Telefonos();
                    telefonos.Num_tel = t.Num_tel;

                    proveedor.Telefonos.Add(telefonos);
                }

                foreach (var d in proveedorVM.DireccionesVM)
                {
                    Direcciones direcciones = new Direcciones();
                    direcciones.Estado = d.Estado;
                    direcciones.Municipio = d.Municipio;
                    direcciones.Colonia = d.Colonia;
                    direcciones.Calle = d.Calle;

                    proveedor.Direcciones.Add(direcciones);
                }

                context.Proveedor.Add(proveedor);
                context.SaveChanges();
                return true;
            }
        }

        public List<ProveedorVM> ListaProveedores()
        {
            List<ProveedorVM> proveedorVMs = new List<ProveedorVM>();

            using (var context = new SistemaDeVentasEntities())
            {
                var lista = context.Proveedor.ToList();
                foreach(var l in lista)
                {
                    ProveedorVM proveedorVM = new ProveedorVM();
                    proveedorVM.Id = l.Id;
                    proveedorVM.Nombre = l.Nombre;
                    proveedorVM.Descripcion= l.Descripcion;
                    proveedorVM.Fecha_Registro=l.Fecha_Registro;

                    proveedorVMs.Add(proveedorVM);
                }
            }
            return proveedorVMs;
        }

        public List<ProveedorVM> GetProveedorId()
        {
            List<ProveedorVM> proveedorVMs = new List<ProveedorVM>();

            using (var context = new SistemaDeVentasEntities())
            {
                var lista = context.Proveedor.ToList();
                foreach(var l in lista)
                {
                    ProveedorVM proveedorVM = new ProveedorVM();
                    proveedorVM.Nombre = l.Nombre;
                    proveedorVM.Id= l.Id;

                    proveedorVMs.Add(proveedorVM);
                }
            }
            return proveedorVMs;
        }
    }
}
