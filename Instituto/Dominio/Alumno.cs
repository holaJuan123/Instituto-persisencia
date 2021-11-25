namespace Instituto.Dominio
{
    public class Alumno
    {
        // Atributos
        private int _id;
        private string _nombre;
        private string _apellido;

        #region Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        #endregion

        public Alumno(int pId, string pNombre, string pApellido)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }

        public Alumno() { }
        public override string ToString()
        {
            return this.Id + "  " + this.Nombre + "  " + this.Apellido;
        }
    }
}
