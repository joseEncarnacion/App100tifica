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

        // 1 = basico, 2 = intermendio
        public int nivelDificulta { get; set; }
        //id selecionadel random
        public string AlgoritmoRandomSelected;
        //persistencia del nombre quien hace el algoritmo
        public string nombreUsuario { get; set; }



        // validaciones para insertar algoritmos
        public bool validarAlgortimoB(CEalgoritmo e)
        {
            bool respond = true;

            if(e.titulo == string.Empty)
            {
                MessageBox.Show("Debe incluir un titulo");
                respond = false;
            }

            if (e.problema == string.Empty)
            {
                MessageBox.Show("Debe incluir un problema");
                respond = false;
            }

            return respond;
        }

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

        public void algoritmoBasico()
        {
            // variabble busqueda /> Aqui se llena el DataTable para tener el total de filas que 
            //tiene nuestra tabla
            var busqueda = CN_countAlgoritmo();
            // a traves del metodo buscaralgoritmo seleccionamos un id de la tabla 
            //lo introducimos en una variable
            int id = BuscarAlgoritmoRamdom(busqueda);

            MessageBox.Show(id.ToString());
            if (id>0)
            {
                DataTable dt = CN_buscarAlgoritmoBasico(id); 
                var algoritmoSeleccionado = dt.Rows[0]["problema"];
                AlgoritmoRandomSelected = algoritmoSeleccionado.ToString();
            }
            else
            {
                MessageBox.Show("Fallo");
            }
            //creamos nuestro objeto dt e insertamos el objeto obtenido de nuestra db
            
            //DataTable dt = CN_buscarAlgoritmoBasico(id);
           
            //acedemos a nuestro atributo Row si primer elemento y le decimos que 
            //queremos leer la [columna] problema
            
            //var algoritmoSeleccionado = dt.Rows[0]["problema"];
           
            // MessageBox.Show(id.ToString());
           // MessageBox.Show(algoritmoSeleccionado.ToString());

            //AlgoritmoRandomSelected = algoritmoSeleccionado.ToString();
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
