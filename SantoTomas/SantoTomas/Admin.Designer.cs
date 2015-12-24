namespace SantoTomas
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btn_sysusers = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnencargadopc = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sysusers
            // 
            this.btn_sysusers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sysusers.BackgroundImage")));
            this.btn_sysusers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sysusers.Location = new System.Drawing.Point(48, 41);
            this.btn_sysusers.Name = "btn_sysusers";
            this.btn_sysusers.Size = new System.Drawing.Size(161, 107);
            this.btn_sysusers.TabIndex = 11;
            this.btn_sysusers.UseVisualStyleBackColor = true;
            this.btn_sysusers.Click += new System.EventHandler(this.btn_sysusers_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "USUARIOS SISTEMA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "ENCARGADOS PC";
            // 
            // btnencargadopc
            // 
            this.btnencargadopc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnencargadopc.BackgroundImage")));
            this.btnencargadopc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnencargadopc.Location = new System.Drawing.Point(231, 41);
            this.btnencargadopc.Name = "btnencargadopc";
            this.btnencargadopc.Size = new System.Drawing.Size(161, 107);
            this.btnencargadopc.TabIndex = 20;
            this.btnencargadopc.UseVisualStyleBackColor = true;
            this.btnencargadopc.Click += new System.EventHandler(this.btnencargadopc_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.Location = new System.Drawing.Point(364, 207);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 33);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 252);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnencargadopc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_sysusers);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sysusers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnencargadopc;
        private System.Windows.Forms.Button btnVolver;
    }
}