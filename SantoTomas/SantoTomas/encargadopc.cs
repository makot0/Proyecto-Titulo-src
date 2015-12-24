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
    public partial class encargadopc : Form 
    {
        public encargadopc()
        {
            InitializeComponent();
        }
      SqlConnection con = new SqlConnection("Persist Security Info = False; User ID = sa; Password=123456;Initial Catalog = proyecto; Server=MAKOTO");
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new Menu();
            m.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Open();
           string id = txtID.Text;
           string rut = txtRut.Text;
           string usuario = txtUsuario.Text;
           string nombre = txtNombre.Text;
           string apellido = txtApellido.Text;
           string cargo =  txtCargo.Text;
           string correo = txtCorreo.Text;
           string anexo = txtAnexo.Text;

            if (string.IsNullOrWhiteSpace(txtRut.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                errorProvider1.SetError(txtRut, "No se aceptan datos en blanco.");

                con.Close();
            }
            else
            {
                try
                {
                    SqlCommand sql = new SqlCommand("INSERT INTO sys_users(usuario, clave)" +
                                                    " values('" + usuario + "','" + anexo + "')", con);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || (int.Parse(txtID.Text) < 1))
            {
                errorProvider2.SetError(txtID, "Por favor indica un ID válido.");

                con.Close();
            }
            else
            {
                try
                {
                    con.Open();
                    int eliminar = int.Parse(txtID.Text);
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
        public void limpiarForm()
        {
            txtID.Text = null;
            txtRut.Text = null;
            txtUsuario.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtCargo.Text = null;
            txtCorreo.Text = null;
            txtAnexo.Text = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    if ((string.IsNullOrWhiteSpace(txtID.Text) || int.Parse(txtID.Text) <= 0) || (string.IsNullOrWhiteSpace(txtclave.Text)))
        //    {
        //        errorProvider2.SetError(txtID, "Favor llenar los  datos requeridos.");

        //        con.Close();
        //    }
        //    else
        //    {
        //        try
        //        {
        //            con.Open();
        //            int ID = int.Parse(txtID.Text);

        //            SqlCommand actualizar = new SqlCommand("UPDATE sys_users set clave='" +  + "' WHERE ID=" + ID + "", con);
        //            actualizar.ExecuteNonQuery();

        //            MessageBox.Show("listo!, actualizado correctamente");
        //            con.Close();
        //            limpiarForm();
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Ha ocurrido un error, favor revisar los datos ingresados");
        //            con.Close();
        //        }
        //    }
        //}

    }

    
}
