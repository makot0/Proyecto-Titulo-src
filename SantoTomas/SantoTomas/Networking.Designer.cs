namespace SantoTomas
{
    partial class Networking
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Networking));
            this.Volver = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mantenedor = new System.Windows.Forms.TabPage();
            this.comboubi = new System.Windows.Forms.ComboBox();
            this.ubicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSetubi222 = new SantoTomas.proyectoDataSetubi222();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.tiponetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet1 = new SantoTomas.proyectoDataSet1();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtobservcaciones = new System.Windows.Forms.TextBox();
            this.txtmac = new System.Windows.Forms.TextBox();
            this.txtsn = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Listar = new System.Windows.Forms.TabPage();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ubicacionTableAdapter = new SantoTomas.proyectoDataSetubi222TableAdapters.ubicacionTableAdapter();
            this.tipo_netTableAdapter = new SantoTomas.proyectoDataSet1TableAdapters.tipo_netTableAdapter();
            this.tabControl1.SuspendLayout();
            this.mantenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSetubi222)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiponetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).BeginInit();
            this.Listar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(583, 288);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 0;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mantenedor);
            this.tabControl1.Controls.Add(this.Listar);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 270);
            this.tabControl1.TabIndex = 1;
            // 
            // mantenedor
            // 
            this.mantenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mantenedor.BackgroundImage")));
            this.mantenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mantenedor.Controls.Add(this.comboubi);
            this.mantenedor.Controls.Add(this.combotipo);
            this.mantenedor.Controls.Add(this.txtbuscar);
            this.mantenedor.Controls.Add(this.label9);
            this.mantenedor.Controls.Add(this.btnBuscar);
            this.mantenedor.Controls.Add(this.btnLimpiar);
            this.mantenedor.Controls.Add(this.btnEliminar);
            this.mantenedor.Controls.Add(this.btnAgregar);
            this.mantenedor.Controls.Add(this.dtfecha);
            this.mantenedor.Controls.Add(this.txtobservcaciones);
            this.mantenedor.Controls.Add(this.txtmac);
            this.mantenedor.Controls.Add(this.txtsn);
            this.mantenedor.Controls.Add(this.txtmodelo);
            this.mantenedor.Controls.Add(this.txtmarca);
            this.mantenedor.Controls.Add(this.txtid);
            this.mantenedor.Controls.Add(this.label8);
            this.mantenedor.Controls.Add(this.label7);
            this.mantenedor.Controls.Add(this.label6);
            this.mantenedor.Controls.Add(this.label5);
            this.mantenedor.Controls.Add(this.label4);
            this.mantenedor.Controls.Add(this.label3);
            this.mantenedor.Controls.Add(this.label2);
            this.mantenedor.Controls.Add(this.label1);
            this.mantenedor.Location = new System.Drawing.Point(4, 22);
            this.mantenedor.Name = "mantenedor";
            this.mantenedor.Padding = new System.Windows.Forms.Padding(3);
            this.mantenedor.Size = new System.Drawing.Size(682, 244);
            this.mantenedor.TabIndex = 0;
            this.mantenedor.Text = "Mantenedor";
            this.mantenedor.UseVisualStyleBackColor = true;
            // 
            // comboubi
            // 
            this.comboubi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ubicacionBindingSource, "idUbicacion", true));
            this.comboubi.DataSource = this.ubicacionBindingSource;
            this.comboubi.DisplayMember = "nombre";
            this.comboubi.FormattingEnabled = true;
            this.comboubi.Location = new System.Drawing.Point(432, 118);
            this.comboubi.MaxLength = 3;
            this.comboubi.Name = "comboubi";
            this.comboubi.Size = new System.Drawing.Size(100, 21);
            this.comboubi.TabIndex = 24;
            this.comboubi.ValueMember = "idUbicacion";
            // 
            // ubicacionBindingSource
            // 
            this.ubicacionBindingSource.DataMember = "ubicacion";
            this.ubicacionBindingSource.DataSource = this.proyectoDataSetubi222;
            // 
            // proyectoDataSetubi222
            // 
            this.proyectoDataSetubi222.DataSetName = "proyectoDataSetubi222";
            this.proyectoDataSetubi222.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combotipo
            // 
            this.combotipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tiponetBindingSource, "netID", true));
            this.combotipo.DataSource = this.tiponetBindingSource;
            this.combotipo.DisplayMember = "nombre";
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(432, 23);
            this.combotipo.MaxLength = 3;
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(100, 21);
            this.combotipo.TabIndex = 23;
            this.combotipo.ValueMember = "netID";
            // 
            // tiponetBindingSource
            // 
            this.tiponetBindingSource.DataMember = "tipo_net";
            this.tiponetBindingSource.DataSource = this.proyectoDataSet1;
            // 
            // proyectoDataSet1
            // 
            this.proyectoDataSet1.DataSetName = "proyectoDataSet1";
            this.proyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(558, 90);
            this.txtbuscar.MaxLength = 3;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(599, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(576, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(588, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(506, 215);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(424, 215);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(82, 218);
            this.dtfecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(101, 20);
            this.dtfecha.TabIndex = 16;
            // 
            // txtobservcaciones
            // 
            this.txtobservcaciones.Location = new System.Drawing.Point(432, 162);
            this.txtobservcaciones.MaxLength = 50;
            this.txtobservcaciones.Name = "txtobservcaciones";
            this.txtobservcaciones.Size = new System.Drawing.Size(100, 20);
            this.txtobservcaciones.TabIndex = 15;
            // 
            // txtmac
            // 
            this.txtmac.Location = new System.Drawing.Point(432, 70);
            this.txtmac.MaxLength = 50;
            this.txtmac.Name = "txtmac";
            this.txtmac.Size = new System.Drawing.Size(100, 20);
            this.txtmac.TabIndex = 13;
            // 
            // txtsn
            // 
            this.txtsn.Location = new System.Drawing.Point(211, 166);
            this.txtsn.MaxLength = 50;
            this.txtsn.Name = "txtsn";
            this.txtsn.Size = new System.Drawing.Size(100, 20);
            this.txtsn.TabIndex = 11;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(211, 116);
            this.txtmodelo.MaxLength = 50;
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 10;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(211, 67);
            this.txtmarca.MaxLength = 50;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 9;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(211, 26);
            this.txtid.MaxLength = 3;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ubicación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MAC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Dispositivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "N. de Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Listar
            // 
            this.Listar.Controls.Add(this.btnRefrescar);
            this.Listar.Controls.Add(this.dataGridView1);
            this.Listar.Location = new System.Drawing.Point(4, 22);
            this.Listar.Name = "Listar";
            this.Listar.Padding = new System.Windows.Forms.Padding(3);
            this.Listar.Size = new System.Drawing.Size(682, 244);
            this.Listar.TabIndex = 1;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(294, 215);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // ubicacionTableAdapter
            // 
            this.ubicacionTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_netTableAdapter
            // 
            this.tipo_netTableAdapter.ClearBeforeFill = true;
            // 
            // Networking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 323);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Volver);
            this.Name = "Networking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Networking";
            this.Load += new System.EventHandler(this.Networking_Load);
            this.tabControl1.ResumeLayout(false);
            this.mantenedor.ResumeLayout(false);
            this.mantenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSetubi222)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiponetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).EndInit();
            this.Listar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mantenedor;
        private System.Windows.Forms.TabPage Listar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.TextBox txtobservcaciones;
        private System.Windows.Forms.TextBox txtmac;
        private System.Windows.Forms.TextBox txtsn;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboubi;
        private System.Windows.Forms.ComboBox combotipo;
        private proyectoDataSetubi222 proyectoDataSetubi222;
        private System.Windows.Forms.BindingSource ubicacionBindingSource;
        private proyectoDataSetubi222TableAdapters.ubicacionTableAdapter ubicacionTableAdapter;
        private proyectoDataSet1 proyectoDataSet1;
        private System.Windows.Forms.BindingSource tiponetBindingSource;
        private proyectoDataSet1TableAdapters.tipo_netTableAdapter tipo_netTableAdapter;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}