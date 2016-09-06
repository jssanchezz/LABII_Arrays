using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Alumno
    {
        public string nombre;
        public int legajo;

        public Alumno(string nomb, int leg)
        {
            this.nombre = nomb;
            this.legajo = leg;
        }

        public static bool operator ==(Alumno unAlumno, Alumno otroAlumno)
        {
            if (unAlumno.legajo == otroAlumno.legajo)
                return true;
            return false;
        }

        public static bool operator !=(Alumno unAlumno, Alumno otroAlumno)
        {
            if (unAlumno.legajo != otroAlumno.legajo)
                return true;
            return false;
        }
    }

    
}
