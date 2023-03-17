using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using capaDatos;
using System.Data;



namespace capaNegocio
{
    public class CNalgoritmo
    {

        CDalgoritmo algoritmosRef = new CDalgoritmo();

        // validaciones para insertar algoritmos


        //logica para seleccion aleatoria de algoritmo
        public DataTable CN_countAlgoritmo()
        {
            return algoritmosRef.cantidadAlgoritmo();
        }


        //Mantenimiento de algortimo 

        public void CN_insertarRegistro(CEalgoritmo algot)
        {
            algoritmosRef.CD_insertarAlgoritmo(algot);
        }

    }
}
