
using CoreEscuela.Entidades;

namespace Platzi.Entidades
{
    public class Evaluaciones
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public Asignatura Asignatura { get; set; }
        public Alumno Alumno { get; set; }
        public float Nota { get; set; }


        public Evaluaciones() => UniqueID = Guid.NewGuid().ToString();


    }
}
