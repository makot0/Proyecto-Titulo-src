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
using System.Configuration;

namespace SantoTomas
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            Nada();
        }

        SqlConnection con = new SqlConnection("Persist Security Info = False; User ID = sa; Password=123456;Initial Catalog = proyecto; Server=MAKOTO");

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDssysusers.sys_users' table. You can move, or remove it, as needed.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insertarRegistro();
        }


        public void insertarRegistro()
        {
            con.Open();
            string usuario = txtnombre.Text;
            string clave = txtclave.Text;

            if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtclave.Text))
            {
                errorpop.SetError(txtnombre, "No se aceptan datos en blanco.");

                con.Close();
            }
            else
            {
                try
                {
                    SqlCommand sql = new SqlCommand("INSERT INTO sys_users(usuario, clave)" +
                                                    " values('" + usuario + "','" + clave + "')",con);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("ingresado correctamente");
                    con.Close();
                    limpiarForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("error, no se ha ingresado el usuario.");
                    con.Close();
                    limpiarForm();
                }
                
            }

        }

        private void btnResfrescar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from sys_users", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || (int.Parse(txtId.Text) < 1))
            {
                errorpop.SetError(txtId, "Por favor indica un ID válido.");

                con.Close();
            }
            else
            {
                try
                {
                    con.Open();
                    int eliminar = int.Parse(txtId.Text);
                    SqlCommand delete = new SqlCommand("Delete from sys_users where ID=" + eliminar + "", con);
                    delete.ExecuteNonQuery();

                    MessageBox.Show("Se eliminó el usuario correctamente.");
                    con.Close();
                    limpiarForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error, favor revisar los datos ingresados");
                    con.Close();
                }
            }
        }

        public void Nada()
        {
            MessageBox.Show("nada");
        }

        public void limpiarForm()
        {
            txtId.Text = null;
            txtnombre.Text = null;
            txtclave.Text = null;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtId.Text) || int.Parse(txtId.Text) <= 0) || (string.IsNullOrWhiteSpace(txtclave.Text)))
            {
                errorpop.SetError(txtId, "Favor llenar los  datos requeridos.");

                con.Close();
            }
            else
            {
                try
                {
                    con.Open();
                   int ID = int.Parse(txtId.Text);
                   string clave = txtclave.Text;

                    SqlCommand actualizar = new SqlCommand("UPDATE sys_users set clave='"+clave+"' WHERE ID="+ID+"", con);
                    actualizar.ExecuteNonQuery();

                    MessageBox.Show("listo!, actualizado correctamente");
                    con.Close();
                    limpiarForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error, favor revisar los datos ingresados");
                    con.Close();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                errorpop.SetError(txtnombre, "Ingresa un ID.");

                con.Close();
            }
            else
            {
                try
                {
                    con.Open();
                    //  int buscar = int.Parse(txtId.Text);

                    var buscar = txtId.Text;
                    SqlCommand buscar2 = new SqlCommand("SELECT usuario, clave from sys_users " + 
                                                        "WHERE ID=" + buscar + "", con);
                    buscar2.ExecuteNonQuery();

                    MessageBox.Show("listo!");
                    con.Close();
                    limpiarForm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error, favor revisar los datos ingresados");
                    con.Close();
                }
            }
        }

        
    }
}
