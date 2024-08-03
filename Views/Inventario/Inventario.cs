using PuntoDeVenta.Controllers;
using PuntoDeVenta.Models;
using PuntoDeVenta.ViewModel;
using System;
using System.Collections;
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
    public partial class Inventario : Form
    {
        private readonly ArticuloController articulocontroller = null;
        List<ArticuloVM> art = null;
        public Inventario()
        {
            InitializeComponent();
            articulocontroller = new ArticuloController();
            art = new List<ArticuloVM>();
        }


        ///Eventos
        private void Inventario_Load(object sender, EventArgs e)
        {
            DropdownListConsultas();
            LlenarTabla();
            this.KeyPreview = true;
        }

        private void Inventario_principal_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Caja caja = new Caja();
            caja.Show();
        }

        private void inventario_proveedores_btn_Click(object sender, EventArgs e)
        {
            
            Proveedores provedorView = new Proveedores();
            provedorView.Show();
        }

        private void Agregar_Articulo_Click(object sender, EventArgs e)
        {
            Añadir_Articulo AñadirArticulo = new Añadir_Articulo();
            AñadirArticulo.Show();
        }

        private void TablaArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TablaArticulos.Columns["Editar"].Index) 
            {
                int id = Convert.ToInt32(TablaArticulos.Rows[e.RowIndex].Cells["Id"].Value);
                if(id != 0)
                {
                    Edit(id);
                }
                
            }
            if (e.ColumnIndex == TablaArticulos.Columns["Eliminar"].Index)
            {
                int id = Convert.ToInt32(TablaArticulos.Rows[e.RowIndex].Cells["Id"].Value);
                if (id != 0)
                {
                    Delete(id);
                }
                    
            }
            if (e.ColumnIndex == TablaArticulos.Columns["Detalle"].Index)
            {
                int id = Convert.ToInt32(TablaArticulos.Rows[e.RowIndex].Cells["Id"].Value);
                if (id != 0)
                {
                    details(id);
                }
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta();
            CargarDatos();
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            RefreshTable(true);
        }

        private void Ventasbtn_Click(object sender, EventArgs e)
        {
            VentasRealizadas ventas = new VentasRealizadas();
            ventas.ShowDialog();
        }


        ///Metodos de ejecucion
        public void RefreshTable(bool verificacion)
        {
            if (verificacion)
            {
                TablaArticulos.Rows.Clear();
                LlenarTabla();
            }
            
        }

        public void Delete(int id)
        {
            var result = MessageBox.Show("Estas seguro de eliminar este articulo?", "Escoge", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var val = articulocontroller.Delete(id);
                if (val)
                {
                    MessageBox.Show("Articulo eliminado");
                }
                else
                {
                    MessageBox.Show("Surgio un error al eliminar el articulo");
                }
            }
        }

        public void Edit(int id)
        {
            Editar_Articulo editar = new Editar_Articulo();
            editar.Show();
            editar.llenar(id);
        }

        public void details(int id)
        {
            Detalle_Articulo detalle = new Detalle_Articulo();
            detalle.Show();
            detalle.LlenarVista(id);
        }

        public void LlenarTabla()
        {
            var lista = articulocontroller.GetArticulos();
            foreach (var l in lista)
            {
                TablaArticulos.Rows.Add(l.Id, l.Nombre, l.Cod_Barras, l.Stock, l.Fecha_Registro, l.Precio_Compra, l.Precio_Venta, l.Descripcion, "🖍", "❌", "📝");
            }

        }

        public void Consulta()
        {
            Consulta consulta= new Consulta();
            consulta.Nombre = ValorConsulta.Text;
            consulta.id =  (int)ConsultaBox.SelectedValue;
            art = articulocontroller.DatosConsulta(consulta);
        }

        public void DropdownListConsultas()
        {
            List<Consulta> consultas = new List<Consulta>();
            consultas.Add(new Consulta { Nombre = "Nombre", id = 1 });
            consultas.Add(new Consulta { Nombre = "Codigo de barras", id = 2 });
            consultas.Add(new Consulta { Nombre = "Stock", id = 3 });
            consultas.Add(new Consulta { Nombre = "Precio de Compra", id = 4 });
            consultas.Add(new Consulta { Nombre = "Precio de Venta", id = 5 });

            ConsultaBox.DataSource = consultas;
            ConsultaBox.ValueMember = "id";
            ConsultaBox.DisplayMember= "Nombre";
        }

        public void CargarDatos()
        {
            TablaArticulos.Rows.Clear();
            datos();
        }

        public void datos()
        {
            var lista = art;

            foreach (var l in lista)
            {
                TablaArticulos.Rows.Add(l.Id, l.Nombre, l.Cod_Barras, l.Stock, l.Fecha_Registro, l.Precio_Compra, l.Precio_Venta, l.Descripcion, "🖍", "❌", "📝");
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Hide();
        }

        private void Inventario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Consulta();
                CargarDatos();
                ValorConsulta.Text = "";
            }
        }
    }
}
