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
            Clases.Conexion conecta = new Clases.Conexion();

            if ((conecta.AbrirConexion()) == true)
            {
                MySqlCommand comando = new MySqlCommand("select * FROM usuario where codigo_usuario='" + txtuser.Text + "' and clave_usuario='" + txtpass.Text + "' ", conecta.conexion);
                MySqlDataReader ejecuta = comando.ExecuteReader();
                if (ejecuta.Read() == true)
                {
                    MessageBox.Show("Bienvenido " + ejecuta["codigo_usuario"]);
                   
                    Menu_principal menu = new Menu_principal();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto");
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
