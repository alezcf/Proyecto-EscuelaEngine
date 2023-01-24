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

            Escuela.cursos = new List<Curso>() {
            new Curso("Cálculo II", TiposJornada.Mañana),
            new Curso("Estructura de Datos", TiposJornada.Noche),
            new Curso("Arquitectura de Computadores", TiposJornada.Noche),
            };
        }
    }
}
