using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
     

namespace SantoTomas
{
    class Conexion
    {

        private SqlConnection conexionBD = new SqlConnection("Persist Security Info = False; User ID = sa; Password=123456;Initial Catalog = proyecto; Server=MAKOTO");


    
        public void Conectar()
        {
            conexionBD.Open();
        }

        public void Desconectar()
        {

            conexionBD.Close();
        }
    

    }
}
