using capaEntidad;
using capaDatos;
using System.Data;

namespace capaNegocio
{
    public class CNestudiantes
    {
        // objeto de la capa datos
        CDestudiantes datoEstudiante = new CDestudiantes();
       

        public bool validarDatosEstudiante(CEestudiante estudiante)
        {
            bool resultado = true;

            if(estudiante.Matricula == string.Empty)  // ""
            {
                MessageBox.Show("Matricula Obligatoria");
                resultado= false;
            }

            if(estudiante.nombreE == string.Empty)
            {
                MessageBox.Show("El nombre es obligatorio");
                resultado= false;
            }

           if(estudiante.carreraID <= 0) {
                MessageBox.Show("Debe Elegir almenos una carrera");
                resultado= false;
            }

            return resultado;
        }



        //crud 
        public DataTable NEstudiante_listado()
        {
            return datoEstudiante.Datos_Listar();
        }


        public void NEstudiante_insertar(CEestudiante est)
        {
            datoEstudiante.Datos_insertarEstudiante(est);

        }

    }
}