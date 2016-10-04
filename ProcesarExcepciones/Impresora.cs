using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesarExcepciones
{
    public enum TipoRespuesta
    {
        Ok,
        ErrorDevice,
        ErrorPrinting
    }

    public class Impresora
    {
        public TipoRespuesta Open()
        {
            return TipoRespuesta.Ok;
        }

        public TipoRespuesta Print(string texto)
        {
            System.Console.WriteLine(texto);
            //return TipoRespuesta.ErrorPrinting;
            return TipoRespuesta.Ok;
        }

        public TipoRespuesta Close()
        {
            return TipoRespuesta.Ok;
        }
    }
}
