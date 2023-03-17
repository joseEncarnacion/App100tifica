using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();
          
        }

        //objeto de la clase Entidad estudiante
        CEestudiante estudiantes = new CEestudiante();

        // objeto de la capa Negocio 
        CNestudiantes negocionEstudiante= new CNestudiantes();

        // Metodos para el control de la aplicacion 


        //Limpiar los inputs
        private void limpiar()
        {
            cBoxCarrera.Text = string.Empty;
            textMatricula.Text = string.Empty;
            textNombre.Text = string.Empty;
            textpassword.Text = string.Empty;   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        

        //Boton para registrar estudiante
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //datos de los input
            //
            bool resultado;
            

            //estudiantes.idEstudiante= text;
            estudiantes.Matricula= textMatricula.Text;
            estudiantes.nombreE = textNombre.Text;
            estudiantes.carreraID = cBoxCarrera.Text;
            estudiantes.password = textpassword.Text;

            resultado = negocionEstudiante.validarDatosEstudiante(estudiantes);
           
            if(resultado == false)
            {
                return;
            }
            
            negocionEstudiante.NEstudiante_insertar(estudiantes);

            MessageBox.Show("Registrado Satisfactorio");

            limpiar();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}