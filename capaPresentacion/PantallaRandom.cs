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
        CNRandomBtnParams Parameters= new CNRandomBtnParams();

        private void btn_basico_Click(object sender, EventArgs e)
        {
           
            //string a;
            Resultado p_Resultado = new Resultado();
            // AlgoritmoNegocio.NE_Ramdombasico();
            // AlgoritmoNegocio.AlgoritmoSeleccionadoBasico();

            Parameters.btnRandom = 1;
            Resultado1.Visible= true;
            timerCountD.Start();

           // this.Close();
           // p_Resultado.Show();


        }

        private void btn_intermedio_Click(object sender, EventArgs e)
        {
            Parameters.btnRandom = 2;
            Resultado1.Visible = true;
            timerCountD.Start();
            
        }

        private void btn_PedirTiempo_Click(object sender, EventArgs e)
        {
            //Aplazar tiempo 
            minuteLeft += 5;
            btn_PedirTiempo.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //terminar reto
            timerCountD.Stop();
            Resultado pantallaResultado = new Resultado();

            pantallaResultado.Show();
            this.Hide();
        }

        private void panelProblema_Paint(object sender, PaintEventArgs e)
        {
            if (Parameters.btnRandom == 1)
            {
                AlgoritmoNegocio.NE_Ramdombasico();
                textProblema.Text = AlgoritmoNegocio.AlgoritmoSeleccionadoBasico();
               // MessageBox.Show("HA selecionado el facil");
            }
            else
            {
               // MessageBox.Show("HA selecionado avanzado");
                algoritmomedNegocio.NE_RamdomIntermedio();
                textProblema.Text = algoritmomedNegocio.AlgoritmoSeleccionadoIntermedio();
              
            }
        }

        int secoundLeft = 60;
        int minuteLeft = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (minuteLeft > 0)
            {
                if (secoundLeft > 0)
                {
                    secoundLeft -= 1;

                    text_segundo.Text = secoundLeft + "";
                    text_minuto.Text = minuteLeft + ":";
                }
                else
                {
                    secoundLeft = 60;
                    minuteLeft -= 1;

                }

            }
            else if (secoundLeft == 0)
            {
                minuteLeft -= 1;
                secoundLeft = 60;

            }

            if (minuteLeft <=1)
            {
                text_minuto.Text = "0:";

                if (secoundLeft > 0)
                {
                    secoundLeft -= 1;
                    text_segundo.Text = secoundLeft + "";

                    
                }
                else if(text_minuto.Text == "0:" && secoundLeft == 0)
                {
                    
                    timerCountD.Stop();
                   // MessageBox.Show("Ha terminado el tiempo");
                    Resultado pantallaResultado = new Resultado();

                    pantallaResultado.Show();
                    this.Hide();
                }
            }
            
        }
    }
}
