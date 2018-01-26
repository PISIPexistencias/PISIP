using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pisip
{
    public partial class Registro_clientes : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
       
        public Registro_clientes()
        {
            InitializeComponent();
        }

        private void Registro_clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (conecta.AbrirConexion() == true)
                {
                    Clases.Cliente pCliente = new Clases.Cliente();
                    pCliente.Cedula_Cliente = txtcedula.Text;
                    pCliente.Apellidos_Cliente = txtapellidos.Text;
                    pCliente.Nombres_Cliente = txtnombres.Text;
                    pCliente.Correo_Cliente = txtmail.Text;
                    pCliente.Direccion_Cliente = txtdireccion.Text;
                    pCliente.Telefono_Cliente = Convert.ToDouble(txttelefono.Text);

                    int resultado;
                    resultado = Clases.Cliente.AgregarCliente(conecta.conexion,pCliente);
                    if (resultado > 0)
                    {
                        
                        this.Close();
                       

                    }
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
    }
}
