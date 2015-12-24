using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SantoTomas
{
    public partial class IP : Form
    {
            
           public IP()
        {
            InitializeComponent();
                                  
        }

        SqlConnection con = new SqlConnection("Persist Security Info = False; User ID = sa; Password=123456;Initial Catalog = proyecto; Server=MAKOTO");

        public object ConfigurationManager { get; private set; }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new Menu();
            m.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           // asignarIP aIP = new asignarIP();
            //Show();
        }

        private void disponibilidadIPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IP_Load(object sender, EventArgs e)
        {
            
            lblConexion.Text = "Conectado a la bbdd";
         }

        private void radioButton1_CheckedChanged(object sender, EventArgs f)
        {

            llenarContadores();

            try
                {
                SqlDataAdapter sda = new SqlDataAdapter("select numIP as Disponibles from IP where estado='disponible'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;

                dataGridView4.DataSource = null;
            }
            catch
                {
               
                MessageBox.Show("Error de conexión con la BBDD");
                }



           
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            llenarContadores();
            dataGridView2.DataSource = null;
            dataGridView4.DataSource = null;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT  "
                                                           + " i.numIP IP,"
                                                           + " e.usuario,"
                                                           + " c.idComputadora"
                                                           + " FROM"
                                                           + " IP as i"
                                                           + " INNER JOIN computadora as c on i.idIP = c.IP"
                                                           + " INNER JOIN encargado_pc as e on c.idencargadopc = e.idEncargado",con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            // llenado Data Grid View Networking

            SqlDataAdapter sda2 = new SqlDataAdapter("select "
                                                        + " n.networkingID ID,"
                                                        + " t.nombre Dispositivo,"
                                                        + " n.IP,"
                                                        + " u.nombre Ubicacion,"
                                                        + " n.observaciones"
                                                        + " from"
                                                        + " networking as n"
                                                        + " INNER JOIN tipo_net as t on t.netID = n.tipoDispositivo"
                                                        + " INNER JOIN ubicacion as u on u.idUbicacion = n.Ubicacion", con);

            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView4.DataSource = dt2;


            con.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

              private void button5_Click(object sender, EventArgs e)
        {


            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtIDCompu.Text) || string.IsNullOrWhiteSpace(txtIP.Text))
            {
                lblConexion.Text = "ha ocurrido un error al realizar la acción";
                errorProviderip.SetError(txtIP, "debe ingresar una IP válida" );
                errorProviderip.SetError(txtIDCompu, " ingrese un ID");

        }
            else
            {
                int compu_id = int.Parse(txtIDCompu.Text);
                SqlDataAdapter consulta = new SqlDataAdapter("SELECT COUNT(*) FROM computadora WHERE IP > 0 AND idComputadora = " + compu_id + "", con);

                DataTable dt = new DataTable(); //this is creating a virtual table  
                consulta.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Ya tiene una IP asignada!");
                    con.Close();
                }
                else
                { 
                    con.Open();
                String asignarID = txtIDCompu.Text;
                int asignarIDCompu = int.Parse(asignarID);  // asigna ip a computadora

                String asignar2 = txtIP.Text;
                int asignarIP2 = int.Parse(asignar2);  // actualiza estado de ip a ocupada


                    if (int.Parse(txtIP.Text) > 255)
                    {
                        lblConexion.Text = "No existen las IP mayor a 255 en IPv4!";
                        con.Close();
                    }
                    else
                    {
                        SqlCommand sql = new SqlCommand("update computadora set IP=" + asignarIP2 + " where idComputadora=" + asignarIDCompu + "", con);
                        sql.ExecuteNonQuery();
                        SqlCommand sql2 = new SqlCommand("update IP set estado='ocupada', observacion='-' where numIP=" + asignarIP2 + "", con);
                        sql2.ExecuteNonQuery();
                        lblConexion.Text = "Se han actualizado los datos exitosamente.";
                        con.Close();

                        txtIP.Text = null;
                        txtIDCompu.Text = null;
                        //txtIDCompu.Text = null;
                        con.Close();
                    }
                }


            }

}

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter buscar = new SqlDataAdapter("select numIP, estado from IP", con);
            DataTable dt1 = new DataTable();
            buscar.Fill(dt1);
            dataGridView2.DataSource = dt1;
           
            SqlCommand sqlcount1 = new SqlCommand("select count(*) from IP where estado='ocupada';select count(*) from IP where estado='disponible'",con);
            sqlcount1.ExecuteNonQuery();
            using (IDataReader rdr = sqlcount1.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int firstIntCol = rdr.GetInt32(0); // assuming the first column is of type Int32
                                                       // other fields ...
                    lblocupadas.Text = firstIntCol.ToString();
                }
                if (rdr.NextResult())
                {
                    while (rdr.Read())
                    {
                        int firstIntCol = rdr.GetInt32(0); // assuming the first column is of type Int32
                                                           // other fields ...

                        lbldisponibles.Text = firstIntCol.ToString();
                    }
                    
                }

                con.Close();
            }
            con.Close();
        }

        private SqlCommand ToString(string v)
        {
            throw new NotImplementedException();
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            con.Open();
            dataGridView2.DataSource = null;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  "
                                                         + " i.numIP IP,"
                                                           + " e.usuario,"
                                                           + " c.idComputadora"
                                                           + " FROM"
                                                           + " IP as i"
                                                           + " INNER JOIN computadora as c on i.numIP = c.IP"
                                                           + " INNER JOIN encargado_pc as e on c.idencargadopc = e.idEncargado", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select numIP as Disponibles from IP where estado='disponible'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch
            {

                MessageBox.Show("Error de conexión con la BBDD");
            }
        }

        private void txtIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtIDCompu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

       

        private void txtliberar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        void llenarContadores()
        {
            con.Open();
            SqlCommand sqlcount1 = new SqlCommand("select count(*) from IP where estado='ocupada';select count(*) from IP where estado='disponible'",con);
            sqlcount1.ExecuteNonQuery();
            using (IDataReader rdr = sqlcount1.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int firstIntCol = rdr.GetInt32(0); // assuming the first column is of type Int32
                                                       // other fields ...
                    lblocupadas.Text = firstIntCol.ToString();
                }
                if (rdr.NextResult())
                {
                    while (rdr.Read())
                    {
                        int firstIntCol = rdr.GetInt32(0); // assuming the first column is of type Int32
                                                           // other fields ...

                        lbldisponibles.Text = firstIntCol.ToString();
                    }

                }

                con.Close();
            }
        }       //

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter buscar = new SqlDataAdapter("select numIP, estado from IP", con);
            DataTable dt1 = new DataTable();
            buscar.Fill(dt1);
            dataGridView2.DataSource = dt1;

            SqlCommand sqlcount1 = new SqlCommand("select count(*) from IP where estado='ocupada';select count(*) from IP where estado='disponible'",con);
            sqlcount1.ExecuteNonQuery();
            using (IDataReader rdr = sqlcount1.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int firstIntCol = rdr.GetInt32(0); // assuming the first column is of type Int32
                                                       // other fields ...
                    lblocupadas.Text = firstIntCol.ToString();
                }
                if (rdr.NextResult())
                {
                    while (rdr.Read())
                    {
                        int firstIntCol = rdr.GetInt32(0); // assuming the first column is of type Int32
                                                           // other fields ...

                        lbldisponibles.Text = firstIntCol.ToString();
                    }

                }

                con.Close();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtIP.Text) || int.Parse(txtIP.Text) == 0) || (string.IsNullOrWhiteSpace(txtIDCompu.Text) || int.Parse(txtIDCompu.Text) == 0))
            {
                errorProviderip.SetError(txtIP, "Error, no puedes dejar los campo vacíos, o ingresar un 0");

            }
            else
            {
                    String liberar = txtIP.Text;
                    int liberarIP = int.Parse(liberar);
                    string id = txtIDCompu.Text;
                    int idpc = int.Parse(id);

                    con.Open();
                    SqlCommand sql = new SqlCommand("update IP set estado='disponible', observacion='-' where numIP=" + liberarIP + "",con);
                    sql.ExecuteNonQuery();
                    SqlCommand sql2 = new SqlCommand("update computadora set IP=NULL where idComputadora=" + idpc + "",con);
                    sql2.ExecuteNonQuery();
                    con.Close();
                    // lblOK.Text = "";
                    txtIP.Text = null;
                }
             }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbuscar.Text) || int.Parse(txtbuscar.Text) == 0)
            {
                errorProviderip.SetError(txtbuscar, "Error, no puedes dejar este campo vacío, o usar el 0");

            }
            else
            {
                String buscarIP1 = txtbuscar.Text;
                int buscarIP = int.Parse(buscarIP1);
                SqlDataAdapter buscar = new SqlDataAdapter("select numIP, estado, observacion from IP where numIP=" + buscarIP + "", con);
                DataTable dt1 = new DataTable();
                buscar.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Asignar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            con.Open();

            
            string net_ip = txt_ip.Text;
            string net_id = txt_id.Text;

            if (validacionesTXT(net_ip, net_id) == false)
            {
                errorProviderip.SetError(txt_id, "Error, no puedes dejar este campo vacío, o usar el 0");
            }
            else
            {
                SqlDataAdapter consulta = new SqlDataAdapter("SELECT COUNT(*) FROM networking WHERE IP > 0 AND networkingID = " + net_id + "", con);

                DataTable dt = new DataTable(); //this is creating a virtual table  
                consulta.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("ya tiene una ip asignada, favor liberar","Asignación IP");
                    con.Close();
                }
                else
                {
                    int net_ip2 = int.Parse(txt_ip.Text);
                    int net_id2 = int.Parse(txt_id.Text);
                    SqlCommand consulta_updateip = new SqlCommand("UPDATE IP set estado='ocupada' " +
                                                         "WHERE numIP=" + net_ip2 + "", con);
                    consulta_updateip.ExecuteNonQuery();

                    SqlCommand consulta_updateip2 = new SqlCommand("UPDATE networking set IP=" + net_ip2 +
                                                         "WHERE networkingID=" + net_id2 + "", con);
                    consulta_updateip2.ExecuteNonQuery();

                    MessageBox.Show("IP Asignada!.");

                    con.Close();
                }
            }
            con.Close();
        }

        private void btnNetliberar_Click(object sender, EventArgs e)
        {
            
            string net_id = txt_id.Text;
            string net_ip = txt_ip.Text;

            if (validacionesTXT(net_id, net_ip) == false)
                {
                con.Open();
                errorProviderip.SetError(txt_id, "Error, no puedes dejar este campo vacío, o usar el 0");
                con.Close();
            }
            else
            {
                SqlDataAdapter consulta = new SqlDataAdapter("SELECT COUNT(*) FROM networking WHERE IP > 0 AND networkingID = " + net_id + "", con);

                DataTable dt = new DataTable(); //this is creating a virtual table  
                consulta.Fill(dt);
                if (dt.Rows[0][0].ToString() == "0")
                {
                    MessageBox.Show("Error, no tiene una ip asignada!");
                    con.Close();
                    txt_id.Text = "";
                    txt_ip.Text = "";
                }
                else
                {
                    con.Open();
                    int net_ip2 = int.Parse(txt_ip.Text);
                    int net_id2 = int.Parse(txt_id.Text);
                    SqlCommand consulta_updateip = new SqlCommand("UPDATE IP set estado='disponible' " +
                                                         "WHERE numIP=" + net_ip2 + "", con);
                    consulta_updateip.ExecuteNonQuery();

                    SqlCommand consulta_updateip2 = new SqlCommand("UPDATE networking set IP=null WHERE networkingID=" + net_id2 + "", con);
                    consulta_updateip2.ExecuteNonQuery();

                    MessageBox.Show("IP liberada!.");

                    txt_id.Text = "";
                    txt_ip.Text = "";
                    con.Close();
                }
            }
        }


        private Boolean validacionesTXT(string net_id, string net_ip)
        {
            if (string.IsNullOrWhiteSpace(txt_ip.Text) || int.Parse(txt_id.Text) <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dgvIP = new SqlDataAdapter("select "
                                                        + " n.networkingID ID,"
                                                        + " t.nombre Dispositivo,"
                                                        + " n.IP,"
                                                        + " u.nombre Ubicacion,"
                                                        + " n.observaciones"
                                                        + " from"
                                                        + " networking as n"
                                                        + " INNER JOIN tipo_net as t on t.netID = n.tipoDispositivo"
                                                        + " INNER JOIN ubicacion as u on u.idUbicacion = n.Ubicacion", con);

            DataTable dt2 = new DataTable();
            dgvIP.Fill(dt2);
            dgnetworkingip.DataSource = dt2;
        }
    }
}