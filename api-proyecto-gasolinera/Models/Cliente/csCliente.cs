using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using static api_proyecto_gasolinera.Models.Cliente.csEstructuraCliente;

namespace api_proyecto_gasolinera.Models.Cliente
{
    public class csCliente
    {
        public responseCliente insertarCliente(int Nit, string Nombre, string Veiculo)
        {
            responseCliente result = new responseCliente();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "INSERT INTO Cliente(nit, nombre_cliente, tipo_vehiculo) VALUES ('" + Nit + "', '" + Nombre + "', '" + Veiculo + "')";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message.ToString();
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }

            return result;
        }

        public responseCliente actualizarCliente(int Nit, string Nombre, string Veiculo)
        {
            responseCliente result = new responseCliente();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "UPDATE Cliente SET nombre_cliente = '" + Nombre + "', tipo_vehiculo = '" + Veiculo + "' WHERE nit = '" + Nit + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message.ToString();
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }

            return result;
        }

        public responseCliente eliminarCliente(int Nit)
        {
            responseCliente result = new responseCliente();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "DELETE FROM Cliente WHERE nit = '" + Nit + "'";
                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operación realizada exitosamente";
            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrió un error al realizar la transacción, descripción del error: " + ex.Message.ToString();
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }

            return result;
        }

        public DataSet listarClientes()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                string cadena = "SELECT * FROM Cliente";
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

        public DataSet listarClientePorNit(int Nit)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);

            try
            {
                con.Open();
                string cadena = "SELECT * FROM Cliente WHERE nit = '" + Nit + "'";
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