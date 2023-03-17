using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class PantallaMantEstudiantes : Form
    {
        public PantallaMantEstudiantes()
        {
            InitializeComponent();
        }

        CEestudiante entidadEstudiante = new CEestudiante();
        CNestudiantes negocioEstudiante= new CNestudiantes();
        CNalgoritmo algoritmo= new CNalgoritmo();

        public void listarEstudiante()
        {
            // DataTable dt = negocioEstudiante.NEstudiante_listado();
           // DataTable dt = algoritmo.CN_countAlgoritmo();
            DataTable dt = algoritmo.CN_buscarAlgoritmoBasico(2);
            dataGridView1.DataSource = dt;

            int g = dt.Rows.Count;

           // logica para obtener un dato de una fila 
            var datico =
                dt.Rows[0]["problema"];

           
        
            // MessageBox.Show(g.ToString());
            MessageBox.Show(datico.ToString());
        }

        private void PantallaMantEstudiantes_Load(object sender, EventArgs e)
        {
            listarEstudiante();

        }
    }
}
