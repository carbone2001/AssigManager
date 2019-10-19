using System;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Hermanos;
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
            this.hermanientasToolStripMenuItem.Enabled = false;
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
                this.hermanientasToolStripMenuItem.Enabled = true;
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
                this.lsbHermanos.Items.Add(x);
            }
            foreach (Asignacion x in this.escuela.ListaAsignaciones)
            {
                if (x.Semana.Month == this.cmbMes.SelectedIndex + 1 && x.Semana.Year == (int)this.cmbAño.SelectedItem)
                    this.lsbAsignaciones.Items.Add(x);
            }
        }

        private void btnEditarInfoHermano_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.lsbHermanos.SelectedItem, null))
            {
                FrmHermano formHermano = new FrmHermano((Hermano)this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex]);
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
                FrmAsignacion formAsignacion = new FrmAsignacion((Asignacion)this.lsbAsignaciones.SelectedItem, this.escuela);
                if (formAsignacion.DialogResult != DialogResult.Cancel)
                {
                    formAsignacion.ShowDialog();
                    if (formAsignacion.DialogResult == DialogResult.OK)
                        this.escuela.ListaAsignaciones[this.escuela.ListaAsignaciones.IndexOf((Asignacion)this.lsbAsignaciones.SelectedItem)] = formAsignacion.asignacion;
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
                {
                    if (this.escuela == formAsignacion.asignacion)
                    {
                        this.cmbMes.SelectedIndex = formAsignacion.asignacion.Semana.Month - 1;
                        this.cmbAño.SelectedItem = formAsignacion.asignacion.Semana.Year;
                        this.lsbAsignaciones.SelectedItem = formAsignacion.asignacion.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado la asignacion.", "Buscar Asignacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnBuscarHermano_Click(object sender, EventArgs e)
        {
            FrmHermano frmHermano = new FrmHermano();
            if (!(frmHermano.DialogResult == DialogResult.Cancel))
            {
                frmHermano.ShowDialog();
                if (frmHermano.DialogResult == DialogResult.OK)
                    if (this.escuela == frmHermano.hermano)
                    {
                        this.lsbHermanos.SelectedItem = frmHermano.hermano.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado al hermano.", "Buscar Hermano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void cambiarNombreDeCongregacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEscuela formEscuela = new FrmEscuela();
            formEscuela.ShowDialog();
            if (formEscuela.DialogResult == DialogResult.OK)
            {
                this.escuela = formEscuela.escuela;
                this.Text = String.Format("AssigManager ({0})", this.escuela.NombreCongregacion);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();

            DialogResult result = fb.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("FUNCION EN ESTADO DE PRUBA!", "FUNCION EN ESTADO DE PRUBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult result = fb.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter archivoAGuardar = new StreamWriter(fb.SelectedPath + "\\DATA_ASSIGMANAGER.txt"))
                    {
                        foreach (Asignacion x in this.escuela.ListaAsignaciones)
                        {
                            archivoAGuardar.WriteLine(x.ToString());
                        }
                        MessageBox.Show("El archivo se ha guardado con exito!", "Archivo Guardado", MessageBoxButtons.OK);
                    }
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
            }
        }

        private void btnVolverAHoy_Click(object sender, EventArgs e)
        {
            this.cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            this.cmbAño.SelectedItem = DateTime.Now.Year;
        }

        private void btnAsignacionesHermanoEspecifico_Click(object sender, EventArgs e)
        {
            frmHermanoEspecifico h = new frmHermanoEspecifico(this.escuela);
            h.ShowDialog();
        }
    }
}
