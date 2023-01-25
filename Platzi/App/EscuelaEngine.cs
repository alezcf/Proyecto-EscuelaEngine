using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreEscuela.Entidades;
using Platzi.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine() {
 

        }  

        public void Inicializar()
        {
            Escuela = new Escuela("Universidad del Bío-Bío", 2001,
                                      TiposEscuela.Preescolar, "Chile", "Concepción");

            CargarCursos();
            CargarAsignaturas();
            
            
            CargarEvaluaciones();
        }
        private void CargarCursos()
        {
            Escuela.cursos = new List<Curso>() {
            new Curso("Cálculo II", TiposJornada.Mañana),
            new Curso("Estructura de Datos", TiposJornada.Noche),
            new Curso("Arquitectura de Computadores", TiposJornada.Noche),
            };
            Random rnd = new Random();

            foreach(var curso in Escuela.cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] name = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastName = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] middleName = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in name
                               from n2 in middleName
                               from a1 in lastName
                               select new Alumno { Nombre = $" {n1} {n2} {a1}" };


            // OrderBy ordena dependiendo del key generado (ID único) - Take retorna n posiciones del array.
            return listaAlumnos.OrderBy( ( al ) => al.UniqueID ).Take(cantidad).ToList();
        }
        private void CargarAsignaturas()
        {
            foreach(var curso in Escuela.cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura("Cálculo II"),
                    new Asignatura("Arquitectura de Computadores"),
                    new Asignatura("Estructura de Datos"),
                    new Asignatura("Estadistica"),
                    new Asignatura("Administración general"),
                };

                curso.Asignaturas = listaAsignaturas;
            }
        }
        
        private void CargarEvaluaciones()
        {

            
                foreach (var curso in this.Escuela.cursos)
                {
                    curso.Evaluaciones = new List<Evaluaciones>();

                    foreach (var alumno in curso.Alumnos)
                    {
                        foreach (var asignatura in curso.Asignaturas)
                        {
                            curso.Evaluaciones.AddRange(GenerarEvaluacionesAlAzar(alumno, asignatura));
                        }
                    }
                }
            

        }
        private List<Evaluaciones> GenerarEvaluacionesAlAzar(Alumno alumno, Asignatura asignatura)
        {

            Random rnd = new Random();
            string[] nombreEvaluaciones = { "Nota 1", "Nota2", "Nota3", "Nota 4", "Nota 5" };
            var listEvaluaciones = new List<Evaluaciones>();

            var evaluacion = new Evaluaciones();
            foreach (var nota in nombreEvaluaciones)
            {
                evaluacion.Nombre = nota;
                evaluacion.Alumno = alumno;
                evaluacion.Asignatura = asignatura;

                evaluacion.Nota = (float)(rnd.NextDouble() * (5.0 - 0));

                listEvaluaciones.Add(evaluacion);
            }

            return listEvaluaciones;


        }
    }
}
