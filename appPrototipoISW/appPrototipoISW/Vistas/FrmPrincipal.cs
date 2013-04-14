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
            CmbTipo.Items.Add("Emicina");
            CmbTipo.Items.Add("Baymec");
            CmbTipo.Items.Add("Paracitol");
        }

        private void tablasToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            textBox4.Text = "";
            groupBox3.Visible = false;
            button3.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
                this.groupBox2.Visible = true;
            else this.groupBox2.Visible = false;
        }

        private void BtnCambiar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha Aplicado el Plan", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            button3.Enabled = true;
        }
    }
}
