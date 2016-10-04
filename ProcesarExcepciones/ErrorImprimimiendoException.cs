using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesarExcepciones
{
    public class ErrorImprimimiendoException : Exception
    {
        public ErrorImprimimiendoException(string message):base(message)
        {

        }

    }
}
