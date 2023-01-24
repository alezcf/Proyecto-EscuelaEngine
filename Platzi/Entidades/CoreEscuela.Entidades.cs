using CoreEscuela.Entidades;

namespace Platzi.Entidades
{
    public class Escuela
    {

        public string nombre;
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public TiposEscuela TipoEscuela { get; set; }
        public int FechaDeCreacion { get; set; }
        public List<Curso> cursos { get; set; }


        //    public Escuela(string nombre, int fecha) => (Nombre, FechaDeCreacion) = (nombre, fecha);
        public string Nombre
        {
            get { return "Copia = " + nombre.ToUpper(); }
            set { nombre = value; }
        }

        public Escuela(string nombre, int fecha, TiposEscuela tipo, string pais="", string ciudad="") {
            (Nombre, FechaDeCreacion, TipoEscuela, Pais, Ciudad) = (nombre, fecha, tipo, pais, ciudad);
        }


        // System.Environment.NewLine es un salto de linea válido para variados S.O
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }



    }
}