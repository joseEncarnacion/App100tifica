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


        /* Paso a Paso:
         *  crear la funcion del numero aleatorio 
         *  ejecutar el procedimiento almacenado que busca por termino
         *  
         */

        //metodo que al hacer clic en basico o intermedio toma el dato para
        //mostarlo en la pantalla de resultado
        public string CN_ResultadoAlgoritmoMostrar(string dato)
        {
            string respuesta = dato;

            return respuesta;
        }


        //reutilizacion del metodo para pasarle un datatable por parametros
        public int BuscarAlgoritmoRamdom(DataTable dt)
        {
            // dt = CN_countAlgoritmo();
            int CantidadAlgoritmo = dt.Rows.Count;

            //variable random
            Random generarAleatorio= new Random();
            int numeroAleatorio = 0;

            numeroAleatorio = generarAleatorio.Next(1, CantidadAlgoritmo+1);

            return numeroAleatorio;

        }


        //Mantenimiento de algortimo 

        //buscar por termino DB

        public DataTable CN_buscarAlgoritmoBasico(int id)
        {
            return algoritmosRef.CD_buscarAlgoritmoBasico(id);
        }

        public DataTable CN_buscarAlgoritmoIntermedio(int id)
        {
            return algoritmosRef.CD_buscarAlgoritmoIntermedio(id);
        }


        //listar
        public DataTable CN_countAlgoritmo()
        {
            return algoritmosRef.cantidadAlgoritmo();
        }

        //insertar
        public void CN_insertarRegistro(CEalgoritmo algot)
        {
            algoritmosRef.CD_insertarAlgoritmo(algot);
        }

        //actualizar
        public void CN_ActualizarRegistro(CEalgoritmo algot)
        {
            algoritmosRef.CD_ActualizarAlgoritmo(algot) ;
        }

        //eliminar
        public void CN_EliminarRegistro(int id)
        {
            algoritmosRef.CD_EliminarAlgoritmo(id) ;
        }

    }
}
