namespace LeyDemeter
{
    public class Asignatura
    {

        public Asignatura(int identificador, string nombre, Profesor cooordinador)
        {
            this.Identificador = identificador;
            this.Nombre = nombre;
            this.Coordinador = cooordinador;
        }

        public Profesor Coordinador { get; private set; }
        public int Identificador { get; private set; }
        public string Nombre { get; private set; }
    }
}