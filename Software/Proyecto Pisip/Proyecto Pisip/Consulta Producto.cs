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
    public partial class Consulta_Producto : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        public Consulta_Producto()
        {
            InitializeComponent();
        }

        private void Consulta_Producto_Load(object sender, EventArgs e)
        {
            txtNombreProducto.CharacterCasing = CharacterCasing.Upper;
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaProducto(conecta.conexion, txtNombreProducto.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ListaProducto(MySqlConnection conectar, string bNombreProducto)
        {
            dgvProducto.DataSource = Clases.Producto.Busca_Producto(conectar, bNombreProducto);
            // 0,5,6,9
            dgvProducto.Columns[1].Visible = false;
            dgvProducto.Columns[2].Visible = false;
            dgvProducto.Columns[3].Visible = false;
            dgvProducto.Columns[4].Visible = false;
            dgvProducto.Columns[7].Visible = false;
            dgvProducto.Columns[8].Visible = false;
            dgvProducto.Columns[10].Visible = false;
            dgvProducto.Columns[11].Visible = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaProducto(conecta.conexion, txtNombreProducto.Text);
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
