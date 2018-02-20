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
    public partial class CambioLogin : Form
    {
        public CambioLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void CambioLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClaveActual.Text == lblclave.Text)
                {
                    if (txtClaveNueva.Text == txtComfirmaClave.Text)
                    {
                        Clases.Conexion conecta1 = new Clases.Conexion();
                        if ((conecta1.AbrirConexion()) == true)
                        {
                            int resultado=0;
                            MySqlCommand comando = new MySqlCommand("update usuario set CLAVE_USUARIO='" + txtClaveNueva.Text + "' where CODIGO_USUARIO='" + lblUsuario.Text + "' ", conecta1.conexion);
                            comando.ExecuteNonQuery();
                            if (Convert.ToInt16(lblPrimeraVez.Text) == 1)
                            {
                                resultado = Clases.Roles.ModificarRolesPrimeraVez(conecta1.conexion, Convert.ToString(lblUsuario.Text));
                            }
                            
                            if (resultado > 0)
                            {
                                
                                lblclave.Text = txtClaveNueva.Text;

                            }
                            MessageBox.Show("La clave ha sido modificada ");
                            conecta1.CerrarConexion();
                            conecta1.conexion.Dispose();
                            this.Close();
                            //this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("no conectado");
                        }

                    }
                    else
                    {
                        MessageBox.Show("La Clave Nueva y la Confrimacion no coinciden, por favor verifique", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }else
                {
                    MessageBox.Show("La Clave Actual no es la correcta, por favor verifique","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
