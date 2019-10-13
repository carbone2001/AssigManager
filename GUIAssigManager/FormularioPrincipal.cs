using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.lblNombreCongregacion.Text = "Congregacion No Definida";
            this.lblNombreCongregacion.Enabled = false;
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEscuela formEscuela = new FrmEscuela();
            formEscuela.ShowDialog();
            if(formEscuela.DialogResult == DialogResult.OK)
            {
                this.escuela = formEscuela.escuela;
                this.lblNombreCongregacion.Text = this.escuela.NombreCongregacion;
                this.grbAsignacion.Enabled = true;
                this.grbHermanos.Enabled = true;
                this.escuelaToolStripMenuItem.Enabled = false;
            }
        }

        private void btnAgregarHermano_Click(object sender, EventArgs e)
        {
            FrmHermano newHermano = new FrmHermano();
            newHermano.ShowDialog();
            if(newHermano.DialogResult == DialogResult.OK)
            {
                this.escuela += newHermano.hermano;
            }
            this.ActualizarListBox();
        }
        public void ActualizarListBox()
        {
            this.lsbHermanos.Items.Clear();
            foreach(Hermano x in this.escuela.ListaHermanos)
            {
                this.lsbHermanos.Items.Add(x.ToString());
            }
        }

        private void btnEditarInfoHermano_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.lsbHermanos.SelectedItem, null))
            {
                FrmHermano formHermano = new FrmHermano(this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex]);
                formHermano.ShowDialog();
                if(formHermano.DialogResult == DialogResult.OK)
                this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex] = formHermano.hermano;
            }
            this.ActualizarListBox();
        }

        private void btnEliminarHermano_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.lsbHermanos.SelectedItem, null))
            {
                string mensaje = String.Format("¿Seguro que quiere eliminar a {0} {1}?", this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex].Apellido, this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex].Nombre);
                if(MessageBox.Show(mensaje, "Eliminar Hermano", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
                {
                    this.escuela -= this.escuela.ListaHermanos[this.lsbHermanos.SelectedIndex];
                }
            }
            this.ActualizarListBox();
        }
    }
}
