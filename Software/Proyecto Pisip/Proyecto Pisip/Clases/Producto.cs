using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Pisip.Clases
{
    public class Producto
    {
        public int Cod_Producto { get; set; }
        public int Cod_Bod_Producto { get; set; }
        public string Sucursal_Bod_Producto { get; set; }
        public int Cod_Prov_Producto { get; set; }
        public string Nombre_Prov_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public int Stock_Producto { get; set; }
        public int Stock_Min_Producto { get; set; }
        public double Precio_Compra_Producto { get; set; }
        public double Precio_Venta_Producto { get; set; }
        public DateTime Fecha_Caduca_Producto { get; set; }
        public int Iva_Producto { get; set; }
        public int Estado_Producto { get; set; }

        public Producto()
        {
        }
        public Producto(int pCodProducto, int pCodBodProducto,string pSucursalBodProducto, int pCod_ProvProducto, string pNomProvProducto, string pNombreProducto, int pStockProducto, int pStockMinProducto, double pPrecioCompraProducto, double pPrecioVentaProducto, DateTime pFechaCaducaProducto, int pIvaProducto ,int pEstadoProducto)
        {
            this.Cod_Producto = pCodProducto;
            this.Cod_Bod_Producto = pCodBodProducto;
            this.Sucursal_Bod_Producto = pSucursalBodProducto;
            this.Cod_Prov_Producto = pCod_ProvProducto;
            this.Nombre_Prov_Producto = pNomProvProducto;
            this.Nombre_Producto = pNombreProducto;
            this.Stock_Producto = pStockProducto;
            this.Stock_Min_Producto = pStockMinProducto;
            this.Precio_Compra_Producto = pPrecioCompraProducto;
            this.Precio_Venta_Producto = pPrecioVentaProducto;
            this.Fecha_Caduca_Producto = pFechaCaducaProducto;
            this.Iva_Producto = pIvaProducto;
            this.Estado_Producto = pEstadoProducto;
        }
        public static int AgregarProducto(MySqlConnection conexion, Producto pProducto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Insertar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            //comando.Parameters.AddWithValue("@codProducto", pProducto.Cod_Producto);
            comando.Parameters.AddWithValue("@codBodegaPro", pProducto.Cod_Bod_Producto);
            comando.Parameters.AddWithValue("@codProveePro", pProducto.Cod_Prov_Producto);
            comando.Parameters.AddWithValue("@nombreProducto", pProducto.Nombre_Producto);
            comando.Parameters.AddWithValue("@stockProducto", pProducto.Stock_Producto);
            comando.Parameters.AddWithValue("@stockMinProducto", pProducto.Stock_Min_Producto);
            comando.Parameters.AddWithValue("@precioCompraProducto", pProducto.Precio_Compra_Producto);
            comando.Parameters.AddWithValue("@precioVentaProducto", pProducto.Precio_Venta_Producto);
            comando.Parameters.AddWithValue("@fechaCaducaProducto", pProducto.Fecha_Caduca_Producto);
            comando.Parameters.AddWithValue("@ivaProducto", pProducto.Iva_Producto);
            comando.Parameters.AddWithValue("@estadoProducto", pProducto.Estado_Producto);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarProducto(MySqlConnection conexion, Producto pProducto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Actualizar_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codProducto", pProducto.Cod_Producto);
            comando.Parameters.AddWithValue("@codBodegaPro", pProducto.Cod_Bod_Producto);
            comando.Parameters.AddWithValue("@codProveePro", pProducto.Cod_Prov_Producto);
            comando.Parameters.AddWithValue("@nombreProducto", pProducto.Nombre_Producto);
            comando.Parameters.AddWithValue("@stockProducto", pProducto.Stock_Producto);
            comando.Parameters.AddWithValue("@stockMinProducto", pProducto.Stock_Min_Producto);
            comando.Parameters.AddWithValue("@precioCompraProducto", pProducto.Precio_Compra_Producto);
            comando.Parameters.AddWithValue("@precioVentaProducto", pProducto.Precio_Venta_Producto);
            comando.Parameters.AddWithValue("@fechaCaducaProducto", pProducto.Fecha_Caduca_Producto);
            comando.Parameters.AddWithValue("@ivaProducto", pProducto.Iva_Producto);
            comando.Parameters.AddWithValue("@estadoProducto", pProducto.Estado_Producto);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Producto> Busca_Producto(MySqlConnection conexion, string B_NombreProducto)
        {
            List<Producto> listaProduc = new List<Producto>();
            MySqlCommand consulta = new MySqlCommand("select CODIGO_PRODUCTO,pr.CODIGO_BODEGA, b.SUCURSAL, pr.CODIGO_PROVEEDOR, p.NOMBRE_PROVEEDOR, NOMBRE_PRODUCTO,STOCK,STOCK_MINIMO, PRECIO_COMPRA, PRECIO_VENTA, FECHA_CADUCA,IVA_PRODUCTO, ESTADO_PRODUCTO from producto pr, Bodega b, proveedores p where pr.CODIGO_BODEGA = b.CODIGO_BODEGA and pr.CODIGO_PROVEEDOR = p.CODIGO_PROVEEDOR AND NOMBRE_PRODUCTO LIKE ('%" + B_NombreProducto + "%') ", conexion);
            MySqlDataReader ejecuta = consulta.ExecuteReader();
            while (ejecuta.Read())
            {
                Producto Bproducto = new Producto();
                Bproducto.Cod_Producto = ejecuta.GetInt32(0);
                Bproducto.Cod_Bod_Producto = ejecuta.GetInt32(1);
                Bproducto.Sucursal_Bod_Producto = ejecuta.GetString(2);
                Bproducto.Cod_Prov_Producto = ejecuta.GetInt32(3);
                Bproducto.Nombre_Prov_Producto = ejecuta.GetString(4);
                Bproducto.Nombre_Producto = ejecuta.GetString(5);
                Bproducto.Stock_Producto = ejecuta.GetInt32(6);
                Bproducto.Stock_Min_Producto = ejecuta.GetInt32(7);
                Bproducto.Precio_Compra_Producto = ejecuta.GetDouble(8);
                Bproducto.Precio_Venta_Producto = ejecuta.GetDouble(9);
                Bproducto.Fecha_Caduca_Producto = ejecuta.GetDateTime(10);
                Bproducto.Iva_Producto = ejecuta.GetInt16(11);
                Bproducto.Estado_Producto = ejecuta.GetInt16(12);

                listaProduc.Add(Bproducto);
            }
            return listaProduc;
        }
        public static Producto ObtenerProducto(MySqlConnection conexion, int pCodProducto)
        {
            Producto pProducto = new Producto();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Obtener_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codProducto", pCodProducto);

            MySqlDataReader ejecuta = comando.ExecuteReader();
            while (ejecuta.Read())
            {
                pProducto.Cod_Producto = ejecuta.GetInt32(0);
                pProducto.Cod_Bod_Producto = ejecuta.GetInt32(1);
                pProducto.Sucursal_Bod_Producto = ejecuta.GetString(2);
                pProducto.Cod_Prov_Producto = ejecuta.GetInt32(3);
                pProducto.Nombre_Prov_Producto = ejecuta.GetString(4);
                pProducto.Nombre_Producto = ejecuta.GetString(5);
                pProducto.Stock_Producto = ejecuta.GetInt32(6);
                pProducto.Stock_Min_Producto = ejecuta.GetInt32(7);
                pProducto.Precio_Compra_Producto = ejecuta.GetDouble(8);
                pProducto.Precio_Venta_Producto = ejecuta.GetDouble(9);
                pProducto.Fecha_Caduca_Producto = ejecuta.GetDateTime(10);
                pProducto.Iva_Producto = ejecuta.GetInt16(11);
                pProducto.Estado_Producto = ejecuta.GetInt16(12);

            }
            return pProducto;
        }
        public static int EliminarProducto(MySqlConnection conexion, int pCodProducto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codProducto", pCodProducto);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int ModificarStockProducto(MySqlConnection conexion, int pCodProducto,int pValorExistencia)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Actualizar_Stock_Producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codProducto", pCodProducto);
            comando.Parameters.AddWithValue("@ValorExistencia", pValorExistencia);
            
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int llenaProducto(MySqlConnection conexion, DataGridView dgv, int pCodFactura)
        {
            DataTable dt;
            //MySqlCommand comando = new MySqlCommand();
            //comando.CommandText = "select SECUENCIAL,DESCRIPCION,CANTIDADXPRODUCTO,VALOR_UNITARIO,VALOR_TOTAL, 0 as Iva,CODIGO_FACTURA from detalle_factura where CODIGO_FACTURA="+ pCodFactura + "  ";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Connection = conexion;

            //comando.Parameters.AddWithValue("@codProducto", pCodFactura);

            MySqlDataAdapter ejecuta = new MySqlDataAdapter("select SECUENCIAL,DESCRIPCION,CANTIDADXPRODUCTO,VALOR_UNITARIO,VALOR_TOTAL, 0 as Iva,CODIGO_FACTURA from detalle_factura where CODIGO_FACTURA=" + pCodFactura + "  ",conexion);
            dt = new DataTable();
            ejecuta.Fill(dt);
            dgv.DataSource = dt;
            return 1;
        }

    }
}
