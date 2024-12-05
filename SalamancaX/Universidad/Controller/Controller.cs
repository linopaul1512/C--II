using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Universidad.Modelos;

namespace Universidad.Controller
{
    internal class Controller
    {
        //) Todas las secciones de una asignatura en particular, ordenadas de forma descendente por su cantidad de estudiantes
        public List<Seccion> seciones_asignatura (Asignatura asignatura)
        {
            
            using (var db = new UniversidadContext())
            {
                var found = db.Secciones.OrderByDescending(x => x.Estudiantes).Where(y => y.Asignatura == asignatura).ToList();
                return found;
            };
        }

        //Cuáles asignaturas está cursando un estudiante
        public List<Asignatura> search_students_asignatures(Estudiante estudiante)
        {
            using (var db = new UniversidadContext())
            {
                var found = db.Asignaturas.Where(x => x.Secciones.Where(y => y.Estudiantes.Contains(estudiante)).Any()).ToList();
                return found;
            }

        }

        //Cuáles son los estudiantes de una carrera.
        public List<Estudiante> studiantes_carrera(Carrera carrera)
        {
            using (var db = new UniversidadContext())
            {
                var found = db.Estudiantes.Where(y => y.Carrera == carrera).ToList();
                return found;
            }

        }
    }
}
