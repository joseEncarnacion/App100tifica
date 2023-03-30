using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using capaEntidad;

namespace capaDatos
{
    public class CDusuario
    {
        SqlConnection conn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["dataConnex"].ConnectionString);


        public DataTable Datos_Listar(UsuarioMant USER)
        {
            SqlCommand cmd = new SqlCommand("sp_usuario", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", USER.UsuarioE);
            cmd.Parameters.AddWithValue("@pass", USER.passE);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
