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
    public partial class Actualizar_productos : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();

        public Actualizar_productos()
        {
            InitializeComponent();
        }

        private void Actualizar_productos_Load(object sender, EventArgs e)
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
        public void ListaProducto(MySqlConnection conectar, string bNombreProducto)
        {
            dgvProducto.DataSource = Clases.Producto.Busca_Producto(conectar, bNombreProducto);
            dgvProducto.Columns[1].Visible = false;
            dgvProducto.Columns[3].Visible = false;
            dgvProducto.Columns[11].Visible = false;
            dgvProducto.Columns[12].Visible = false;
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Registro_productos registraProducto = new Registro_productos();
            registraProducto.lblAccion.Text = "I";
            registraProducto.Show();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.SelectedRows.Count == 1)
                {
                    Registro_productos registraProducto = new Registro_productos();
                    registraProducto.txtCodProducto.Text = Convert.ToString(dgvProducto.CurrentRow.Cells[0].Value);
                    registraProducto.lblAccion.Text = "M";
                    registraProducto.Show();


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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProducto.SelectedRows.Count == 1)
                {
                    Registro_productos registraProducto = new Registro_productos();
                    registraProducto.txtCodProducto.Text = Convert.ToString(dgvProducto.CurrentRow.Cells[0].Value);
                    registraProducto.lblAccion.Text = "E";
                    registraProducto.Show();


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
