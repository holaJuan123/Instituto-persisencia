using Instituto.Dominio;
using System.Web.UI.WebControls;
using System;

namespace Instituto.Presentación
{
    public partial class frmAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.Listar();
            }
        }

        #region Métodos Auxiliares
        private bool faltanDatos()
        {
            if (this.txtId.Text == "" || this.txtNombre.Text == "" || this.txtApellido.Text == "")
            {
                return true;
            }
            return false;
        }
        private void Listar()
        {
            this.lstAlumnos.DataSource = null;
            Dominio.ControladoraInstituto unaContra = new ControladoraInstituto();
            this.lstAlumnos.DataSource = unaContra.ListaAlumnos();
            this.lstAlumnos.DataBind();
        }
        private void cargarAlumno(short pId)
        {
            Dominio.ControladoraInstituto unaContra = new Dominio.ControladoraInstituto();
            Dominio.Alumno unAlumno = unaContra.BuscarAlumno(pId);
            this.txtId.Text = unAlumno.Id.ToString();
            this.txtNombre.Text = unAlumno.Nombre;
            this.txtApellido.Text = unAlumno.Apellido;
        }
        private void Limpiar()
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.lblMensajes.Text = ".";
            this.txtId.Focus();
        }

        

        #endregion
        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!this.faltanDatos())
            {
                int id = Convert.ToInt16(this.txtId.Text);
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;

                Alumno unAlumno = new Alumno(id, nombre, apellido);
                ControladoraInstituto dominio = new ControladoraInstituto();
                if (dominio.AltaAlumno(unAlumno))
                {
                    this.lblMensajes.Text = "Alumno dado de alta con exito.";
                    this.Listar();
                    this.Limpiar();
                }
                else
                {
                    this.lblMensajes.Text = "Ya existe Alumno con este Id.";
                }

            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            ControladoraInstituto dominio = new ControladoraInstituto();
            if (dominio.BajaAlumno(id))
            {
                this.lblMensajes.Text = "Alumno fue dato de baja, todo salió bien.";
                this.Listar();
                this.Limpiar();
            }
            else
            {
                this.lblMensajes.Text = "Baja falló.";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            Alumno unAlumno = new Alumno(id, nombre, apellido);
            ControladoraInstituto dominio = new ControladoraInstituto();
            if (dominio.ModificarAlumno(unAlumno))
            {
                this.lblMensajes.Text = "Alumno modificado, todo salió bien.";
                this.Listar();
                this.Limpiar();
            }
            else
            {
                this.lblMensajes.Text = "Modificar falló.";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.lstAlumnos.SelectedIndex > -1)
            {
                string linea = this.lstAlumnos.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                this.cargarAlumno(id);
                this.lstAlumnos.SelectedIndex = -1;
            }
            else
            {
                this.lblMensajes.Text = "Debe seleccionar un alumno de la lista.";
            }
        }


    }
}