using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data; 

namespace Proyecto_Pisip.Clases
{
    public class DetalleFactura
    {
        public int Codigo_Factura { get; set; }
        public int Codigo_Producto { get; set; }
        public int Secuencial_Detalle { get; set; }
        public string Descripcion_Detalle { get; set; }
        public int Cantidad_Detalle { get; set; }
        public double PrecioUnitario_Detalle { get; set; }
        public double Total_Detalle { get; set; }
        public DetalleFactura()
        {
        }
        public DetalleFactura(int pCodFactura, int pCodCliente, int pSecuencialDetalle, string pDescripcionDetalle, int pCantidadDetalle, double pPrecioUnitarioDetalle, double pTotalDetalle)
        {
            this.Codigo_Factura = pCodFactura;
            this.Codigo_Producto = pCodCliente;
            this.Secuencial_Detalle = pSecuencialDetalle;
            this.Descripcion_Detalle = pDescripcionDetalle;
            this.Cantidad_Detalle = pCantidadDetalle;
            this.PrecioUnitario_Detalle = pPrecioUnitarioDetalle;
            this.Total_Detalle = pTotalDetalle;
        }
        public static int AgregarDetalle(MySqlConnection conexion, DetalleFactura pDetalle)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Insertar_Detalle";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codFactura", pDetalle.Codigo_Factura);
            comando.Parameters.AddWithValue("@codProducto", pDetalle.Codigo_Producto);
            comando.Parameters.AddWithValue("@secuencialDetalle", pDetalle.Secuencial_Detalle);
            comando.Parameters.AddWithValue("@descripcionDetalle", pDetalle.Descripcion_Detalle);
            comando.Parameters.AddWithValue("@cantidadDetalle", pDetalle.Cantidad_Detalle);
            comando.Parameters.AddWithValue("@precioUnitarioDetalle", pDetalle.PrecioUnitario_Detalle);
            comando.Parameters.AddWithValue("@totalDetalle", pDetalle.Total_Detalle);

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

        //public static IList<DetalleFactura> Busca_Factura(MySqlConnection conexion, string B_ApellidoCli, string b_NombreCli)
        //{
        //    List<DetalleFactura> lista = new List<DetalleFactura>();
        //    MySqlCommand consulta = new MySqlCommand("select  CODIGO_FACTURA,f.ID_CLIENTE,c.CEDULA,(c.APELLIDOS + c.NOMBRES) as Nomcli, FECHA_FACTURA, IVA_VALOR, SUB_TOTAL, VALOR_TOTAL from factura f, cliente c where f.id_cliente = c.id_cliente and c.APELLIDOS LIKE ('%" + B_ApellidoCli + "%') and c.NOMBRES LIKE ('%" + B_ApellidoCli + "%') ", conexion);
        //    MySqlDataReader ejecuta = consulta.ExecuteReader();
        //    while (ejecuta.Read())
        //    {
        //        DetalleFactura Bfactura = new DetalleFactura();
        //        Bfactura.Codigo_Factura = ejecuta.GetInt32(0);
        //        Bfactura.Cod_Cliente_Factura = ejecuta.GetInt32(1);
        //        Bfactura.Cedula_Cli_Factura = ejecuta.GetString(2);
        //        Bfactura.Nombre_Cli_Factura = ejecuta.GetString(3);
        //        Bfactura.Fecha_factura = ejecuta.GetDateTime(4);
        //        Bfactura.Iva_Factura = ejecuta.GetDouble(5);
        //        Bfactura.Sub_Total_Factura = ejecuta.GetDouble(6);
        //        Bfactura.Sub_Total_Factura = ejecuta.GetDouble(7);


        //        lista.Add(Bfactura);
        //    }
        //    return lista;
        //}
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
