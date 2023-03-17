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

        private void btn_basico_Click(object sender, EventArgs e)
        {
            var busqueda = AlgoritmoNegocio.CN_countAlgoritmo();
            int id= AlgoritmoNegocio.BuscarAlgoritmoRamdom(busqueda);


        }
    }
}
