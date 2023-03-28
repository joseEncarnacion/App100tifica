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


        //Listar Registro
        public DataTable Datos_Listar()
        {
            SqlCommand cmd = new SqlCommand("sp_listar", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Insertar registro
        public void Datos_insertarEstudiante(CEestudiante est)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAREst", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mat", est.Matricula);
            cmd.Parameters.AddWithValue("@nom", est.nombreE);
            cmd.Parameters.AddWithValue("@carrer", est.carreraID);
            if(conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Eliminar registro en la base de datos
        public void Datos_Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_elimiarEstudiante", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MatriculaEst", id);
            if(conn.State==ConnectionState.Open) conn.Close();
            conn.Open() ;
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        //Actualizar resgistro 
        public void ActualizarDatos(CEestudiante est)
        {
            SqlCommand cmd = new SqlCommand("SP_EditarEst", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mat", est.Matricula);
            cmd.Parameters.AddWithValue("@nom", est.nombreE);
            cmd.Parameters.AddWithValue("@carrer", est.carreraID);
            if (conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }



    }



}