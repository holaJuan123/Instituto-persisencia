using Instituto.Persistencia;
using System.Collections.Generic;

namespace Instituto.Dominio
{
    public class ControladoraInstituto
    {
        public ControladoraInstituto()
        {
            this._persistencia = new ControladoraPersistencia();
            this._listaAlumnos = _persistencia.ListaAlumnos();
            this._listaMaterias = _persistencia.ListaMaterias();
        }
        private ControladoraPersistencia _persistencia;
        private List<Alumno> _listaAlumnos;
        private List<Materia> _listaMaterias;
        private static List<Curso> _listaCursos = new List<Curso>();

        #region ABM Alumnos

        public List<Alumno> ListaAlumnos()
        {
            return this._listaAlumnos;
        }

        public Alumno BuscarAlumno(int pId)
        {
            foreach (Alumno unAlumno in this._listaAlumnos)
            {
                if (unAlumno.Id == pId)
                {
                    return unAlumno;
                }
            }
            return null;
        }

        public bool AltaAlumno(Alumno pAlumno)
        {
            if (this.BuscarAlumno(pAlumno.Id) == null)
            {
                if (this._persistencia.AltaAlumno(pAlumno))
                {
                    this._listaAlumnos.Add(pAlumno);
                    return true;
                }
            }
            return false;
        }

        public bool BajaAlumno(int pId)
        {
            Alumno unAlumno = this.BuscarAlumno(pId);
            if (unAlumno != null)
            {
                if (this._persistencia.BajaAlumno(pId))
                {
                    return this._listaAlumnos.Remove(unAlumno);
                }
            }
            return false;
        }

        public bool ModificarAlumno(Alumno pAlumno)
        {
            Alumno unAlumno = this.BuscarAlumno(pAlumno.Id);
            if (unAlumno != null)
            {
                if (this._persistencia.ModificarAlumno(pAlumno))
                {
                    unAlumno.Nombre = pAlumno.Nombre;
                    unAlumno.Apellido = pAlumno.Apellido;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region ABM Materias

        public List<Materia> ListaMaterias()
        {
            return this._listaMaterias;
        }

        public Materia BuscarMateria(int pId)
        {
            foreach (Materia unaMateria in this._listaMaterias)
            {
                if (unaMateria.Id == pId)
                {
                    return unaMateria;
                }
            }
            return null;
        }

        public bool AltaMateria(Materia pMateria)
        {
            if (this.BuscarMateria(pMateria.Id) == null)
            {
                if (this._persistencia.AltaMateria(pMateria))
                {
                    this._listaMaterias.Add(pMateria);
                    return true;
                }
            }
            return false;
        }

        public bool BajaMateria(int pId)
        {
            Materia unaMateria = this.BuscarMateria(pId);
            if (unaMateria != null)
            {
                if (this._persistencia.BajaMateria(pId))
                {
                    return this._listaMaterias.Remove(unaMateria);
                }
            }
            return false;
        }

        public bool ModificarMateria(Materia pMateria)
        {
            Materia unaMateria = this.BuscarMateria(pMateria.Id);
            if (unaMateria != null)
            {
                if (this._persistencia.ModificarMateria(pMateria))
                {
                    unaMateria.Nombre = pMateria.Nombre;
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region ABM Cursos

        public List<Curso> ListaCursos()
        {
            return _listaCursos;
        }

        public Curso BuscarCurso(int pId)
        {
            foreach (Curso unCurso in _listaCursos)
            {
                if (unCurso.Id == pId)
                {
                    return unCurso;
                }
            }
            return null;
        }

        public bool AltaCurso(Curso pCurso)
        {
            if (this.BuscarCurso(pCurso.Id) == null)
            {
                _listaCursos.Add(pCurso);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BajaCurso(int pId)
        {
            Curso unCurso = this.BuscarCurso(pId);
            if (unCurso == null)
            {
                return false;
            }
            else
            {
                return _listaCursos.Remove(unCurso);
            }
        }

        public bool ModificarCurso(Curso pCurso)
        {
            Curso unCurso = this.BuscarCurso(pCurso.Id);
            if (unCurso == null)
            {
                return false;
            }
            else
            {
                unCurso.Materia = pCurso.Materia;
                unCurso.Alumno = pCurso.Alumno;
                unCurso.Año = pCurso.Año;
                unCurso.Nota = pCurso.Nota;
                return true;
            }
        }

        #endregion
    }
}