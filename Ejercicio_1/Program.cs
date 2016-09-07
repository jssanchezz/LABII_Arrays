using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula nuevaAula;
            
            nuevaAula = new Aula();

            Alumno primerAlumno;
            primerAlumno = new Alumno("Juan", 123);
            nuevaAula = nuevaAula + primerAlumno;

            Alumno segundoAlumno;
            segundoAlumno = new Alumno("Marta", 124);
            nuevaAula = nuevaAula + segundoAlumno;

            Alumno tercerAlumno;
            tercerAlumno = new Alumno("Pepe", 455);
            nuevaAula = nuevaAula + tercerAlumno;


            nuevaAula = nuevaAula - tercerAlumno;

            Alumno cuartoAlumno;
            cuartoAlumno = new Alumno("Gaston", 655);
            nuevaAula = nuevaAula + cuartoAlumno;

            
            nuevaAula.AgregarAlumno(primerAlumno);
            
            nuevaAula.AgregarAlumno(segundoAlumno);
            
            nuevaAula.AgregarAlumno(tercerAlumno);

            

            nuevaAula.MostrarAlumnos(nuevaAula);
            
            Console.ReadKey();

            

            
        }
    }
}
