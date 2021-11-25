using Instituto.Dominio;
using System.Collections.Generic;

namespace Instituto.Persistencia
{
    public class ControladoraPersistencia
    {
        #region Persistencia Alumno

        public bool AltaAlumno(Alumno pAlumno)
        {
            return new PAlumno().Alta(pAlumno);
        }

        public bool BajaAlumno(int pId)
        {
            return new PAlumno().Baja(pId);
        }

        public bool ModificarAlumno(Alumno pAlumno)
        {
            return new PAlumno().Modificar(pAlumno);
        }

        public List<Alumno> ListaAlumnos()
        {
            return new PAlumno().Lista();
        }

        #endregion

        #region Persistencia Materia

        public bool AltaMateria(Materia pMateria)
        {
            return new PMateria().Alta(pMateria);
        }

        public bool BajaMateria(int pId)
        {
            return new PMateria().Baja(pId);
        }

        public bool ModificarMateria(Materia pMateria)
        {
            return new PMateria().Modificar(pMateria);
        }

        public List<Materia> ListaMaterias()
        {
            return new PMateria().Lista();
        }

        #endregion
    }
}
