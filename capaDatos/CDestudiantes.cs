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
        public void Seleccionador()
        {
            Random random = new Random();
            int max_id = 10; 
            int random_id = random.Next(1, max_id + 1);

            Conection.open();
            command.Parameters.AddWithValue("@id", random_id);
            command.Parameters.AddWithValue("@nivel", "basico");

            if (reader.Read())
            {
                string algoritmo = reader.GetString(0);
                Console.WriteLine(algoritmo); // o reemplaza por tu método para presentar el algoritmo en pantalla
            }
            else
            {
                Console.WriteLine("No se encontró ningún algoritmo con el ID y nivel especificados");

            }
    }


   
}