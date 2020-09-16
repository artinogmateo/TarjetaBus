using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class D_Persona : D_Datos
    {
        private D_Datos conexion = new D_Datos();

        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "MostrarPersonass";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            conexion.CerrarConexion();
            return dt;
        }

        public DataTable ExisteTarjeta()
        {
            dt.Clear();
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "TarjetaExiste";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            conexion.CerrarConexion();
            return dt;
        }

        public void Insertar(E_Persona persona)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "InsetarPersonass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombrePersonass", persona.nombresPersona);
            cmd.Parameters.AddWithValue("@apellidoPersona", persona.apellidosPersona);
            cmd.Parameters.AddWithValue("@tipoDocumento", persona.tipoDocumento);
            cmd.Parameters.AddWithValue("@ndocumento", persona.documentoNumero);
            cmd.Parameters.AddWithValue("@cUIL", persona.CUIL);
            cmd.Parameters.AddWithValue("@fechaNacimiento", persona.fechaNacimiento);
            cmd.Parameters.AddWithValue("@edad", persona.edadPersona);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Editar(E_Persona persona)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EditarPersonass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombrePersonass", persona.nombresPersona);
            cmd.Parameters.AddWithValue("@apellidoPersona", persona.apellidosPersona);
            cmd.Parameters.AddWithValue("@tipoDocumento", persona.tipoDocumento);
            cmd.Parameters.AddWithValue("@ndocumento", persona.documentoNumero);
            cmd.Parameters.AddWithValue("@cUIL", persona.CUIL);
            cmd.Parameters.AddWithValue("@fechaNacimiento", persona.fechaNacimiento);
            cmd.Parameters.AddWithValue("@edad", persona.edadPersona);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Eliminar(int ndocumentoPers)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EliminarPersonass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ndocumentoPers", ndocumentoPers);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public bool ExisteNroDocumento(int NumeroDocumento)
        {
            bool existe = false;

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "ExisteNroDocumento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroDocumento", NumeroDocumento);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                existe = (dr.HasRows);
            }
            cmd.Parameters.Clear();
            return existe;
        }

        public bool ExisteTarjetaAsociada(int NumeroDocumento)
        {
            bool existe = false;

            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "ExisteTarjetaAsociada";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroDocumento", NumeroDocumento);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                existe = (dr.HasRows);
            }
            cmd.Parameters.Clear();
            return existe;

        }
    }
}
