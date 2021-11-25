namespace Instituto.Dominio
{
    public class Curso
    {
        // Atributos
        private int _id;
        private Materia _materia;
        private Alumno _alumno;
        private short _año;
        private short _nota;

        #region Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Materia Materia
        {
            get { return _materia; }
            set { _materia = value; }
        }

        public Alumno Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }

        public short Año
        {
            get { return _año; }
            set { _año = value; }
        }

        public short Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        #endregion

        public Curso(int pId, Materia pMateria, Alumno pAlumno, short pAño, short pNota)
        {
            this.Id = pId;
            this.Materia = pMateria;
            this.Alumno = pAlumno;
            this.Año = pAño;
            this.Nota = pNota;
        }

        public override string ToString()
        {
            return "CURSO id: "+ this.Id + ",  MATERIA: " + this.Materia.Nombre + "  --  " + this.Alumno.Nombre + 
                "  " + this.Alumno.Apellido + " " + this.Año + "  NOTA: " + this.Nota;
        }
    }
}