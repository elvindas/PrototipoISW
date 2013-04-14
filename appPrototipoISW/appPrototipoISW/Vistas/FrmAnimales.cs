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
    public partial class FrmAnimales : Form
    {
        public FrmAnimales()
        {
            InitializeComponent();
            CmbGenero.Items.Add("Macho");
            CmbGenero.Items.Add("Embra");
            CmbRaza.Items.Add("Holstein");
            CmbRaza.Items.Add("Jersey");
            CmbRaza.Items.Add("Pardo Suizo");
            DataTable Tabla2 = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon2;//Esta variable de tipo DataRow solo la declaramos y mas adelante la utilizaremos para agregarsela al dataTable que ya declaramos arriba 
            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla2.Columns.Add(new DataColumn("Codigo Animal"));
            Tabla2.Columns.Add(new DataColumn("Nombre"));
            Tabla2.Columns.Add(new DataColumn("Raza"));
            Tabla2.Columns.Add(new DataColumn("Genero"));
            Tabla2.Columns.Add(new DataColumn("Codigo Padre"));
            Tabla2.Columns.Add(new DataColumn("Codigo Madre"));
            Tabla2.Columns.Add(new DataColumn("Fecha Nacimiento"));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon2 = Tabla2.NewRow();
            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            Renglon2[0] = "01";
            Renglon2[1] = "Lorenso";
            Renglon2[2] = "Pardo Suizo";
            Renglon2[3] = "Macho";
            Renglon2[4] = "120";
            Renglon2[5] = "026";
            Renglon2[6] = "1/04/2013";
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            Tabla2.Rows.Add(Renglon2);
            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            GridActividad.DataSource = Tabla2;
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
            TxtNombre.Text=("Lorenso");
            CmbRaza.Text=("Pardo Suizo");
            CmbGenero.Text=("Macho");
            madre.Text=("026");
            padre.Text=("120");
            dtpDesde.Text=("1/04/2013");
            
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
            this.CmbRaza.Text = "";
            this.TxtNombre.Text = "";
            this.CmbGenero.Text = "";
            tollEmpleados.Enabled = true;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.BoxActividad.Enabled = false;
            this.TxtCodigo.Text = "";
            this.CmbRaza.Text = "";
            this.TxtNombre.Text = "";
            this.CmbGenero.Text = "";
            tollEmpleados.Enabled = true;
            TxtCodigo.Text = null;
            TxtNombre.Text = null;
            CmbRaza.Text = null;
            CmbGenero.Text = null;
            madre.Text = null;
            padre.Text =null;
            dtpDesde.Text =null;

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edito Dato con exito", "Editar Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BoxActividad.Enabled = false;
            this.TxtCodigo.Text = "";
            this.CmbRaza.Text = "";
            this.TxtNombre.Text = "";
            this.CmbGenero.Text = "";
            tollEmpleados.Enabled = true;
            TxtCodigo.Text = null;
            TxtNombre.Text = null;
            CmbRaza.Text = null;
            CmbGenero.Text = null;
            madre.Text = null;
            padre.Text = null;
            dtpDesde.Text = null;
        }
    }
}
