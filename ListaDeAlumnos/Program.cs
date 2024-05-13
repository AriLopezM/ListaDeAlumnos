using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeAlumnos
{
    public partial class Universidad
    {
        private List<Alumnos> listaAlumnos;

        // Constructor para inicializar la lista de alumnos
        public Universidad()
        {
            listaAlumnos = new List<Alumnos>();
        }

        // Método para agregar un nuevo alumno a la lista
        public void AgregarAlumno(Alumnos alumno)
        {
            listaAlumnos.Add(alumno);
        }

        // Método para obtener la lista de alumnos
        public List<Alumnos> ObtenerListaAlumnos()
        {
            return listaAlumnos;
        }
    }
}
