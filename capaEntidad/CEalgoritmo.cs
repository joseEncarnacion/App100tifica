using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEalgoritmo
    {

        //Definir atributos de la base de dato para la tabla algoritmo

        public int IDalgoritmo { get; set; }
        public string titulo { get; set; }
        public string problema { get; set; }
        public string matricula { get; set; }
        public int complejidad { get; set; }
    }
}
