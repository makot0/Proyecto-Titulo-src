using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SantoTomas
{
    public partial class FormLogin : Form
    {
        public object TIMER { get; private set; }

        //SqlConnection con = new SqlConnection("Persist Security Info = False; User ID = sa; Password=123456;Initial Catalog = proyecto; Server=MAKOTO");
        SqlConnection con = new SqlConnection("Persist Security Info = False; User ID = sa; Password=123456;Initial Catalog = proyecto; Server=192.168.1.14");

        // Conexion con = new Conexion();
        public FormLogin()    //MAKOT0-PC

        {
            InitializeComponent();

            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;

            lblfecha.Text = today.ToString("dd-mm-yy");
            lblhora.Text = now.ToShortTimeString();

           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            FormLogin f = new FormLogin();
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e) 
        {

            try
            {
              
                string Username = txtNombre.Text;
                string Clave = txtClave.Text;
                con.Open();
                SqlDataAdapter consulta = new SqlDataAdapter("SELECT COUNT(*) FROM sys_users WHERE usuario = '"+ Username +"' AND clave = '"+ Clave +"'",con);

                DataTable dt = new DataTable(); //this is creating a virtual table  
                consulta.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                  
                    Menu m = new Menu();
                    m.lblUsuario.Text = Username;
                    m.Show();
                    this.Hide();

                    
                }
                else
                    //
                    errorProvider1.SetError(txtNombre, "Escriba un nombre de usuario y clave válidos");
                txtNombre.Focus();
             
                con.Close();
                

            } // fin try
            catch(SqlException ex)
            {
                if (ex is SqlException)
                {
                    MessageBox.Show("Error, no pudo conectarse.","Conexión a Base de Datos",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
                
            }    // fin catch


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
           // errorProvider1.SetError(txtNombre, "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mensaje principal","mensaje titulo", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

       
    }
}
