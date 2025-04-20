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
    public partial class Form_Anasayfa : Form
    {
        public Form_Anasayfa()
        {
            InitializeComponent();
        }
        int secim = 0;
        Baglanti bgl = new Baglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "ÖĞRETMEN TC :";
            secim = 1;
            label1.Visible = true;
            label2.Visible = true;
            tx_no.Visible = true;
            tx_sifre.Visible = true;
            btn_giris.Visible = true;
        }

        private void btn_ogrenci_Click(object sender, EventArgs e)
        {
            label1.Text = "    ÖĞRENCİ NO :";
            secim = 0;
            label1.Visible = true;
            label2.Visible = true;
            tx_no.Visible = true;
            tx_sifre.Visible = true;
            btn_giris.Visible = true;
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (secim == 0) {
                bgl.baglantiopen();
                SqlCommand cmdkontrol = new SqlCommand("select * from Tbl_Ogrenci where ogrencino=@k1 AND ogrencisifre=@k2",bgl.con);
                cmdkontrol.Parameters.AddWithValue("@k1",tx_no.Text);
                cmdkontrol.Parameters.AddWithValue("@k2", tx_sifre.Text);
                SqlDataReader rd = cmdkontrol.ExecuteReader();
                if (rd.Read())
                {
                    Form_Ogrenci frmogrenci = new Form_Ogrenci();
                    frmogrenci.id = Convert.ToInt32(tx_no.Text);
                    frmogrenci.Show();
                }
                else
                {
                    MessageBox.Show("Giriş Hatası ...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rd.Close();
                bgl.baglanticlose();
            }
            else if (secim == 1)
            {
                bgl.baglantiopen();
                SqlCommand komut2 = new SqlCommand("select * from Tbl_Ogretmen where ogretmentc=@c1 AND ogretmensifre=@c2",bgl.con);
                komut2.Parameters.AddWithValue("c1", tx_no.Text);
                komut2.Parameters.AddWithValue("c2", tx_sifre.Text);
                SqlDataReader r =komut2.ExecuteReader();
                if (r.Read())
                {
                    Form_Ogretmen frmogretmen = new Form_Ogretmen();
                    frmogretmen.ogrid = tx_no.Text;
                    frmogretmen.Show();
                }
                else
                {
                    MessageBox.Show("Giriş Hatası ...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                r.Close();
                bgl.baglanticlose();
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Form_Admin frmadmin = new Form_Admin();
            frmadmin.Show();
        }
    }
}
