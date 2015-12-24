using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantoTomas
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new Menu();
            m.Show();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSCompleto.mantencion' table. You can move, or remove it, as needed.
            this.mantencionTableAdapter.Fill(this.DSCompleto.mantencion);
            // TODO: This line of code loads data into the 'DSCompleto.encargado_pc' table. You can move, or remove it, as needed.
            this.encargado_pcTableAdapter.Fill(this.DSCompleto.encargado_pc);
            // TODO: This line of code loads data into the 'repo1.computadora' table. You can move, or remove it, as needed.
            this.computadoraTableAdapter.Fill(this.repo1.computadora);

            this.reporte_pc.RefreshReport();
            this.reporte_mantenciones.RefreshReport();
        }


    }
}
