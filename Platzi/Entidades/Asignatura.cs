
using CoreEscuela.Entidades;

namespace Platzi.Entidades
{
    public class Asignatura
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public List<Evaluaciones> Evaluaciones { get; set; }

        public Asignatura() => UniqueID = Guid.NewGuid().ToString();

        public Asignatura(string nombre)
        {
            this.Nombre = nombre;
        }


    }
}
