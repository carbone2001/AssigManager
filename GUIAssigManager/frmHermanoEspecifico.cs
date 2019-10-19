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
using Hermanos;

namespace GUIAssigManager
{
    public partial class frmHermanoEspecifico : Form
    {
        private Escuela escuela;
        public frmHermanoEspecifico()
        {
            InitializeComponent();
            foreach(ETipoOrdenamiento x in ETipoOrdenamiento.GetValues(typeof(ETipoOrdenamiento)))
                this.cmbOrdenamientos.Items.Add(x);
            this.cmbOrdenamientos.SelectedIndex = 0;

        }
        public frmHermanoEspecifico(Escuela e):this()
        {
            foreach (Hermano h in e.ListaHermanos)
                this.cmbListaDeHermanos.Items.Add(h);
            this.escuela = e;
            if (this.escuela.ListaHermanos.Count > 0)
                this.cmbListaDeHermanos.SelectedIndex = 0;
        }

        private void cmbListaDeHermanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(!Object.Equals(null, this.cmbListaDeHermanos.SelectedItem))
                {
                    this.lsbListaAsignacionesDelHermano.Items.Clear();
                    Hermano h = (Hermano)this.cmbListaDeHermanos.SelectedItem;
                    switch ((ETipoOrdenamiento)this.cmbOrdenamientos.SelectedItem)
                    {
                        case ETipoOrdenamiento.Ascendente:
                            this.escuela.ListaAsignaciones.Sort(Asignacion.OrdenarPorFechaAsc);
                            break;
                        case ETipoOrdenamiento.Descendente:
                            this.escuela.ListaAsignaciones.Sort(Asignacion.OrdenarPorFechaDesc);
                            break;
                    }

                    foreach (Asignacion x in this.escuela.ListaAsignaciones)
                    {
                        if (x.Hermano == h)
                            this.lsbListaAsignacionesDelHermano.Items.Add(x);

                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOrdenamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbListaDeHermanos_SelectedIndexChanged(sender, e);
        }
    }
}
