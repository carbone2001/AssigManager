using System;
using System.Windows.Forms;
using Entidades;
using Hermanos;
namespace GUIAssigManager
{
    public partial class FrmHermano : Form
    {
        public Hermano hermano;
        public FrmHermano()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.hermano = new Hermano();
            foreach (EPrivilegio p in EPrivilegio.GetValues(typeof(EPrivilegio)))
            {
                this.cmbPrivilegio.Items.Add(p);
            }
            this.txtApellido.Text = this.hermano.Apellido;
            this.txtNombre.Text = this.hermano.Nombre;
            this.txtNumeroTelefono.Text = this.hermano.Telefono;
            this.nudEdad.Value = (Decimal)this.hermano.Edad;
            this.ckbBautizado.Checked = this.hermano.Bautizado;
            this.cmbPrivilegio.SelectedItem = this.hermano.Privilegio;
            this.ckbHabilitado.Checked = true;
        }
        public FrmHermano(Hermano h) : this()
        {
            this.txtApellido.Text = h.Apellido;
            this.txtNombre.Text = h.Nombre;
            this.txtNumeroTelefono.Text = h.Telefono;
            this.nudEdad.Value = (Decimal)h.Edad;
            this.ckbBautizado.Checked = h.Bautizado;
            this.cmbPrivilegio.SelectedItem = h.Privilegio;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.hermano = new Hermano(this.txtApellido.Text, this.txtNombre.Text, (int)this.nudEdad.Value, this.txtNumeroTelefono.Text, this.ckbBautizado.Checked, this.ckbHabilitado.Checked, (EPrivilegio)this.cmbPrivilegio.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
