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

        private void button3_Click(object sender, EventArgs e)
        {
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

            DataTable Tabla = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon;//Esta variable de tipo DataRow solo la declaramos y mas adelante la utilizaremos para agregarsela al dataTable que ya declaramos arriba 
            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla.Columns.Add(new DataColumn("Codigo Plan"));
            Tabla.Columns.Add(new DataColumn("Codigo Vacuna"));
            Tabla.Columns.Add(new DataColumn("Descripcion"));
            Tabla.Columns.Add(new DataColumn("Observaciones"));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon = Tabla.NewRow();
            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            Renglon[0] = "002";
            Renglon[1] = "001";
            Renglon[2] = "Desparasitante";
            Renglon[3] = "2 cm /kg";
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            Tabla.Rows.Add(Renglon);
            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            GridAtractivo.DataSource = Tabla;

        }
    }
}
