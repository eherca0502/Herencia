using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clases
{
    public class Administrativo : Persona
    {
        public string NombreJefe { get; set; }
        public string Area { get; set; }
    }
}
