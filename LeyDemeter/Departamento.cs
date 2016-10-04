using System;
using System.Collections.Generic;
using System.Linq;

namespace LeyDemeter
{
    public class Departamento
    {

        public Departamento(int identificador, string nombre)
        {
            this.Identificador = identificador;
            this.Nombre = nombre;
            this.asignaturas = new List<Asignatura>();
        }

        public int Identificador { get; private set; }
        public string Nombre { get; private set; }
        private IList<Asignatura> asignaturas;

        public void AddAsignatura(Asignatura asignatura)
        {
            asignaturas.Add(asignatura);
        }

        public Profesor GetCoordinadorAsignatura(int identificadorAsignatura)
        {
            Profesor profesor;

            profesor = GetAsignatura(identificadorAsignatura).Coordinador;

            return profesor;

        }

        public Asignatura GetAsignatura(int identificador)
        {
            return asignaturas
                    .Where<Asignatura>(asignatura => asignatura.Identificador == identificador)
                    .FirstOrDefault<Asignatura>();
        }
    }
}