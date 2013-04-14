namespace appPrototipoISW.Vistas
{
    partial class FrmHistorial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial));
            this.label10 = new System.Windows.Forms.Label();
            this.GridActividad = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-3, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 92;
            this.label10.Text = "Lista de  Animales";
            // 
            // GridActividad
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.GridActividad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridActividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridActividad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridActividad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridActividad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridActividad.Location = new System.Drawing.Point(0, 363);
            this.GridActividad.Name = "GridActividad";
            this.GridActividad.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.GridActividad.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridActividad.Size = new System.Drawing.Size(649, 166);
            this.GridActividad.TabIndex = 91;
            this.GridActividad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridActividad_CellDoubleClick);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(39, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 89;
            this.label7.Text = "Codigo del  Animal";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(33, 222);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(155, 42);
            this.btnFiltrar.TabIndex = 93;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(240, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(397, 268);
            this.richTextBox1.TabIndex = 94;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 37);
            this.label1.TabIndex = 95;
            this.label1.Text = "Consultar Hisrorial";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(649, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GridActividad);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistorial";
            this.Text = "FrmHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.GridActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GridActividad;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}