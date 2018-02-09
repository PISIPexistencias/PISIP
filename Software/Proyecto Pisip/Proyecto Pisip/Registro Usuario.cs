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
                    txtClaveUsu.Clear();
                    
                    
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

        private void btnBuscaEmpl_Click(object sender, EventArgs e)
        {
            ConsultaEmpleado consultaEmpl = new ConsultaEmpleado();
            consultaEmpl.ShowDialog();
            if (Convert.ToInt32( consultaEmpl.dgvEmpleado.CurrentRow.Cells[0].Value)>= 0)
            {
                txtCodEmpleado.Text = Convert.ToString(consultaEmpl.dgvEmpleado.CurrentRow.Cells[0].Value);
                txtApellidoUsu.Text = Convert.ToString(consultaEmpl.dgvEmpleado.CurrentRow.Cells[4].Value);
                txtNombreUsu.Text = Convert.ToString(consultaEmpl.dgvEmpleado.CurrentRow.Cells[5].Value);
            }
            consultaEmpl.Dispose();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (conecta.AbrirConexion() == true)
                {
                    int resultado = 0, resultado1 = 0;
                    Clases.Usuario pUsuario = new Clases.Usuario();
                    pUsuario.Cod_Usuario = txtcodigo.Text;
                    pUsuario.Cod_Empl_Usuario = Convert.ToInt32(txtCodEmpleado.Text);
                    pUsuario.Apellido_Empl_Usuario = txtApellidoUsu.Text;
                    pUsuario.Nombre_Empl_Usuario = txtNombreUsu.Text;
                    pUsuario.Clave_Usuario = txtClaveUsu.Text;
                    pUsuario.Perfil_Rol_Usuario = cmbRol.DisplayMember;
                    pUsuario.CodRol_Usuario=Convert.ToInt16( cmbRol.SelectedValue);
                    if (cmbEstado.Text == "Activo")
                    {
                        pUsuario.Estado_Usuario = 0;
                    }
                    else
                    {
                        pUsuario.Estado_Usuario = 1;
                    }

                    switch (lblAccion.Text)
                    {

                        case "I": resultado = Clases.Usuario.AgregarUsuario(conecta.conexion, pUsuario); resultado1 = Clases.Usuario.AgregarRolUsuario(conecta.conexion, pUsuario.Cod_Usuario, pUsuario.CodRol_Usuario); break;

                        case "M": resultado = Clases.Usuario.ModificarUsuario(conecta.conexion, pUsuario); resultado1 = Clases.Usuario.ModificarRolUsuario(conecta.conexion, pUsuario.Cod_Usuario, pUsuario.CodRol_Usuario); break;

                        case "E": resultado = Clases.Usuario.EliminarUsuario(conecta.conexion, pUsuario.Cod_Usuario); resultado1 = Clases.Usuario.EliminarRolUsuario(conecta.conexion, pUsuario.Cod_Usuario); break;

                    }


                    if ((resultado > 0) && (resultado1 > 0))
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
                this.Close();
            }
        }
    }
}
