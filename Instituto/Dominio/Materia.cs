namespace Instituto.Dominio
{
    public class Materia
    {
        // Atributos
        private int _id;
        private string _nombre;

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

        #endregion

        public Materia(int pId, string pNombre)
        {
            this.Id = pId;
            this.Nombre = pNombre;
        }

        public override string ToString()
        {
            return this.Id + "  " + this.Nombre;
        }
    }
}