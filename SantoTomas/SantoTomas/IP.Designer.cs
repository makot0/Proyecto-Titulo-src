namespace SantoTomas
{
    partial class IP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IP));
            this.btnvolver = new System.Windows.Forms.Button();
            this.errorProviderip = new System.Windows.Forms.ErrorProvider(this.components);
            this.Networking = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNetliberar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.lblocupadas = new System.Windows.Forms.Label();
            this.lbldisponibles = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Asignar = new System.Windows.Forms.TabPage();
            this.btn_liberar2 = new System.Windows.Forms.Button();
            this.btn_buscar2 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtIDCompu = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConexion = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.proyectoDataSet = new SantoTomas.proyectoDataSet();
            this.iPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPTableAdapter = new SantoTomas.proyectoDataSetTableAdapters.IPTableAdapter();
            this.networkingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsnet = new SantoTomas.dsnet();
            this.networkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsnetworking = new SantoTomas.dsnetworking();
            this.networkingTableAdapter = new SantoTomas.dsnetworkingTableAdapters.networkingTableAdapter();
            this.networkingTableAdapter1 = new SantoTomas.dsnetTableAdapters.networkingTableAdapter();
            this.dgnetworkingip = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderip)).BeginInit();
            this.Networking.SuspendLayout();
            this.Estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Asignar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnetworking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgnetworkingip)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(648, 323);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 0;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // errorProviderip
            // 
            this.errorProviderip.ContainerControl = this;
            // 
            // Networking
            // 
            this.Networking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Networking.BackgroundImage")));
            this.Networking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Networking.Controls.Add(this.btnrefresh);
            this.Networking.Controls.Add(this.dgnetworkingip);
            this.Networking.Controls.Add(this.label13);
            this.Networking.Controls.Add(this.label12);
            this.Networking.Controls.Add(this.btnNetliberar);
            this.Networking.Controls.Add(this.btnGuardar);
            this.Networking.Controls.Add(this.txt_id);
            this.Networking.Controls.Add(this.txt_ip);
            this.Networking.Controls.Add(this.label9);
            this.Networking.Controls.Add(this.label8);
            this.Networking.Location = new System.Drawing.Point(4, 22);
            this.Networking.Name = "Networking";
            this.Networking.Padding = new System.Windows.Forms.Padding(3);
            this.Networking.Size = new System.Drawing.Size(722, 263);
            this.Networking.TabIndex = 4;
            this.Networking.Text = "IP - Dispositivos de Red";
            this.Networking.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(142, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "ID Dispositivo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Dirección IP";
            // 
            // btnNetliberar
            // 
            this.btnNetliberar.Location = new System.Drawing.Point(260, 178);
            this.btnNetliberar.Name = "btnNetliberar";
            this.btnNetliberar.Size = new System.Drawing.Size(75, 23);
            this.btnNetliberar.TabIndex = 8;
            this.btnNetliberar.Text = "Liberar";
            this.btnNetliberar.UseVisualStyleBackColor = true;
            this.btnNetliberar.Click += new System.EventHandler(this.btnNetliberar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 178);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Asignar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(218, 93);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 4;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(218, 131);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 20);
            this.txt_ip.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = " IP Para dispositivos de red.";
            // 
            // Estado
            // 
            this.Estado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Estado.BackgroundImage")));
            this.Estado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Estado.Controls.Add(this.dataGridView4);
            this.Estado.Controls.Add(this.radioButton3);
            this.Estado.Controls.Add(this.lblocupadas);
            this.Estado.Controls.Add(this.lbldisponibles);
            this.Estado.Controls.Add(this.button1);
            this.Estado.Controls.Add(this.label6);
            this.Estado.Controls.Add(this.label3);
            this.Estado.Controls.Add(this.dataGridView2);
            this.Estado.Controls.Add(this.radioButton2);
            this.Estado.Controls.Add(this.radioButton1);
            this.Estado.Location = new System.Drawing.Point(4, 22);
            this.Estado.Name = "Estado";
            this.Estado.Padding = new System.Windows.Forms.Padding(3);
            this.Estado.Size = new System.Drawing.Size(722, 263);
            this.Estado.TabIndex = 3;
            this.Estado.Text = "Estado";
            this.Estado.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(269, 120);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(447, 108);
            this.dataGridView4.TabIndex = 24;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(194, 82);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 17);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ver Todo";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // lblocupadas
            // 
            this.lblocupadas.AutoSize = true;
            this.lblocupadas.Location = new System.Drawing.Point(193, 152);
            this.lblocupadas.Name = "lblocupadas";
            this.lblocupadas.Size = new System.Drawing.Size(10, 13);
            this.lblocupadas.TabIndex = 21;
            this.lblocupadas.Text = "-";
            // 
            // lbldisponibles
            // 
            this.lbldisponibles.AutoSize = true;
            this.lbldisponibles.Location = new System.Drawing.Point(193, 120);
            this.lbldisponibles.Name = "lbldisponibles";
            this.lbldisponibles.Size = new System.Drawing.Size(10, 13);
            this.lbldisponibles.TabIndex = 20;
            this.lbldisponibles.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(90, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total Utilizadas    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(90, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total Disponibles : ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(269, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(447, 111);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(193, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Utilizadas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton2_MouseClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(108, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Disponibles";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButton1_MouseClick);
            // 
            // Asignar
            // 
            this.Asignar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Asignar.BackgroundImage")));
            this.Asignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Asignar.Controls.Add(this.btn_liberar2);
            this.Asignar.Controls.Add(this.btn_buscar2);
            this.Asignar.Controls.Add(this.txtbuscar);
            this.Asignar.Controls.Add(this.txtIDCompu);
            this.Asignar.Controls.Add(this.txtIP);
            this.Asignar.Controls.Add(this.dataGridView1);
            this.Asignar.Controls.Add(this.label5);
            this.Asignar.Controls.Add(this.lblConexion);
            this.Asignar.Controls.Add(this.btn_Actualizar);
            this.Asignar.Controls.Add(this.label2);
            this.Asignar.Controls.Add(this.label1);
            this.Asignar.Location = new System.Drawing.Point(4, 22);
            this.Asignar.Name = "Asignar";
            this.Asignar.Padding = new System.Windows.Forms.Padding(3);
            this.Asignar.Size = new System.Drawing.Size(722, 263);
            this.Asignar.TabIndex = 0;
            this.Asignar.Text = "Asignar y Liberar  IP - Computadoras";
            this.Asignar.UseVisualStyleBackColor = true;
            this.Asignar.Click += new System.EventHandler(this.Asignar_Click);
            // 
            // btn_liberar2
            // 
            this.btn_liberar2.Location = new System.Drawing.Point(243, 174);
            this.btn_liberar2.Name = "btn_liberar2";
            this.btn_liberar2.Size = new System.Drawing.Size(75, 23);
            this.btn_liberar2.TabIndex = 27;
            this.btn_liberar2.Text = "Liberar";
            this.btn_liberar2.UseVisualStyleBackColor = true;
            this.btn_liberar2.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Location = new System.Drawing.Point(589, 60);
            this.btn_buscar2.Name = "btn_buscar2";
            this.btn_buscar2.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar2.TabIndex = 26;
            this.btn_buscar2.Text = "Buscar";
            this.btn_buscar2.UseVisualStyleBackColor = true;
            this.btn_buscar2.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(457, 62);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 25;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // txtIDCompu
            // 
            this.txtIDCompu.AcceptsTab = true;
            this.txtIDCompu.Location = new System.Drawing.Point(218, 107);
            this.txtIDCompu.MaxLength = 3;
            this.txtIDCompu.Name = "txtIDCompu";
            this.txtIDCompu.Size = new System.Drawing.Size(100, 20);
            this.txtIDCompu.TabIndex = 3;
            this.txtIDCompu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCompu_KeyPress);
            // 
            // txtIP
            // 
            this.txtIP.AcceptsTab = true;
            this.txtIP.Location = new System.Drawing.Point(218, 74);
            this.txtIP.MaxLength = 3;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 72);
            this.dataGridView1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dirección IP";
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(382, 225);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(10, 13);
            this.lblConexion.TabIndex = 2;
            this.lblConexion.Text = ".";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(157, 174);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 6;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Computadora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección IP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Asignar);
            this.tabControl1.Controls.Add(this.Networking);
            this.tabControl1.Controls.Add(this.Estado);
            this.tabControl1.Location = new System.Drawing.Point(13, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 289);
            this.tabControl1.TabIndex = 1;
            // 
            // proyectoDataSet
            // 
            this.proyectoDataSet.DataSetName = "proyectoDataSet";
            this.proyectoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iPBindingSource
            // 
            this.iPBindingSource.DataMember = "IP";
            this.iPBindingSource.DataSource = this.proyectoDataSet;
            // 
            // iPTableAdapter
            // 
            this.iPTableAdapter.ClearBeforeFill = true;
            // 
            // networkingBindingSource1
            // 
            this.networkingBindingSource1.DataMember = "networking";
            this.networkingBindingSource1.DataSource = this.dsnet;
            // 
            // dsnet
            // 
            this.dsnet.DataSetName = "dsnet";
            this.dsnet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // networkingBindingSource
            // 
            this.networkingBindingSource.DataMember = "networking";
            this.networkingBindingSource.DataSource = this.dsnetworking;
            // 
            // dsnetworking
            // 
            this.dsnetworking.DataSetName = "dsnetworking";
            this.dsnetworking.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // networkingTableAdapter
            // 
            this.networkingTableAdapter.ClearBeforeFill = true;
            // 
            // networkingTableAdapter1
            // 
            this.networkingTableAdapter1.ClearBeforeFill = true;
            // 
            // dgnetworkingip
            // 
            this.dgnetworkingip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnetworkingip.Location = new System.Drawing.Point(361, 22);
            this.dgnetworkingip.Name = "dgnetworkingip";
            this.dgnetworkingip.Size = new System.Drawing.Size(355, 192);
            this.dgnetworkingip.TabIndex = 11;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(501, 221);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 12;
            this.btnrefresh.Text = "Refrescar";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // IP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 360);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnvolver);
            this.HelpButton = true;
            this.Name = "IP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ IP";
            this.Load += new System.EventHandler(this.IP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderip)).EndInit();
            this.Networking.ResumeLayout(false);
            this.Networking.PerformLayout();
            this.Estado.ResumeLayout(false);
            this.Estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Asignar.ResumeLayout(false);
            this.Asignar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.networkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnetworking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgnetworkingip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvolver;
        private proyectoDataSet proyectoDataSet;
        private System.Windows.Forms.BindingSource iPBindingSource;
        private proyectoDataSetTableAdapters.IPTableAdapter iPTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProviderip;
        private dsnetworking dsnetworking;
        private System.Windows.Forms.BindingSource networkingBindingSource;
        private dsnetworkingTableAdapters.networkingTableAdapter networkingTableAdapter;
        private dsnet dsnet;
        private System.Windows.Forms.BindingSource networkingBindingSource1;
        private dsnetTableAdapters.networkingTableAdapter networkingTableAdapter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Asignar;
        private System.Windows.Forms.Button btn_liberar2;
        private System.Windows.Forms.Button btn_buscar2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txtIDCompu;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Estado;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label lblocupadas;
        private System.Windows.Forms.Label lbldisponibles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage Networking;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNetliberar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.DataGridView dgnetworkingip;
    }
}