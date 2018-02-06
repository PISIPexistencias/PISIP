using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_Pisip.Clases
{
    public class Empleado
    {
        public int Cod_Empleado { get; set; }
        public int Cod_Bodega { get; set; }
        public string Sucursal_Bodega { get; set; }
        public string Cedula_Empleado { get; set; }
        public string Apellidos_Empleado { get; set; }
        public string Nombres_Empleado { get; set; }
        public string Cargo_Empleado { get; set; }
        public int Estado_empleado { get; set; }
        public Empleado()
        {
        }
        public Empleado(int pCodEmpleado, int pCodBodega, string pSucBodega ,string pCedEmpleado, string pApeEmpleado, string pNomEmpleado, string pCarEmpleado, int pEstEmpleado)
        {
            this.Cod_Empleado = pCodEmpleado;
            this.Cod_Bodega = pCodBodega;
            this.Sucursal_Bodega = pSucBodega;
            this.Cedula_Empleado = pCedEmpleado;
            this.Apellidos_Empleado = pApeEmpleado;
            this.Nombres_Empleado = pNomEmpleado;
            this.Cargo_Empleado = pCarEmpleado;
            this.Estado_empleado = pEstEmpleado;
        }
        public static int AgregarEmpleado(MySqlConnection conexion, Empleado pEmpleado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Insertar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codBodega", pEmpleado.Cod_Bodega);
            comando.Parameters.AddWithValue("@cedulaEmpleado", pEmpleado.Cedula_Empleado);
            comando.Parameters.AddWithValue("@apellidosEmpleado", pEmpleado.Apellidos_Empleado);
            comando.Parameters.AddWithValue("@nombres_Empleado", pEmpleado.Nombres_Empleado);
            comando.Parameters.AddWithValue("@cargoEmpleado", pEmpleado.Cargo_Empleado);
            comando.Parameters.AddWithValue("@estadoEmpleado", pEmpleado.Estado_empleado);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ModificarEmpleado(MySqlConnection conexion, Empleado pEmpleado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Actualizar_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codEmpleado", pEmpleado.Cod_Empleado);
            comando.Parameters.AddWithValue("@codBodega", pEmpleado.Cod_Bodega);
            comando.Parameters.AddWithValue("@cedulaEmpleado", pEmpleado.Cedula_Empleado);
            comando.Parameters.AddWithValue("@apellidosEmpleado", pEmpleado.Apellidos_Empleado);
            comando.Parameters.AddWithValue("@nombresEmpleado", pEmpleado.Nombres_Empleado);
            comando.Parameters.AddWithValue("@cargoEmpleado", pEmpleado.Cargo_Empleado);
            comando.Parameters.AddWithValue("@estadoEmpleado", pEmpleado.Estado_empleado);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static IList<Empleado> Busca_Empleado(MySqlConnection conexion, string B_Cedula, string B_Apellidos, String B_Nombres)
        {
            List<Empleado> listaEmp = new List<Empleado>();
            MySqlCommand consulta = new MySqlCommand("select CODIGO_EMPLEADO,e.CODIGO_BODEGA,b.SUCURSAL,CEDULA_EMPLEADO,APELLIDOS_EMPLEADO,NOMBRES_EMPLEADO,CARGO_EMPLEADO,ESTADO_EMPLEADO from empleados e,Bodega b where e.CODIGO_BODEGA=b.CODIGO_BODEGA and ESTADO_EMPLEADO=0 and  CEDULA_EMPLEADO LIKE ('%" + B_Cedula + "%') AND APELLIDOS_EMPLEADO LIKE ('%" + B_Apellidos + "%') AND  NOMBRES_EMPLEADO LIKE ('%" + B_Nombres + "%') ", conexion);
            MySqlDataReader ejecuta = consulta.ExecuteReader();
            while (ejecuta.Read())
            {
                Empleado Bempleado = new Empleado();
                Bempleado.Cod_Empleado = ejecuta.GetInt16(0);
                Bempleado.Cod_Bodega = ejecuta.GetInt16(1);
                Bempleado.Sucursal_Bodega = ejecuta.GetString(2);
                Bempleado.Cedula_Empleado = ejecuta.GetString(3);
                Bempleado.Apellidos_Empleado = ejecuta.GetString(4);
                Bempleado.Nombres_Empleado = ejecuta.GetString(5);
                Bempleado.Cargo_Empleado = ejecuta.GetString(6);
                Bempleado.Estado_empleado = ejecuta.GetInt16(7);

                listaEmp.Add(Bempleado);
            }
            return listaEmp;
        }
        public static Empleado ObtenerEmpleado(MySqlConnection conexion, int pCodEmpleado)
        {
            Empleado pEmpleado = new Empleado();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Obtener_Empleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codEmpleado", pCodEmpleado);

            MySqlDataReader ejecuta = comando.ExecuteReader();
            while (ejecuta.Read())
            {
                pEmpleado.Cod_Empleado = ejecuta.GetInt32(0);
                pEmpleado.Cod_Bodega = ejecuta.GetInt32(1);
                pEmpleado.Sucursal_Bodega = ejecuta.GetString(2);
                pEmpleado.Cedula_Empleado = ejecuta.GetString(3);
                pEmpleado.Apellidos_Empleado = ejecuta.GetString(4);
                pEmpleado.Nombres_Empleado = ejecuta.GetString(5);
                pEmpleado.Cargo_Empleado = ejecuta.GetString(6);
                pEmpleado.Estado_empleado = ejecuta.GetInt16(7);

            }
            return pEmpleado;
        }
        public static int EliminarEmpleado(MySqlConnection conexion, int pCodEmpleado)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_EliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codEmpleado", pCodEmpleado);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
