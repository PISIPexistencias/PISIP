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
    public partial class Actualizar_clientes : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();

        public Actualizar_clientes()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_clientes_Load(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaCliente(conecta.conexion, txt_ced_actualizar.Text, txt_ape_actualizar.Text, txt_nom_actualizar.Text);
                    conecta.CerrarConexion();
                }

                
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void ListaCliente(MySqlConnection conectar, string Bcedula, string Bapellidos, string Bnombres )
        {
            dgvCliente.DataSource = Clases.Cliente.Busca_Cliente(conectar, Bcedula, Bapellidos, Bnombres);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaCliente(conecta.conexion, txt_ced_actualizar.Text, txt_ape_actualizar.Text, txt_nom_actualizar.Text);
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
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Registro_clientes registraCliente = new Registro_clientes();
           
            registraCliente.Show();

        }

        private void Actualizar_clientes_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("activo");
        }
    }
}
