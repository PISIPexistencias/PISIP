using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_Pisip.Clases
{
    public class Factura
    {
        public int Codigo_Factura { get; set; }
        public int Cod_Cliente_Factura { get; set; }
        public DateTime Fecha_factura { get; set; }
        public double Iva_Factura { get; set; }
        public double Sub_Total_Factura { get; set; }
        public double Total_Factura { get; set; }
        public Factura()
        {
        }
        public Factura(int pCodFactura, int pCodCliFactura, DateTime pFechaFactura, double pIvaFactura, double pSubTotalFactura, double pTotalFactura)
        {
            this.Codigo_Factura = pCodFactura;
            this.Cod_Cliente_Factura = pCodCliFactura;
            this.Fecha_factura = pFechaFactura;
            this.Iva_Factura = pIvaFactura;
            this.Sub_Total_Factura = pSubTotalFactura;
            this.Total_Factura = pTotalFactura;
        }
        //public static int AgregarCliente(MySqlConnection conexion, Cliente pCliente)
        //{
        //    int retorno = 0;
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandText = "PA_Insertar_Cliente";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;

        //    comando.Parameters.AddWithValue("@cedula_cli", pCliente.Cedula_Cliente);
        //    comando.Parameters.AddWithValue("@apellidos_cli", pCliente.Apellidos_Cliente);
        //    comando.Parameters.AddWithValue("@nombres_cli", pCliente.Nombres_Cliente);
        //    comando.Parameters.AddWithValue("@correo_cli", pCliente.Correo_Cliente);
        //    comando.Parameters.AddWithValue("@direccion_cli", pCliente.Direccion_Cliente);
        //    comando.Parameters.AddWithValue("@telefono_cli", pCliente.Telefono_Cliente);
        //    retorno = comando.ExecuteNonQuery();
        //    return retorno;
        //}

        //public static int ModificarCliente(MySqlConnection conexion, Cliente pCliente)
        //{
        //    int retorno = 0;
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandText = "PA_Actualizar_Cliente";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;

        //    comando.Parameters.AddWithValue("@cod_cliente", pCliente.Id_Cliente);
        //    comando.Parameters.AddWithValue("@cedula_cli", pCliente.Cedula_Cliente);
        //    comando.Parameters.AddWithValue("@apellidos_cli", pCliente.Apellidos_Cliente);
        //    comando.Parameters.AddWithValue("@nombres_cli", pCliente.Nombres_Cliente);
        //    comando.Parameters.AddWithValue("@correo_cli", pCliente.Correo_Cliente);
        //    comando.Parameters.AddWithValue("@direccion_cli", pCliente.Direccion_Cliente);
        //    comando.Parameters.AddWithValue("@telefono_cli", pCliente.Telefono_Cliente);
        //    retorno = comando.ExecuteNonQuery();
        //    return retorno;
        //}

        public static IList<Factura> Busca_Cliente(MySqlConnection conexion, string B_Cedula, string B_Apellidos, String B_Nombres)
        {
            List<Factura> lista = new List<Factura>();
            MySqlCommand consulta = new MySqlCommand("select ID_CLIENTE, CEDULA, APELLIDOS, NOMBRES, CORREO_CLIENTE, DIRECCION_CLIENTE, TELEFONO_CLIENTE from cliente where CEDULA LIKE ('%" + B_Cedula + "%') AND APELLIDOS LIKE ('%" + B_Apellidos + "%') AND  NOMBRES LIKE ('%" + B_Nombres + "%') ", conexion);
            MySqlDataReader ejecuta = consulta.ExecuteReader();
            while (ejecuta.Read())
            {
                Factura Bfactura = new Factura();
                Bfactura.Codigo_Factura = ejecuta.GetInt32(0);
                Bfactura.Cod_Cliente_Factura = ejecuta.GetInt32(1);
                Bfactura.Fecha_factura = ejecuta.GetDateTime(2);
                Bfactura.Iva_Factura = ejecuta.GetDouble(3);
                Bfactura.Sub_Total_Factura = ejecuta.GetDouble(4);
                Bfactura.Sub_Total_Factura = ejecuta.GetDouble(5);


                lista.Add(Bfactura);
            }
            return lista;
        }
        //public static Cliente ObtenerCliente(MySqlConnection conexion, int pIdCliente)
        //{
        //    Cliente pCliente = new Cliente();
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandText = "PA_Obtener_Cliente";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;

        //    comando.Parameters.AddWithValue("@cod_cliente", pIdCliente);

        //    MySqlDataReader ejecuta = comando.ExecuteReader();
        //    while (ejecuta.Read())
        //    {
        //        pCliente.Id_Cliente = ejecuta.GetInt32(0);
        //        pCliente.Cedula_Cliente = ejecuta.GetString(1);
        //        pCliente.Apellidos_Cliente = ejecuta.GetString(2);
        //        pCliente.Nombres_Cliente = ejecuta.GetString(3);
        //        pCliente.Correo_Cliente = ejecuta.GetString(4);
        //        pCliente.Direccion_Cliente = ejecuta.GetString(5);
        //        pCliente.Telefono_Cliente = ejecuta.GetDouble(6);


        //    }
        //    return pCliente;
        //}
        ////public static int EliminarCliente(MySqlConnection conexion, int pcodCliente)
        ////{
        ////    int retorno = 0;
        ////    MySqlCommand comando = new MySqlCommand();
        ////    comando.CommandText = "PA_EliminarCliente";
        ////    comando.CommandType = CommandType.StoredProcedure;
        ////    comando.Connection = conexion;

        ////    comando.Parameters.AddWithValue("@cod_cliente", pcodCliente);
        ////    retorno = comando.ExecuteNonQuery();
        ////    return retorno;
        ////}

    }
}
