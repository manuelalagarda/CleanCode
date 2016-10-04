using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyDemeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Universidad universidad = UniversidadFactory.CrearUniversidad();

            System.Console.WriteLine(universidad.GetCoordinadorAsignatura(1, 1).Nombre);
            System.Console.ReadKey();

        }

    }
}
