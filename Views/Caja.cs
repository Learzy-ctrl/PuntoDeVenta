using PuntoDeVenta.Controllers;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta.Views
{
    public partial class Caja : Form
    {
        private readonly ArticuloController articuloController = null;
        private  Recibo_Cambio recibo_Cambio = null;
        private readonly VentaController ventaController = null;
        public Caja()
        {
            InitializeComponent();
            articuloController= new ArticuloController();
            recibo_Cambio= new Recibo_Cambio();
            ventaController= new VentaController();
            timer1.Start();
        }

        private void GenerarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                recibo_Cambio.Show();
                recibo_Cambio.total(decimal.Parse(Totallabel.Text.ToString()));
                VentaGenerar("no");
                refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Reinicia la Caja principal");
            }
            
        }

        private void Principal_inventario_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventarioView = new Inventario();
            inventarioView.Show();
        }

        private void Principal_proveedores_btn_Click(object sender, EventArgs e)
        {
            Proveedores proveedoresView = new Proveedores();
            proveedoresView.ShowDialog();
        }

        private void Ventasbtn_Click(object sender, EventArgs e)
        {
            VentasRealizadas venta = new VentasRealizadas();
            venta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentaGenerar("si");

            refresh();
        }


        public void SendCodBarras()
        {
            bool validacion = true;

            string codigo = Codbarras.Text;
            var articulo = articuloController.GetArticulo(codigo);
            int ide = articulo.Id;
            
            
                if (ide != 0)
                {
                    string id = articulo.Id.ToString();
                    string nombre = articulo.Nombre;
                    string descripcion = articulo.Descripcion;
                    string precio = articulo.Precio_Venta.ToString();
                    int cantidad = 1;
                    string importe = (cantidad * decimal.Parse(precio)).ToString();
                    descripcionLabel.Text = descripcion;

                    if (articulo.Imagen != null)
                    {
                        MemoryStream ms2 = new MemoryStream(articulo.Imagen);
                        Bitmap bmp = new Bitmap(ms2);
                        FotoArticulo.Image = bmp;
                    }


                    if (TablaVenta.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow t in TablaVenta.Rows)
                        {
                            if (t.Cells[0].Value.ToString() == id)
                            {
                                int can = (int)t.Cells[3].Value;
                                can += 1;
                                importe = (can * decimal.Parse(precio)).ToString();
                                t.Cells[3].Value = can;
                                t.Cells[4].Value = importe;
                                validacion = false;
                            }
                        }
                    }
                    if (validacion)
                    {
                        TablaVenta.Rows.Add(new object[] { id, nombre, precio, cantidad, importe, "Eliminar" });
                    }

                    Codbarras.Text = "";

                    CalcularTotal();
                }
            
            
            
           
        }

        public void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow t in TablaVenta.Rows)
            {
                decimal importe = decimal.Parse(t.Cells[4].Value.ToString());
                total += importe;
            }

            Totallabel.Text = total.ToString();
        }

        public void VentaGenerar(string yesorno)
        {
            try
            {
                VentaVM venta = new VentaVM();

                venta.fecha = DateTime.Now;
                venta.FechaHora = DateTime.Now;
                venta.total = decimal.Parse(Totallabel.Text.ToString());
                venta.VentaCancel = yesorno;

                foreach (DataGridViewRow t in TablaVenta.Rows)
                {
                    int idarticulo = int.Parse(t.Cells[0].Value.ToString());

                    Detalle_ventaVM detalle_Venta = new Detalle_ventaVM();

                    detalle_Venta.idArticulo = idarticulo;
                    detalle_Venta.cantidad = int.Parse(t.Cells[3].Value.ToString());
                    detalle_Venta.precio = decimal.Parse(t.Cells[4].Value.ToString());


                    venta.Detalle_ventaVM.Add(detalle_Venta);

                }

                recibo_Cambio.recibir(venta);
            }
            catch (Exception)
            {

            }
        }

        public void refresh()
        {
            TablaVenta.Rows.Clear();
            Totallabel.Text = "0,00";
            FotoArticulo.Image = null;
            descripcionLabel.Text = "Descripcion del Producto";
            GenerarVenta.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendCodBarras();
            Activarbtn();
        }

        private void TablaVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != TablaVenta.Columns["Op"].Index)
            {
                return;
            }
            else
            {
                var fila = TablaVenta.Rows[e.RowIndex];
                int can = (int)fila.Cells[3].Value;
                string preciostring = fila.Cells[2].Value.ToString();

                decimal precio = decimal.Parse(preciostring);

                if(can >= 2)
                {
                    can -= 1;
                    fila.Cells[3].Value = can;
                    fila.Cells[4].Value = (precio * can).ToString();
                }
                else
                {
                    TablaVenta.Rows.RemoveAt(e.RowIndex);
                }
                CalcularTotal();
                Activarbtn();
            }
        }

        public void Activarbtn()
        {
            int filas = TablaVenta.Rows.Count;
            if(filas > 0) 
            {
                GenerarVenta.Enabled = true;
            }
            else
            {
                GenerarVenta.Enabled = false;
                refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            Time.Text = currentDateTime.ToString("MM/dd/yyyy hh:mm:ss tt");

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Hide();
            reportes.Show();
        }

        private void Caja_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F2)
            {
                Inventario inventario = new Inventario();
                inventario.Show();
                this.Hide();
            }
            if(e.KeyCode == Keys.F3)
            {
                Proveedores proveedores = new Proveedores();
                proveedores.Show();
            }
            if (e.KeyCode == Keys.F4)
            {
                VentasRealizadas ventas = new VentasRealizadas();
                ventas.Show();
            }
            if (e.KeyCode == Keys.F5)
            {
                Reportes reportes =  new Reportes();
                reportes.Show();
                this.Hide();
            }
            if (e.KeyCode == Keys.Alt)
            {
                Codbarras.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                SendCodBarras();
                Activarbtn();
            }


        }

        private void Caja_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Codbarras.Focus();
        }

        private void Codbarras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
