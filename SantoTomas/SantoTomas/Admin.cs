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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_sysusers_Click(object sender, EventArgs e)
        {
            Usuarios usuarios1 = new Usuarios();
            usuarios1.Show();
        }

        private void btnencargadopc_Click(object sender, EventArgs e)
        {
            encargadopc encargado = new encargadopc();
            encargado.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new SantoTomas.Menu();
            menu.Show();
        }
    }
}
