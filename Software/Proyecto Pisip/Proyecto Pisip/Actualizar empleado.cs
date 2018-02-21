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
    public partial class Actualizar_empleado : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        Clases.Validacion valida = new Clases.Validacion();
        public Actualizar_empleado()
        {
            InitializeComponent();
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

        private void Actualizar_empleado_Load(object sender, EventArgs e)
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
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Registro_Empleados registraEmpleado = new Registro_Empleados();
            registraEmpleado.lblAccion.Text = "I";
            registraEmpleado.Show();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleado.SelectedRows.Count == 1)
                {
                    Registro_Empleados registraEmpleado = new Registro_Empleados();
                    registraEmpleado.txtcodigo.Text = Convert.ToString(dgvEmpleado.CurrentRow.Cells[0].Value);
                    registraEmpleado.lblAccion.Text = "M";
                    //this.Hide();
                    registraEmpleado.Show();


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
                if (dgvEmpleado.SelectedRows.Count == 1)
                {
                    Registro_Empleados registraEmpleado = new Registro_Empleados();
                    registraEmpleado.txtcodigo.Text = Convert.ToString(dgvEmpleado.CurrentRow.Cells[0].Value);
                    registraEmpleado.lblAccion.Text = "E";
                    //this.Hide();
                    registraEmpleado.Show();


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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
