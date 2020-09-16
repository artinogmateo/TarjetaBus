using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// ///////////////// está esta lista... no se toca mas /////////////////////////////
/// </summary>
namespace Datos
{
    public  class D_Datos
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=ARTINO;Initial Catalog=TrabajandoEnCapas_ok;Integrated Security=True");

        

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
