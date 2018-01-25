using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        public static IList<Cliente> Busca_Cliente(MySqlConnection conexion, string B_Cedula, string B_Apellidos, String B_Nombres)
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlCommand consulta = new MySqlCommand(string.Format("select ID_CLIENTE, CEDULA, APELLIDOS, NOMBRES, CORREO_CLIENTE, DIRECCION_CLIENTE, TELEFONO_CLIENTE from cliente where CEDULA like('%(0)%') and APELLIDOS like('%(1)%') and NOMBRES like('%(2)%')",B_Cedula,B_Apellidos,B_Nombres), conexion );
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
    }
}
