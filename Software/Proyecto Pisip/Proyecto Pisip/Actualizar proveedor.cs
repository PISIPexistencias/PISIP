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
    public partial class Actualizar_proveedor : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();

        public Actualizar_proveedor()
        {
            InitializeComponent();
        }

        private void Actualizar_proveedor_Load(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaProveedor(conecta.conexion, txtRucProveedor.Text, txtProveedor.Text);
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
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    ListaProveedor(conecta.conexion, txtRucProveedor.Text, txtProveedor.Text);
                    conecta.CerrarConexion();
                }


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Registro_proveedor registraProvee = new Registro_proveedor();
            registraProvee.lblAccion.Text = "I";
            registraProvee.Show();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProveedor.SelectedRows.Count == 1)
                {
                    Registro_proveedor registraProvee = new Registro_proveedor();
                    registraProvee.txtCodigo.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[0].Value);
                    registraProvee.lblAccion.Text = "M";
                    //this.Hide();
                    registraProvee.Show();


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
                if (dgvProveedor.SelectedRows.Count == 1)
                {
                    Registro_proveedor registraProvee = new Registro_proveedor();
                    registraProvee.txtCodigo.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[0].Value);
                    registraProvee.lblAccion.Text = "E";
                    //this.Hide();
                    registraProvee.Show();


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
