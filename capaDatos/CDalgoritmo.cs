using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace capaDatos
{
    public class CDalgoritmo
    {

        /*Nota importante:
         *  deben crear la base de datos en su sql server llamada ==> appcientifica <==
         */


        //conexion con mi base de datos
        SqlConnection conn =
           new SqlConnection(ConfigurationManager.ConnectionStrings["dataConnex"].ConnectionString);


        // Metodo para termino de busqueda del algoritmo
        // aqui se creara solo el metodo que va a consultar con la base de datos

       /* public string cantidadAlgoritmo222()
        {
             //int cantidad = 0;
            SqlCommand cmd = new SqlCommand("SP_countarprueba", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            string dato = adapter.ToString();

            //cantidad= Convert.ToInt32(dato);
            //SqlCommand cmd = new SqlCommand("SP_countarAlgoritmos", conn);

            return dato;
        }*/

        

            public DataTable cantidadAlgoritmo()
            {
            // int cantidad = 0;
                  SqlCommand cmd = new SqlCommand("SP_listarAlgoritmosBasicos", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;


            }


        //buscar Por termino de busquedace

        //basico
        public DataTable CD_buscarAlgoritmoBasico(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarUnAlgoritmoBasico", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idalgot", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            adapter.Fill(dt);

            return dt;

        }
         
        //intermedio
        public DataTable CD_buscarAlgoritmoIntermedio(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarUnAlgoritmoBasico", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idalgot", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;

        }

        //Metodo para insertar algoritmo

        public void CD_insertarAlgoritmo(CEalgoritmo algot)
        {
            SqlCommand cmd = new SqlCommand("SP_CrearAlgoritmo", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", algot.titulo);
            cmd.Parameters.AddWithValue("@problem", algot.problema);
            cmd.Parameters.AddWithValue("@matric", algot.matricula);
            cmd.Parameters.AddWithValue("@comples", algot.complejidad);
            if(conn.State == ConnectionState.Open) conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }


        // Metodo para actualizar

        public void CD_ActualizarAlgoritmo(CEalgoritmo algot)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ActualizarAlgoritmo", conn);
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           


        }



        // metodo para eliminar 

        public void CD_EliminarAlgoritmo(int id)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_EliminarAlgoritmo");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlgBasico", id);
                if (conn.State == ConnectionState.Open) conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);

            
            }
            
        }


        //Metodo para consultar todos los algoritmo que existen 

    }
}
