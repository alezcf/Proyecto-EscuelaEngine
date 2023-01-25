
using CoreEscuela.Entidades;

namespace Platzi.Entidades
{
    public class Alumno
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public Alumno() => UniqueID = Guid.NewGuid().ToString();


    }
}
