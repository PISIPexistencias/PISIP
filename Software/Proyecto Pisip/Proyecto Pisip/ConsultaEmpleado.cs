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
    public partial class ConsultaEmpleado : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        Clases.Validacion valida = new Clases.Validacion();
        public ConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void ConsultaEmpleado_Load(object sender, EventArgs e)
        {
            txtApeEmpleado.CharacterCasing = CharacterCasing.Upper;
            txtNomEmpleado.CharacterCasing = CharacterCasing.Upper;
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaEmpleado(conecta.conexion, txtCedEmpleado.Text, txtApeEmpleado.Text, txtNomEmpleado.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void ListaEmpleado(MySqlConnection conectar, string Bcedula, string Bapellidos, string Bnombres)
        {
            dgvEmpleado.DataSource = Clases.Empleado.Busca_Empleado(conectar, Bcedula, Bapellidos, Bnombres);
            dgvEmpleado.Columns[1].Visible = false;
            dgvEmpleado.Columns[2].Visible = false;
            dgvEmpleado.Columns[3].Visible = false;
            dgvEmpleado.Columns[6].Visible = false;
            dgvEmpleado.Columns[7].Visible = false;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaEmpleado(conecta.conexion, txtCedEmpleado.Text, txtApeEmpleado.Text, txtNomEmpleado.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCedEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }

        private void txtApeEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }

        private void txtNomEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }
    }
}
