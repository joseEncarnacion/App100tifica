using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CNalgoritmoIntermedio
    {

        //Refactorizando random /> nuevo random 
        Random Randomrand = new Random();
        int numSelected;
        List<string> listaAlgoritmosIntermedio = new List<string>();

        public void NE_RamdomIntermedio()
        {
            DataTable dtbasico = CNlistarAlgotMed();
            int x = 0;


            while (x < dtbasico.Rows.Count)
            {

                if (dtbasico.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay algoritmos disponebles a mostrar");
                }
                else
                {
                    var filas = dtbasico.Rows[x]["problema"].ToString();
                    listaAlgoritmosIntermedio.Add(filas);

                }
                

                x++;


            }


        }


        //metodo Random basico
        public string AlgoritmoSeleccionadoIntermedio()
        {
            string seleccionado = string.Empty;
            try
            {
                numSelected = Randomrand.Next(0, listaAlgoritmosIntermedio.Count);
                seleccionado = listaAlgoritmosIntermedio[numSelected];
                MessageBox.Show(seleccionado);
            }
            catch(Exception ex) {
                MessageBox.Show("Problemas al mostrar el algortimo" + ex);

            }

                return seleccionado;
           

           

            

        }



        public


        CDAlgoritmoIntermedio medAlritmo =new CDAlgoritmoIntermedio();

        public DataTable CNlistarAlgotMed()
        {
            return medAlritmo.ListarAlgoritmoMed();
        }

        public void CNinsertarAlgMed(CEalgoritmo algMed)
        {
            medAlritmo.CD_insertarAlgoritmoMed(algMed);
        }

        public void CNedidar(CEalgoritmo algMed)
        {
            medAlritmo.CD_ActualizarAlgoritmoMed(algMed);
        }

        public void CNeliminar(int id)
        {
            medAlritmo.CD_EliminarAlgoritmoMed(id);
        }

    }
}
