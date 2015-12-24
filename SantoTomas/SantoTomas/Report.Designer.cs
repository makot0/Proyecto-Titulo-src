namespace SantoTomas
{
    partial class Reportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.computadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repo1 = new SantoTomas.repo1();
            this.btn_volver = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reporte_pc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.computadoraTableAdapter = new SantoTomas.repo1TableAdapters.computadoraTableAdapter();
            this.DSCompleto = new SantoTomas.DSCompleto();
            this.encargado_pcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encargado_pcTableAdapter = new SantoTomas.DSCompletoTableAdapters.encargado_pcTableAdapter();
            this.reporte_mantenciones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mantencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantencionTableAdapter = new SantoTomas.DSCompletoTableAdapters.mantencionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSCompleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encargado_pcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // computadoraBindingSource
            // 
            this.computadoraBindingSource.DataMember = "computadora";
            this.computadoraBindingSource.DataSource = this.repo1;
            // 
            // repo1
            // 
            this.repo1.DataSetName = "repo1";
            this.repo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(648, 323);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 0;
            this.btn_volver.Text = "volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 305);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reporte_pc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reporte_pc
            // 
            this.reporte_pc.AllowDrop = true;
            this.reporte_pc.AutoSize = true;
            this.reporte_pc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporte_pc.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.encargado_pcBindingSource;
            this.reporte_pc.LocalReport.DataSources.Add(reportDataSource1);
            this.reporte_pc.LocalReport.ReportEmbeddedResource = "SantoTomas.Report1.rdlc";
            this.reporte_pc.Location = new System.Drawing.Point(3, 3);
            this.reporte_pc.Name = "reporte_pc";
            this.reporte_pc.Size = new System.Drawing.Size(716, 273);
            this.reporte_pc.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reporte_mantenciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // computadoraTableAdapter
            // 
            this.computadoraTableAdapter.ClearBeforeFill = true;
            // 
            // DSCompleto
            // 
            this.DSCompleto.DataSetName = "DSCompleto";
            this.DSCompleto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // encargado_pcBindingSource
            // 
            this.encargado_pcBindingSource.DataMember = "encargado_pc";
            this.encargado_pcBindingSource.DataSource = this.DSCompleto;
            // 
            // encargado_pcTableAdapter
            // 
            this.encargado_pcTableAdapter.ClearBeforeFill = true;
            // 
            // reporte_mantenciones
            // 
            this.reporte_mantenciones.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "mantencionesxd";
            reportDataSource2.Value = this.mantencionBindingSource;
            this.reporte_mantenciones.LocalReport.DataSources.Add(reportDataSource2);
            this.reporte_mantenciones.LocalReport.ReportEmbeddedResource = "SantoTomas.Report2.rdlc";
            this.reporte_mantenciones.Location = new System.Drawing.Point(3, 3);
            this.reporte_mantenciones.Name = "reporte_mantenciones";
            this.reporte_mantenciones.Size = new System.Drawing.Size(716, 273);
            this.reporte_mantenciones.TabIndex = 0;
            // 
            // mantencionBindingSource
            // 
            this.mantencionBindingSource.DataMember = "mantencion";
            this.mantencionBindingSource.DataSource = this.DSCompleto;
            // 
            // mantencionTableAdapter
            // 
            this.mantencionTableAdapter.ClearBeforeFill = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 360);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_volver);
            this.Name = "Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSCompleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encargado_pcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantencionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_pc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource computadoraBindingSource;
        private repo1 repo1;
        private repo1TableAdapters.computadoraTableAdapter computadoraTableAdapter;
        private DSCompleto DSCompleto;
        private System.Windows.Forms.BindingSource encargado_pcBindingSource;
        private DSCompletoTableAdapters.encargado_pcTableAdapter encargado_pcTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reporte_mantenciones;
        private System.Windows.Forms.BindingSource mantencionBindingSource;
        private DSCompletoTableAdapters.mantencionTableAdapter mantencionTableAdapter;
    }
}