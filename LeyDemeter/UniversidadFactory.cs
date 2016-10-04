using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyDemeter
{
    public sealed class UniversidadFactory
    {
        public static Universidad CrearUniversidad()
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
