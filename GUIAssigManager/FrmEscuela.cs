using System;
using System.Windows.Forms;
using Entidades;
namespace GUIAssigManager
{
    public partial class FrmEscuela : Form
    {
        public Escuela escuela;
        public FrmEscuela()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.escuela = new Escuela(txtNombreCongregacion.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
