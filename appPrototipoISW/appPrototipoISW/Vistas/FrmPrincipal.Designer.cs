namespace appPrototipoISW.Vistas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registraNacimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BoxAgenda = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.GridAtractivo = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GridActividad = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.BoxAgenda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAtractivo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registraNacimientoToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registraNacimientoToolStripMenuItem
            // 
            this.registraNacimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registraNacimientoToolStripMenuItem.Image")));
            this.registraNacimientoToolStripMenuItem.Name = "registraNacimientoToolStripMenuItem";
            this.registraNacimientoToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.registraNacimientoToolStripMenuItem.Text = "Registro Animal";
            this.registraNacimientoToolStripMenuItem.Click += new System.EventHandler(this.registraNacimientoToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendaToolStripMenuItem.Image")));
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.agendaToolStripMenuItem.Text = "Asignar Plan";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alimentaciónToolStripMenuItem,
            this.actividadToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // alimentaciónToolStripMenuItem
            // 
            this.alimentaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alimentaciónToolStripMenuItem.Image")));
            this.alimentaciónToolStripMenuItem.Name = "alimentaciónToolStripMenuItem";
            this.alimentaciónToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.alimentaciónToolStripMenuItem.Text = "Plan de Vacunas";
            this.alimentaciónToolStripMenuItem.Click += new System.EventHandler(this.alimentaciónToolStripMenuItem_Click);
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actividadToolStripMenuItem.Image")));
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.actividadToolStripMenuItem.Text = "Catalogo de Vacunas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrarToolStripMenuItem.Image")));
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historialToolStripMenuItem.Image")));
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 505);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.BoxAgenda);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aplicar Plan de Vacunas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BoxAgenda
            // 
            this.BoxAgenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BoxAgenda.BackgroundImage")));
            this.BoxAgenda.Controls.Add(this.label3);
            this.BoxAgenda.Controls.Add(this.label9);
            this.BoxAgenda.Controls.Add(this.BtnCambiar);
            this.BoxAgenda.Controls.Add(this.groupBox2);
            this.BoxAgenda.Controls.Add(this.checkBox1);
            this.BoxAgenda.Controls.Add(this.dateTimePicker1);
            this.BoxAgenda.Controls.Add(this.dtpDesde);
            this.BoxAgenda.Controls.Add(this.label1);
            this.BoxAgenda.Controls.Add(this.GridAtractivo);
            this.BoxAgenda.Controls.Add(this.btnFiltrar);
            this.BoxAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxAgenda.Location = new System.Drawing.Point(3, 3);
            this.BoxAgenda.Name = "BoxAgenda";
            this.BoxAgenda.Size = new System.Drawing.Size(631, 469);
            this.BoxAgenda.TabIndex = 19;
            this.BoxAgenda.TabStop = false;
            this.BoxAgenda.Text = "Aplicar Plan de Vacunas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 95;
            this.label3.Text = "Hasta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 94;
            this.label9.Text = "Desde";
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCambiar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCambiar.Image")));
            this.BtnCambiar.Location = new System.Drawing.Point(343, 252);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(249, 51);
            this.BtnCambiar.TabIndex = 93;
            this.BtnCambiar.Text = "Aplicar Plan a la Selección";
            this.BtnCambiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCambiar.UseVisualStyleBackColor = false;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(338, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 197);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avanzadas";
            this.groupBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 91;
            this.label6.Text = "Codigo del  Animal";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 88;
            this.label5.Text = "Codigo de  Vacuna";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 85;
            this.label2.Text = "Codigo del  Plan";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Location = new System.Drawing.Point(338, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 84;
            this.checkBox1.Text = "Busqueda Avanzada";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 76;
            this.dateTimePicker1.Value = new System.DateTime(2012, 3, 13, 0, 0, 0, 0);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(79, 34);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(160, 20);
            this.dtpDesde.TabIndex = 75;
            this.dtpDesde.Value = new System.DateTime(2012, 3, 13, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Plan de Vacunas";
            // 
            // GridAtractivo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.GridAtractivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAtractivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridAtractivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAtractivo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridAtractivo.Location = new System.Drawing.Point(3, 309);
            this.GridAtractivo.Name = "GridAtractivo";
            this.GridAtractivo.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.GridAtractivo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridAtractivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAtractivo.Size = new System.Drawing.Size(625, 157);
            this.GridAtractivo.TabIndex = 68;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(10, 142);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(229, 42);
            this.btnFiltrar.TabIndex = 54;
            this.btnFiltrar.Text = "Filtrar Plan ";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(641, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aplicar Inyectables";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.GridActividad);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 473);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aplicar Inyectables";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbTipo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(146, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 100);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(114, 42);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(147, 21);
            this.CmbTipo.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 78;
            this.label8.Text = "Vacuna";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 85;
            this.label10.Text = "Lista de  Animales";
            // 
            // GridActividad
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.GridActividad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridActividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridActividad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridActividad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridActividad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridActividad.Location = new System.Drawing.Point(3, 304);
            this.GridActividad.Name = "GridActividad";
            this.GridActividad.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.GridActividad.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridActividad.Size = new System.Drawing.Size(629, 166);
            this.GridActividad.TabIndex = 84;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Enabled = false;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(350, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 51);
            this.button3.TabIndex = 83;
            this.button3.Text = "Aplicar Vacuna ";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(143, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 81;
            this.label7.Text = "Codigo del  Animal";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 44);
            this.button4.TabIndex = 80;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(649, 529);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.BoxAgenda.ResumeLayout(false);
            this.BoxAgenda.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAtractivo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraNacimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox BoxAgenda;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridAtractivo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GridActividad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}