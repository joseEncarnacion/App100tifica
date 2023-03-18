using capaEntidad;
using capaDatos;
using System.Data;
using System.Text.RegularExpressions;

namespace capaNegocio
{
    public class CNestudiantes 
    {
        // objeto de la capa datos
        CDestudiantes datoEstudiante = new CDestudiantes();
        
        public bool validarDatosEstudiante(CEestudiante estudiante)
        {
            bool resultado = true;

            //Valida que los campos no esten vacios.
            if (estudiante.Matricula == string.Empty)  // ""
            {
                MessageBox.Show("Matricula Obligatoria");
                resultado = false;
            }

            if (estudiante.nombreE == string.Empty)
            {
                MessageBox.Show("El nombre es obligatorio");
                resultado = false;
            }

            if (estudiante.carreraID == string.Empty)
            {
                MessageBox.Show("Debe Elegir almenos una carrera");
                resultado = false;
            }

            if (estudiante.password == string.Empty)
            {
                MessageBox.Show("El Password es obligatorio");
                resultado = false;
            }
            // Validar que los campos Nombres y carrera sea solos letras

            if (!estudiante.nombreE.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("El nombre solo puede contener letras");
                resultado = false;
            }
            if (!estudiante.carreraID.All(c => char.IsLetter(c)))
            {
                MessageBox.Show("La carrera solo puede contener letras");
                resultado = false;
            }

            //Validacion de que la matricula solo tenga numeros y que no pase de 8.

            if (Regex.IsMatch(estudiante.Matricula, @"^[0-9]+$"))
            {
                // La matrícula solo contiene números
            }
            else
            {
                MessageBox.Show("La matrícula debe contener solo números");
                resultado = false;
            }

            if (Regex.IsMatch(estudiante.Matricula, @"^[0-9]{8}$"))
            {
                // La matrícula contiene exactamente 8 números
            }
            else
            {
                MessageBox.Show("La matrícula debe tener 8 digitos");
                resultado = false;
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

        public void Neestudiante_editar(CEestudiante est) {

            datoEstudiante.ActualizarDatos(est);
        }

    }
}