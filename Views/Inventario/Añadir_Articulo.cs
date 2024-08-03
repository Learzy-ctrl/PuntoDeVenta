using PuntoDeVenta.Controllers;
using PuntoDeVenta.Models;
using PuntoDeVenta.Services;
using PuntoDeVenta.ViewModel;
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

    public partial class Añadir_Articulo : Form
    {
        private readonly ArticuloController articuloController = null;
        private readonly Inventario VistaInventario = null;
        byte[] file = null;
        public Añadir_Articulo()
        {
            InitializeComponent();
            articuloController = new ArticuloController();
            VistaInventario = new Inventario();
        }

        private void Add_categoria_Click(object sender, EventArgs e)
        {
            
            AddCategoria categoria = new AddCategoria();
            categoria.Show();
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            GuardarArticulo();
            MessageBox.Show("Registro exitoso");
            refresh();
            
        }

        private void Añadir_Articulo_Load(object sender, EventArgs e)
        {
            DropdownList();
        }

        


        public void GuardarArticulo()
        {
            ArticuloVM articuloVM = new ArticuloVM();

            articuloVM.Nombre = NombreArticulo.Text;
            articuloVM.Cod_Barras = CodBarras.Text;
            articuloVM.Stock = int.Parse(Stock.Text);
            articuloVM.Precio_Compra = decimal.Parse(PrecioCompra.Text);
            articuloVM.Precio_Venta = decimal.Parse(PrecioVenta.Text);
            articuloVM.Descripcion = Descripcion.Text;
            articuloVM.Imagen = file;

            articuloVM.IdCategorias = (int)CategoriaList.SelectedValue; 
            articuloVM.IdProveedor = (int)ProveedorList.SelectedValue;

            articuloController.Añadir_Articulo(articuloVM);

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

        private void SubirImagen_Click(object sender, EventArgs e)
        {
                img();
              
                var imagen = file;
                if (imagen != null)
                {
                MemoryStream ms2 = new MemoryStream(imagen);
                Bitmap bmp = new Bitmap(ms2);
                Imagenbox.Image = bmp;
                }
                
           
        }

        public void img()
        {
            try
            {
                openFileDialog1.InitialDirectory = "d:\\";
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
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProveedor pro = new AgregarProveedor();
            pro.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DropdownList();
        }

        public void refresh()
        {
            NombreArticulo.Text = "";
            CodBarras.Text = "";
            Stock.Text = "";
            PrecioCompra.Text = "";
            PrecioVenta.Text = "";
            Descripcion.Text = "";
            Imagenbox.Image = null;
        }
    }
}
