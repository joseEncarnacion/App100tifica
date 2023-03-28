﻿using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       // CEestudiante estudiantes = new CEestudiante();
        CNestudiantes estudiantes = new CNestudiantes();
        CEestudiante estudianteEntidad = new CEestudiante();
        CNalgoritmo algoritmos= new CNalgoritmo();
        CEalgoritmo EntidadAlgortimo   = new CEalgoritmo();

        private void limpiarInputEst()
        {
            txtMantCarreraCBOX.Text = string.Empty;
            txtMant_matricula.Text = string.Empty;  
            txtMant_NombreEST.Text = string.Empty;  
        }

        private void registrarAlgoritmobasico()
        {
            bool respond;

            EntidadAlgortimo.titulo = txtmantTitulo.Text;
            EntidadAlgortimo.problema = txtmantproblema.Text;

            respond = algoritmos.validarAlgortimoB(EntidadAlgortimo);

            if(respond ==false ) {
                return;
             }

            algoritmos.CN_insertarRegistro(EntidadAlgortimo);
            MessageBox.Show("Registrado satisfactoriamente");

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = true;
        }

        private void btn_regresarP1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrarSolucion_Click(object sender, EventArgs e)
        {
            this.Close();
            Pantalla1 p1 = new Pantalla1();
            p1.Close();
        }

        private void btn_mantEstudiante_Click(object sender, EventArgs e)
        {
            panelAdmin1.Visible = true; 
            panelMantAlgtBasico.Visible = false;
            panelalgtIntermedio.Visible = false;
        }

        private void btn_algotBasico_Click(object sender, EventArgs e)
        {
            //algoritmo mantenimiento basico
            panelMantAlgtBasico.Visible = true;
            panelalgtIntermedio.Visible = false;
        }

        private void btn_algotIntermedio_Click(object sender, EventArgs e)
        {
            //algoritmo intermedio
            panelMantAlgtBasico.Visible = true;
            panelalgtIntermedio.Visible = true;
            
        }

        private void listarEstudiantes()
        {
            DataTable dt = estudiantes.NEstudiante_listado();
            dataGEstudiantes.DataSource = dt;
        }

        private void panelAdmin1_Paint(object sender, PaintEventArgs e)
        {
            //Traer registros 
            listarEstudiantes();
        }

        private void panelMantAlgtBasico_Paint(object sender, PaintEventArgs e)
        {
            //trael registros alg basico

            DataTable dt = algoritmos.CN_countAlgoritmo();
            dataGalgotBasico.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardar algoritmo intermedio
        }

        private void panelalgtIntermedio_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            //guardar algoritmo basico

            registrarAlgoritmobasico();
        }

        private void btn_editarManEST_Click(object sender, EventArgs e)
        {
            //editarmantenimiento estudiante
          
            editarestudiante();
            listarEstudiantes();
            limpiarInputEst();



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGEstudiantes.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                int Eliminar = Convert.ToInt32(dataGEstudiantes.Rows[e.RowIndex].Cells["matricula"].Value.ToString());
                //metodo eliminar
                estudiantes.NEestudiante_Eliminar(Eliminar);

                //nueva lista
                listarEstudiantes();



            }
            else if (dataGEstudiantes.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                txtMant_matricula.Text = dataGEstudiantes.Rows[e.RowIndex].Cells["matricula"].Value.ToString();
                txtMant_NombreEST.Text = dataGEstudiantes.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtMantCarreraCBOX.Text = dataGEstudiantes.Rows[e.RowIndex].Cells["carrera"].Value.ToString();
            }

        }

        private void editarestudiante()
        {
            bool respuesta;

            estudianteEntidad.Matricula = txtMant_matricula.Text;
            estudianteEntidad.nombreE = txtMant_NombreEST.Text;
            estudianteEntidad.carreraID = txtMantCarreraCBOX.Text;

            respuesta =estudiantes.validarDatosEstudiante(estudianteEntidad);

            if (respuesta == false) return;

            estudiantes.Neestudiante_editar(estudianteEntidad);
            MessageBox.Show("Editado satisfactoriamente");

        }

        private void dataGalgotBasico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eventos de un clic en dataGridview
            if (dataGalgotBasico.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                int eliminar =Convert.ToInt32(dataGalgotBasico.Rows[e.RowIndex].Cells["idAlgoritmo"].Value.ToString());
            
                algoritmos.CN_EliminarRegistro(eliminar);
                //falta el metodo listar algoritmo
                
            }


        }
    }
}
