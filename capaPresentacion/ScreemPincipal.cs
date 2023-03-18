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
    public partial class ScreemPincipal : Form
    {
        public ScreemPincipal()
        {
            InitializeComponent();
        }

      //  ScreemPincipal sprincipal = new ScreemPincipal();
        Pantalla1 p1 = new Pantalla1();

        private void ScreemPincipal_Load(object sender, EventArgs e)
        {
            AbrirFormPantalla1(new Pantalla1());
        }

        private void Panelscreem1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AbrirFormPantalla1(object p1)
        {
            if(this.Panelscreem1.Controls.Count > 0) {
                this.Panelscreem1.Controls.RemoveAt(0);
                                             
            }

            Form formulario = p1 as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.Panelscreem1.Controls.Add(formulario);
            this.Panelscreem1.Tag = formulario;
            formulario.Show();

        }
    }
}
