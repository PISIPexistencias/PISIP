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
    public partial class Actualizar_Usuario : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        public Actualizar_Usuario()
        {
            InitializeComponent();
        }

        private void Actualizar_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaUsuario(conecta.conexion, txtCodUsuario.Text, txtApellidoUsu.Text, txtNombreUsu.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void ListaUsuario(MySqlConnection conectar, string Bcodigo, string Bapellidos, string Bnombres)
        {
            dgvUsuario.DataSource = Clases.Usuario.Busca_Usuario(conectar, Bcodigo, Bapellidos, Bnombres);
           
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaUsuario(conecta.conexion, txtCodUsuario.Text, txtApellidoUsu.Text, txtNombreUsu.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Registro_Usuario  registraUsuario = new Registro_Usuario();
            registraUsuario.lblAccion.Text = "I";
            registraUsuario.Show();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuario.SelectedRows.Count == 1)
                {
                    Registro_Usuario registraUsuario = new Registro_Usuario();
                    registraUsuario.txtcodigo.Text = Convert.ToString(dgvUsuario.CurrentRow.Cells[0].Value);
                    registraUsuario.lblAccion.Text = "M";
                    //this.Hide();
                    registraUsuario.Show();


                }
                else
                {
                    MessageBox.Show("Seleccione un registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
