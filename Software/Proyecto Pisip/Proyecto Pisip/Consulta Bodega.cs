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

namespace Proyecto_Pisip.Clases
{
    
    public partial class Consulta_Bodega : Form
    {
        Conexion conecta = new Conexion();
        Validacion valida = new Validacion();
        public Consulta_Bodega()
        {
            InitializeComponent();
        }

        private void Consulta_Bodega_Load(object sender, EventArgs e)
        {
            txtSucursal.CharacterCasing = CharacterCasing.Upper;
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaBodega(conecta.conexion, txtSucursal.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListaBodega(MySqlConnection conectar, string Bsucursal)
        {
            dgvBodega.DataSource = Clases.Bodega.Busca_Bodega(conectar, Bsucursal);
            dgvBodega.Columns[2].Visible = false;
            dgvBodega.Columns[3].Visible = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaBodega(conecta.conexion, txtSucursal.Text);
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

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }
    }
}
