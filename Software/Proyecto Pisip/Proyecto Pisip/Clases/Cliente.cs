using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_Pisip.Clases
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }
        public string Cedula_Cliente { get; set; }
        public string Apellidos_Cliente { get; set; }
        public string Nombres_Cliente { get; set; }
        public string Correo_Cliente { get; set; }
        public string Direccion_Cliente { get; set; }
        public double Telefono_Cliente { get; set; }
        public Cliente()
        {
        }
        public Cliente(int Cid, string Ccedula, string Capellidos,string Cnombres,string Ccorreo,string Cdireccion, double Ctelefono)
        {
            this.Id_Cliente = Cid;
            this.Cedula_Cliente = Ccedula;
            this.Apellidos_Cliente = Capellidos;
            this.Nombres_Cliente = Cnombres;
            this.Correo_Cliente = Ccorreo;
            this.Direccion_Cliente = Cdireccion;
            this.Telefono_Cliente = Ctelefono;
        }
        public static int AgregarCliente(MySqlConnection conexion, Cliente pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Insertar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@cedula_cli", pCliente.Cedula_Cliente);
            comando.Parameters.AddWithValue("@apellidos_cli", pCliente.Apellidos_Cliente);
            comando.Parameters.AddWithValue("@nombres_cli", pCliente.Nombres_Cliente);
            comando.Parameters.AddWithValue("@correo_cli", pCliente.Correo_Cliente);
            comando.Parameters.AddWithValue("@direccion_cli", pCliente.Direccion_Cliente);
            comando.Parameters.AddWithValue("@telefono_cli", pCliente.Telefono_Cliente);
            retorno=comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarCliente(MySqlConnection conexion, Cliente pCliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Actualizar_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@cod_cliente", pCliente.Id_Cliente);
            comando.Parameters.AddWithValue("@cedula_cli", pCliente.Cedula_Cliente);
            comando.Parameters.AddWithValue("@apellidos_cli", pCliente.Apellidos_Cliente);
            comando.Parameters.AddWithValue("@nombres_cli", pCliente.Nombres_Cliente);
            comando.Parameters.AddWithValue("@correo_cli", pCliente.Correo_Cliente);
            comando.Parameters.AddWithValue("@direccion_cli", pCliente.Direccion_Cliente);
            comando.Parameters.AddWithValue("@telefono_cli", pCliente.Telefono_Cliente);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Cliente> Busca_Cliente(MySqlConnection conexion, string B_Cedula, string B_Apellidos, String B_Nombres)
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlCommand consulta = new MySqlCommand("select ID_CLIENTE, CEDULA, APELLIDOS, NOMBRES, CORREO_CLIENTE, DIRECCION_CLIENTE, TELEFONO_CLIENTE from cliente where CEDULA LIKE ('%" + B_Cedula + "%') AND APELLIDOS LIKE ('%" + B_Apellidos + "%') AND  NOMBRES LIKE ('%" + B_Nombres + "%') ", conexion );
            MySqlDataReader ejecuta = consulta.ExecuteReader();
            while (ejecuta.Read())
            {
                Cliente Bcliente = new Cliente();
                Bcliente.Id_Cliente = ejecuta.GetInt32(0);
                Bcliente.Cedula_Cliente = ejecuta.GetString(1);
                Bcliente.Apellidos_Cliente = ejecuta.GetString(2);
                Bcliente.Nombres_Cliente = ejecuta.GetString(3);
                Bcliente.Correo_Cliente = ejecuta.GetString(4);
                Bcliente.Direccion_Cliente = ejecuta.GetString(5);
                Bcliente.Telefono_Cliente = ejecuta.GetDouble(6);

                lista.Add(Bcliente);
            }
            return lista;
        }
        public static Cliente ObtenerCliente(MySqlConnection conexion, int pIdCliente)
        {
            Cliente pCliente = new Cliente();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Obtener_Cliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@cod_cliente", pIdCliente);

            MySqlDataReader ejecuta = comando.ExecuteReader();
            while (ejecuta.Read())
            {
                pCliente.Id_Cliente = ejecuta.GetInt32(0);
                pCliente.Cedula_Cliente= ejecuta.GetString(1);
                pCliente.Apellidos_Cliente = ejecuta.GetString(2);
                pCliente.Nombres_Cliente = ejecuta.GetString(3);
                pCliente.Correo_Cliente = ejecuta.GetString(4);
                pCliente.Direccion_Cliente = ejecuta.GetString(5);
                pCliente.Telefono_Cliente = ejecuta.GetDouble(6);

                
            }
            return pCliente;
        }
    }
}
