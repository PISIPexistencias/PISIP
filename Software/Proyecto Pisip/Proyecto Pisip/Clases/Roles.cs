﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Proyecto_Pisip.Clases
{
    public class Roles
    {
        public string Cod_Usuario_RolUsuario { get; set; }
        public int Cod_Rol_RolUsuario { get; set; }
        public int Primer_Ingreso_RolUsuario { get; set; }
        public int Estado_RolUsuario { get; set; }
        public Roles()
        {
        }
        public Roles(string pCodUsuarioRolUsuario, int pRolRolUsuario, int pPrimerIngresoRolUsuario, int pEstadoRolUsuario)
        {
            this.Cod_Usuario_RolUsuario = pCodUsuarioRolUsuario;
            this.Cod_Rol_RolUsuario = pRolRolUsuario;
            this.Primer_Ingreso_RolUsuario = pPrimerIngresoRolUsuario;
            this.Estado_RolUsuario = pEstadoRolUsuario;


        }
        //public static int AgregarProveedor(MySqlConnection conexion, Proveedor pProveedor)
        //{
        //    int retorno = 0;
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandText = "PA_Insertar_Proveedor";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;

        //    //comando.Parameters.AddWithValue("@codProvee", pProveedor.Cod_Proveedor);
        //    comando.Parameters.AddWithValue("@rucProvee", pProveedor.Ruc_Proveedor);
        //    comando.Parameters.AddWithValue("@nombreprovee", pProveedor.Nombre_Proveedor);
        //    comando.Parameters.AddWithValue("@direccionProvee", pProveedor.Direccion_Proveedor);
        //    comando.Parameters.AddWithValue("@fonoProvee", pProveedor.Fono_Proveedor);
        //    comando.Parameters.AddWithValue("@contactoprovee", pProveedor.Contacto_Proveedor);
        //    comando.Parameters.AddWithValue("@estadoprovee", pProveedor.Estado_Proveedor);
        //    retorno = comando.ExecuteNonQuery();
        //    return retorno;
        //}

        public static int ModificarRolesPrimeraVez(MySqlConnection conexion, string pCodUsuario)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "PA_Actualizar_Roles";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            comando.Parameters.AddWithValue("@codUsuario", pCodUsuario);
            comando.Parameters.AddWithValue("@primeraVez", 2);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //public static IList<Proveedor> Busca_Proveedor(MySqlConnection conexion, string B_Ruc, String B_Nombres)
        //{
        //    List<Proveedor> listaEmp = new List<Proveedor>();
        //    MySqlCommand consulta = new MySqlCommand("select CODIGO_PROVEEDOR,RUC_PROVEEDOR,NOMBRE_PROVEEDOR,DIRECCION_PROVEEDOR,FONO_PROVEEDOR,CONTACTO_PROVEEDOR,ESTADO_PROVEEDOR from proveedores where RUC_PROVEEDOR LIKE ('%" + B_Ruc + "%') AND  NOMBRE_PROVEEDOR LIKE ('%" + B_Nombres + "%') AND ESTADO_PROVEEDOR=0", conexion);
        //    MySqlDataReader ejecuta = consulta.ExecuteReader();
        //    while (ejecuta.Read())
        //    {
        //        Proveedor Bproveedor = new Proveedor();
        //        Bproveedor.Cod_Proveedor = ejecuta.GetInt32(0);
        //        Bproveedor.Ruc_Proveedor = ejecuta.GetString(1);
        //        Bproveedor.Nombre_Proveedor = ejecuta.GetString(2);
        //        Bproveedor.Direccion_Proveedor = ejecuta.GetString(3);
        //        Bproveedor.Fono_Proveedor = ejecuta.GetString(4);
        //        Bproveedor.Contacto_Proveedor = ejecuta.GetString(5);
        //        Bproveedor.Estado_Proveedor = ejecuta.GetInt16(6);

        //        listaEmp.Add(Bproveedor);
        //    }
        //    return listaEmp;
        //}
        //public static Proveedor ObtenerProveedor(MySqlConnection conexion, int pcodProvee)
        //{
        //    Proveedor pProveedor = new Proveedor();
        //    MySqlCommand comando = new MySqlCommand();
        //    comando.CommandText = "PA_Obtener_Proveedor";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    comando.Connection = conexion;

        //    comando.Parameters.AddWithValue("@codProvee", pcodProvee);

        //    MySqlDataReader ejecuta = comando.ExecuteReader();
        //    while (ejecuta.Read())
        //    {
        //        pProveedor.Cod_Proveedor = ejecuta.GetInt32(0);
        //        pProveedor.Ruc_Proveedor = ejecuta.GetString(1);
        //        pProveedor.Nombre_Proveedor = ejecuta.GetString(2);
        //        pProveedor.Direccion_Proveedor = ejecuta.GetString(3);
        //        pProveedor.Fono_Proveedor = ejecuta.GetString(4);
        //        pProveedor.Contacto_Proveedor = ejecuta.GetString(5);
        //        pProveedor.Estado_Proveedor = ejecuta.GetInt16(6);

        //    }
        //    return pProveedor;
        //}
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
    }
}
