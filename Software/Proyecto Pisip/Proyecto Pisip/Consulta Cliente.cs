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
    public partial class Consulta_Cliente : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        Clases.Validacion valida = new Clases.Validacion();
        public Consulta_Cliente()
        {
            InitializeComponent();
        }

        private void Consulta_Cliente_Load(object sender, EventArgs e)
        {
            txtApellidoCli.CharacterCasing = CharacterCasing.Upper;
            txtNombreCli.CharacterCasing = CharacterCasing.Upper;
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaCliente(conecta.conexion, txtCedulaCli.Text, txtApellidoCli.Text, txtNombreCli.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListaCliente(MySqlConnection conectar, string Bcedula, string Bapellidos, string Bnombres)
        {
            dgvClientes.DataSource = Clases.Cliente.Busca_Cliente(conectar, Bcedula, Bapellidos, Bnombres);
            dgvClientes.Columns[4].Visible = false;
            dgvClientes.Columns[5].Visible = false;
            dgvClientes.Columns[6].Visible = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaCliente(conecta.conexion, txtCedulaCli.Text, txtApellidoCli.Text, txtNombreCli.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCedulaCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }

        private void txtApellidoCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }

        private void txtNombreCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }
    }
}
