using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static api_proyecto_gasolinera.Models.Abasto.csEstructuraAbasto;

namespace api_proyecto_gasolinera.Models.Abasto
{
    public class csAbasto
    {
        public responseAbasto InsertarAbasto(string idAbasto, int idBomba, string nombreProveedor, double cantidadGalones, double precioPorM3, double costoTotal)
        {
            responseAbasto result = new responseAbasto();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string cadena = "INSERT INTO Abastecimiento (idabastecimiento, idbomba, nombre_proveedor, cantidad_galones, precio_por_m3, costo_total) VALUES " +
                        "('" + idAbasto + "', '" + idBomba + "', '" + nombreProveedor + "','" + cantidadGalones + "','" + precioPorM3 + "','" + costoTotal + "')";
                    SqlCommand cmd = new SqlCommand(cadena, con);
                    result.respuesta = cmd.ExecuteNonQuery();
                    result.descripcion_respuesta = "Operación realizada exitosamente";
                }
                catch (Exception ex)
                {
                    result.respuesta = 0;
                    result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message;
                }
            }

            return result;
        }

        public responseAbasto ActualizarAbasto(string idAbasto, int idBomba, string nombreProveedor, double cantidadGalones, double precioPorM3, double costoTotal)
        {
            responseAbasto result = new responseAbasto();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string cadena = "UPDATE Abastecimiento SET idbomba = '" + idBomba + "', nombre_proveedor = '" + nombreProveedor + "', cantidad_galones = '" + cantidadGalones + "'," +
                        " precio_por_m3 = '" + precioPorM3 + "', costo_total = '" + costoTotal + "' WHERE idabastecimiento = '" + idAbasto + "'";
                    SqlCommand cmd = new SqlCommand(cadena, con);
                    result.respuesta = cmd.ExecuteNonQuery();
                    result.descripcion_respuesta = "Operación realizada exitosamente";
                }
                catch (Exception ex)
                {
                    result.respuesta = 0;
                    result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message;
                }
            }

            return result;
        }

        public responseAbasto EliminarAbasto(string idAbasto)
        {
            responseAbasto result = new responseAbasto();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string cadena = "DELETE FROM Abastecimiento WHERE idabastecimiento = '" + idAbasto + "'";
                    SqlCommand cmd = new SqlCommand(cadena, con);
                    result.respuesta = cmd.ExecuteNonQuery();
                    result.descripcion_respuesta = "Operación realizada exitosamente";
                }
                catch (Exception ex)
                {
                    result.respuesta = 0;
                    result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message;
                }
            }

            return result;
        }

        public DataSet ListarAbasto()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string cadena = "SELECT * FROM Abastecimiento";
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

        public DataSet ListarAbastoXid(string idAbasto)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string cadena = "SELECT * FROM Abastecimiento WHERE idabastecimiento = '" + idAbasto + "'";
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
}
