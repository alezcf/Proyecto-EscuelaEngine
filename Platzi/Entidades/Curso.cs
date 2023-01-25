using Platzi.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set;}
        public List<Asignatura> Asignaturas { get; set; }
        public List <Alumno> Alumnos { get; set; }
        public List<Evaluaciones> Evaluaciones { get; set; }

        public Curso(string nombre, TiposJornada jornada) {
            UniqueID = Guid.NewGuid().ToString();
            (Nombre, Jornada) = (nombre, jornada);
        }

        public override string ToString()
        {
            return $"ID: {UniqueID} {System.Environment.NewLine}Nombre: {Nombre} {System.Environment.NewLine}Jornada: {Jornada}";
        }

    }
}
