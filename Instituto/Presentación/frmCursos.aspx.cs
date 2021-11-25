using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Instituto.Dominio;

namespace Instituto.Presentación
{
    public partial class frmCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ListarAlumnos();
                this.ListarMateria();
                this.ListarCursos();
            }
        }

        #region Métodos Auxiliares
        private void ListarAlumnos() 
        {
            Dominio.ControladoraInstituto unaContra = new Dominio.ControladoraInstituto();
            this.lstAlumno.DataSource = null;
            this.lstAlumno.DataSource = unaContra.ListaAlumnos();
            this.lstAlumno.DataBind();
        }
        private void ListarMateria()
        {
            Dominio.ControladoraInstituto unaContra = new Dominio.ControladoraInstituto();
            this.lstMateria.DataSource = null;
            this.lstMateria.DataSource = unaContra.ListaMaterias();
            this.lstMateria.DataBind();
        }
        private bool faltanDatos() 
        {
            if (this.txtId.Text == " " || this.txtAño.Text == "" || this.txtNota.Text == "")
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        private Object devuelveObjeto(ListBox pLista, string pOjetoNombre)
        {
            if (pLista.SelectedIndex > -1)
            {
                string linea = pLista.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                Dominio.ControladoraInstituto unaContra = new ControladoraInstituto();
                switch (pOjetoNombre)
                {
                    case "Alumno":
                        Dominio.Alumno unAlumno = unaContra.BuscarAlumno(id);
                        return unAlumno;
                    case "Materia":
                        Dominio.Materia unaMateria = unaContra.BuscarMateria(id);
                        return unaMateria;
                }
            }
            return null;
        }
        private void ListarCursos() 
        {
            Dominio.ControladoraInstituto unaContra = new ControladoraInstituto();
            this.lstCursos.DataSource = null;
            this.lstCursos.DataSource = unaContra.ListaCursos();
            this.lstCursos.DataBind();
        }
        #endregion

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            ControladoraInstituto unaContra = new ControladoraInstituto();
            Alumno unAlumno;
            Materia unaMateria;
            unAlumno = (Alumno)this.devuelveObjeto(this.lstAlumno, "Alumno");
            unaMateria = (Materia)this.devuelveObjeto(this.lstMateria, "Materia");

            short id = short.Parse(this.txtId.Text);
            short año = short.Parse(this.txtAño.Text);
            short nota = short.Parse(this.txtNota.Text);
            Curso unCurso = new Curso(id, unaMateria, unAlumno, año, nota);
            if (unaContra.AltaCurso(unCurso))
            {
                this.lblMensaje.Text = "INGRESO correcto";
                this.ListarCursos();
            }
            else 
            {
                this.lblMensaje.Text = "Ups !! Houston we have problems!!";
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
        }
    }
}