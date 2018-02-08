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
    
    public class Usuario
    {

        public string Cod_Usuario { get; set; }
        public int Cod_Empl_Usuario { get; set; }
        public string Clave_Usuario { get; set; }
        public int Estado_Usuario { get; set; }
        public string Apellido_Empl_Usuario { get; set; }
        public string Nombre_Empl_Usuario { get; set; }
        public string Perfil_Rol_Usuario { get; set; }

        public Usuario()
        {
        }
        public Usuario(string pCodUsuario, int pCodEmpleado, string pClaveUsuario, int pEstadoUsuario, string pApeEmplUsuario, string pNomEmplUsuario, string pPerfRolUsuario)
        {
            this.Cod_Usuario = pCodUsuario;
            this.Cod_Empl_Usuario = pCodEmpleado;
            this.Clave_Usuario = pClaveUsuario;
            this.Estado_Usuario = pEstadoUsuario;
            this.Apellido_Empl_Usuario = pApeEmplUsuario;
            this.Nombre_Empl_Usuario = pNomEmplUsuario;
            this.Perfil_Rol_Usuario = pPerfRolUsuario;

        }
        public static int AgregarProveedor(MySqlConnection conexion, Proveedor pProveedor)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Insertar_Proveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            //comando.Parameters.AddWithValue("@codProvee", pProveedor.Cod_Proveedor);
            comando.Parameters.AddWithValue("@rucProvee", pProveedor.Ruc_Proveedor);
            comando.Parameters.AddWithValue("@nombreprovee", pProveedor.Nombre_Proveedor);
            comando.Parameters.AddWithValue("@direccionProvee", pProveedor.Direccion_Proveedor);
            comando.Parameters.AddWithValue("@fonoProvee", pProveedor.Fono_Proveedor);
            comando.Parameters.AddWithValue("@contactoprovee", pProveedor.Contacto_Proveedor);
            comando.Parameters.AddWithValue("@estadoprovee", pProveedor.Estado_Proveedor);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //public static int ModificarProveedor(MySqlConnection conexion, Proveedor pProveedor)
        //{
        //    int retorno = 0;
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandText = "PA_Actualizar_Proveedor";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;

        //    comando.Parameters.AddWithValue("@codProvee", pProveedor.Cod_Proveedor);
        //    comando.Parameters.AddWithValue("@rucProvee", pProveedor.Ruc_Proveedor);
        //    comando.Parameters.AddWithValue("@nombreProvee", pProveedor.Nombre_Proveedor);
        //    comando.Parameters.AddWithValue("@direccionProvee", pProveedor.Direccion_Proveedor);
        //    comando.Parameters.AddWithValue("@fonoProvee", pProveedor.Fono_Proveedor);
        //    comando.Parameters.AddWithValue("@contactoProvee", pProveedor.Contacto_Proveedor);
        //    comando.Parameters.AddWithValue("@estadoprovee", pProveedor.Estado_Proveedor);
        //    retorno = comando.ExecuteNonQuery();
        //    return retorno;
        //}

        public static IList<Usuario> Busca_Usuario(MySqlConnection conexion, string B_CodUsuario, String B_ApellidosUsu,String B_NombresUsu)
        {
            List<Usuario> listaUsu = new List<Usuario>();
            MySqlCommand consulta = new MySqlCommand("select u.CODIGO_USUARIO,u.CODIGO_EMPLEADO,CLAVE_USUARIO,ESTADO_USUARIO,APELLIDOS_EMPLEADO,NOMBRES_EMPLEADO,DESCRIPCION_ROL from usuario u, empleados e, roles r, usuario_rol ur where u.CODIGO_EMPLEADO = e.CODIGO_EMPLEADO and u.CODIGO_USUARIO = ur.CODIGO_USUARIO and ur.CODIGO_ROL = r.CODIGO_ROL and u.CODIGO_USUARIO LIKE ('%" + B_CodUsuario + "%') AND  NOMBRES_EMPLEADO LIKE ('%" + B_NombresUsu + "%')  AND  APELLIDOS_EMPLEADO LIKE ('%" + B_ApellidosUsu + "%') ", conexion);
            MySqlDataReader ejecuta = consulta.ExecuteReader();
            while (ejecuta.Read())
            {
                Usuario Busuario = new Usuario();
                Busuario.Cod_Usuario = ejecuta.GetString(0);
                Busuario.Cod_Empl_Usuario = ejecuta.GetInt32(1);
                Busuario.Clave_Usuario = ejecuta.GetString(2);
                Busuario.Estado_Usuario = ejecuta.GetInt16(3);
                Busuario.Apellido_Empl_Usuario = ejecuta.GetString(4);
                Busuario.Nombre_Empl_Usuario = ejecuta.GetString(5);
                Busuario.Perfil_Rol_Usuario = ejecuta.GetString(6);

                listaUsu.Add(Busuario);
            }
            return listaUsu;
        }
        public static Usuario ObtenerUsuario(MySqlConnection conexion, string pcodUsuario)
        {
            Usuario pUsuario = new Usuario();
            MySqlCommand comando = new MySqlCommand("select u.CODIGO_USUARIO,u.CODIGO_EMPLEADO,CLAVE_USUARIO,ESTADO_USUARIO,APELLIDOS_EMPLEADO,NOMBRES_EMPLEADO,DESCRIPCION_ROL from usuario u, empleados e, roles r, usuario_rol ur where u.CODIGO_EMPLEADO = e.CODIGO_EMPLEADO and u.CODIGO_USUARIO = ur.CODIGO_USUARIO and ur.CODIGO_ROL = r.CODIGO_ROL and u.CODIGO_USUARIO LIKE ('%" + pcodUsuario + "%') ", conexion); 
            //comando.CommandText = "PA_Obtener_Usuario";
            //comando.CommandType = CommandType.StoredProcedure;
            //comando.Connection = conexion;

            //comando.Parameters.AddWithValue("@codUsuario", pcodUsuario);

            MySqlDataReader ejecuta = comando.ExecuteReader();
            while (ejecuta.Read())
            {
                pUsuario.Cod_Usuario = ejecuta.GetString(0);
                pUsuario.Cod_Empl_Usuario = ejecuta.GetInt32(1);
                pUsuario.Clave_Usuario = ejecuta.GetString(2);
                pUsuario.Estado_Usuario = ejecuta.GetInt16(3);
                pUsuario.Apellido_Empl_Usuario = ejecuta.GetString(4);
                pUsuario.Nombre_Empl_Usuario = ejecuta.GetString(5);
                pUsuario.Perfil_Rol_Usuario = ejecuta.GetString(6);


            }
            return pUsuario;
        }
        //public static int EliminarProveedor(MySqlConnection conexion, int pCodprovee)
        //{
        //    int retorno = 0;
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandText = "PA_EliminarProveedor";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;

        //    comando.Parameters.AddWithValue("@codProvee", pCodprovee);
        //    retorno = comando.ExecuteNonQuery();
        //    return retorno;
        //}

        public void CargaRol(MySqlConnection conexion, ComboBox Combo)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "Roles";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;
            MySqlDataAdapter llena = new MySqlDataAdapter(comando);

            DataTable dt = new DataTable();
            llena.Fill(dt);
            Combo.DataSource = dt;
            Combo.ValueMember = "CODIGO_ROL";
            Combo.DisplayMember = "DESCRIPCION_ROL";
        }
    }
}
