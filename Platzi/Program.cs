using System;
using CoreEscuela;
using CoreEscuela.Entidades;
using Platzi.Entidades;

using static System.Console;

namespace Etapa1
{
    class Program
    {

        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();
            engine.Inicializar();
            imprimirCursos(engine.Escuela);
            WriteLine(engine.Escuela);
            WriteLine("===============");
        }

        public static void imprimirCursos(Escuela escuela)
        {
            // Primero verifico escuela y luego el atributo cursos de mi objeto principal.
            if (escuela?.cursos == null)
                return;

            foreach(var cursoActual in escuela.cursos){
                WriteLine("===============");
                WriteLine($"ID: { cursoActual.UniqueID} {System.Environment.NewLine}" +
                                  $"Nombre: { cursoActual.Nombre} {System.Environment.NewLine}" +
                                  $"Jornada: { cursoActual.Jornada}");
            }
        }
    }
}