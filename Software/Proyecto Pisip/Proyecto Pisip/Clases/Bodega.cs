using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Pisip.Clases
{
    public class Bodega
    {
        public int Cod_Bodega { get; set; }
        public string Sucursal_Bodega { get; set; }
        public string Direccion_Bodega { get; set; }
        public string Fono_Bodega { get; set;}

        public Bodega()
        {
        }
        public Bodega(int pCodBodega,string pSucursalBodega, string pDireccionBodega,string pFonoBodega)
        {
            this.Cod_Bodega = pCodBodega;
            this.Sucursal_Bodega = pSucursalBodega;
            this.Direccion_Bodega = pDireccionBodega;
            this.Fono_Bodega = pFonoBodega;
        }

        public static IList<Bodega> Busca_Bodega(MySqlConnection conexion, String B_Sucursal)
        {
            List<Bodega> listaBodega = new List<Bodega>();
            MySqlCommand consulta = new MySqlCommand("select CODIGO_BODEGA,SUCURSAL,DIRECCION_BODEGA,FONO_BODEGA from bodega where SUCURSAL LIKE ('%" + B_Sucursal + "%') ", conexion);
            MySqlDataReader ejecuta = consulta.ExecuteReader();
            while (ejecuta.Read())
            {
                Bodega Bbodega = new Bodega();
                Bbodega.Cod_Bodega = ejecuta.GetInt32(0);
                Bbodega.Sucursal_Bodega = ejecuta.GetString(1);
                Bbodega.Direccion_Bodega = ejecuta.GetString(2);
                Bbodega.Fono_Bodega = ejecuta.GetString(3);
                

                listaBodega.Add(Bbodega);
            }
            return listaBodega;
        }


    }
}
