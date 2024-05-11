using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using static api_proyecto_gasolinera.Models.Bomba.csEstructuraBomba;


namespace api_proyecto_gasolinera.Models.Bomba
{
    public class csBomba
    {
        
        public responseBomba insertarBomba(int idBomba, int idTipoGasolina, double m_Gasolina, double Precio_Galon)
        {
            responseBomba result= new responseBomba();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {
               
                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "INSERT INTO Bomba(idbomba, idtipogasolina, m_gasolina, precio_galon) VALUES " +
                    "('" + idBomba + "', '" + idTipoGasolina + "', '" + m_Gasolina + "','" + Precio_Galon +"')";
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

        public responseBomba actualizarBomba(int idBomba, int idTipoGasolina, double m_Gasolina, double Precio_Galon)
        {
            responseBomba result = new responseBomba();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "UPDATE Bomba SET idtipogasolina = '"+idTipoGasolina+"', m_gasolina = '"+m_Gasolina+"', precio_galon = '"+ Precio_Galon + "' WHERE idbomba = '"+idBomba+"'";
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

        public responseBomba eliminarBomba(int idBomba)
        {
            responseBomba result = new responseBomba();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "delete from Bomba where idbomba = '" + idBomba + "'";
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

        public DataSet listarBomba()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Bomba";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "Lista";
                return dsi;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public DataSet listarBombaXid(int idBomba)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Bomba where idbomba='"+ idBomba + "'";
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