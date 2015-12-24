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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            compuMenu cMenu = new compuMenu();
            cMenu.Show();
           this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IP ip = new IP();
            ip.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmantenciones_Click(object sender, EventArgs e)
        {
            Mantenciones mantencion = new Mantenciones();
            mantencion.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Networking net1 = new Networking();
            net1.Show();
            this.Hide();
        }

       private void btnInformes_Click(object sender, EventArgs e)
        {
            Reportes repoman = new Reportes();
            repoman.Show();
            this.Hide();
        }

        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admini = new Admin();
            admini.Show();
            this.Hide();
        }
    }
}
