using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using static api_proyecto_gasolinera.Models.Tipo_de_gasolina.csEstructuraTipo_de_gasolina;


namespace api_proyecto_gasolinera.Models.Tipo_de_gasolina
{
    public class csTipo_de_gasolina
    {

        public responseTipo_de_gasolina insertarTipo_de_gasolina(int idtipogasolina, string descripcion)
        {
            responseTipo_de_gasolina result = new responseTipo_de_gasolina();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "INSERT INTO Tipo_de_gasolina(idtipogasolina, descripcion) VALUES " +
                    "('" + idtipogasolina + "', '" + descripcion + "')";
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

        public responseTipo_de_gasolina actualizarTipo_de_gasolina(int idtipogasolina, string descripcion)
        {
            responseTipo_de_gasolina result = new responseTipo_de_gasolina();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "UPDATE Tipo_de_gasolina SET descripcion = '" + descripcion + "' WHERE idtipogasolina = '" + idtipogasolina + "'";
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

        public responseTipo_de_gasolina eliminarTipo_de_gasolina(int idtipogasolina)
        {
            responseTipo_de_gasolina result = new responseTipo_de_gasolina();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "delete from Tipo_de_gasolina where idtipogasolina = '" + idtipogasolina + "'";
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

        public DataSet listarTipo_de_gasolina()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Tipo_de_gasolina";
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

        public DataSet listarTipo_de_gasolinaXid(int idtipogasolina)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Tipo_de_gasolina where idtipogasolina='" + idtipogasolina + "'";
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