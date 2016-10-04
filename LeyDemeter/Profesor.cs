using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyDemeter
{
    public class Profesor
    {

        public int Identificador { get; }
        public string Nombre {get; set;}

        public Profesor(int identificador, string nombre)
        {
            Identificador = identificador;
            Nombre = nombre;
        }
    }
}
