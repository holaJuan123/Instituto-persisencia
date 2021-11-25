using Instituto.Dominio;
using System;

namespace Instituto.Presentación
{
    public partial class frmMaterias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.Listar();
            }
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            int idT = Convert.ToInt16(this.textoId.Text);
            string nombreT = this.textoNombre.Text;

            Materia unaMateria = new Materia(idT, nombreT);
            ControladoraInstituto dominio = new ControladoraInstituto();
            if (dominio.AltaMateria(unaMateria))
            {
                this.lblMensajes.Text = "Alta salió bien.";
                this.Listar();
                this.Limpiar();
            }
            else
            {
                this.lblMensajes.Text = "Alta falló.";
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.textoId.Text);
            ControladoraInstituto dominio = new ControladoraInstituto();
            if (dominio.BajaMateria(id))
            {
                this.lblMensajes.Text = "Baja salió bien.";
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
            int id = int.Parse(this.textoId.Text);
            string nombre = this.textoNombre.Text;
            Materia unaMateria = new Materia(id, nombre);
            ControladoraInstituto dominio = new ControladoraInstituto();
            if (dominio.ModificarMateria(unaMateria))
            {
                this.lblMensajes.Text = "Modificar salió bien.";
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

        private void Listar()
        {
            ControladoraInstituto dominio = new ControladoraInstituto();
            this.lstMat.DataSource = dominio.ListaMaterias();
            this.lstMat.DataBind();
        }

        private void Limpiar()
        {
            this.textoId.Text = "";
            this.textoNombre.Text = "";
            this.textoId.Focus();
        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.lstMat.SelectedIndex > -1)
            {
                string linea = this.lstMat.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                this.cargarMateria(id);
                this.lstMat.SelectedIndex = -1;
            }

            else
            {
                this.lblMensajes.Text = "Debe seleccionar una materia de la lista.";
            }
        }

        private void cargarMateria(short pId)
        {
            Dominio.ControladoraInstituto unaContra = new Dominio.ControladoraInstituto();
            Dominio.Materia unMateria = unaContra.BuscarMateria(pId);
            this.textoId.Text = unMateria.Id.ToString();
            this.textoNombre.Text = unMateria.Nombre;
        }
    }
}
