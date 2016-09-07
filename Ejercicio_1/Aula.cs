using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Aula
    {
        public int numero;
        public Alumno[] listaDeAlumnos;

        public Aula()
        {
            this.listaDeAlumnos = new Alumno[10];

            /*for (int i = 0; i < 10; i++)
            {
                this.listaDeAlumnos[i] = new Alumno(null, 0);
            }

            foreach (Alumno alumno in this.listaDeAlumnos)
            {
                alumno.nombre = "Natalia";
            }*/
        }

        public void MostrarAlumnos(Aula aula)
        {
            foreach (Alumno alumno in aula.listaDeAlumnos)
            {
                if ((object)alumno != null)
                {
                    Console.WriteLine(alumno.nombre);
                    Console.WriteLine(alumno.legajo);
                }
                
            }
        }

        /// <summary>
        /// Devuelve el indice del primer elemento null, de lo contrario retorna -1
        /// </summary>
        /// <returns></returns>
        public int ObtenerIndice()
        {
            int contador;

            for (contador = 0; contador < 10; contador++)
            {
                if((object)this.listaDeAlumnos[contador]==null)
                    break;
            }

            if(contador < 10)
                return contador;
            else
                return -1;
        }

        /// <summary>
        /// Retorna el indice del objeto, de lo contrario retorna -1.
        /// </summary>
        /// <param name="unAlumno"></param>
        /// <returns></returns>
        public int ObtenerIndice(Alumno unAlumno)
        {
            int i;

            for ( i = 0; i < 10; i++)
            {
                if ((object)this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i] == unAlumno)
                    break;
            }

            if (i < 10)
                return i;
            else
                return -1;
        }

        public void AgregarAlumno(Alumno unAlumno)
        {
            int indice = this.ObtenerIndice();

            if (this.ExisteAlumno(unAlumno))
            {
                if (indice != -1)
                    this.listaDeAlumnos[indice] = unAlumno;
                else
                    Console.WriteLine("No hay lugar.");            
            }
        }

        public void BorrarAlumno(Alumno unAlumno)
        {
            for (int i = 0; i < 10; i++)
            {
                if ((object)this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i] == unAlumno)
                {
                    this.listaDeAlumnos[i] = null;
                    break;
                }
            }
        }

        public bool ExisteAlumno(Alumno unAlumno)
        {
            int indice = this.ObtenerIndice(unAlumno);

            if (indice == -1)
                return true;
            return false;
        }

        static public bool operator ==(Aula elAula, Alumno unAlumno)//Si El aula contiene un alumno especifico
        {
            if (elAula.ExisteAlumno(unAlumno))
                return true;
            return false;
        }

        static public bool operator !=(Aula elAula, Alumno unAlumno)
        {
            if (elAula.ExisteAlumno(unAlumno))
                return false;
            return true;
        }

        static public Aula operator +(Aula elAula, Alumno unAlumno)//Agrega un alumno al aula
        {
            elAula.AgregarAlumno(unAlumno);
            return elAula;
        }

        static public Aula operator -(Aula elAula, Alumno unAlumno)//Borra un alumno del aula
        {
            elAula.BorrarAlumno(unAlumno);
            return elAula;
        }
    }

}
