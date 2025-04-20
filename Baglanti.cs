using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EokulOtomasyon
{
    public class Baglanti
    {
        public SqlConnection con = new SqlConnection("Data Source=HALIT\\SQLEXPRESS;Initial Catalog=Eokul;Integrated Security=True;Encrypt=False");
        public void baglantiopen()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void baglanticlose()
        {
            if (con.State == System.Data.ConnectionState.Open) { 
                con.Close();
            }
        }
    }
}
