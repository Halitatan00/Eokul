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

namespace EokulOtomasyon
{
    public partial class Form_Ogrenci : Form
    {
        public Form_Ogrenci()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        public int id;
        int id2;
        private void Form_Ogrenci_Load(object sender, EventArgs e)
        {
            label3.Text = id.ToString();
            //AD VE BİLGİLER
            bgl.baglantiopen();
            SqlCommand conlistele = new SqlCommand("SELECT ogrenciid,ogrencino, ogrenciad FROM Tbl_Ogrenci WHERE ogrencino = @k1", bgl.con);
            conlistele.Parameters.AddWithValue("@k1", id);
            SqlDataReader rd = conlistele.ExecuteReader();
            if (rd.Read())
            {
                label3.Text = rd["ogrencino"].ToString();
                label4.Text = rd["ogrenciad"].ToString();
                label5.Text = rd["ogrenciid"].ToString();
            }
            rd.Close();
            bgl.baglanticlose();
            id2=Convert.ToInt16(label5.Text);
            //LİSTELE NOTLARI
            bgl.baglantiopen();
            SqlCommand cmd = new SqlCommand("Select o.ogrenciad,g.ogretmenad, d.dersad, n.not1, n.not2, n.not3, n.ortalama from Tbl_Notlar n inner join Tbl_Ogrenci o on o.ogrenciid = n.ogrenciid inner join Tbl_Dersler d on d.dersid = n.dersid inner join Tbl_Ogretmen g on g.ogretmenid=n.ogrenciid Where o.ogrenciid=@o1",bgl.con);
            cmd.Parameters.AddWithValue("@o1", id2);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanticlose();
            
        }
    }
}
