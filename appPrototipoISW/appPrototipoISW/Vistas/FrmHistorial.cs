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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable Tabla2 = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon2;//Esta variable de tipo DataRow solo la declaramos y mas adelante la utilizaremos para agregarsela al dataTable que ya declaramos arriba 
            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla2.Columns.Add(new DataColumn("Codigo Animal"));
            Tabla2.Columns.Add(new DataColumn("Nombre"));
            Tabla2.Columns.Add(new DataColumn("Raza"));
            Tabla2.Columns.Add(new DataColumn("Genero"));
            Tabla2.Columns.Add(new DataColumn("Codigo Aplicacion"));
            Tabla2.Columns.Add(new DataColumn("Observaciones"));
            Tabla2.Columns.Add(new DataColumn("Fecha Aplicacion"));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon2 = Tabla2.NewRow();
            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            Renglon2[0] = "01";
            Renglon2[1] = "Lorenso";
            Renglon2[2] = "Pardo Suizo";
            Renglon2[3] = "Macho";
            Renglon2[4] = "002";
            Renglon2[5] = "Cotrol Paracitos";
            Renglon2[6] = "18/04/2013";
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            Tabla2.Rows.Add(Renglon2);
            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            GridActividad.DataSource = Tabla2; 

        }

        private void GridActividad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text=("Codigo del Animal          01\n"+
                               "Nombre                         Lorenso\n"+
                               "Raza                             Pardo Suizo\n"+
                               "Genero                          Macho\n"+
                               "Se le aplico el Plan        002\n"+
                               "Observaciones              Cotrol Paracitos\n"+
                               "El día                            18/08/2013");
        }

    }
}
