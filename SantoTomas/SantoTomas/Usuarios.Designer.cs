namespace SantoTomas
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Nuevos = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.listar = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnResfrescar = new System.Windows.Forms.Button();
            this.proyectoDssysusers = new SantoTomas.proyectoDssysusers();
            this.sysusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sys_usersTableAdapter = new SantoTomas.proyectoDssysusersTableAdapters.sys_usersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.errorpop = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.Nuevos.SuspendLayout();
            this.listar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDssysusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(107, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(308, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Nuevos);
            this.tabControl1.Controls.Add(this.listar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 222);
            this.tabControl1.TabIndex = 2;
            // 
            // Nuevos
            // 
            this.Nuevos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nuevos.BackgroundImage")));
            this.Nuevos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Nuevos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nuevos.Controls.Add(this.btnBuscar);
            this.Nuevos.Controls.Add(this.label2);
            this.Nuevos.Controls.Add(this.txtId);
            this.Nuevos.Controls.Add(this.label1);
            this.Nuevos.Controls.Add(this.btnActualizar);
            this.Nuevos.Controls.Add(this.txtclave);
            this.Nuevos.Controls.Add(this.btnEliminar);
            this.Nuevos.Controls.Add(this.txtnombre);
            this.Nuevos.Controls.Add(this.btnAgregar);
            this.Nuevos.Controls.Add(this.lblClave);
            this.Nuevos.Controls.Add(this.lblNombre);
            this.Nuevos.Location = new System.Drawing.Point(4, 22);
            this.Nuevos.Name = "Nuevos";
            this.Nuevos.Padding = new System.Windows.Forms.Padding(3);
            this.Nuevos.Size = new System.Drawing.Size(412, 196);
            this.Nuevos.TabIndex = 0;
            this.Nuevos.Text = "Nuevos Usuarios";
            this.Nuevos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(327, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 20);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese ID de Usuario";
            // 
            // txtId
            // 
            this.txtId.AcceptsTab = true;
            this.txtId.Location = new System.Drawing.Point(196, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(204, 149);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(196, 95);
            this.txtclave.MaxLength = 15;
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 3;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(196, 64);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(138, 103);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(138, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // listar
            // 
            this.listar.Controls.Add(this.dataGridView1);
            this.listar.Controls.Add(this.btnResfrescar);
            this.listar.Location = new System.Drawing.Point(4, 22);
            this.listar.Name = "listar";
            this.listar.Padding = new System.Windows.Forms.Padding(3);
            this.listar.Size = new System.Drawing.Size(412, 196);
            this.listar.TabIndex = 1;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnResfrescar
            // 
            this.btnResfrescar.Location = new System.Drawing.Point(156, 170);
            this.btnResfrescar.Name = "btnResfrescar";
            this.btnResfrescar.Size = new System.Drawing.Size(75, 23);
            this.btnResfrescar.TabIndex = 1;
            this.btnResfrescar.Text = "Refrescar";
            this.btnResfrescar.UseVisualStyleBackColor = true;
            this.btnResfrescar.Click += new System.EventHandler(this.btnResfrescar_Click);
            // 
            // proyectoDssysusers
            // 
            this.proyectoDssysusers.DataSetName = "proyectoDssysusers";
            this.proyectoDssysusers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sysusersBindingSource
            // 
            this.sysusersBindingSource.DataMember = "sys_users";
            this.sysusersBindingSource.DataSource = this.proyectoDssysusers;
            // 
            // sys_usersTableAdapter
            // 
            this.sys_usersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorpop
            // 
            this.errorpop.ContainerControl = this;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.Nuevos.ResumeLayout(false);
            this.Nuevos.PerformLayout();
            this.listar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDssysusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorpop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Nuevos;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage listar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnResfrescar;
        private proyectoDssysusers proyectoDssysusers;
        private System.Windows.Forms.BindingSource sysusersBindingSource;
        private proyectoDssysusersTableAdapters.sys_usersTableAdapter sys_usersTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorpop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        protected System.Windows.Forms.TextBox txtId;
    }
}