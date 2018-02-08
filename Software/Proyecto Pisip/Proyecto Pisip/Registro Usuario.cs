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
    
    public partial class Registro_Usuario : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        Clases.Usuario Usuarioseleccionado { get; set; }
        public Registro_Usuario()
        {
            InitializeComponent();
        }

        private void Registro_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                Clases.Usuario pUsuario = new Clases.Usuario();
                pUsuario.CargaRol(conecta.conexion, cmbRol);
                if (lblAccion.Text == "I")
                {
                    
                    txtcodigo.Clear();
                    txtCodEmpleado.Clear();
                    txtApellidoUsu.Clear();
                    txtNombreUsu.Clear();
                    //txtUsuarioUsu.Clear();
                    txtClaveUsu.Clear();
                    //pUsuario.CargaRol(conecta.conexion, cmbRol);
                    
                }
                else if ((lblAccion.Text == "M") || (lblAccion.Text == "E"))
                {
                    if (conecta.AbrirConexion() == true)
                    {
                        Usuarioseleccionado = Clases.Usuario.ObtenerUsuario(conecta.conexion, txtcodigo.Text);
                        txtcodigo.Text = Usuarioseleccionado.Cod_Usuario;
                        txtCodEmpleado.Text = Convert.ToString(Usuarioseleccionado.Cod_Empl_Usuario);
                        txtApellidoUsu.Text = Usuarioseleccionado.Apellido_Empl_Usuario;
                        txtNombreUsu.Text = Usuarioseleccionado.Nombre_Empl_Usuario;
                        txtClaveUsu.Text = Usuarioseleccionado.Clave_Usuario;
                        cmbRol.Text = Usuarioseleccionado.Perfil_Rol_Usuario;
                        if (Usuarioseleccionado.Estado_Usuario == 0)
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

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodRol.Text = Convert.ToString(cmbRol.SelectedValue);
        }

        private void cmbRol_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
