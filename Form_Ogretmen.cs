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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EokulOtomasyon
{
    public partial class Form_Ogretmen : Form
    {
        public Form_Ogretmen()
        {
            InitializeComponent();
        }
        public string ogrid;
        Baglanti bgl =new Baglanti();
        int ogrenciid;
        int notid;
        void listele()
        {
            bgl.baglantiopen();
            SqlCommand cmd2 = new SqlCommand(
                "SELECT n.notid,o.ogrenciad, g.ogretmenad, d.dersad, n.not1, n.not2, n.not3, n.ortalama " +
                "FROM Tbl_Notlar n " +
                "INNER JOIN Tbl_Ogrenci o ON o.ogrenciid = n.ogrenciid " +
                "INNER JOIN Tbl_Dersler d ON d.dersid = n.dersid " +
                "INNER JOIN Tbl_Ogretmen g ON g.ogretmenid = n.ogretmenid " +
                "WHERE g.ogretmenid = @o1", bgl.con);

            cmd2.Parameters.AddWithValue("@o1", Convert.ToInt32(label11.Text));
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt3 = new DataTable();
            da2.Fill(dt3);
            dataGridView2.DataSource = dt3;
            bgl.baglanticlose();
        }
        private void Form_Ogretmen_Load(object sender, EventArgs e)
        {
            //AD-SOYAD
            bgl.baglantiopen();
            SqlCommand com = new SqlCommand("select ogretmenid,ogretmenad,ogretmentc from Tbl_Ogretmen where ogretmentc=@o1",bgl.con);
            com.Parameters.AddWithValue("@o1",ogrid);
            SqlDataReader rd = com.ExecuteReader();
            if (rd.Read())
            {
                label3.Text = rd["ogretmentc"].ToString();
                label4.Text = rd["ogretmenad"].ToString();
                label11.Text = rd["ogretmenid"].ToString();
            }
            bgl.baglanticlose();

            //Öğrencileri sırala
            bgl.baglantiopen();
            SqlCommand comlistele1 = new SqlCommand("Select * from Tbl_Ogrenci", bgl.con);
            SqlDataAdapter da = new SqlDataAdapter(comlistele1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanticlose();

            //Notlar
            listele();

            //ComboBoxa ders çek
            bgl.baglantiopen();
            SqlCommand cmd3 = new SqlCommand("Select * from Tbl_Dersler", bgl.con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd3);
            DataTable dt4 = new DataTable();
            dataAdapter.Fill(dt4);
            cb_dersad.DisplayMember = "Dersad";
            cb_dersad.ValueMember = "Dersid";
            cb_dersad.DataSource = dt4;
            bgl.baglanticlose();

            //Ogrencileri bakınca gelsin


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //ekle
            bgl.baglantiopen();
            SqlCommand cmdekle = new SqlCommand("insert into Tbl_Notlar (ogretmenid,ogrenciid,dersid,not1,not2,not3,ortalama) Values (@e1,@e2,@e3,@e4,@e5,@e6,@e7)",bgl.con);
            cmdekle.Parameters.AddWithValue("@e1", Convert.ToInt32(label11.Text));
            cmdekle.Parameters.AddWithValue("@e2", ogrenciid);
            cmdekle.Parameters.AddWithValue("@e3", Convert.ToInt32(cb_dersad.SelectedValue));
            cmdekle.Parameters.AddWithValue("@e4", Convert.ToInt32(tx_not1.Text));
            cmdekle.Parameters.AddWithValue("@e5", Convert.ToInt32(tx_not2.Text));
            cmdekle.Parameters.AddWithValue("@e6", Convert.ToInt32(tx_not3.Text));
            cmdekle.Parameters.AddWithValue("@e7", (Convert.ToInt32(tx_not1.Text) + Convert.ToInt32(tx_not3.Text) + Convert.ToInt32(tx_not2.Text))/3);
            cmdekle.ExecuteNonQuery();
            MessageBox.Show("Eklendi ...","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanticlose();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            tx_ograd.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            ogrenciid = Convert.ToInt32(dataGridView1.Rows[secim].Cells[0].Value);

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim2 =dataGridView2.SelectedCells[0].RowIndex;
            notid= Convert.ToInt32(dataGridView2.Rows[secim2].Cells[0].Value);
            tx_ograd.Text = dataGridView2.Rows[secim2].Cells[1].Value.ToString();
            cb_dersad.Text = dataGridView2.Rows[secim2].Cells[3].Value.ToString();
            tx_not1.Text = dataGridView2.Rows[secim2].Cells[4].Value.ToString();
            tx_not2.Text = dataGridView2.Rows[secim2].Cells[5].Value.ToString();
            tx_not3.Text = dataGridView2.Rows[secim2].Cells[6].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmd6 = new SqlCommand("Update Tbl_Notlar Set not1=@n1,not2=@n2,not3=@n3,ortalama=@n5 where notid=@n4",bgl.con);
            cmd6.Parameters.AddWithValue("@n1", tx_not1.Text);
            cmd6.Parameters.AddWithValue("@n2", tx_not2.Text);
            cmd6.Parameters.AddWithValue("@n3", tx_not3.Text);
            cmd6.Parameters.AddWithValue("@n4", notid);
            cmd6.Parameters.AddWithValue("@n5",(Convert.ToInt32(tx_not1.Text)+ Convert.ToInt32(tx_not2.Text) + Convert.ToInt32(tx_not3.Text))/3);
            cmd6.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Güncellem Başarılı ...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            listele();
        }
    }
}
