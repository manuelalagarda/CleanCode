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
            Universidad universidad = CrearUniversidad();

            System.Console.WriteLine(universidad.GetDepartamento(1).GetAsignatura(1).Coordinador.Nombre);
            System.Console.ReadKey();



        }

        private static Universidad CrearUniversidad()
        {
            Profesor profesor = new Profesor(1, "Pedro Lopez");
            Asignatura asignatura = new Asignatura(1, "Programación", profesor);
            Departamento departamento = new Departamento(1, "Departamento de informática");
            departamento.AddAsignatura(asignatura);
            Universidad universidad = new Universidad("UPV");
            universidad.AddDepartamento(departamento);

            return universidad;
        }
    }
}
