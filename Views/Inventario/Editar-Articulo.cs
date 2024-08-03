using PuntoDeVenta.Controllers;
using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PuntoDeVenta.Views
{
    public partial class Editar_Articulo : Form
    {
        int ide;
        byte[] file = null;

        private readonly ArticuloController articuloController = null;

        public Editar_Articulo()
        {
            InitializeComponent();
            articuloController= new ArticuloController();

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void Editar_Articulo_Load(object sender, EventArgs e)
        {
            DropdownList();
        }

        public void llenar(int id)
        {
            
                using (var context = new SistemaDeVentasEntities())
                {
                    var articulo = context.Articulo.Find(id);
                    if (articulo != null)
                    {
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
                        ide = id;
                    }
                    
                }
            
            
        }

        private void SubirImagen_Click(object sender, EventArgs e)
        {
            img();

            var imagen = file;
            if (imagen != null)
            {
                MemoryStream ms2 = new MemoryStream(imagen);
                Bitmap bmp = new Bitmap(ms2);
                imgbox.Image = bmp;
            }
        }

        public void img()
        {
            try
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                }


                Stream mystream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    mystream.CopyTo(ms);
                    file = ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DropdownList()
        {
            var proveedores = articuloController.GetProveedores();
            var categorias = articuloController.GetCategoria();

            CategoriaList.DataSource = categorias;
            CategoriaList.ValueMember = "Id";
            CategoriaList.DisplayMember = "Nombre";

            ProveedorList.DataSource = proveedores;
            ProveedorList.ValueMember = "Id";
            ProveedorList.DisplayMember = "Nombre";
        }

        public void guardar()
        {
            try
            {
                ArticuloVM articuloVM = new ArticuloVM();

                articuloVM.Id = ide;
                articuloVM.Nombre = NombreArticulo.Text;
                articuloVM.Cod_Barras = CodBarras.Text;
                articuloVM.Stock = int.Parse(Stock.Text);
                articuloVM.Precio_Compra = decimal.Parse(PrecioCompra.Text);
                articuloVM.Precio_Venta = decimal.Parse(PrecioVenta.Text);
                articuloVM.Descripcion = Descripcion.Text;

                if (imgbox.Image != null)
                {
                    var imagen = imgbox.Image;
                    MemoryStream memoria = new MemoryStream();
                    imagen.Save(memoria, ImageFormat.Jpeg);
                    byte[] bytes = memoria.ToArray();
                    memoria.Close();
                    articuloVM.Imagen = bytes;
                }

                if (file != null)
                {
                    articuloVM.Imagen = file;
                }
                articuloVM.IdCategorias = (int)CategoriaList.SelectedValue;
                articuloVM.IdProveedor = (int)ProveedorList.SelectedValue;

                var bole = articuloController.Actualizar(articuloVM);

                if (bole)
                {
                    MessageBox.Show("Actualizacion Exitosa", "Exito");
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar los datos", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error al registrar los datos", "Error");
            }
        }
    }
}
