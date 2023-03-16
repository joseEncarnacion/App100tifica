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
    internal class CDalgoritmo
    {

        /*Nota importante:
         *  deben crear la base de datos en su sql server llamada ==> appcientifica <==
         */


        //conexion con mi base de datos
        SqlConnection conn =
           new SqlConnection(ConfigurationManager.ConnectionStrings["dataConnex"].ConnectionString);


        // Metodo para termino de busqueda del algoritmo
        // aqui se creara solo el metodo que va a consultar con la base de datos






        //Metodo para insertar algoritmo




        // Metodo para actualizar





        // metodo para eliminar 




        //Metodo para consultar todos los algoritmo que existen 

    }
}
