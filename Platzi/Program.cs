using System;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
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
            Printer.DibujarLinea();
            WriteLine(engine.Escuela);
        }

        public static void imprimirCursos(Escuela escuela)
        {
            Printer.DibujarTitulo("Cursos de la Escuela");
            // Primero verifico escuela y luego el atributo cursos de mi objeto principal.
            if (escuela?.cursos == null)
                return;

            foreach(var cursoActual in escuela.cursos){
                WriteLine($"ID: { cursoActual.UniqueID} {System.Environment.NewLine}" +
                                  $"Nombre: { cursoActual.Nombre} {System.Environment.NewLine}" +
                                  $"Jornada: { cursoActual.Jornada}");
            }
        }
    }
}