using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pisip
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaBodega_Click(object sender, EventArgs e)
        {
            Clases.Consulta_Bodega consultaBodega = new Clases.Consulta_Bodega();
            consultaBodega.ShowDialog();
            if (Convert.ToInt32(consultaBodega.dgvBodega.CurrentRow.Cells[0].Value) >= 0)
            {
                txtCodBodega.Text = Convert.ToString(consultaBodega.dgvBodega.CurrentRow.Cells[0].Value);
                txtSucursalBodega.Text = Convert.ToString(consultaBodega.dgvBodega.CurrentRow.Cells[1].Value);

            }
            consultaBodega.Dispose();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            Consulta_Cliente consutaCliente = new Consulta_Cliente();
            consutaCliente.ShowDialog();
            if (Convert.ToInt32(consutaCliente.dgvClientes.CurrentRow.Cells[0].Value) >= 0)
            {
                txtCodigoCli.Text = Convert.ToString(consutaCliente.dgvClientes.CurrentRow.Cells[0].Value);
                txtCedulaCli.Text = Convert.ToString(consutaCliente.dgvClientes.CurrentRow.Cells[1].Value);
                txtNombreCli.Text = Convert.ToString(consutaCliente.dgvClientes.CurrentRow.Cells[2].Value) + " " + Convert.ToString(consutaCliente.dgvClientes.CurrentRow.Cells[3].Value);
            }
            consutaCliente.Dispose();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Consulta_Producto consutaproducto = new Consulta_Producto();
            consutaproducto.ShowDialog();
            if (Convert.ToInt32(consutaproducto.dgvProducto.CurrentRow.Cells[0].Value) >= 0)
            {
                txtCodProducto.Text = Convert.ToString(consutaproducto.dgvProducto.CurrentRow.Cells[0].Value);
                txtNombreProducto.Text = Convert.ToString(consutaproducto.dgvProducto.CurrentRow.Cells[5].Value);
                txtPrecioVenta.Text = Convert.ToString(consutaproducto.dgvProducto.CurrentRow.Cells[9].Value);
            }
            consutaproducto.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
