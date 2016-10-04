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

            try
            {
                impresora.Open();
                impresora.Print("Hola mundo!!!");
                impresora.Close();

            } catch (AccesoDispositivoException ex)
            {
                System.Console.WriteLine("Error al acceder al dispositivo");
            } catch (ErrorImprimimiendoException ex)
            {
                System.Console.WriteLine(ex.Message);
            } catch (Exception ex)
            {
                System.Console.WriteLine("Error desconocido");
            }

           
            System.Console.ReadKey();

        }
    }
}
