using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using static api_proyecto_gasolinera.Models.Forma_de_pago.csEstructuraForma_de_pago;
using static api_proyecto_gasolinera.Models.Forma_de_pago.csForma_de_pago;


namespace api_proyecto_gasolinera.Models.Forma_de_pago
{
    public class csForma_de_pago
    {

        public responseForma_de_pago insertarForma_de_pago(int idformapago, string descripcion)
        {
            responseForma_de_pago result = new responseForma_de_pago();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "INSERT INTO Forma_de_pago(idformapago, descripcion) VALUES " +
                    "('" + idformapago + "','" + descripcion + "')";
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

        public responseForma_de_pago actualizarForma_de_pago(int idformapago, string descripcion)
        {
            responseForma_de_pago result = new responseForma_de_pago();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "UPDATE Forma_de_pago SET idformapago = '" + idformapago + "', descripcion = '" + descripcion + "' WHERE idformapago = '" + idformapago + "'";
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

        public responseForma_de_pago eliminarForma_de_pago(int idformapago)
        {
            responseForma_de_pago result = new responseForma_de_pago();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "delete from Forma_de_pago where idformapago = '" + idformapago + "'";
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

        public DataSet listarForma_de_pago()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Forma_de_pago";
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

        public DataSet listarForma_de_pagoXid(int idformapago)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Forma_de_pago where idformapago='" + idformapago + "'";
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