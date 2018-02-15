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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Conexion conecta = new Clases.Conexion();

                if ((conecta.AbrirConexion()) == true)
                {
                    MySqlCommand comando = new MySqlCommand("select CODIGO_USUARIO,CLAVE_USUARIO,APELLIDOS_EMPLEADO,NOMBRES_EMPLEADO FROM usuario u, empleados e where u.codigo_usuario= '" + txtuser.Text + "' and u.clave_usuario='" + txtpass.Text + "' and u.codigo_empleado = e.codigo_empleado ", conecta.conexion);
                    MySqlDataReader ejecuta = comando.ExecuteReader();
                    if (ejecuta.Read() == true)
                    {
                        MessageBox.Show("Bienvenido " + ejecuta["APELLIDOS_EMPLEADO"] + " " + ejecuta["NOMBRES_EMPLEADO"]);

                        Menu_principal menu = new Menu_principal();
                        this.Hide();
                        menu.Show();
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

    }
}
