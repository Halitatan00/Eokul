using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EokulOtomasyon
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }
        Baglanti bgl =new Baglanti();
        private void Form_Admin_Load(object sender, EventArgs e)
        {
            //ogrenci
            bgl.baglantiopen();
            SqlCommand comlistele1 = new SqlCommand("Select * from Tbl_Ogrenci", bgl.con);
            SqlDataAdapter da = new SqlDataAdapter(comlistele1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanticlose();

            //ders
            bgl.baglantiopen();
            SqlCommand comlistele2 = new SqlCommand("Select * from Tbl_Dersler", bgl.con);
            SqlDataAdapter da2 = new SqlDataAdapter(comlistele2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.baglanticlose();

            //Ogretmen
            bgl.baglantiopen();
            SqlCommand comlistele3 = new SqlCommand("Select * from Tbl_Ogretmen", bgl.con);
            SqlDataAdapter da3 = new SqlDataAdapter(comlistele3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            bgl.baglanticlose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            dersid.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            dersad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
        }

        private void derslistele_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand comlistele2 = new SqlCommand("Select * from Tbl_Dersler", bgl.con);
            SqlDataAdapter da2 = new SqlDataAdapter(comlistele2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.baglanticlose();
        }

        private void dersekle_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("insert into Tbl_Dersler (dersad) values (@d1)",bgl.con);
            cmddersekl.Parameters.AddWithValue("@d1",dersad.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Başarılı ...");
        }

        private void dersguncelle_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("UPDATE Tbl_Dersler SET dersad = @d1 WHERE dersid = @d2", bgl.con);
            cmddersekl.Parameters.AddWithValue("@d1", dersad.Text);
            cmddersekl.Parameters.AddWithValue("@d2", dersid.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Başarılı ...");
        }

        private void derssil_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("DELETE FROM Tbl_Dersler WHERE dersid = @d2", bgl.con);
            cmddersekl.Parameters.AddWithValue("@d2", dersid.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Sildin ...");


        }

        private void ogrencilistele_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand comlistele1 = new SqlCommand("Select * from Tbl_Ogrenci", bgl.con);
            SqlDataAdapter da = new SqlDataAdapter(comlistele1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanticlose();
        }

        private void ogrenciekle_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("insert into Tbl_Ogrenci (ogrencino,ogrenciad,ogrencisoyad,ogrencisifre) values (@o1,@o2,@o3,@o4)", bgl.con);
            cmddersekl.Parameters.AddWithValue("@o1", ogrencino.Text);
            cmddersekl.Parameters.AddWithValue("@o2", ogrenciad.Text);
            cmddersekl.Parameters.AddWithValue("@o3", ogrencisoyad.Text);
            cmddersekl.Parameters.AddWithValue("@o4", ogrencisifre.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Başarılı ...");
        }

        private void ogrenciguncelle_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("UPDATE Tbl_Ogrenci SET ogrencino = @o1,ogrenciad = @o2,ogrencisoyad = @o3,ogrencisifre = @o4 WHERE ogrenciid = @o5", bgl.con);
            cmddersekl.Parameters.AddWithValue("@o1", ogrencino.Text);
            cmddersekl.Parameters.AddWithValue("@o2", ogrenciad.Text);
            cmddersekl.Parameters.AddWithValue("@o3", ogrencisoyad.Text);
            cmddersekl.Parameters.AddWithValue("@o4", ogrencisifre.Text);
            cmddersekl.Parameters.AddWithValue("@o5", ogrenciid.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Başarılı ...");
        }

        private void ogrencisil_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("DELETE FROM Tbl_Ogrenci WHERE ogrenciid = @d2", bgl.con);
            cmddersekl.Parameters.AddWithValue("@d2", ogrenciid.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Sildin ...");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim2 = dataGridView2.SelectedCells[0].RowIndex;
            ogrenciid.Text = dataGridView2.Rows[secim2].Cells[0].Value.ToString();
            ogrencino.Text = dataGridView2.Rows[secim2].Cells[1].Value.ToString();
            ogrenciad.Text = dataGridView2.Rows[secim2].Cells[2].Value.ToString();
            ogrencisoyad.Text = dataGridView2.Rows[secim2].Cells[3].Value.ToString();
            ogrencisifre.Text = dataGridView2.Rows[secim2].Cells[4].Value.ToString();
        }

        private void ogretmenekle_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("insert into Tbl_Ogretmen (ogretmentc,ogretmenad,ogretmensoyad,ogretmensifre) values (@o1,@o2,@o3,@o4)", bgl.con);
            cmddersekl.Parameters.AddWithValue("@o1", ogretmentc.Text);
            cmddersekl.Parameters.AddWithValue("@o2", ogretmenad.Text);
            cmddersekl.Parameters.AddWithValue("@o3", ogretmensoyad.Text);
            cmddersekl.Parameters.AddWithValue("@o4", ogretmensifre.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Başarılı ...");
        }

        private void ogretmensil_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("DELETE FROM Tbl_Ogretmen WHERE ogretmenid = @d2", bgl.con);
            cmddersekl.Parameters.AddWithValue("@d2", ogretmenid.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Sildin ...");
        }

        private void ogretmenlistele_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand comlistele3 = new SqlCommand("Select * from Tbl_Ogretmen", bgl.con);
            SqlDataAdapter da3 = new SqlDataAdapter(comlistele3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            bgl.baglanticlose();
        }

        private void ogretmenguncelle_Click(object sender, EventArgs e)
        {
            bgl.baglantiopen();
            SqlCommand cmddersekl = new SqlCommand("UPDATE Tbl_Ogretmen SET ogretmentc = @o1,ogretmenad = @o2,ogretmensoyad = @o3,ogretmensifre = @o4 WHERE ogretmenid = @o5", bgl.con);
            cmddersekl.Parameters.AddWithValue("@o1", ogretmentc.Text);
            cmddersekl.Parameters.AddWithValue("@o2", ogretmenad.Text);
            cmddersekl.Parameters.AddWithValue("@o3", ogretmensoyad.Text);
            cmddersekl.Parameters.AddWithValue("@o4", ogretmensifre.Text);
            cmddersekl.Parameters.AddWithValue("@o5", ogretmenid.Text);
            cmddersekl.ExecuteNonQuery();
            bgl.baglanticlose();
            MessageBox.Show("Başarılı ...");
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim3 = dataGridView3.SelectedCells[0].RowIndex;
            ogretmenid.Text = dataGridView3.Rows[secim3].Cells[0].Value.ToString();
            ogretmentc.Text = dataGridView3.Rows[secim3].Cells[1].Value.ToString();
            ogretmenad.Text = dataGridView3.Rows[secim3].Cells[2].Value.ToString();
            ogretmensoyad.Text = dataGridView3.Rows[secim3].Cells[3].Value.ToString();
            ogretmensifre.Text = dataGridView3.Rows[secim3].Cells[4].Value.ToString();
        }
    }
}
