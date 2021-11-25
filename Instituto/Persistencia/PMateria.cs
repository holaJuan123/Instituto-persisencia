using Instituto.Dominio;
using System.Collections.Generic;
using System.Data;

namespace Instituto.Persistencia
{
    public class PMateria
    {
        private Conexión _conexión = new Conexión();

        public List<Materia> Lista()
        {
            string sql = "SELECT * FROM materias";
            DataSet datos = this._conexión.Selección(sql);
            List<Materia> lista = new List<Materia>();
            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Materia unaMateria = new Materia(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString());
                lista.Add(unaMateria);
            }
            return lista;
        }

        public bool Alta(Materia pMateria)
        {
            string sql = "INSERT INTO materias (id,nombre) VALUES("
                + pMateria.Id.ToString() + ",'"
                + pMateria.Nombre + "')";
            return this._conexión.Consulta(sql);
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM materias WHERE id=" + pId.ToString();
            return this._conexión.Consulta(sql);
        }

        public bool Modificar(Materia pMateria)
        {
            string sql = "UPDATE materias SET "
                + "nombre='" + pMateria.Nombre + "' "
                + "WHERE id=" + pMateria.Id.ToString();
            return this._conexión.Consulta(sql);
        }
    }
}