using PuntoDeVenta.Controllers;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Views
{
    public partial class AddCategoria : Form
    {
        private readonly CategoriasController categoriasController = null;

        public AddCategoria()
        {
            InitializeComponent();
            categoriasController= new CategoriasController();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
            MessageBox.Show("Registro Exitoso", "Registro Categoria");
            this.Close();

        }

        public void GuardarCategoria()
        {
            CategoriasVM categoriaVM = new CategoriasVM();

            categoriaVM.Nombre = Categoria.Text;

            categoriasController.GuardarCategoria(categoriaVM);
        }

    }
}
