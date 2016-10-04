using System;
using System.Collections.Generic;
using System.Linq;

namespace LeyDemeter
{
    public class Universidad
    {

        public Universidad(string nombre)
        {
            this.Nombre = nombre;
            this.departamentos = new List<Departamento>();
        }

        public string Nombre { get; private set; }

        public Profesor GetCoordinadorAsignatura(int identificadorDepartamento, int identificadorAsignatura)
        {
            Departamento departamento;
            departamento = GetDepartamento(identificadorDepartamento);

            return departamento.GetCoordinadorAsignatura(identificadorAsignatura);
        }

        private IList<Departamento> departamentos;

        public void AddDepartamento(Departamento departamento)
        {
            departamentos.Add(departamento);
        }

        public Departamento GetDepartamento(int identificador)
        {
            return departamentos
                    .Where<Departamento>(departamento => departamento.Identificador == identificador)
                    .FirstOrDefault<Departamento>();
        }
    }
}