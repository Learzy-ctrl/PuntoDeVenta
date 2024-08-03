using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using PuntoDeVenta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Services
{
    internal class ArticuloServices
    {
        ArticuloVM aVM1 = new ArticuloVM();

        public bool AddArticulo(ArticuloVM articuloVM)
        {

            using (var context = new SistemaDeVentasEntities())
            {
                Articulo articulo = new Articulo();
                articulo.Nombre = articuloVM.Nombre;
                articulo.Cod_Barras = articuloVM.Cod_Barras;
                articulo.Stock = articuloVM.Stock;
                articulo.Precio_Compra = articuloVM.Precio_Compra;
                articulo.Precio_Venta = articuloVM.Precio_Venta;
                articulo.Descripcion = articuloVM.Descripcion;
                articulo.IdCategorias = articuloVM.IdCategorias;
                articulo.IdProveedor = articuloVM.IdProveedor;
                articulo.Fecha_Registro = DateTime.Now;
                articulo.Imagen = articuloVM.Imagen;
                context.Articulo.Add(articulo);
                context.SaveChanges();

            }
            return true;



        }

        public List<ArticuloVM> GetArticulos()
        {
            List<ArticuloVM> articulosVM = new List<ArticuloVM>();
            using (var context = new SistemaDeVentasEntities())
            {

                var lista = context.Articulo.ToList();

                foreach (var l in lista)
                {
                    ArticuloVM articuloVM = new ArticuloVM();
                    articuloVM.Id = l.Id;
                    articuloVM.Nombre = l.Nombre;
                    articuloVM.Cod_Barras = l.Cod_Barras;
                    articuloVM.Stock = l.Stock;
                    articuloVM.Precio_Compra = l.Precio_Compra;
                    articuloVM.Precio_Venta = l.Precio_Venta;
                    articuloVM.IdCategorias = l.IdCategorias;
                    articuloVM.IdProveedor = l.IdProveedor;
                    articuloVM.Descripcion = l.Descripcion;
                    articuloVM.Fecha_Registro = l.Fecha_Registro;

                    articulosVM.Add(articuloVM);
                }
            }
            return articulosVM;
        }

        public bool Actualizar(ArticuloVM articuloVM)
        {
            try
            {
                using (var context = new SistemaDeVentasEntities())
                {
                    var articulo = context.Articulo.Find(articuloVM.Id);
                    articulo.Nombre = articuloVM.Nombre;
                    articulo.Cod_Barras = articuloVM.Cod_Barras;
                    articulo.Stock = articuloVM.Stock;
                    articulo.Precio_Compra = articuloVM.Precio_Compra;
                    articulo.Precio_Venta = articuloVM.Precio_Venta;
                    articulo.Imagen = articuloVM.Imagen;
                    articulo.IdCategorias = articuloVM.IdCategorias;
                    articulo.IdProveedor = articuloVM.IdProveedor;
                    articulo.Descripcion = articuloVM.Descripcion;
                    articulo.Fecha_Registro = DateTime.Now;
                    context.Entry(articulo).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception )
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                if (id > 0)
                {
                    using (var context = new SistemaDeVentasEntities())
                    {
                        var articulo = context.Articulo.Find(id);
                        if (articulo != null)
                        {
                            context.Articulo.Remove(articulo);
                            context.SaveChanges();
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ArticuloVM> RegresarDatosConsulta(Consulta consulta)
        {
            List<ArticuloVM> articuloVMs = new List<ArticuloVM>();
            using (var context = new SistemaDeVentasEntities())
            {
                switch (consulta.id)
                {
                    case 1:
                        var nombre = context.Articulo.Where(a => a.Nombre == consulta.Nombre).ToList();
                        foreach (var a in nombre)
                        {
                            ArticuloVM articuloVM = new ArticuloVM();
                            articuloVM.Id = a.Id;
                            articuloVM.Nombre = a.Nombre;
                            articuloVM.Cod_Barras = a.Cod_Barras;
                            articuloVM.Stock = a.Stock;
                            articuloVM.Precio_Compra = a.Precio_Compra;
                            articuloVM.Precio_Venta = a.Precio_Venta;
                            articuloVM.Descripcion = a.Descripcion;
                            articuloVM.Fecha_Registro = a.Fecha_Registro;
                            articuloVMs.Add(articuloVM);
                        }
                        break;
                    case 2:
                        var codigo = context.Articulo.Where(a => a.Cod_Barras == consulta.Nombre).ToList();
                        foreach (var a in codigo)
                        {
                            ArticuloVM articuloVM = new ArticuloVM();
                            articuloVM.Id = a.Id;
                            articuloVM.Nombre = a.Nombre;
                            articuloVM.Cod_Barras = a.Cod_Barras;
                            articuloVM.Stock = a.Stock;
                            articuloVM.Precio_Compra = a.Precio_Compra;
                            articuloVM.Precio_Venta = a.Precio_Venta;
                            articuloVM.Descripcion = a.Descripcion;
                            articuloVM.Fecha_Registro = a.Fecha_Registro;
                            articuloVMs.Add(articuloVM);
                        }
                        break;
                    case 3:
                        var valorstock = int.Parse(consulta.Nombre);
                        var stock = context.Articulo.Where(a => a.Stock == valorstock).ToList();
                        foreach (var a in stock)
                        {
                            ArticuloVM articuloVM = new ArticuloVM();
                            articuloVM.Id = a.Id;
                            articuloVM.Nombre = a.Nombre;
                            articuloVM.Cod_Barras = a.Cod_Barras;
                            articuloVM.Stock = a.Stock;
                            articuloVM.Precio_Compra = a.Precio_Compra;
                            articuloVM.Precio_Venta = a.Precio_Venta;
                            articuloVM.Descripcion = a.Descripcion;
                            articuloVM.Fecha_Registro = a.Fecha_Registro;
                            articuloVMs.Add(articuloVM);
                        }
                        break;
                    case 4:
                        var valorcompra = decimal.Parse(consulta.Nombre);
                        var compra = context.Articulo.Where(a => a.Precio_Compra == valorcompra).ToList();
                        foreach (var a in compra)
                        {
                            ArticuloVM articuloVM = new ArticuloVM();
                            articuloVM.Id = a.Id;
                            articuloVM.Nombre = a.Nombre;
                            articuloVM.Cod_Barras = a.Cod_Barras;
                            articuloVM.Stock = a.Stock;
                            articuloVM.Precio_Compra = a.Precio_Compra;
                            articuloVM.Precio_Venta = a.Precio_Venta;
                            articuloVM.Descripcion = a.Descripcion;
                            articuloVM.Fecha_Registro = a.Fecha_Registro;
                            articuloVMs.Add(articuloVM);
                        }
                        break;
                    case 5:
                        var valorventa = decimal.Parse(consulta.Nombre);
                        var venta = context.Articulo.Where(a => a.Precio_Venta == valorventa).ToList();
                        foreach (var a in venta)
                        {
                            ArticuloVM articuloVM = new ArticuloVM();
                            articuloVM.Id = a.Id;
                            articuloVM.Nombre = a.Nombre;
                            articuloVM.Cod_Barras = a.Cod_Barras;
                            articuloVM.Stock = a.Stock;
                            articuloVM.Precio_Compra = a.Precio_Compra;
                            articuloVM.Precio_Venta = a.Precio_Venta;
                            articuloVM.Descripcion = a.Descripcion;
                            articuloVM.Fecha_Registro = a.Fecha_Registro;
                            articuloVMs.Add(articuloVM);
                        }
                        break;
                }
            }
            return articuloVMs;
        }


        public ArticuloVM GetArticulo(string codbarras)
        {
            ArticuloVM articuloVM = new ArticuloVM();
            using(var context = new SistemaDeVentasEntities())
            {
                var articulo = context.Articulo.Where(a => a.Cod_Barras == codbarras);

                foreach(var a in articulo)
                {
                    articuloVM.Id = a.Id;
                    articuloVM.Nombre = a.Nombre;
                    articuloVM.Descripcion = a.Descripcion;
                    articuloVM.Precio_Venta = a.Precio_Venta;
                    articuloVM.Imagen = a.Imagen;
                }

            }
            return articuloVM;
        }

  
    }
}
