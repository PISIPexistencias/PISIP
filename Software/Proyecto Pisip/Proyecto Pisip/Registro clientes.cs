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
    public partial class Registro_clientes : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        public Clases.Cliente ClienteSeleccionado { get; set; }
       
        public Registro_clientes()
        {
            InitializeComponent();
        }

        private void Registro_clientes_Load(object sender, EventArgs e)
        {
            try
            {
                if (lblAccion.Text == "I")
                {
                    txtcodigo.Clear();
                    txtcedula.Clear();
                    txtapellidos.Clear();
                    txtnombres.Clear();
                    txtmail.Clear();
                    txtdireccion.Clear();
                    txttelefono.Clear();
                }
                else if ((lblAccion.Text == "M") || (lblAccion.Text == "E"))
                {
                    if (conecta.AbrirConexion() == true)
                    {
                        ClienteSeleccionado = Clases.Cliente.ObtenerCliente(conecta.conexion, Convert.ToInt32(txtcodigo.Text));
                        txtcedula.Text = ClienteSeleccionado.Cedula_Cliente;
                        txtapellidos.Text = ClienteSeleccionado.Apellidos_Cliente;
                        txtnombres.Text = ClienteSeleccionado.Nombres_Cliente;
                        txtmail.Text = ClienteSeleccionado.Correo_Cliente;
                        txtdireccion.Text = ClienteSeleccionado.Direccion_Cliente;
                        txttelefono.Text = Convert.ToString(ClienteSeleccionado.Telefono_Cliente);
                        conecta.CerrarConexion();
                    }

                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (conecta.AbrirConexion() == true)
                {
                    int resultado=0;
                    Clases.Cliente pCliente = new Clases.Cliente();
                    pCliente.Id_Cliente = Convert.ToInt32(txtcodigo.Text);
                    pCliente.Cedula_Cliente = txtcedula.Text;
                    pCliente.Apellidos_Cliente = txtapellidos.Text;
                    pCliente.Nombres_Cliente = txtnombres.Text;
                    pCliente.Correo_Cliente = txtmail.Text;
                    pCliente.Direccion_Cliente = txtdireccion.Text;
                    pCliente.Telefono_Cliente = Convert.ToDouble(txttelefono.Text);


                    switch (lblAccion.Text)
                    {

                        case "I": resultado = Clases.Cliente.AgregarCliente(conecta.conexion, pCliente); break;

                        case "M": resultado = Clases.Cliente.ModificarCliente(conecta.conexion, pCliente); break;

                        case "E": resultado = Clases.Cliente.EliminarCliente (conecta.conexion, pCliente.Id_Cliente); break;

                    }

                    
                    if (resultado> 0)
                    {
                        if (lblAccion.Text == "I")
                        {
                            MessageBox.Show("Registro Ingresado exitosamente");
                        }else if (lblAccion.Text == "M")
                        {
                            MessageBox.Show("Registro Actualizado exitosamente");
                        }else if (lblAccion.Text == "E")
                        {
                            MessageBox.Show("Registro Eliminado exitosamente");
                        }
                        
                        
                        this.Close();
                       

                    }
                    conecta.CerrarConexion();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
