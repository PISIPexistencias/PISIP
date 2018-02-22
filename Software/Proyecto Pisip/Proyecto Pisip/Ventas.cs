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
    public partial class Ventas : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        Clases.Validacion valida = new Clases.Validacion();
        
        int filaSeleccionada, numFilas;
        double gSubTotal=0,gIva=0,gTotal=0;
        public Ventas()
        {
            InitializeComponent();
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
            Consulta_Producto consultaproducto = new Consulta_Producto();
            consultaproducto.ShowDialog();
            if (Convert.ToInt32(consultaproducto.dgvProducto.CurrentRow.Cells[0].Value) >= 0)
            {
                txtCodProducto.Text = Convert.ToString(consultaproducto.dgvProducto.CurrentRow.Cells[0].Value);
                txtNombreProducto.Text = Convert.ToString(consultaproducto.dgvProducto.CurrentRow.Cells[5].Value);
                txtPrecioVenta.Text = Convert.ToString(consultaproducto.dgvProducto.CurrentRow.Cells[9].Value);
                txtStock.Text= Convert.ToString(consultaproducto.dgvProducto.CurrentRow.Cells[6].Value);
                if (Convert.ToInt32(consultaproducto.dgvProducto.CurrentRow.Cells[11].Value) == 0)
                {
                    lblCobraIva.Text = "SI";
                }else
                {
                    lblCobraIva.Text = "NO";
                }
                
            }
            consultaproducto.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnBuscaFactura_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta_Factura consultaFactura = new Consulta_Factura();
                consultaFactura.ShowDialog();
                if (consultaFactura.dgvFactura.Rows.Count > 0)
                {
                    if (Convert.ToInt32(consultaFactura.dgvFactura.CurrentRow.Cells[0].Value) >= 0)
                    {
                        Clases.Conexion conectaPro = new Clases.Conexion();
                        txtCodFactura.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[0].Value);
                        txtCodigoCli.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[1].Value);
                        txtCedulaCli.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[2].Value);
                        txtNombreCli.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[3].Value) + " " + Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[4].Value);
                        dtpFechaFactura.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[5].Value);
                        lblIva.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[6].Value);
                        lblSubTotal.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[7].Value);
                        lblTotal.Text = Convert.ToString(consultaFactura.dgvFactura.CurrentRow.Cells[8].Value);
                        lblEstado.Visible = true;
                        if (Convert.ToInt32(consultaFactura.dgvFactura.CurrentRow.Cells[9].Value)==0)
                        {
                            lblEstado.Text = "Activa";
                            btnModificar.Enabled = true;
                        }
                        else
                        {
                            lblEstado.Text = "Anulada";
                            btnModificar.Enabled = false;
                        }
                        
                        dgvDetalleFactura.Visible = false;
                        dgvDetallefatMostrar.Visible = true;
                        if (conectaPro.AbrirConexion() == true)
                        {
                            Clases.Producto.llenaProducto(conectaPro.conexion, dgvDetallefatMostrar, Convert.ToInt32(txtCodFactura.Text));
                            dgvDetallefatMostrar.Columns[5].Visible = false;
                            dgvDetallefatMostrar.Columns[6].Visible = false;

                        }
                        conecta.CerrarConexion();
                        lblAccion.Text = "M";
                        //btnModificar.Enabled = true;
                        btnImprimir.Enabled = true;
                        btnAgregarDetalle.Enabled = false;
                        btnIngresar.Enabled = false;

                    }

                }
                else
                {
                    MessageBox.Show("No se ha Seleccionado ninguna fila");
                }
                consultaFactura.Dispose();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conecta.CerrarConexion();
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            double subTotaldetalle=0;double porcentajeIVA;
            
                if (txtCodProducto.Text != "" && txtCantidad.Text != "")
                {
                    if (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text))
                    {
                        subTotaldetalle = (Convert.ToDouble(txtPrecioVenta.Text) * Convert.ToDouble(txtCantidad.Text));
                        porcentajeIVA = Convert.ToDouble(txtPorcentajeIVA.Text) / 100;
                        dgvDetalleFactura.Rows.Add((dgvDetalleFactura.Rows.Count), txtNombreProducto.Text, txtCantidad.Text, txtPrecioVenta.Text, subTotaldetalle, lblCobraIva.Text, txtCodProducto.Text);

                        gSubTotal = gSubTotal + subTotaldetalle;
                        if (lblCobraIva.Text == "SI")
                        {
                            gIva = gIva + (subTotaldetalle * porcentajeIVA);
                        }
                        gTotal = (gSubTotal + gIva);
                        lblSubTotal.Text = gSubTotal.ToString("#.00");
                        lblIva.Text = gIva.ToString("0.00");
                        lblTotal.Text = gTotal.ToString("#.00");
                        VaciarProducto();
                }
                    else
                    {
                        MessageBox.Show("La Cantidad a Facturar es mayor a la de stock", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    
                }
                else
                {
                    MessageBox.Show("No existen el total de informacion para Añadir al Detalle", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActivaBotonEliminar();
           
            
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            double subtotaldetalle=0; double porcentajeIVA;
            numFilas = dgvDetalleFactura.Rows.Count;
            try
            {
                filaSeleccionada = dgvDetalleFactura.CurrentRow.Index;
                if (filaSeleccionada>=0 && filaSeleccionada != (numFilas - 1))
                {
                    DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar el registro seleccionado?", "Pregutar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        subtotaldetalle = Convert.ToDouble(dgvDetalleFactura.CurrentRow.Cells[4].Value);
                        porcentajeIVA = Convert.ToDouble(txtPorcentajeIVA.Text) / 100;
                        gSubTotal = gSubTotal - subtotaldetalle;
                        if (Convert.ToString(dgvDetalleFactura.CurrentRow.Cells[5].Value) == "SI")
                        {
                            gIva = gIva - (subtotaldetalle * porcentajeIVA);
                        }
                        
                        gTotal = gSubTotal + gIva;

                        lblSubTotal.Text = gSubTotal.ToString("#.00");
                        lblIva.Text = gIva.ToString("0.00");
                        lblTotal.Text = gTotal.ToString("#.00");

                        dgvDetalleFactura.Rows.RemoveAt(filaSeleccionada);
                        RindexSecuencia();
                        VaciarProducto();
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta fila", "Infromacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                ActivaBotonEliminar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetalleFactura_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = Convert.ToString(dgvDetalleFactura.CurrentRow.Cells[1].Value);
            txtPrecioVenta.Text = Convert.ToString(dgvDetalleFactura.CurrentRow.Cells[3].Value);
            txtCantidad.Text = Convert.ToString(dgvDetalleFactura.CurrentRow.Cells[2].Value);
            lblCobraIva.Text = Convert.ToString(dgvDetalleFactura.CurrentRow.Cells[5].Value);
            txtCodProducto.Text = Convert.ToString(dgvDetalleFactura.CurrentRow.Cells[6].Value);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                numFilas = dgvDetalleFactura.Rows.Count;
                if(txtCodigoCli.Text != "" && numFilas > 1)
                {
                    if (conecta.AbrirConexion() == true)
                    {
                        int resultado = 0;
                        Clases.Factura pFactura = new Clases.Factura();
                        if (lblAccion.Text == "I")
                        {
                            pFactura.Codigo_Factura = 0;
                        }
                        else
                        {
                            pFactura.Codigo_Factura = Convert.ToInt32(txtCodFactura.Text);
                        }
                        pFactura.Cod_Cliente_Factura = Convert.ToInt32(txtCodigoCli.Text);
                        pFactura.Fecha_factura = Convert.ToDateTime(dtpFechaFactura.Text);
                        pFactura.Iva_Factura = Convert.ToDouble(lblIva.Text);
                        pFactura.Sub_Total_Factura = Convert.ToDouble(lblSubTotal.Text);
                        pFactura.Total_Factura = Convert.ToDouble(lblTotal.Text);


                        switch (lblAccion.Text)
                        {

                            case "I": resultado = Clases.Factura.AgregarFactura(conecta.conexion, pFactura); break;

                        }


                        if (resultado > 0)
                        {
                            if (lblAccion.Text == "I")
                            {
                                if (IngresaDetalle(pFactura.Cod_Cliente_Factura) == true)
                                {

                                    MessageBox.Show("Registro Ingresado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    //VaciarEncabezado();
                                    //VaciarProducto();
                                    //dgvDetalleFactura.Rows.Clear();
                                    btnIngresar.Enabled = false;
                                    btnImprimir.Enabled = true;

                                }
                            }
                          
                           


                        }
                        conecta.CerrarConexion();
                    }

                }
                else
                {
                    MessageBox.Show("No existe datos del cliente o detalle de factura para realizar el ingreso","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conecta.CerrarConexion();
                
            }
        }

        void ActivaBotonEliminar()
        {
            numFilas = dgvDetalleFactura.Rows.Count;
            if (numFilas > 1)
            {
                btnEliminarDetalle.Enabled = true;
                txtPorcentajeIVA.Enabled = false;
            }
            else
            {
                btnEliminarDetalle.Enabled = false;
                txtPorcentajeIVA.Enabled = true;
                VaciarProducto();
                gSubTotal = 0;
                gIva = 0;
                gTotal = 0;
            }
        }

        void RindexSecuencia()
        {
            int i;
            numFilas = dgvDetalleFactura.Rows.Count;
            for (i = 1; i < numFilas; i++)
            {
                dgvDetalleFactura.CurrentRow.Cells[0].Value = i;
                    
            }
        }
        void VaciarProducto()
        {
            txtCodProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioVenta.Clear();
            txtCantidad.Clear();
            txtStock.Clear();
            lblCobraIva.Text = ".";
            lblEstado.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (conecta.AbrirConexion() == true)
                {
                    int resultado = 0;
                    resultado = Clases.Factura.AnularFactura(conecta.conexion, Convert.ToInt32(txtCodFactura.Text));
                    if (resultado > 0)
                    {
                        MessageBox.Show("El Registro ha sido Anulado Exitosamente");
                        btnModificar.Enabled = false;
                    }
                    conecta.CerrarConexion();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conecta.CerrarConexion();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VaciarEncabezado();
            VaciarProducto();
            dgvDetallefatMostrar.Visible = false;
            dgvDetalleFactura.Visible = true;
            dgvDetalleFactura.Rows.Clear();
            btnIngresar.Enabled = true;
            btnImprimir.Enabled = false;
            btnModificar.Enabled = false;
            lblAccion.Text = "I";
            btnAgregarDetalle.Enabled = true;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int numeroFatura;
            numeroFatura = Convert.ToInt32(txtCodFactura.Text);
            imprimirDetalleFactura detalleFactura = new imprimirDetalleFactura();
            detalleFactura.numeroFactura = numeroFatura;
            detalleFactura.ShowDialog();
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }

        private void txtPorcentajeIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }

        void VaciarEncabezado()
        {
            txtCodFactura.Clear();
            txtCodigoCli.Clear();
            txtNombreCli.Clear();
            txtCedulaCli.Clear();
            lblIva.Text = "0.00";
            lblSubTotal.Text = "0.00";
            lblTotal.Text = "0.00";

        }
        bool IngresaDetalle( int codClienteFactura)
        {
            bool respuesta = true;
            Clases.Conexion conectadetalle = new Clases.Conexion();
            try
            {

                int resultado1 = 0;
                if (conectadetalle.AbrirConexion() == true)
                {
                    Clases.DetalleFactura pDetalle = new Clases.DetalleFactura();
                    int j;
                    txtCodFactura.Text = Convert.ToString(Clases.Factura.ObtenerCodigoFactura(conecta.conexion, codClienteFactura));
                    numFilas = dgvDetalleFactura.Rows.Count;
                    for (j = 0; j < (numFilas - 1); j++)
                    {

                        // detalle factura
                        pDetalle.Codigo_Factura = Convert.ToInt32(txtCodFactura.Text);
                        pDetalle.Codigo_Producto = Convert.ToInt32(dgvDetalleFactura[6, j].Value);
                        pDetalle.Secuencial_Detalle = Convert.ToInt32(dgvDetalleFactura[0, j].Value);
                        pDetalle.Descripcion_Detalle = Convert.ToString(dgvDetalleFactura[1, j].Value);
                        pDetalle.Cantidad_Detalle = Convert.ToInt32(dgvDetalleFactura[2, j].Value);
                        pDetalle.PrecioUnitario_Detalle = Convert.ToDouble(dgvDetalleFactura[3, j].Value);
                        pDetalle.Total_Detalle = Convert.ToDouble(dgvDetalleFactura[4, j].Value);


                        resultado1 = Clases.DetalleFactura.AgregarDetalle(conectadetalle.conexion, pDetalle);

                        if (resultado1 > 0)
                        {
                            if (ActualizaStock(pDetalle.Codigo_Producto, pDetalle.Cantidad_Detalle)==true)
                            {
                                //MessageBox.Show("Registro Ingresado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                respuesta = true;
                            }
                        }
                        else
                        {
                            respuesta = false;
                        }

                       
                    }

                   conectadetalle.CerrarConexion();
                }


                return respuesta;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conectadetalle.CerrarConexion();
                respuesta = false;
                return respuesta;
                
            }
        }
        bool ActualizaStock(int codClienteFactura, int stockActualiza)
        {
            bool respuesta = true;
            Clases.Conexion conecta2 = new Clases.Conexion();
            try
            {
                int resultado1 = 0;
                if (conecta2.AbrirConexion() == true)
                {
                    resultado1 = Clases.Producto.ModificarStockProducto(conecta2.conexion, codClienteFactura, stockActualiza);

                    if (resultado1 > 0)
                    {
                        //MessageBox.Show("Registro Ingresado exitosamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        respuesta = true;
                        conecta2.CerrarConexion();
                    }
                    
                }
                return respuesta;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conecta2.CerrarConexion();
                respuesta = false;
                return respuesta;

            }


        }

    }
}
