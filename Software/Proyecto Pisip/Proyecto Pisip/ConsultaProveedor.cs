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

    public partial class ConsultaProveedor : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();

        public ConsultaProveedor()
        {
            InitializeComponent();
        }

        private void ConsultaProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaProveedor(conecta.conexion, txtCodProveedor.Text, txtNomProveedor.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void ListaProveedor(MySqlConnection conectar, string Bruc, string Bnombres)
        {
            dgvProveedor.DataSource = Clases.Proveedor.Busca_Proveedor(conectar, Bruc, Bnombres);
            dgvProveedor.Columns[1].Visible = false;
            dgvProveedor.Columns[3].Visible = false;
            dgvProveedor.Columns[4].Visible = false;
            dgvProveedor.Columns[5].Visible = false;
            dgvProveedor.Columns[6].Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaProveedor(conecta.conexion, txtCodProveedor.Text, txtNomProveedor.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
