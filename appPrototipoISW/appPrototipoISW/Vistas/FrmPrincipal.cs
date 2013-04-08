using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPrototipoISW.Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tablasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Aplicado el Plan", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsignarPlan plan = new FrmAsignarPlan();
            plan.ShowDialog();
        }

        private void alimentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanes s = new FrmPlanes();
            s.ShowDialog();
        }

        private void registraNacimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnimales s = new FrmAnimales();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Registrado Correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
