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
    public partial class FrmAsignarPlan : Form
    {
        int i = 0;
        public FrmAsignarPlan()
        {
            InitializeComponent();
            i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i += 1;
            richTextBox1.AppendText("\nCodigo del Animal             0"+i+" \n" + "Codigo del Plan                001 \n" + "-----------------------------------------------------------------------");
            MessageBox.Show("Se ha Registrado Correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Replace("\nCodigo del Animal             0" + i + " \n" + "Codigo del Plan                001 \n" + "-----------------------------------------------------------------------", "");
                i -= 1;
            }
            else MessageBox.Show("No hay datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                MessageBox.Show("Se ha Registrado Correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Clear();
                i = 0;
            }
            else MessageBox.Show("No hay datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
    }
}
