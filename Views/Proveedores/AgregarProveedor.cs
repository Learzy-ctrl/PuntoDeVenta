using PuntoDeVenta.Controllers;
using PuntoDeVenta.ViewModel;
using System;
using System.Windows.Forms;

namespace PuntoDeVenta.Views
{
    public partial class AgregarProveedor : Form
    {
        private readonly ProveedoresController proveedoresController = null;

        public AgregarProveedor()
        {
            InitializeComponent();
            proveedoresController = new ProveedoresController();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            GuardarVM();
            MessageBox.Show("Registro exitoso", "Proveedores");
            this.Close();
        }

        public void GuardarVM()
        {
            ProveedorVM proveedorVM = new ProveedorVM();
            EmailVM emailVM = new EmailVM();
            TelefonosVM telefonosVM = new TelefonosVM();
            DireccionesVM direccionesVM = new DireccionesVM();

            ///Tabla email
            emailVM.email1 = Correo.Text;


            ///Tabla telefonos
            telefonosVM.Num_tel = Tel.Text;

            ///Tabla direcciones
            direccionesVM.Estado = Estado.Text;
            direccionesVM.Municipio = Municipio.Text;
            direccionesVM.Colonia = Colonia.Text;
            direccionesVM.Calle = Calle.Text;

            ///Tabla proveedor
            proveedorVM.Nombre = NombreProveedor.Text;
            proveedorVM.Descripcion = Descripcion.Text;


            proveedorVM.EmailVM.Add(emailVM);
            proveedorVM.TelefonosVM.Add(telefonosVM);
            proveedorVM.DireccionesVM.Add(direccionesVM);

            var exito = proveedoresController.AddProveedor(proveedorVM);

            if (exito)
            {
                RegistroExito exito1 = new RegistroExito();
                exito1.Show();
            }
        }
    }
}
