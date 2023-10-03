using Microsoft.Data.SqlClient;
using System.Data;

namespace ConsultasDB.Clases
{
    public class CD_Conexion
    {
        public SqlConnection Conexion = new SqlConnection(@"server=LEVHDLL; Database=BibliotecaDB; integrated security =True; TrustServerCertificate=True");

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
