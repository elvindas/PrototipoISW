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
    public partial class FrmPlanes : Form
    {
        public FrmPlanes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tollEmpleados.Enabled = false;
            BoxActividad.Enabled = true;
            BtnCambiar.Enabled = false;
            BtnAceptar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            tollEmpleados.Enabled = false;
            this.BoxActividad.Enabled = true;
            this.BtnAceptar.Enabled = false;
            this.BtnCambiar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha borrado el Dato con exito", "Borrar Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insertó Dato con exito", "Inserta Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BoxActividad.Enabled = false;
            this.TxtCodigo.Text = "";
            this.TxtNombre.Text = "";
            this.CmbTipo.Text = "";
            tollEmpleados.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.BoxActividad.Enabled = false;
            this.TxtCodigo.Text = "";
            this.TxtNombre.Text = "";
            this.CmbTipo.Text = "";
            tollEmpleados.Enabled = true;
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edito Dato con exito", "Editar Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BoxActividad.Enabled = false;
            this.TxtCodigo.Text = "";
            this.TxtNombre.Text = "";
            this.CmbTipo.Text = "";
            tollEmpleados.Enabled = true;
        }
    }
}
