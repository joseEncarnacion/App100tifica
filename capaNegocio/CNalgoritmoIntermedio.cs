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
        Random Randomrandly = new Random();
        int numSelected;
        List<string> listaAlgoritmosIntermedio = new List<string>();

        CDAlgoritmoIntermedio medAlritmo = new CDAlgoritmoIntermedio();

        public void NE_RamdomIntermedio()
        {
            DataTable dtmed = CNlistarAlgotMed();
            int x = 0;


            while (x < dtmed.Rows.Count)
            {
                
               if (dtmed.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay algoritmos disponebles a mostrar");
                }
                else
                {
                    

                   // MessageBox.Show("si hay algoritmos disponebles a mostrar");
                    var filas = dtmed.Rows[x]["problema"].ToString();
                    listaAlgoritmosIntermedio.Add(filas);
                    //MessageBox.Show(filas);

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
                numSelected = Randomrandly.Next(0, listaAlgoritmosIntermedio.Count);
                seleccionado = listaAlgoritmosIntermedio[numSelected];
               // MessageBox.Show(seleccionado + " seleccionado");
            }
            catch(Exception ex) {
                MessageBox.Show("Problemas al mostrar el algortimo" + ex);
               // MessageBox.Show(numSelected.ToString());
            }

                return seleccionado;
           

           

            

        }



        


        

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
