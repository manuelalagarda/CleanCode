using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesarExcepciones
{

    public class Impresora
    {
        public void Open()
        {
            // .....
        }

        public void Print(string texto)
        {
            //System.Console.WriteLine(texto);
            throw new ErrorImprimimiendoException("Error al imprimir");
        }

        public void Close()
        {
            // ...
        }
    }
}
