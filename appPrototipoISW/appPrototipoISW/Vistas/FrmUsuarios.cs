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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CmbRaza.Items.Add("Administrador");
            CmbRaza.Items.Add("Capataz");
            CmbRaza.Items.Add("Cliente");
            CmbRaza.Items.Add("Veterinario");

            DataTable Tabla2 = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon2;//Esta variable de tipo DataRow solo la declaramos y mas adelante la utilizaremos para agregarsela al dataTable que ya declaramos arriba 
            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla2.Columns.Add(new DataColumn("Cedula"));
            Tabla2.Columns.Add(new DataColumn("Nombre"));
            Tabla2.Columns.Add(new DataColumn("Apellido1"));
            Tabla2.Columns.Add(new DataColumn("Apellido2"));
            Tabla2.Columns.Add(new DataColumn("Rol"));
            Tabla2.Columns.Add(new DataColumn("Usuario"));
            Tabla2.Columns.Add(new DataColumn("Clave"));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon2 = Tabla2.NewRow();
            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            Renglon2[0] = "206570898";
            Renglon2[1] = "Lorenso";
            Renglon2[2] = "Mata";
            Renglon2[3] = "Monos";
            Renglon2[4] = "Administrador";
            Renglon2[5] = "lmata";
            Renglon2[6] = "123";
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            Tabla2.Rows.Add(Renglon2);
            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            GridActividad.DataSource = Tabla2;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.BoxActividad.Enabled = true;
            this.tollEmpleados.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.BoxActividad.Enabled = false;
            this.tollEmpleados.Enabled = true;
            this.txtApellido1.Text = null;
            this.txtApellido2.Text = null;
            this.txtCedula.Text = null;
            this.txtClave.Text = null;
            this.txtNombre.Text = null;
            this.txtUsuario.Text = null;
            this.BoxActividad.Enabled = false;
            this.tollEmpleados.Enabled = true;

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.BoxActividad.Enabled = false;
            this.tollEmpleados.Enabled = true;
            MessageBox.Show("Insertó Dato con exito", "Inserta Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtApellido1.Text = null;
            this.txtApellido2.Text = null;
            this.txtCedula.Text = null;
            this.txtClave.Text = null;
            this.txtNombre.Text = null;
            this.txtUsuario.Text = null;
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            this.txtApellido1.Text = null;
            this.txtApellido2.Text = null;
            this.txtCedula.Text = null;
            this.txtClave.Text = null;
            this.txtNombre.Text = null;
            this.txtUsuario.Text = null;
            this.BoxActividad.Enabled = false;
            this.tollEmpleados.Enabled = true;
            MessageBox.Show("Insertó Dato con exito", "Inserta Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.txtApellido1.Text = "Mata";
            this.txtApellido2.Text = "Monos";
            this.txtCedula.Text = "206570898";
            this.txtClave.Text = "123";
            this.txtNombre.Text = "Lorenso";
            this.txtUsuario.Text = "lmata";
            this.BoxActividad.Enabled = true;
            this.tollEmpleados.Enabled = false;
            this.CmbRaza.Text = "Administrador";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ((DataTable)GridActividad.DataSource).Rows.Clear();
            MessageBox.Show("Se ha borrado el Dato con exito", "Borrar Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            DataTable Tabla2 = new DataTable(); //Declaramos una variable de tipo DataTable y a su vez la inicializamos para usarla mas tarde. 
            DataRow Renglon2;//Esta variable de tipo DataRow solo la declaramos y mas adelante la utilizaremos para agregarsela al dataTable que ya declaramos arriba 
            //Le agregamos columnas a la variable Tabla que es de tipo DataTable 
            Tabla2.Columns.Add(new DataColumn("Cedula"));
            Tabla2.Columns.Add(new DataColumn("Nombre"));
            Tabla2.Columns.Add(new DataColumn("Apellido1"));
            Tabla2.Columns.Add(new DataColumn("Apellido2"));
            Tabla2.Columns.Add(new DataColumn("Rol"));
            Tabla2.Columns.Add(new DataColumn("Usuario"));
            Tabla2.Columns.Add(new DataColumn("Clave"));
            //Aqui es cuando hacemos uso de la variable renglon, la inicializamos diciendole que va a ser un nuevo renglon de la Tabla que es de tipo DataTable 
            Renglon2 = Tabla2.NewRow();
            //Aqui simplemente le agregamos el renglon nuevo con los valores que nosotros querramos, para hacer referencia a cada columna podemos utilizar los indices de cada columna 
            Renglon2[0] = "206570898";
            Renglon2[1] = "Lorenso";
            Renglon2[2] = "Mata";
            Renglon2[3] = "Monos";
            Renglon2[4] = "Administrador";
            Renglon2[5] = "lmata";
            Renglon2[6] = "123";
            //Aqui simplemente le agregamos el renglon nuevo a la tabla 
            Tabla2.Rows.Add(Renglon2);
            //Aqui le decimos al dataGridView que tome la tabla y la muestre y Fin 
            GridActividad.DataSource = Tabla2;

        }
    }
}
