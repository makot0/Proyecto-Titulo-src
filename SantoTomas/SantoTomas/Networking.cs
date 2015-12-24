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
    public partial class Networking : Form
    {
        public Networking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new SantoTomas.Menu();
            m.Show();
        }

        private void Networking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSet1.tipo_net' table. You can move, or remove it, as needed.
            this.tipo_netTableAdapter.Fill(this.proyectoDataSet1.tipo_net);
            // TODO: This line of code loads data into the 'proyectoDataSetubi222.ubicacion' table. You can move, or remove it, as needed.
            this.ubicacionTableAdapter.Fill(this.proyectoDataSetubi222.ubicacion);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string marca = txtmarca.Text;
            string modelo = txtmodelo.Text;
            string nserie = txtsn.Text;
            string tipo = combotipo.SelectedValue.ToString();
            string mac = txtmac.Text;
            string ubicacion = comboubi.SelectedValue.ToString();
            string obervaciones = txtobservcaciones.Text;
            string fecha = dtfecha.Value.ToString();
            string buscar = txtbuscar.Text;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

       
    }
}
