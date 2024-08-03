using PuntoDeVenta.Controllers;
using PuntoDeVenta.Models;
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
    public partial class VentasRealizadas : Form
    {
        private readonly VentaController ventaController = null;
        public VentasRealizadas()
        {
            InitializeComponent();
            ventaController= new VentaController();
        }

        private void VentasRealizadas_Load(object sender, EventArgs e)
        {
            dropdownList();
            llenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        public void llenarTabla()
        {
            var ventas = ventaController.GetVentas();
            foreach(var v in ventas) 
            {
                TablaVentas.Rows.Add(v.idVenta, v.FechaHora, v.total, v.VentaCancel, "📝", "❌");
            }
        }

        private void TablaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TablaVentas.Columns["Detalle"].Index)
            {
                int id = Convert.ToInt32(TablaVentas.Rows[e.RowIndex].Cells["Id"].Value);
                if (id != 0)
                {
                    TablaDetalle.Rows.Clear();
                    LlenarVista(id);
                }

            }
            if (e.ColumnIndex == TablaVentas.Columns["Eliminar"].Index)
            {
                int id = Convert.ToInt32(TablaVentas.Rows[e.RowIndex].Cells["Id"].Value);
                if (id != 0)
                {
                   
                }

            }
        }

     /*   public void details(int id)
        {
            
            Detalle_Ventas detalle_Ventas = new Detalle_Ventas();
            
            detalle_Ventas.Show();
            detalle_Ventas.LlenarVista(id);
            
        }*/

        public void LlenarVista(int id)
        {
            try
            {
                using (var context = new SistemaDeVentasEntities())
                {
                    var detalleVenta = context.Detalle_venta.Where(v => v.idVenta == id);
                    foreach (var d in detalleVenta)
                    {
                        var articulo = context.Articulo.Find(d.idArticulo);
                        TablaDetalle.Rows.Add(d.idDetalle_venta, articulo.Nombre, d.cantidad, d.precio);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshAll();
        }

        public void refreshAll()
        {
            TablaVentas.Rows.Clear();
            llenarTabla();
            TablaDetalle.Rows.Clear();
        }

        public void dropdownList()
        {
            List<Consulta> consultas = new List<Consulta>();
            consultas.Add(new Consulta { Nombre = "Total mayor de", id = 1 });
            consultas.Add(new Consulta { Nombre = "Total menor de", id = 2 });
            consultas.Add(new Consulta { Nombre = "Ventas canceladas", id = 3 });
            consultas.Add(new Consulta { Nombre = "Ventas no canceladas", id = 4 });

            ConsultaBox.DataSource = consultas;
            ConsultaBox.ValueMember = "id";
            ConsultaBox.DisplayMember = "Nombre";
        }

        public void Consulta()
        {
            Consulta consulta = new Consulta();
            consulta.Nombre = Consultatxt.Text;
            consulta.id = (int)ConsultaBox.SelectedValue;
            if(consulta.id >= 3)
            {
               var lista = ventaController.ConsultaVentas(consulta);
               CargarDatos(lista);
            }
            else if(consulta.Nombre != "")
            {
                var lista = ventaController.ConsultaVentas(consulta);
                CargarDatos(lista);
            }
            else
            {
                TablaVentas.Rows.Clear();
            }
            
        }

        public void CargarDatos(List<VentaVM> ventaVMs)
        {
            TablaVentas.Rows.Clear();
            foreach(var v in ventaVMs)
            {
                TablaVentas.Rows.Add(v.idVenta, v.FechaHora, v.total, v.VentaCancel, "📝", "❌");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarDia();
        }

        public void ConsultarDia()
        {
            DateTime fech = FechaSelect.Value;
            DateTime fecha = new DateTime(fech.Year, fech.Month, fech.Day);
            var VentasDia = ventaController.ConsultaFecha(fecha);
            CargarDatos(VentasDia);
        }
    }
}
