using PuntoDeVenta.Controllers;
using PuntoDeVenta.Models;
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
    public partial class Proveedores : Form
    {
        private readonly ProveedoresController controller = null;
        public Proveedores()
        {
            InitializeComponent();
            controller = new ProveedoresController();
            dataGridView1.DataSource = controller.GetProveedores();
        }

        private void proveedores_principal_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Caja principalView = new Caja();
            principalView.Show();
        }

        private void proveedores_inventario_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario inventarioView = new Inventario();
            inventarioView.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor agregarProveedor = new AgregarProveedor();
            agregarProveedor.Show();
        }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                if (id != 0)
                {
                    edit(id);
                }
            }
        }

        public void edit(int id)
        {
            EditarProveedor editarproveedor = new EditarProveedor();
            editarproveedor.Show();
        }

        private void panelji_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
