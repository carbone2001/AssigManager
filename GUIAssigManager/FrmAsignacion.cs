using System;
using System.Windows.Forms;
using Entidades;
using Hermanos;
namespace GUIAssigManager
{
    public partial class FrmAsignacion : Form
    {
        public Asignacion asignacion;
        public Escuela escuela;
        private FrmAsignacion()
        {
            InitializeComponent();
            foreach (EAsignacion a in EAsignacion.GetValues(typeof(EAsignacion)))
                this.cmbAsignacion.Items.Add(a);
            this.cmbAsignacion.SelectedIndex = 0;
            this.cmbEscuela.Items.Add('A'); this.cmbEscuela.Items.Add('B'); this.cmbEscuela.SelectedIndex = 0;
            this.escuela = new Escuela();
        }
        public FrmAsignacion(Escuela x) : this()
        {
            this.escuela = x;
            foreach (Hermano h in this.escuela.ListaHermanos)
            {
                if (h.Estado == true)
                {
                    this.cmbHermano.Items.Add(h.MostrarNombreApellido());
                    this.cmbAyudante.Items.Add(h.MostrarNombreApellido());
                }
            }
           
            if (this.escuela.ListaHermanos.Count == 0)
            {
                MessageBox.Show("No se ha encontrado ningun hermano!", "Lista de Hermanos vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Enabled = false;
            }

        }
        public FrmAsignacion(Asignacion a, Escuela e) : this(e)
        {
            this.cmbHermano.SelectedItem = a.Hermano.MostrarNombreApellido();
            this.cmbHermano.Enabled = false;
            this.cmbAsignacion.SelectedItem = a.Asignacion_;
            this.cmbEscuela.SelectedItem = a.Escuela;
            this.ckbRechazada.Checked = a.Rechazada;
            this.nudAspectoOratoria.Value = a.AspectoOratoria;
            if(!Object.Equals(a.Ayudante,null))
            this.cmbAyudante.SelectedItem = a.Ayudante.MostrarNombreApellido();
            this.dtpSemanaAsignacion.Value = a.Semana;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Hermano aux = null;
            if (!Object.Equals(this.cmbHermano.SelectedItem, null))
            {
                if (this.cmbAyudante.SelectedIndex != -1)
                    aux = this.escuela.ListaHermanos[this.cmbAyudante.SelectedIndex];
                this.asignacion = new Asignacion(
                    this.escuela.ListaHermanos[this.cmbHermano.SelectedIndex],
                    aux, 
                    (EAsignacion)this.cmbAsignacion.SelectedItem,
                    (int)this.nudAspectoOratoria.Value,
                    this.dtpSemanaAsignacion.Value,
                    (char)this.cmbEscuela.SelectedItem);
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
