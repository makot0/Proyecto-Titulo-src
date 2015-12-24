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
    public partial class compuMenu : Form
    {
        public compuMenu()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Persist Security Info = False; User ID = sa; Password=123456;Initial Catalog = proyecto; Server=MAKOTO");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu m = new SantoTomas.Menu();
            m.Show();

        }

        private void comboUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void compuMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDataSetPC.computadora' table. You can move, or remove it, as needed.
          
            SqlDataAdapter querypc = new SqlDataAdapter("SELECT c.idComputadora 'ID', c.marca, c.modelo, c.nombreEquipo 'Nombre Equipo', c.numSerie, c.cpu, c.memoriaRam, c.discoDuro, c.macWlan," +
                   " c.macLan, u.nombre Ubicación, c.soVersion, c.officeVersion, tp.nombre 'Tipo Computadora', i.numIP 'Dirección IP', ep.usuario Usuario, c.fecha_ingreso " +
                   " FROM computadora AS c " +
                   " inner join ubicacion AS u on c.idUbicacion = u.idUbicacion " +
                   " inner join tipo_pc AS tp on c.idtipoPc = tp.idtipoPc " +
                   " inner join encargado_pc AS ep on c.idencargadopc = ep.idEncargado " +
                   " inner join IP AS i on c.IP = i.idIP", con );
            DataTable dtpc = new DataTable();
            querypc.Fill(dtpc);
            dgwcomputadora.DataSource = dtpc;
            // TODO: This line of code loads data into the 'proyectoDataSetcompu222.computadora' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'proyectoDataSettpc222.tipo_pc' table. You can move, or remove it, as needed.
            this.tipo_pcTableAdapter1.Fill(this.proyectoDataSettpc222.tipo_pc);
            // TODO: This line of code loads data into the 'proyectoDataSetubi222.ubicacion' table. You can move, or remove it, as needed.
            this.ubicacionTableAdapter1.Fill(this.proyectoDataSetubi222.ubicacion);
            // TODO: This line of code loads data into the 'proyectoDatacompu.computadora' table. You can move, or remove it, as needed.



        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboubicacion_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }



        private string parseString(object selectedValue)
        {
            throw new NotImplementedException();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string marca = txtmarca.Text;
            string modelo = txtmodelo.Text;
            string nombre = txtnombre.Text;
            string nserie = txtsn.Text;
            string proce = txtproce.Text;
            string lan = txtlan.Text;
            string wlan = txtwlan.Text;
            string so = txtso.Text;
            string office = txtoffice.Text;
            string fecha = tp_Fingreso.Value.ToString();
            string ram = txtmemoriaram.Text;
            string disco = txtmemoriadisco.Text;
            string IP = txtdireccionip.Text;
            string tipopctxt = combotipopc.SelectedValue.ToString();
            int tipopc = int.Parse(tipopctxt);
            string ubicacion = comboubicacion.SelectedValue.ToString();
            int ubicacion1 = int.Parse(ubicacion);
            string encargado = txtidencargado.Text;


            //MessageBox.Show(fecha);
            //MessageBox.Show(ubicacion);
            //MessageBox.Show(tipopctxt);
            //MessageBox.Show(ram.ToString());
            //MessageBox.Show(disco.ToString());
            //MessageBox.Show(ip2.ToString());

            if (string.IsNullOrWhiteSpace(txtsn.Text))
            {

                errorProvidersn.SetError(txtsn, "debe ingresar un nùmero de serie válida");


            }
            else
            {
                SqlDataAdapter consulta = new SqlDataAdapter("SELECT COUNT(*) FROM computadora " +
                " WHERE numSerie = '" + nserie + " '", con);

                DataTable dt = new DataTable(); //this is creating a virtual table  
                consulta.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Nùmero de serie ya ingresado, verifique SN ingresado ");
                    con.Close();
                }
                else
                {
                    try
                    {
                        con.Open();

                        if (string.IsNullOrEmpty(encargado))
                        {
                            encargado = null;
                        }

                        if (string.IsNullOrEmpty(IP) && int.Parse(txtdireccionip.Text) < 0)
                        {
                            IP = null;
                            lblip.Text = "Verificar dirección IP";
                        }

                        SqlCommand insert = new SqlCommand("INSERT " +
                        "INTO computadora(marca, modelo, nombreEquipo, numSerie, cpu, memoriaRam, " +
                        " discoDuro, macWlan, macLan,idUbicacion,soVersion,officeVersion,idtipoPc,idencargadopc,IP,fecha_ingreso) " +
                        " VALUES(" +
                        "'" + marca + "', '" + modelo + "', '" + nombre + "', '" + nserie + "', '" + proce + "'," + ram + "," + disco + ", '" + wlan + "', '" + lan + "', " +
                        "" + ubicacion1 + ",'" + so + "', '" + office + "'," + tipopc + ", '" + encargado + "',  " +
                        "'" + IP + "','" + fecha + "')", con);

                        insert.ExecuteNonQuery();
                        MessageBox.Show("todo ingresado OK!", " Ingreso de nuevo registro");
                        errorProvidersn.Clear();
                        con.Close();

                                                    
                        if(int.Parse(IP) > 0)
                        {

                            con.Open();
                            int ip2 = int.Parse(IP);
                            SqlCommand updateip = new SqlCommand("UPDATE IP set estado='ocupada' where numIP = " + ip2 + "", con);
                            updateip.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("IP : OK ", "Asignación IP");
                        }

                        
                        }  // fin try
                        catch (Exception)
                        {
                            MessageBox.Show("Se ha producido un error, favor verificar datos ingresados!");
                            con.Close();
                        }



                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();

        }

        public void limpiarForm()
        {
            txtmarca.Text = "";
            txtmodelo.Text = "";
            txtnombre.Text = "";
            txtsn.Text = "";
            txtproce.Text = "";
            txtmemoriaram.Text = "";
            txtmemoriadisco.Text = "";
            txtlan.Text = "";
            txtwlan.Text = "";
            comboubicacion.ResetText();
            txtso.Text = "";
            txtoffice.Text = "";
            combotipopc.ResetText();
            txtidencargado.Text = "";
            txtdireccionip.Text = "";
            tp_Fingreso.ResetText();

        }

        private void txtsn_Leave(object sender, EventArgs e)
        {
            con.Open();
            string nserie = txtsn.Text;
            SqlDataAdapter consulta = new SqlDataAdapter("SELECT COUNT(*) FROM computadora " +
                    " WHERE numSerie = '" + nserie + " '", con);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            consulta.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Nùmero de serie ya ingresado, favor verificar datos ");
                con.Close();
            }
            else { con.Close(); }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter querypc = new SqlDataAdapter("SELECT c.idComputadora 'ID', c.marca, c.modelo, c.nombreEquipo 'Nombre Equipo', c.numSerie, c.cpu, c.memoriaRam, c.discoDuro, c.macWlan," +
                   " c.macLan, u.nombre Ubicación, c.soVersion, c.officeVersion, tp.nombre 'Tipo Computadora', i.numIP 'Dirección IP', ep.usuario Usuario, c.fecha_ingreso " +
                   " FROM computadora AS c " +
                   " inner join ubicacion AS u on c.idUbicacion = u.idUbicacion " +
                   " inner join tipo_pc AS tp on c.idtipoPc = tp.idtipoPc " +
                   " inner join encargado_pc AS ep on c.idencargadopc = ep.idEncargado " +
                   " inner join IP AS i on c.IP = i.idIP", con);
            DataTable dtpc = new DataTable();
            querypc.Fill(dtpc);
            dgwcomputadora.DataSource = dtpc;
        }

        private void btn_limpiar2_Click(object sender, EventArgs e)
        {
                    txtBuscar.Text = "";
                    txtIDBeside.Text = "";
                    txt_marca.Text = "";
                    txt_modelo.Text = "";
                    txt_nombre.Text = "";
                    txt_sn.Text = "";
                    txt_proce.Text = "";
                    txt_ram.Text = "";
                    txt_disco.Text = "";
                    txt_lan.Text = "";
                    txt_wlan.Text = "";
                    comboubicacion.Text="";
                    txt_so.Text = "";
                    txt_office.Text = "";
                    combotipopc.Text="";
                    txt_rut.Text = "";
                    txt_updateip.Text = "";
                    tp_Fingreso.Text="";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                errorProvider1.SetError(txtBuscar, "Ingrese un ID a eliminar");
            }
            else
            {
                try
                {
                    con.Open();

                    string eliminarid = txtBuscar.Text;
                    int ideliminar = int.Parse(eliminarid);
                    SqlCommand eliminar = new SqlCommand("Delete from computadora where idComputadora = " + ideliminar + "", con);
                    eliminar.ExecuteNonQuery();
                    MessageBox.Show("ok!");
                    con.Close();
                    errorProvider1.Clear();
                    txtBuscar.Text = "";
                }
                catch (Exception)
                {
                    
                    con.Close();
                }
                con.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
            string idLeave = txtBuscar.Text;
            SqlDataAdapter consulta = new SqlDataAdapter("SELECT COUNT(*) FROM computadora " +
                    " WHERE idComputadora = '" + idLeave + " '", con);

            DataTable dt = new DataTable(); //this is creating a virtual table  
            consulta.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {
                noencontrado.SetError(txtBuscar,"ID no encontrado!");
                con.Close();
            }
            else
            {
                noencontrado.Clear();
                string buscar = txtBuscar.Text;
                int buscarID = int.Parse(buscar);
                SqlDataAdapter MiAdaptador = new SqlDataAdapter("Select idComputadora, marca,modelo,nombreEquipo,numSerie,cpu," +
                    " memoriaRam, discoDuro, macWlan, macLan, idUbicacion, " +
                    " soVersion, officeVersion, idtipoPc, idencargadopc, IP, fecha_ingreso from computadora where idComputadora =" + buscarID + "", con);

                //con.Open();

                DataSet MiDataSet = new DataSet();

                MiAdaptador.Fill(MiDataSet);

                txtIDBeside.Text = MiDataSet.Tables[0].Rows[0][0].ToString();
                txtBuscar.Text = MiDataSet.Tables[0].Rows[0][0].ToString();
                txt_marca.Text = MiDataSet.Tables[0].Rows[0][1].ToString();
                txt_modelo.Text = MiDataSet.Tables[0].Rows[0][2].ToString();
                txt_nombre.Text = MiDataSet.Tables[0].Rows[0][3].ToString();
                txt_sn.Text = MiDataSet.Tables[0].Rows[0][4].ToString();
                txt_proce.Text = MiDataSet.Tables[0].Rows[0][5].ToString();
                txt_ram.Text = MiDataSet.Tables[0].Rows[0][6].ToString();
                txt_disco.Text = MiDataSet.Tables[0].Rows[0][7].ToString();
                txt_wlan.Text = MiDataSet.Tables[0].Rows[0][8].ToString();
                txt_lan.Text = MiDataSet.Tables[0].Rows[0][9].ToString();
                combo_ubi.Text = MiDataSet.Tables[0].Rows[0][10].ToString();
                txt_so.Text = MiDataSet.Tables[0].Rows[0][11].ToString();
                txt_office.Text = MiDataSet.Tables[0].Rows[0][12].ToString();
                combo_pc.Text = MiDataSet.Tables[0].Rows[0][13].ToString();
                txt_rut.Text = MiDataSet.Tables[0].Rows[0][14].ToString();
                txt_updateip.Text = MiDataSet.Tables[0].Rows[0][15].ToString();
                dt_Fingreso2.Text = MiDataSet.Tables[0].Rows[0][16].ToString();


                //  txt_marca.Text = (string)MiDataSet.Tables[0].Rows[0];

                con.Close();
            }
            con.Close();
        }

        private void btn_cambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Ingresa un ID válido","Error",MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                try
                {
                    string nombreEqui = txt_nombre.Text;
                    int ram = int.Parse(txt_ram.Text);
                    int disco = int.Parse(txt_disco.Text);
                    string lan = txt_lan.Text;
                    string wlan = txt_wlan.Text;
                    int ubicacion = int.Parse(combo_ubi.SelectedValue.ToString());
                    string so = txt_so.Text;
                    string office = txt_office.Text;
                  
                    string rut = txt_rut.Text;
                    int ipupdate = int.Parse(txt_updateip.Text);
                    int idUpdate = int.Parse(txtBuscar.Text);


                    con.Open();
                    SqlCommand updatepc = new SqlCommand("update computadora " +
                        "set nombreEquipo = '"+ nombreEqui+"', memoriaRam = " + ram + ", discoDuro = " + disco +
                        ", macWlan = '" + wlan + "', macLan ='" + lan +
                        "',idUbicacion = " + ubicacion + ", soVersion = '" + so +
                        "', officeVersion = '" + office + "',idencargadopc = " + rut + 
                        ", IP =" + ipupdate + " where idComputadora = " + idUpdate + "", con);

                    updatepc.ExecuteNonQuery();

                    MessageBox.Show("Se han actualizado los campos", "Registro de cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(ipupdate.ToString());
                    MessageBox.Show(ubicacion.ToString());
                    con.Close();

                        // actualizar IP
                    



                    //if (ipupdate > 0)
                    //{

                    //    con.Open();
                    //    int ip2 = ipupdate;
                    //    SqlCommand updateip = new SqlCommand("UPDATE IP set estado='ocupada' where numIP = " + ipupdate + "", con);
                    //    updateip.ExecuteNonQuery();
                    //    con.Close();
                    //    MessageBox.Show("IP : OK ", "Asignación IP");
                    //}
                }

                catch (Exception)
                {
                    MessageBox.Show("error");
                    con.Close();
                }
                con.Close();
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
           // this.BindingContext[proyectoDataSetcompu222, "idComputadora"].Position -= 1;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combo_ubi_Leave(object sender, EventArgs e)
        {
            MessageBox.Show(combo_ubi.SelectedValue.ToString(),"selected value");
            MessageBox.Show(combo_ubi.Text, "Text");
        }
    }
}
