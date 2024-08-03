using PuntoDeVenta.Controllers;
using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Views
{
    public partial class Reportes : Form
    {
        private readonly ReportesController reportesController = null;
        public Reportes()
        {
            InitializeComponent();
            reportesController= new ReportesController();
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {

        }


        private void Reportes_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
            ConsultarDia();
        }

        public void ConsultarDia()
        {
            DateTime fech = FechaSelect.Value;
            DateTime fecha = new DateTime(fech.Year, fech.Month, fech.Day);
            var VentasDia = reportesController.ListaVentas(fecha);
            LlenarTabla(VentasDia);
        }

        public void LlenarTabla(List<VentaVM> ventas)
        {
            var ventasDia = ventas;
            decimal total = 0;
            foreach(var v in ventasDia)
            {
                
                var fecha = v.FechaHora;
                var id = v.idVenta;
                
                var ventaCancel = v.VentaCancel;
                if(ventaCancel == "no")
                {
                    total += v.total;
                    foreach (var dv in v.Detalle_ventaVM)
                    {
                        TablaReportes.Rows.Add(id, dv.ArticuloVM.Nombre, dv.cantidad, dv.precio, fecha);
                    }
                }
                
            }

            LabelTotal.Text = total.ToString();
            
        }

        private void Inventario_principal_btn_Click(object sender, EventArgs e)
        {
            Caja caja = new Caja();
            caja.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Show();
            this.Hide();
        }

        private void inventario_proveedores_btn_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = new Proveedores();
            proveedores.ShowDialog();
            
        }

        private void Ventasbtn_Click(object sender, EventArgs e)
        {
            VentasRealizadas ventas = new VentasRealizadas();
            ventas.ShowDialog();
        }

        public void refresh()
        {
            TablaReportes.Rows.Clear();
        }
    }
}
