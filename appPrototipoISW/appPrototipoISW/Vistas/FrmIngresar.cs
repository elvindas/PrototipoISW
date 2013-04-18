using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPrototipoISW
{
    public partial class Loging : Form
    {
        public Loging()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((this.txtContraseña.Text.ToString() == "123") || (this.txtUsuario.Text.ToString() == "lmata"))
                this.Close();
            else
                MessageBox.Show("Nombre de usuario o contasrña incorrecta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }
    }
}
