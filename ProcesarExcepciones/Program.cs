using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesarExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();
            TipoRespuesta respuesta = TipoRespuesta.Ok;

            respuesta = impresora.Open();
            if (respuesta == TipoRespuesta.Ok)
            {
                respuesta = impresora.Print("Hola Mundo!!");
                switch (respuesta)
                {
                    case TipoRespuesta.Ok:
                        System.Console.WriteLine("Impresión correcta");
                        break;
                    case TipoRespuesta.ErrorDevice:
                        System.Console.WriteLine("Error al acceder al dispositivo");
                        break;
                    case TipoRespuesta.ErrorPrinting:
                        System.Console.WriteLine("Error al imprimir");
                        break;
                }

                respuesta = impresora.Close();
                if (respuesta != TipoRespuesta.Ok)
                {
                    System.Console.WriteLine("Error al acceder dispositivo");
                }

            } else
            {
                System.Console.WriteLine("Error al acceder dispositivo");
            }
           

            System.Console.ReadKey();

        }
    }
}
