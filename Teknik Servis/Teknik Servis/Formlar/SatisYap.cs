using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Teknik_Servis.Formlar
{
    public partial class SatisYap : Form
    {
        public SatisYap()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            NewMethod();
        }
        private void NewMethod()
        {
            if (textBox9.Text == "")
            {
                foreach (Control item in dataGridView1.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        if (item != textBox7)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1();
        SqlConnection baglanti = new SqlConnection(@"Data Source=aslan;Initial Catalog=DbTeknıkServis;Integrated Security=True;Encrypt=False");
        DataSet daset = new DataSet();

        private void barkodkontrol()

        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from SEPET", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox9.Text == read["BARKODNO"].ToString())

                { durum = false; }

            }
            baglanti.Close();
        }
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select* from SEPET", baglanti);
            adtr.Fill(daset, "SEPET");
            dataGridView1.DataSource = daset.Tables["SEPET"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[11].Visible = false;

            //(ID0 VERGINO1,ADSOYAD2,TELEFON3,BARKODNO4,AD,MARKA,,KATEGORİ,MIKTAR,SATISFİYAT,TOPLAMFIYAT,TARIH
            baglanti.Close();

        }
        private void hesapla()
        {

            try
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(TOPLAMFIYAT) from SEPET", baglanti);
                labelControl1.Text = "Toplam" + (dataGridView1.Rows.Count - 1) + "Kayıt Listendi";
                double tutar=0, kdv = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    tutar += double.Parse(dataGridView1.Rows[i].Cells["TOPLAMFIYAT"].Value.ToString());
                    kdv = tutar * 20 / 100;
                        

                }
                labelControl1.Text=tutar.ToString("C2");
                labelControl2.Text=kdv.ToString("C2");
                //labelControl1.Text = tutar.ExecuteScalar() + "TL";
                //labelControl2.Text = komut.ExecuteScalar() + "TL";
                


                //double fiyat = Convert.ToDouble(TxtFiyat.Text);
                //    double kdv = Convert.ToDouble(TxtKdv.Text);

                //    fiyat = fiyat + (fiyat * kdv) / 100;

                //    if (checkEdit1.Checked)
                //        lblsonuc.Text = (fiyat - fiyat * 0.05).ToString();
                //    else
                //        lblsonuc.Text = fiyat.ToString();


                baglanti.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("hata");
            }
        }
        public void metot1()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.BARKODNO,
                               u.AD,
                               u.MARKA,
                               KATEGORİ = u.TBLKATEGORİ.AD,
                               u.STOK,
                               u.ALISFİYAT,
                               u.SATISFİYAT,


                           };

            gridControl1.DataSource = degerler.ToList();
        }
            private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void SatisYap_Load(object sender, EventArgs e)
        {
            sepetlistele();
            metot1();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox7.Text = "";
            }
            //Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from TBLURUN where BARKODNO like '" + textBox9.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox8.Text = read["AD"].ToString();
                textBox2.Text = read["MARKA"].ToString();
               


                textBox6.Text = read["SATISFİYAT"].ToString();

            }
            baglanti.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            try
            {
                textBox3.Text = (double.Parse(textBox7.Text) * double.Parse(textBox6.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    textBox3.Text = (double.Parse(textBox7.Text) * double.Parse(textBox6.Text)).ToString();
            //}
            //catch (Exception)
            //{


            //    }
            }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into SEPET(VERGINO,ADSOYAD,TELEFON,BARKODNO,AD,MARKA,MIKTAR,SATISFİYAT,TOPLAMFIYAT,TARIH) values(@VERGINO,@ADSOYAD,@TELEFON,@BARKODNO,@AD,@MARKA,@MIKTAR,@SATISFİYAT,@TOPLAMFIYAT,@TARIH)", baglanti);
                komut.Parameters.AddWithValue("@VERGINO", textBox4.Text);
                komut.Parameters.AddWithValue("@ADSOYAD", textBox1.Text);
                komut.Parameters.AddWithValue("@TELEFON", textBox5.Text);
                komut.Parameters.AddWithValue("@BARKODNO", textBox9.Text);


                komut.Parameters.AddWithValue("@AD", textBox8.Text);
                komut.Parameters.AddWithValue("@MARKA", textBox2.Text);
                
                komut.Parameters.AddWithValue("@MIKTAR", int.Parse(textBox7.Text));
                komut.Parameters.AddWithValue("@SATISFİYAT", double.Parse(textBox6.Text));
                komut.Parameters.AddWithValue("@TOPLAMFIYAT", double.Parse(textBox3.Text));
                komut.Parameters.AddWithValue("@TARIH", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

            }

            else
            {

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update SEPET set MIKTAR=MIKTAR+'" + int.Parse(textBox7.Text) + "'where BARKODNO='" + textBox9.Text + "'", baglanti);

                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update SEPET set TOPLAMFIYAT=MIKTAR*SATISFİYAT where BARKODNO='" + textBox9.Text + "'", baglanti);
                komut3.ExecuteNonQuery();

                baglanti.Close();
            }

            textBox7.Text = "1";
            daset.Tables["SEPET"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    if (item != textBox7)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox4.Text == "")
            {
                textBox1.Text = "";
                textBox5.Text = "";
            }
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from TBLCARİ where ADSOYAD like '" + textBox4.Text + "'", baglanti);

            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox1.Text = read["VERGINO"].ToString();
                textBox5.Text = read["TELEFON"].ToString();

            }
            baglanti.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btnİptal_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from  SEPET", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["SEPET"].Clear();
            sepetlistele();
            hesapla();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from  SEPET where BARKODNO='" + dataGridView1.CurrentRow.Cells["BARKODNO"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["SEPET"].Clear();
            sepetlistele();
            hesapla();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

