using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using static api_proyecto_gasolinera.Models.Usuario.csEstructuraUsuario;

namespace api_proyecto_gasolinera.Models.Usuario
{
    public class csUsuario
    {

        public responseUsuario insertarUsuario(int idusuario, int idempleado, string contraseña, string alias, string pasatiempos, string correo_alternativo)
        {
            responseUsuario result = new responseUsuario();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "INSERT INTO Usuario(idusuario, idempleado, contraseña, alias, pasatiempos, correo_alternativo) VALUES " +
                    "('" + idusuario + "', '" + idempleado + "', '" + contraseña + "','" + alias + "', '" + pasatiempos + "', '" + correo_alternativo + "')";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operacion realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrio un error al realizar la transaccion, descripcion del error: " + ex.Message.ToString();

            }
            con.Close();
            return result;

        }

        public responseUsuario actualizarUsuario(int idusuario, int idempleado, string contraseña, string alias, string pasatiempos, string correo_alternativo)
        {
            responseUsuario result = new responseUsuario();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "UPDATE Usuario SET idempleado= '"+idempleado+"', contraseña = '" + contraseña + "', alias = '" + alias + "', pasatiempos = '" + pasatiempos + "', correo_alternativo = '" + correo_alternativo + "' WHERE idusuario = '" + idusuario + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operacion realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrio un error al realizar la transaccion, descripcion del error: " + ex.Message.ToString();

            }
            con.Close();
            return result;

        }

        public responseUsuario eliminarUsuario(int idusuario)
        {
            responseUsuario result = new responseUsuario();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "delete from Usuario where idusuario = '" + idusuario + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operacion realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrio un error al realizar la transaccion, descripcion del error: " + ex.Message.ToString();

            }
            con.Close();
            return result;

        }

        public DataSet ListarUsuario()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Usuario";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Lista";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataSet ListarUsuarioXid(int usuario)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from usuario where idusuario='" + usuario + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Lista";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}