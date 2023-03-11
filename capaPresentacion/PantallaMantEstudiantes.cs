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

        public void listarEstudiante()
        {
            DataTable dt = negocioEstudiante.NEstudiante_listado();
            dataGridView1.DataSource = dt;
        }

        private void PantallaMantEstudiantes_Load(object sender, EventArgs e)
        {
            listarEstudiante();
        }
    }
}
