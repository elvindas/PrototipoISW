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
            DataTable Tabla2 = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon2;//Esta variable de tipo DataRow solo la declaramos y mas adelante la utilizaremos para agregarsela al dataTable que ya declaramos arriba 
            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla2.Columns.Add(new DataColumn("Codigo Plan"));
            Tabla2.Columns.Add(new DataColumn("Codigo Vacuna"));
            Tabla2.Columns.Add(new DataColumn("Descripcion"));
            Tabla2.Columns.Add(new DataColumn("Observaciones"));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon2 = Tabla2.NewRow();
            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            Renglon2[0] = "002";
            Renglon2[1] = "02";
            Renglon2[2] = "Desparasitante";
            Renglon2[3] = "2 cm /kg";
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            Tabla2.Rows.Add(Renglon2);
            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            GridAtractivo.DataSource = Tabla2;
            string[] Option2 = { "Emicina", "Baymec", "Paracitol" };
            // cargar los valores por defecto en el combo
            foreach (string ioption in Option2)
                this.CmbTipo.Items.Add(ioption.ToString());
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
            TxtCodigo.Text=("01");
            TxtNombre.Text = ("Desparasitante");
            CmbTipo.Text = ("Baymec");
            richTextBox1.Text = ("2 cm /kg");
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
            TxtCodigo.Text = null;
            TxtNombre.Text = null;
            CmbTipo.Text = null;
            richTextBox1.Text = null;
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edito Dato con exito", "Editar Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BoxActividad.Enabled = false;
            this.CmbTipo.Text = "";
            tollEmpleados.Enabled = true;
            TxtCodigo.Text = null;
            TxtNombre.Text = null;
            CmbTipo.Text = null;
            richTextBox1.Text = null;
        }
    }
}
