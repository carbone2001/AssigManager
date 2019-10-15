using System;
using System.Windows.Forms;
using Entidades;
namespace GUIAssigManager
{
    public partial class FormularioPrincipal : Form
    {
        Escuela escuela;
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            escuela = new Escuela();
            this.grbAsignacion.Enabled = false;
            this.grbHermanos.Enabled = false;
            this.Text = "AssigManager (Congregacion No Definida)";
            foreach (ETipoOrdenamiento p in ETipoOrdenamiento.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenamientoHermanos.Items.Add(p);
            }

            this.cmbOrdenamientoHermanos.SelectedIndex = 0;
            foreach (ETipoOrdenamientoAsignacion p in ETipoOrdenamientoAsignacion.GetValues(typeof(ETipoOrdenamientoAsignacion)))
            {
                this.cmbOrdenamientoAsignaciones.Items.Add(p);
            }
            this.cmbOrdenamientoAsignaciones.SelectedIndex = 0;
            foreach (EMeses p in EMeses.GetValues(typeof(EMeses)))
            {
                this.cmbMes.Items.Add(p);
            }
            this.cmbMes.SelectedIndex = DateTime.Now.Month - 1;

            this.cmbAño.Items.Add(DateTime.Now.Year);
            this.cmbAño.SelectedItem = DateTime.Now.Year;
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEscuela formEscuela = new FrmEscuela();
            formEscuela.ShowDialog();
            if (formEscuela.DialogResult == DialogResult.OK)
            {
                this.escuela = formEscuela.escuela;
                this.Text = String.Format("AssigManager ({0})", this.escuela.NombreCongregacion);
                this.grbAsignacion.Enabled = true;
                this.grbHermanos.Enabled = true;
                this.escuelaToolStripMenuItem.Enabled = false;
            }
        }

        private void btnAgregarHermano_Click(object sender, EventArgs e)
        {
            FrmHermano newHermano = new FrmHermano();
            newHermano.ShowDialog();
            if (newHermano.DialogResult == DialogResult.OK)
            {
                this.escuela += newHermano.hermano;
            }
            this.ActualizarListBox();
        }
        public void ActualizarListBox()
        {
            this.lsbHermanos.Items.Clear();
            this.lsbAsignaciones.Items.Clear();
            foreach (Asignacion p in this.escuela.ListaAsignaciones)
            {
                if (this.cmbAño.Items.IndexOf(p.Semana.Year) == -1)
                    this.cmbAño.Items.Add(p.Semana.Year);
            }
            switch ((ETipoOrdenamiento)this.cmbOrdenamientoHermanos.SelectedItem)
            {
                case ETipoOrdenamiento.Ascendente:
                    this.escuela.ListaHermanos.Sort(Hermano.OrdenarPorApellidoAsc);
                    break;
                case ETipoOrdenamiento.Descendente:
                    this.escuela.ListaHermanos.Sort(Hermano.OrdenarPorApellidoDesc);
                    break;
            }
            if (!Object.Equals(null, this.cmbOrdenamientoAsignaciones.SelectedItem))
                switch ((ETipoOrdenamientoAsignacion)this.cmbOrdenamientoAsignaciones.SelectedItem)
                {
                    case ETipoOrdenamientoAsignacion.Fecha_Ascendente:
                        this.escuela.ListaAsignaciones.Sort(Asignacion.OrdenarPorFechaAsc);
                        break;
                    case ETipoOrdenamientoAsignacion.Fecha_Descendente:
                        this.escuela.ListaAsignaciones.Sort(Asignacion.OrdenarPorFechaDesc);
                        break;
                    default:
                        break;
                }

            foreach (Hermano x in this.escuela.ListaHermanos)
            {
                this.lsbHermanos.Items.Add(x.ToString());
            }
            foreach (Asignacion x in this.escuela.ListaAsignaciones)
            {
                if (x.Semana.Month == this.cmbMes.SelectedIndex + 1 && x.Semana.Year == (int)this.cmbAño.SelectedItem)
                    this.lsbAsignaciones.Items.Add(x.ToString());
            }
        }

        private void btnEditarInfoHermano_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.lsbHermanos.SelectedItem, null))
            {
                FrmHermano formHermano = new FrmHermano(this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex]);
                formHermano.ShowDialog();
                if (formHermano.DialogResult == DialogResult.OK)
                    this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex] = formHermano.hermano;
            }
            this.ActualizarListBox();
        }

        private void btnEliminarHermano_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.lsbHermanos.SelectedItem, null))
            {
                string mensaje = String.Format("¿Seguro que quiere eliminar a {0} {1}?", this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex].Apellido, this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex].Nombre);
                if (MessageBox.Show(mensaje, "Eliminar Hermano", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.escuela -= this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex];
                }
            }
            this.ActualizarListBox();
        }

        private void cmbOrdenamientoHermanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarListBox();
        }

        private void btnAgregarAsignacion_Click(object sender, EventArgs e)
        {
            FrmAsignacion formAsignacion = new FrmAsignacion(this.escuela);
            if (formAsignacion.DialogResult != DialogResult.Cancel)
            {
                formAsignacion.ShowDialog();
                if (formAsignacion.DialogResult != DialogResult.Cancel)
                {
                    this.escuela += formAsignacion.asignacion;
                }
            }
            this.ActualizarListBox();


        }

        private void btnEditarAsignaciones_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.lsbAsignaciones.SelectedItem, null))
            {
                FrmAsignacion formAsignacion = new FrmAsignacion(this.escuela.ListaAsignaciones[this.lsbAsignaciones.SelectedIndex], this.escuela);
                if (formAsignacion.DialogResult != DialogResult.Cancel)
                {
                    formAsignacion.ShowDialog();
                    if (formAsignacion.DialogResult == DialogResult.OK)
                        this.escuela.ListaAsignaciones[this.lsbAsignaciones.SelectedIndex] = formAsignacion.asignacion;
                }
            }
            this.ActualizarListBox();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarListBox();
        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarListBox();
        }

        private void cmbOrdenamientoAsignaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarListBox();
        }

        private void btnEliminarAsignaciones_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.lsbAsignaciones.SelectedItem, null))
            {
                string mensaje = String.Format("¿Seguro que quiere eliminar esta asignacion?");
                if (MessageBox.Show(mensaje, "Eliminar Asignacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.escuela -= this.escuela.ListaAsignaciones[this.lsbAsignaciones.SelectedIndex];
                }
            }
            this.ActualizarListBox();
        }

        private void btnBuscarAsignaciones_Click(object sender, EventArgs e)
        {
            FrmAsignacion formAsignacion = new FrmAsignacion(this.escuela);


            if (!(formAsignacion.DialogResult == DialogResult.Cancel))
            {
                formAsignacion.ShowDialog();
                if (formAsignacion.DialogResult == DialogResult.OK)
                    if (this.escuela == formAsignacion.asignacion)
                    {
                        this.cmbMes.SelectedIndex = formAsignacion.asignacion.Semana.Month - 1;
                        this.cmbAño.SelectedItem = formAsignacion.asignacion.Semana.Year;
                        this.cmbOrdenamientoAsignaciones.SelectedItem = formAsignacion.asignacion;
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado la asignacion.", "Buscar Asignacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
            }



        }
    }
}
