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
        Clases.Validacion valida = new Clases.Validacion();

        public Actualizar_clientes()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_clientes_Load(object sender, EventArgs e)
        {
            txt_ape_actualizar.CharacterCasing = CharacterCasing.Upper;
            txt_nom_actualizar.CharacterCasing = CharacterCasing.Upper;
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
            dgvClientes.DataSource = Clases.Cliente.Busca_Cliente(conectar, Bcedula, Bapellidos, Bnombres);
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
            registraCliente.lblAccion.Text = "I";
            registraCliente.Show();

        }

        private void Actualizar_clientes_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("activo");
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count == 1)
                {
                    Registro_clientes registraCli = new Registro_clientes();
                    registraCli.txtcodigo.Text= Convert.ToString(dgvClientes.CurrentRow.Cells[0].Value);
                    registraCli.lblAccion.Text = "M";
                    //this.Hide();
                    registraCli.Show();


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
                if (dgvClientes.SelectedRows.Count == 1)
                {
                    Registro_clientes registraCli = new Registro_clientes();
                    registraCli.txtcodigo.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[0].Value);
                    registraCli.lblAccion.Text = "E";
                    //this.Hide();
                    registraCli.Show();


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

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_ced_actualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.soloNumero(e);
        }

        private void txt_ape_actualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }

        private void txt_nom_actualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            valida.sololetras(e);
        }
    }
}
