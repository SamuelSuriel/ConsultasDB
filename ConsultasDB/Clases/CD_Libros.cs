using Microsoft.Data.SqlClient;
using System.Data;

namespace ConsultasDB.Clases
{
    public class CD_Libros
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarLibros()
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcMostrarLibros";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void InsertarLibro(string titulo, int paginas, int idMateria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcInsertarLibros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@paginas", paginas);
            comando.Parameters.AddWithValue("@idMateria", idMateria);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void EditarLibro(int id, string titulo, int paginas, int idMateria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEditarLibro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Titulo", titulo);
            comando.Parameters.AddWithValue("@paginas", paginas);
            comando.Parameters.AddWithValue("@idMateria", idMateria);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarLibro(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prcEliminarLibro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
