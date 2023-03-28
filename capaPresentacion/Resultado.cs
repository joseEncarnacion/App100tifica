using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capaPresentacion
{
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        CNalgoritmo AlgoritmoNegocio = new CNalgoritmo();
        CNalgoritmoIntermedio algoritmoMed = new CNalgoritmoIntermedio();   

        private void Resultado_Load(object sender, EventArgs e)
        {


            AlgoritmoNegocio.NE_Ramdombasico();
            txt_Problema.Text = AlgoritmoNegocio.AlgoritmoSeleccionadoBasico();


        }
        
        private void btnTerminar_Click(object sender, EventArgs e)
        {


        }
    }
}
