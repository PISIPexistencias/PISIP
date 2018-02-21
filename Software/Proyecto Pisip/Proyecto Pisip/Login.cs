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
    public partial class Login : Form
    {
        Clases.Validacion valida = new Clases.Validacion();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpass.CharacterCasing = CharacterCasing.Upper;
            txtuser.CharacterCasing = CharacterCasing.Upper;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Conexion conecta = new Clases.Conexion();

                if ((conecta.AbrirConexion()) == true)
                {
                    MySqlCommand comando = new MySqlCommand("select u.CODIGO_USUARIO,u.CLAVE_USUARIO,APELLIDOS_EMPLEADO,NOMBRES_EMPLEADO,ur.PRIMER_INGRESO FROM usuario u, empleados e,usuario_rol ur where u.codigo_usuario= '" + txtuser.Text + "' and u.clave_usuario='" + txtpass.Text + "' and u.codigo_empleado = e.codigo_empleado and u.CODIGO_USUARIO=ur.CODIGO_USUARIO ", conecta.conexion);
                    MySqlDataReader ejecuta = comando.ExecuteReader();
                    if (ejecuta.Read() == true)
                    {
                        if (Convert.ToInt16(ejecuta["PRIMER_INGRESO"]) == 1)
                        {
                            MessageBox.Show("Este es su primer ingreso al sistema por, por favor cambie la clave","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            CambioLogin cambiaLogin = new CambioLogin();
                            cambiaLogin.lblUsuario.Text = Convert.ToString(ejecuta["CODIGO_USUARIO"]);
                            cambiaLogin.lblclave.Text = Convert.ToString(ejecuta["CLAVE_USUARIO"]);
                            cambiaLogin.lblPrimeraVez.Text= Convert.ToString(ejecuta["PRIMER_INGRESO"]);
                            cambiaLogin.ShowDialog();
                            txtpass.Text = cambiaLogin.lblclave.Text;
                            cambiaLogin.Dispose();

                        }
                        else
                        {
                            MessageBox.Show("Bienvenido " + ejecuta["APELLIDOS_EMPLEADO"] + " " + ejecuta["NOMBRES_EMPLEADO"]);

                            Menu_principal menu = new Menu_principal();
                            this.Hide();
                            menu.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario Incorrecto", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        txtuser.Clear();
                        txtpass.Clear();
                    }
                    conecta.CerrarConexion();
                    conecta.conexion.Dispose();

                }
                else
                {
                    MessageBox.Show("no conectado");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambioCalve_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text != "")
                {
                    Clases.Conexion conecta = new Clases.Conexion();

                    if ((conecta.AbrirConexion()) == true)
                    {
                        MySqlCommand comando = new MySqlCommand("select CODIGO_USUARIO,CLAVE_USUARIO,APELLIDOS_EMPLEADO,NOMBRES_EMPLEADO FROM usuario u, empleados e where u.codigo_usuario= '" + txtuser.Text + "' and u.codigo_empleado = e.codigo_empleado ", conecta.conexion);
                        MySqlDataReader ejecuta = comando.ExecuteReader();
                        if (ejecuta.Read() == true)
                        {
                            CambioLogin cambiaLogin = new CambioLogin();
                            cambiaLogin.lblclave.Text = Convert.ToString(ejecuta["CLAVE_USUARIO"]);
                            cambiaLogin.lblUsuario.Text = Convert.ToString(ejecuta["CODIGO_USUARIO"]);
                            cambiaLogin.lblPrimeraVez.Text = "2";
                            cambiaLogin.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Usuario No Existe", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            txtuser.Clear();
                            txtpass.Clear();
                        }
                        conecta.CerrarConexion();
                        
                    }

                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese el Usuario","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }
    }
}
