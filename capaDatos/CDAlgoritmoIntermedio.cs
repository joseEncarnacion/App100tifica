using capaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CDAlgoritmoIntermedio
    {
        //conexion con mi base de datos
        SqlConnection conn =
           new SqlConnection(ConfigurationManager.ConnectionStrings["dataConnex"].ConnectionString);



        public DataTable ListarAlgoritmoMed()
        {
            // int cantidad = 0;
            SqlCommand cmd = new SqlCommand("SP_listarAlgoritmosintermedio", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;

        }

        //Metodo para insertar algoritmo Intermedio

        public void CD_insertarAlgoritmoMed(CEalgoritmo algot)
        {
            SqlCommand cmd = new SqlCommand("SP_CrearAlgoritmoIntermedio", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", algot.titulo);
            cmd.Parameters.AddWithValue("@problem", algot.problema);
            cmd.Parameters.AddWithValue("@matric", algot.matricula);
            cmd.Parameters.AddWithValue("@comples", algot.complejidad);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }


        // Metodo para actualizar

        public void CD_ActualizarAlgoritmoMed(CEalgoritmo algot)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarAlgoritmoIntermedio", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", algot.titulo);
            cmd.Parameters.AddWithValue("@problem", algot.problema);
            cmd.Parameters.AddWithValue("@matric", algot.matricula);
            cmd.Parameters.AddWithValue("@comples", algot.complejidad);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }



        // metodo para eliminar 

        public void CD_EliminarAlgoritmoMed(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_EliminarAlgoritmoIntermedio");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idAlgBasico", id);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
