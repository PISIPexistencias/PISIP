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
    public partial class Registro_proveedor : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        Clases.Validacion valida = new Clases.Validacion();
        public Clases.Proveedor ProveedorSeleccionado { get; set; }
        public Registro_proveedor()
        {
            InitializeComponent();
        }

        private void Registro_proveedor_Load(object sender, EventArgs e)
        {
            txtProveedor.CharacterCasing = CharacterCasing.Upper;
            txtContacto.CharacterCasing = CharacterCasing.Upper;
            txtDireccion.CharacterCasing = CharacterCasing.Upper;
            try
            {
                if (lblAccion.Text == "I")
                {
                    txtCodigo.Clear();
                    txtRuc.Clear();
                    txtProveedor.Clear();
                    txtDireccion.Clear();
                    txtContacto.Clear();
                    txtFono.Clear();
                    //txtEstado.Clear();

                }
                else if ((lblAccion.Text == "M") || (lblAccion.Text == "E"))
                {
                    if (conecta.AbrirConexion() == true)
                    {
                        ProveedorSeleccionado = Clases.Proveedor.ObtenerProveedor(conecta.conexion, Convert.ToInt32(txtCodigo.Text));
                        txtRuc.Text = ProveedorSeleccionado.Ruc_Proveedor;
                        txtProveedor.Text = ProveedorSeleccionado.Nombre_Proveedor;
                        txtDireccion.Text = ProveedorSeleccionado.Direccion_Proveedor;
                        txtFono.Text = ProveedorSeleccionado.Fono_Proveedor;
                        txtContacto.Text = ProveedorSeleccionado.Contacto_Proveedor;
                        //txtEstado.Text = Convert.ToString( ProveedorSeleccionado.Estado_Proveedor);
                        if (ProveedorSeleccionado.Estado_Proveedor == 0)
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
                    Clases.Proveedor pProveedor = new Clases.Proveedor();
                    if (lblAccion.Text == "I")
                    {
                        pProveedor.Cod_Proveedor = 0;
                    }
                    else
                    {
                        pProveedor.Cod_Proveedor = Convert.ToInt32(txtCodigo.Text);
                    }
                    
                    pProveedor.Ruc_Proveedor = txtRuc.Text;
                    pProveedor.Nombre_Proveedor = txtProveedor.Text;
                    pProveedor.Direccion_Proveedor = txtProveedor.Text;
                    pProveedor.Fono_Proveedor = txtFono.Text;
                    pProveedor.Contacto_Proveedor = txtContacto.Text;
                    //pProveedor.Estado_Proveedor = Convert.ToInt16(txtEstado.Text);
                    if (cmbEstado.Text == "Activo")
                    {
                        pProveedor.Estado_Proveedor = 0;
                    }
                    else
                    {
                        pProveedor.Estado_Proveedor = 1;
                    }

                    switch (lblAccion.Text)
                    {

                        case "I": resultado = Clases.Proveedor.AgregarProveedor(conecta.conexion, pProveedor); break;

                        case "M": resultado = Clases.Proveedor.ModificarProveedor(conecta.conexion, pProveedor); break;

                        case "E": resultado = Clases.Proveedor.EliminarProveedor(conecta.conexion, pProveedor.Cod_Proveedor); break;

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFono_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }
    }
}
