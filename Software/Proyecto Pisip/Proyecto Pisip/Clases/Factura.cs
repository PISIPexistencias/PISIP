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
        public string Cedula_Cli_Factura { get; set; }
        public string Apellido_Cli_Factura { get; set; }
        public string Nombre_Cli_Factura { get; set; }
        public DateTime Fecha_factura { get; set; }
        public double Iva_Factura { get; set; }
        public double Sub_Total_Factura { get; set; }
        public double Total_Factura { get; set; }
        public int Estado_Factura { get; set; }
        public Factura()
        {
        }
        public Factura(int pCodFactura, int pCodCliFactura, string pCedulaCliFactura, string pApellidoCliFactura, string pNombreCliFactura, DateTime pFechaFactura, double pIvaFactura, double pSubTotalFactura, double pTotalFactura, int pEstadoFactura)
        {
            this.Codigo_Factura = pCodFactura;
            this.Cod_Cliente_Factura = pCodCliFactura;
            this.Cedula_Cli_Factura = pCedulaCliFactura;
            this.Apellido_Cli_Factura = pApellidoCliFactura;
            this.Nombre_Cli_Factura = pNombreCliFactura;
            this.Fecha_factura = pFechaFactura;
            this.Iva_Factura = pIvaFactura;
            this.Sub_Total_Factura = pSubTotalFactura;
            this.Total_Factura = pTotalFactura;
            this.Estado_Factura = pEstadoFactura;
        }
        public static int AgregarFactura(MySqlConnection conexion, Factura pFactura)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Insertar_Factura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            //comando.Parameters.AddWithValue("@codFactura", pFactura.Codigo_Factura);
            comando.Parameters.AddWithValue("@codCliente", pFactura.Cod_Cliente_Factura);
            comando.Parameters.AddWithValue("@fechaFactura", pFactura.Fecha_factura);
            comando.Parameters.AddWithValue("@ivaFactura", pFactura.Iva_Factura);
            comando.Parameters.AddWithValue("@subtotalFactura", pFactura.Sub_Total_Factura);
            comando.Parameters.AddWithValue("@totalFactura", pFactura.Total_Factura);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

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

        public static IList<Factura> Busca_Factura(MySqlConnection conexion, string B_ApellidoCli, string b_NombreCli)
        {
            List<Factura> lista = new List<Factura>();
            MySqlCommand consulta = new MySqlCommand("select  CODIGO_FACTURA,f.ID_CLIENTE,c.CEDULA, c.APELLIDOS, c.NOMBRES , FECHA_FACTURA, IVA_VALOR, SUB_TOTAL, VALOR_TOTAL , ESTADO_FACTURA from factura f, cliente c where f.id_cliente = c.id_cliente and c.APELLIDOS LIKE ('%" + B_ApellidoCli + "%') and c.NOMBRES LIKE ('%" + B_ApellidoCli + "%') ", conexion);
            MySqlDataReader ejecuta = consulta.ExecuteReader();
            while (ejecuta.Read())
            {
                Factura Bfactura = new Factura();
                Bfactura.Codigo_Factura = ejecuta.GetInt32(0);
                Bfactura.Cod_Cliente_Factura = ejecuta.GetInt32(1);
                Bfactura.Cedula_Cli_Factura = ejecuta.GetString(2);
                Bfactura.Apellido_Cli_Factura = ejecuta.GetString(3);
                Bfactura.Nombre_Cli_Factura = ejecuta.GetString(4);
                Bfactura.Fecha_factura = ejecuta.GetDateTime(5);
                Bfactura.Iva_Factura = ejecuta.GetDouble(6);
                Bfactura.Sub_Total_Factura = ejecuta.GetDouble(7);
                Bfactura.Total_Factura = ejecuta.GetDouble(8);
                Bfactura.Estado_Factura = ejecuta.GetInt32(9);


                lista.Add(Bfactura);
            }
            return lista;
        }
        public static int ObtenerCodigoFactura(MySqlConnection conexion, int pCodCliente)
        {
            int rCodFactura=0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Obtener_CodigoFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@cod_cliente", pCodCliente);

            MySqlDataReader ejecuta = comando.ExecuteReader();
            while (ejecuta.Read())
            {
                rCodFactura = ejecuta.GetInt32(0);
            }
            return rCodFactura;
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
        public static int AnularFactura(MySqlConnection conexion, int pcodFactura)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_AnularFactura";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codFactura", pcodFactura);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }
}
