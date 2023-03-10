using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Docente : Persona
    {
        //Propiedades
        public string Contrato { get; set; }
        public int MateriasAsignadas { get; set; }
    }
}
