using PuntoDeVenta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Views
{
    public partial class Detalle_Articulo : Form
    {
        public Detalle_Articulo()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

        }

        public void LlenarVista(int id)
        {
            try
            {
                using (var context = new SistemaDeVentasEntities())
                {
                    var articulo = context.Articulo.Find(id);
                    if (articulo != null)
                    {
                        var categoria = context.Categorias.Find(articulo.IdCategorias);
                        var proveedor = context.Proveedor.Find(articulo.IdProveedor);
                        if (articulo.Imagen != null)
                        {
                            MemoryStream ms2 = new MemoryStream(articulo.Imagen);
                            Bitmap bmp = new Bitmap(ms2);
                            imgbox.Image = bmp;
                        }
                        NombreArticulo.Text = articulo.Nombre;
                        CodBarras.Text = articulo.Cod_Barras;
                        Stock.Text = articulo.Stock.ToString();
                        PrecioCompra.Text = articulo.Precio_Compra.ToString();
                        PrecioVenta.Text = articulo.Precio_Venta.ToString();
                        Descripcion.Text = articulo.Descripcion;
                        Fecha.Text = articulo.Fecha_Registro.ToString();
                        Categoria.Text = categoria.Nombre;
                        Proveedor.Text = proveedor.Nombre;
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }
            
        }
    }
}
