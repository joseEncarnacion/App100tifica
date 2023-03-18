using capaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace capaDatos
{
    public class CDestudiantes
    {
        SqlConnection conn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["dataConnex"].ConnectionString);



        public DataTable Datos_Listar()
        {
            SqlCommand cmd = new SqlCommand("sp_listar", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Datos_insertarEstudiante(CEestudiante est)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarEstudinte", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mat", est.Matricula);
            cmd.Parameters.AddWithValue("@nom", est.nombreE);
            cmd.Parameters.AddWithValue("@carrer", est.carreraID);
            if(conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }



}