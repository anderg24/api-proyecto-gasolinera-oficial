using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using static api_proyecto_gasolinera.Models.Empleado.csEstructuraEmpleado;

namespace api_proyecto_gasolinera.Models.Empleado
{
    public class csEmpleado
    {
        
        public responseEmpleado insertarEmpleado(int idempleado, string nombre_empleado, string direccion, string telefono, string correo_electronico, string puesto)
        {
            responseEmpleado result= new responseEmpleado();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {
               
                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "INSERT INTO Empleado(idempleado, nombre_empleado, direccion, telefono, correo_electronico, puesto) VALUES " +
                    "('" + idempleado + "', '" + nombre_empleado + "', '" + direccion + "','" + telefono + "', '" + correo_electronico + "', '" + puesto + "')";
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

        public responseEmpleado actualizarEmpleado(int idempleado, string nombre_empleado, string direccion, string telefono, string correo_electronico, string puesto)
        {
            responseEmpleado result = new responseEmpleado();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "UPDATE Empleado SET nombre_empleado = '"+nombre_empleado+"', direccion = '"+direccion+"', telefono = '"+ telefono + "', correo_electronico = '"+correo_electronico+"', puesto = '"+puesto+"' WHERE idempleado = '"+idempleado+"'";
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

        public responseEmpleado eliminarEmpleado(int idempleado)
        {
            responseEmpleado result = new responseEmpleado();
            string conexion = "";
            SqlConnection con = null;
            conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            try
            {

                con = new SqlConnection(conexion);
                con.Open();
                string cadena = "delete from Empleado where idempleado = '" + idempleado + "'";
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

        public DataSet listarEmpleado()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Empleado";
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

        public DataSet listarEmpleadoXid(int idempleado)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            try
            {
                string cadena = "select * from Empleado where idempleado='"+idempleado+"'";
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