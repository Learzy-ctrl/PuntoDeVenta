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
    
    public partial class Recibo_Cambio : Form
    {
        decimal totales = 0;
        VentaVM venta = null;
        private readonly VentaController ventaController = null;
        public Recibo_Cambio()
        {
            InitializeComponent();
            timer1.Start();
            venta = new VentaVM();
            ventaController = new VentaController();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            venta.VentaCancel = "no";
            var validacion = ventaController.guardarventa(venta);
            if (validacion)
            {
                MessageBox.Show("Venta Exitosa", "Punto de venta");
            }
            else
            {
                MessageBox.Show("Venta Cancelada", "Punto de venta");
            }
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            venta.VentaCancel = "si";
            var validacion = ventaController.guardarventa(venta);
            if (validacion)
            {
                MessageBox.Show("Venta Cancelada", "Punto de venta");
            }
            else
            {
                MessageBox.Show("Venta Cancelada", "Punto de venta");
            }

            this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                decimal recibod = decimal.Parse(recibo.Text.ToString());
                decimal cambiod = recibod - totales;
                cambio.Text = cambiod.ToString();
            }
            catch (Exception)
            {

            }
            

        }

        public void total(decimal amount)
        {
            totales = amount;
            totallbl.Text = totales.ToString();
        }

        public void recibir(VentaVM ventavm)
        {
            venta = ventavm;
        }
    }
}
