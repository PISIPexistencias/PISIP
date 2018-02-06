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
    public partial class Registro_Empleados : Form
    {
        Clases.Conexion conecta = new Clases.Conexion();
        public Clases.Empleado EmpleadoSeleccionado { get; set; }
        public Registro_Empleados()
        {
            InitializeComponent();
        }

        private void Registro_Empleados_Load(object sender, EventArgs e)
        {
            try
            {
                if (lblAccion.Text == "I")
                {
                    txtcodigo.Clear();
                    txtcodBodega.Clear();
                    txtsucursal.Clear();
                    txtcedula.Clear();
                    txtapellidos.Clear();
                    txtnombres.Clear();
                    txtcargo.Clear();
                    txtestado.Clear();
                    
                }
                else if ((lblAccion.Text == "M") || (lblAccion.Text == "E"))
                {
                    if (conecta.AbrirConexion() == true)
                    {
                        EmpleadoSeleccionado = Clases.Empleado.ObtenerEmpleado(conecta.conexion, Convert.ToInt32(txtcodigo.Text));
                        txtcedula.Text = EmpleadoSeleccionado.Cedula_Empleado;
                       txtcodBodega.Text = Convert.ToString( EmpleadoSeleccionado.Cod_Bodega);
                        txtapellidos.Text = EmpleadoSeleccionado.Apellidos_Empleado;
                        txtnombres.Text = EmpleadoSeleccionado.Nombres_Empleado;
                        txtcargo.Text = EmpleadoSeleccionado.Cargo_Empleado;
                        txtestado.Text = Convert.ToString( EmpleadoSeleccionado.Estado_empleado);
                        conecta.CerrarConexion();
                    }

                }
            }
            catch (MySqlException ex)
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
                    int resultado = 0;
                    Clases.Empleado pEmpleado = new Clases.Empleado();
                    pEmpleado.Cod_Bodega = Convert.ToInt32(txtcodigo.Text);
                    pEmpleado.Cedula_Empleado = txtcedula.Text;
                    pEmpleado.Apellidos_Empleado = txtapellidos.Text;
                    pEmpleado.Nombres_Empleado = txtnombres.Text;
                    pEmpleado.Cargo_Empleado = txtcargo.Text;
                    pEmpleado.Estado_empleado = Convert.ToInt16( txtestado.Text);

                    switch (lblAccion.Text)
                    {

                        case "I": resultado = Clases.Empleado.AgregarEmpleado(conecta.conexion, pEmpleado); break;

                        case "M": resultado = Clases.Empleado.ModificarEmpleado(conecta.conexion, pEmpleado); break;

                        case "E": resultado = Clases.Empleado.EliminarEmpleado(conecta.conexion, pEmpleado.Cod_Empleado); break;

                    }


                    if (resultado > 0)
                    {
                        if (lblAccion.Text == "I")
                        {
                            MessageBox.Show("Registro Ingresado exitosamente");
                        }
                        else if (lblAccion.Text == "M")
                        {
                            MessageBox.Show("Registro Actualizado exitosamente");
                        }
                        else if (lblAccion.Text == "E")
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
    }
}
