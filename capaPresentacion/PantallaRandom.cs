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
            /*
            
            // variabble busqueda /> Aqui se llena el DataTable para tener el total de filas que 
            //tiene nuestra tabla
            var busqueda = AlgoritmoNegocio.CN_countAlgoritmo();
            // a traves del metodo buscaralgoritmo seleccionamos un id de la tabla 
            //lo introducimos en una variable
            int id= AlgoritmoNegocio.BuscarAlgoritmoRamdom(busqueda);

            //creamos nuestro objeto dt e insertamos el objeto obtenido de nuestra db
            DataTable dt =AlgoritmoNegocio.CN_buscarAlgoritmoBasico(id);
            //acedemos a nuestro atributo Row si primer elemento y le decimos que 
            //queremos leer la [columna] problema
            var algoritmoSeleccionado = dt.Rows[0]["problema"];
           // MessageBox.Show(id.ToString());
            MessageBox.Show(algoritmoSeleccionado.ToString());

            */

            /*
            string resuldato = algoritmoSeleccionado.ToString();

            AlgoritmoNegocio.CN_ResultadoAlgoritmoMostrar(resuldato);

            */

            //Enviar a la pantalla de resultado
            string a;
            Resultado p_Resultado = new Resultado();
            this.Close();
            p_Resultado.Show();
            

        }
    }
}
