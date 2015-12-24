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
    public partial class Mantenciones : Form
    {
        public Mantenciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new SantoTomas.Menu();
            m.Show();
            
        }
    }
}
