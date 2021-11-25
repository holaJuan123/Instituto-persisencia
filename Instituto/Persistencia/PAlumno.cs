using Instituto.Dominio;
using System.Collections.Generic;
using System.Data;

namespace Instituto.Persistencia
{
    public class PAlumno
    {
        private Conexión _conexión = new Conexión();

        public List<Alumno> Lista()
        {
            string sql = "SELECT * FROM alumnos";
            DataSet datos = this._conexión.Selección(sql);
            List<Alumno> lista = new List<Alumno>();
            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Alumno unAlumno = new Alumno(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    fila[2].ToString());
                lista.Add(unAlumno);
            }
            return lista;
        }

        public bool Alta(Alumno pAlumno)
        {
            string sql = "INSERT INTO alumnos (id,nombre,apellido) VALUES("
                + pAlumno.Id.ToString() + ",'"
                + pAlumno.Nombre + "','"
                + pAlumno.Apellido + "')";
            return this._conexión.Consulta(sql);
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM alumnos WHERE id=" + pId.ToString();
            return this._conexión.Consulta(sql);
        }

        public bool Modificar(Alumno pAlumno)
        {
            string sql = "UPDATE alumnos SET "
                + "nombre='" + pAlumno.Nombre + "',"
                + "apellido='" + pAlumno.Apellido + "' "
                + "WHERE id=" + pAlumno.Id.ToString();
            return this._conexión.Consulta(sql);
        }
    }
}
