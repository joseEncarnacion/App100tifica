using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();

            cBoxCarrera.DropDownStyle= ComboBoxStyle.DropDownList;
          
        }

        //objeto de la clase Entidad estudiante
        CEestudiante estudiantes = new CEestudiante();

        // objeto de la capa Negocio 
        CNestudiantes negocionEstudiante= new CNestudiantes();
        CNalgoritmo NegocioAlgoritmo = new CNalgoritmo();

        // Metodos para el control de la aplicacion 


        //Limpiar los inputs
        private void limpiar()
        {
            cBoxCarrera.Text = string.Empty;
            textMatricula.Text = string.Empty;
            textNombre.Text = string.Empty;
             
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
            
            

            resultado = negocionEstudiante.validarDatosEstudiante(estudiantes);
           
            if(resultado == false)
            {
                return;
            }
            
            negocionEstudiante.NEstudiante_insertar(estudiantes);

            //Captar el nombre del estudiante loguado
            NegocioAlgoritmo.nombreUsuario = estudiantes.nombreE;


            MessageBox.Show("Enhorabuena! Registrado Satisfactorio");

            
            PantallaRandom p1 = new PantallaRandom();
            p1.Show();

            this.Hide();
            limpiar();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          
            limpiar();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Login longinVentana = new Login();

            longinVentana.Show();
            this.Hide();
        }

        private void textMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32 && e.KeyChar<= 47) || (e.KeyChar >=58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled= true;
                return;

            }
        }
    }
}