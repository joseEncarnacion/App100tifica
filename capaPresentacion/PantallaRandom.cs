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
    public partial class PantallaRandom : Form
    {
        public PantallaRandom()
        {
            InitializeComponent();
        }

        CNalgoritmo AlgoritmoNegocio = new CNalgoritmo();
        CNalgoritmoIntermedio algoritmomedNegocio  =new CNalgoritmoIntermedio();

        private void btn_basico_Click(object sender, EventArgs e)
        {
           
            //string a;
            Resultado p_Resultado = new Resultado();
          AlgoritmoNegocio.NE_Ramdombasico();
            AlgoritmoNegocio.AlgoritmoSeleccionadoBasico();
            this.Close();
            p_Resultado.Show();


        }

        private void btn_intermedio_Click(object sender, EventArgs e)
        {
            algoritmomedNegocio.AlgoritmoSeleccionadoIntermedio();
        }
    }
}
