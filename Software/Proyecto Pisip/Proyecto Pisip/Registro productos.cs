using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Proyecto_Pisip
{
    public partial class Registro_productos : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        public Clases.Producto ProductoSeleccionado { get; set; }
        public Registro_productos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnBuscaProveedor_Click(object sender, EventArgs e)
        {
            ConsultaProveedor consultaProvee = new ConsultaProveedor();
            consultaProvee.ShowDialog();
            if (Convert.ToInt32(consultaProvee.dgvProveedor.CurrentRow.Cells[0].Value) >= 0)
            {
                txtCodProvProducto.Text = Convert.ToString(consultaProvee.dgvProveedor.CurrentRow.Cells[0].Value);
                txtNomProvProducto.Text = Convert.ToString(consultaProvee.dgvProveedor.CurrentRow.Cells[2].Value);
                
            }
            consultaProvee.Dispose();
        }

        private void btnBuscaBodega_Click(object sender, EventArgs e)
        {
            Clases.Consulta_Bodega consultaBodega = new Clases.Consulta_Bodega();
            consultaBodega.ShowDialog();
            if (Convert.ToInt32(consultaBodega.dgvBodega.CurrentRow.Cells[0].Value) >= 0)
            {
                txtcodBodProducto.Text = Convert.ToString(consultaBodega.dgvBodega.CurrentRow.Cells[0].Value);
                txtSucursalProducto.Text = Convert.ToString(consultaBodega.dgvBodega.CurrentRow.Cells[1].Value);

            }
            consultaBodega.Dispose();
        }

        private void Registro_productos_Load(object sender, EventArgs e)
        {
            try
            {
                if (lblAccion.Text == "I")
                {
                    txtCodProducto.Clear();
                    txtcodBodProducto.Clear();
                    txtSucursalProducto.Clear();
                    txtCodProvProducto.Clear();
                    txtNomProvProducto.Clear();
                    txtNombreProducto.Clear();
                    txtStockProducto.Text="0";
                    txtnuevoStock.Text="0";
                    txtStockMinProducto.Clear();
                    txtPrecioCompraProducto.Clear();
                    txtPrecioVentaProducto.Clear();
                    

                }
                else if ((lblAccion.Text == "M") || (lblAccion.Text == "E"))
                {
                    if (conecta.AbrirConexion() == true)
                    {
                        ProductoSeleccionado = Clases.Producto.ObtenerProducto(conecta.conexion, Convert.ToInt32(txtCodProducto.Text));
                        txtCodProducto.Text = Convert.ToString( ProductoSeleccionado.Cod_Producto);
                        txtNombreProducto.Text = ProductoSeleccionado.Nombre_Producto;
                        txtcodBodProducto.Text = Convert.ToString( ProductoSeleccionado.Cod_Bod_Producto);
                        txtSucursalProducto.Text = ProductoSeleccionado.Sucursal_Bod_Producto;
                        txtCodProvProducto.Text = Convert.ToString( ProductoSeleccionado.Cod_Prov_Producto);
                        txtNomProvProducto.Text = ProductoSeleccionado.Nombre_Prov_Producto;
                        txtStockProducto.Text = Convert.ToString(ProductoSeleccionado.Stock_Producto);
                        txtnuevoStock.Text = "0";
                        txtStockMinProducto.Text = Convert.ToString(ProductoSeleccionado.Stock_Min_Producto);
                        txtPrecioCompraProducto.Text = Convert.ToString(ProductoSeleccionado.Precio_Compra_Producto);
                        txtPrecioVentaProducto.Text = Convert.ToString(ProductoSeleccionado.Precio_Venta_Producto);

                        if (ProductoSeleccionado.Estado_Producto == 0)
                        {
                            cmbEstado.Text = "Activo";
                        }
                        else
                        {
                            cmbEstado.Text = "Inactivo";
                        }

                        conecta.CerrarConexion();
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (conecta.AbrirConexion() == true)
                {
                    int resultado = 0;
                    Clases.Producto pProducto = new Clases.Producto();
                    if (lblAccion.Text == "I")
                    {
                        pProducto.Cod_Producto = 0;
                    }
                    else
                    {
                        pProducto.Cod_Producto = Convert.ToInt32(txtCodProducto.Text);
                    }
                    pProducto.Nombre_Producto =txtNombreProducto.Text;
                    pProducto.Cod_Bod_Producto = Convert.ToInt32(txtcodBodProducto.Text);
                    pProducto.Sucursal_Bod_Producto = txtSucursalProducto.Text;
                    pProducto.Cod_Prov_Producto = Convert.ToInt32( txtCodProvProducto.Text);
                    pProducto.Nombre_Prov_Producto = txtNomProvProducto.Text;
                    pProducto.Stock_Producto = Convert.ToInt32(txtStockProducto.Text)+ Convert.ToInt32(txtnuevoStock.Text);
                    pProducto.Stock_Min_Producto = Convert.ToInt32(txtStockMinProducto.Text);
                    pProducto.Precio_Compra_Producto = Convert.ToDouble(txtPrecioCompraProducto.Text);
                    pProducto.Precio_Venta_Producto = Convert.ToDouble(txtPrecioVentaProducto.Text);
                    pProducto.Fecha_Caduca_Producto = Convert.ToDateTime(dtpFechaCaducaProducto.Text);

                    if (cmbEstado.Text == "Activo")
                    {
                        pProducto.Estado_Producto = 0;
                    }
                    else
                    {
                        pProducto.Estado_Producto = 1;
                    }

                    switch (lblAccion.Text)
                    {

                        case "I": resultado = Clases.Producto.AgregarProducto(conecta.conexion, pProducto); break;

                        case "M": resultado = Clases.Producto.ModificarProducto(conecta.conexion, pProducto); break;

                        case "E": resultado = Clases.Producto.EliminarProducto(conecta.conexion, pProducto.Cod_Producto); break;

                    }


                    if (resultado > 0)
                    {
                        if (lblAccion.Text == "I")
                        {
                            MessageBox.Show("Registro Ingresado exitosamente");
                        }
                        else if (lblAccion.Text == "M")
                        {
                            MessageBox.Show("Registro Actualizado exitosamente");
                        }
                        else if (lblAccion.Text == "E")
                        {
                            MessageBox.Show("Registro Eliminado exitosamente");
                        }


                        this.Close();


                    }
                    conecta.CerrarConexion();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
