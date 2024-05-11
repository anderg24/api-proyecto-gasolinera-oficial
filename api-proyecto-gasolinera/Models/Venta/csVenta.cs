using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static api_proyecto_gasolinera.Models.Ventas.CSEstructuraVentas;

namespace api_proyecto_gasolinera.Models.Ventas
{
    public class csVenta
    {
        public responseVenta InsertarVenta(string idVenta, string nit, int idEmpleado, int idFormapago, int idTipoGasolina, int idBomba, DateTime fecha, int total_venta)
        {
            responseVenta result = new responseVenta();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                string cadena = "INSERT INTO Venta (idventa, nit, idempleado, idformapago, idtipogasolina, idbomba, fecha, total_venta) VALUES " +
                                "('" + idVenta + "', '" + nit + "', '" + idEmpleado + "', '" + idFormapago + "', '" + idTipoGasolina + "', '" + idBomba + "', '" + fecha + "', '" + total_venta + "')";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message.ToString();
            }
           
                con.Close();
            

            return result;
        }

        public responseVenta ActualizarVenta(string idVenta, string nit, int idEmpleado, int idFormapago, int idTipoGasolina, int idBomba, DateTime fecha, int total_venta)
        {
            responseVenta result = new responseVenta();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                string cadena = "UPDATE Venta SET nit = '" + nit + "', idempleado = '" + idEmpleado + "', idformapago = '" + idFormapago + "', idtipogasolina = '" + idTipoGasolina + "', idbomba = '" + idBomba + "', fecha = '" + fecha + "', total_venta = '" + total_venta + "' WHERE idventa = '" + idVenta + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message.ToString();
            }
           
                con.Close();
            

            return result;
        }

        public responseVenta EliminarVenta(string idVenta)
        {
            responseVenta result = new responseVenta();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                string cadena = "DELETE FROM Venta WHERE idventa = '" + idVenta + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message.ToString();
            }
           
                con.Close();
            

            return result;
        }

        public DataSet ListarVenta()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                try
                {
                    string cadena = "SELECT * FROM Venta";
                    SqlCommand cmd = new SqlCommand(cadena, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsi);
                    dsi.Tables[0].TableName = "Lista";
                    return dsi;
                }
                catch (Exception ex)
                {
                    // Manejar excepciones aquí
                    return null;
                }
            }
        }

        public DataSet ListarVentaXId(string idVenta)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                try
                {
                    string cadena = "SELECT * FROM Venta WHERE idventa='" + idVenta + "'";
                    SqlCommand cmd = new SqlCommand(cadena, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dsi);
                    dsi.Tables[0].TableName = "Lista";
                    return dsi;
                }
                catch (Exception ex)
                {
                    // Manejar excepciones aquí
                    return null;
                }
            }
        }

    }
}
