
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class D_Tarjeta
    {
        private D_Datos conexion = new D_Datos();

        SqlDataReader dr;
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "MostrarTarjetass";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            conexion.CerrarConexion();
            return dt;
        }

        public void Insertar(E_Tarjeta tarjeta)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "InsetarTarjetass";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroTarjetass", tarjeta.numeroTarjeta);
                cmd.Parameters.AddWithValue("@dniTarjetass", tarjeta.documentoPersonaTarjeta);
                cmd.Parameters.AddWithValue("@saldo", tarjeta.saldoTarjeta);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Connection = conexion.CerrarConexion();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void Editar(E_Tarjeta tarjeta)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EditarTarjetass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dniTarjetass", tarjeta.documentoPersonaTarjeta);
            cmd.Parameters.AddWithValue("@numeroTarjetass", tarjeta.numeroTarjeta);
            cmd.Parameters.AddWithValue("@saldo", tarjeta.saldoTarjeta);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void Eliminar(int numeroTarjetass)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "EliminarTarjetass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroTarjetass", numeroTarjetass);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public void CargarSaldo_PagarPasaje(E_Tarjeta tarjeta)
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "CargarSaldo_PagarPasaje";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dniTarjetass", tarjeta.documentoPersonaTarjeta);
            cmd.Parameters.AddWithValue("@numeroTarjetass", tarjeta.numeroTarjeta);
            cmd.Parameters.AddWithValue("@saldo", tarjeta.saldoTarjeta);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public bool ExisteNroTarjeta(int NumeroTarjeta)
        {
            bool existe = false;

            cmd.Connection = conexion.AbrirConexion(); 
            cmd.CommandText = "ExisteNroTarjeta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroTarjeta", NumeroTarjeta);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                existe = (dr.HasRows);
            }
            cmd.Parameters.Clear();
            return existe;
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
    }
}
