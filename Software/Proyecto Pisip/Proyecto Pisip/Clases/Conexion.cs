using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace Proyecto_Pisip.Clases
{
    public class Conexion
    {
        public MySqlConnection conexion;
        public Conexion()
        {
            //conexion = new MySqlConnection("server=127.0.0.1; port=3306; database=existencias; Uid=root; pwd=rtmysql2014");
            conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConectaMySql"].ConnectionString);
            
        }
        public bool AbrirConexion()
        {
            try
            {
                if (Convert.ToBoolean(conexion.State) == false)
                {
                    conexion.Open();
                    
                }
                return true;

            }
            catch(MySqlException ex)
            {
                return false;
                throw ex;

            }

        }
        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;

            }
        }
    }
}
