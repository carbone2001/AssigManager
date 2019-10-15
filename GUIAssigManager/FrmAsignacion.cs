using System;
using System.Windows.Forms;
using Entidades;
namespace GUIAssigManager
{
    public partial class FrmAsignacion : Form
    {
        public Asignacion asignacion;
        private FrmAsignacion()
        {
            InitializeComponent();

            foreach (EAsignacion a in EAsignacion.GetValues(typeof(EAsignacion)))
                this.cmbAsignacion.Items.Add(a);
            this.cmbAsignacion.SelectedIndex = 0;
            this.cmbEscuela.Items.Add('A'); this.cmbEscuela.Items.Add('B'); this.cmbEscuela.SelectedIndex = 0;
        }
        public FrmAsignacion(Escuela e) : this()
        {
            foreach (Hermano h in e.ListaHermanos)
            {
                if (h.Estado == true)
                {
                    this.cmbHermano.Items.Add(h);
                }
            }
            if (e.ListaHermanos.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningun hermano!", "Lista de Hermanos vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Enabled = false;
            }

        }
        public FrmAsignacion(Asignacion a, Escuela e) : this(e)
        {
            this.cmbHermano.SelectedItem = a.Hermano;
            this.cmbHermano.Enabled = false;
            this.cmbAsignacion.SelectedItem = a.Asignacion_;
            this.cmbEscuela.SelectedItem = a.Escuela;
            this.ckbRechazada.Checked = a.Rechazada;
            this.dtpSemanaAsignacion.Value = a.Semana;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Object.Equals(this.cmbHermano.SelectedItem, null))
            {
                this.asignacion = new Asignacion((Hermano)this.cmbHermano.SelectedItem, (EAsignacion)this.cmbAsignacion.SelectedItem, this.dtpSemanaAsignacion.Value, (char)this.cmbEscuela.SelectedItem);
                this.asignacion.Rechazada = this.ckbRechazada.Checked;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hermano para continuar!", "Error al Seleccionar Hermano", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
