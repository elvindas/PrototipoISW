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
            string[] Option2 = { "Emicina", "Baymec", "Paracitol" };
            // cargar los valores por defecto en el combo
            foreach (string ioption in Option2)
                this.CmbTipo.Items.Add(ioption.ToString());
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
            Renglon2[0] = "015";
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;//Esta variable de tipo DataRow solo la declaramos y mas adelante la utilizaremos para agregarsela al dataTable que ya declaramos arriba 
            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Codigo Plan"));
            Tabla.Columns.Add(new DataColumn("Codigo Animal"));
            Tabla.Columns.Add(new DataColumn("Codigo Vacuna"));
            Tabla.Columns.Add(new DataColumn("Descripcion"));
            Tabla.Columns.Add(new DataColumn("Observaciones"));
            Tabla.Columns.Add(new DataColumn("Fecha"));
            Tabla.Columns.Add(new DataColumn("Estado"));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon = Tabla.NewRow();
            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            Renglon[0] = "015";
            Renglon[1] = "056";
            Renglon[2] = "012";
            Renglon[3] = "Desparasitante";
            Renglon[4] = "2 cm /kg";
            Renglon[5] = "30/04/2013";
            Renglon[6] = "Pendiente";
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            Tabla.Rows.Add(Renglon);
            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            GridAtractivo.DataSource = Tabla;

        }
    }
}
