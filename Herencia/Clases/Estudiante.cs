using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
     public class Estudiante : Persona
    {
        //Propiedades
        public string Programa { get; set; }
        public string SemestreActual { get; set; }
    }
}
