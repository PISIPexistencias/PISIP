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
    public partial class Consulta_Factura : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        public Consulta_Factura()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaFactura(conecta.conexion, txtApeCliFactura.Text, txtNomCliFactura.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListaFactura(MySqlConnection conectar, string Bapellidos, string Bnombres)
        {
            dgvFactura.DataSource = Clases.Factura.Busca_Factura(conectar, Bapellidos, Bnombres);
            //dgvFactura.Columns[1].Visible = false;
            //dgvFactura.Columns[2].Visible = false;
            //dgvFactura.Columns[3].Visible = false;
            //dgvFactura.Columns[6].Visible = false;
            //dgvFactura.Columns[7].Visible = false;

        }

        private void Consulta_Factura_Load(object sender, EventArgs e)
        {
            txtApeCliFactura.CharacterCasing = CharacterCasing.Upper;
            txtNomCliFactura.CharacterCasing = CharacterCasing.Upper;
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaFactura(conecta.conexion, txtApeCliFactura.Text, txtNomCliFactura.Text);
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
    }
}
