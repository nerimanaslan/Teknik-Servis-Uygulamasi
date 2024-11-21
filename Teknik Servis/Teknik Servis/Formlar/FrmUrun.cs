using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Teknik_Servis.Formlar
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
                DbTeknıkServisEntities1  db = new DbTeknıkServisEntities1();
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
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            metot1();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                  select new
                                                  {

                                                     x.ID,
                                                      x.AD,
                                                  }).ToList();

        }
        bool durum;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && TxtBarkodNo.Text != "" && txtalisfiyat.Text != "" && txtsatisfiyat.Text != "" && txtstok.Text != "" && txtmarka.Text != "" && txtstok.Text != "")
            {
                TBLURUN t = new TBLURUN();
                t.AD = txtad.Text;
                //t.PERSONEL =byte.Parse(TxtPersonel.EditValue.ToString());
                t.BARKODNO = TxtBarkodNo.Text;
                t. MARKA = txtmarka.Text;
                t.ALISFİYAT = decimal.Parse(txtalisfiyat.Text);
                t.SATISFİYAT= decimal.Parse(txtsatisfiyat.Text);
                t.STOK = byte.Parse(txtstok.Text.ToString());
                t.DURUM = false;
                t.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());





                db.TBLURUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Bilgisi Başarıyla Kaydededildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                metot1();

            }
            else
            { MessageBox.Show("Aynı Cari Veya Boşluk Olamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            //    //}
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Boşluk Bırakmayınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            //}
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {

            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try { 
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                TxtBarkodNo.Text = gridView1.GetFocusedRowCellValue("BARKODNO").ToString();
            txtmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            txtalisfiyat.Text = gridView1.GetFocusedRowCellValue("ALISFİYAT").ToString();
            txtsatisfiyat.Text = gridView1.GetFocusedRowCellValue("SATISFİYAT").ToString();
            txtstok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            lookUpEdit1.Text= gridView1.GetFocusedRowCellValue("KATEGORİ").ToString();
            }
            catch

            {
                MessageBox.Show("Hata!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txtıd.Text);
                var deger = db.TBLURUN.Find(id);
                deger.BARKODNO = TxtBarkodNo.Text;

                deger.AD = txtad.Text;
                deger.STOK = short.Parse(txtstok.Text);
                deger.MARKA = txtmarka.Text;
                deger.ALISFİYAT = decimal.Parse(txtalisfiyat.Text);
                deger.SATISFİYAT = decimal.Parse(txtsatisfiyat.Text);
                deger.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());

                db.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            catch (Exception)

            {
                MessageBox.Show("Hata!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try { 

            int id = int.Parse(txtıd.Text);
            var deger = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            metot1();
        }
            catch
            {
                MessageBox.Show("Hata!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

    }

  

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            try { 

            txtad.Text = "";
            TxtBarkodNo.Text = "";
            txtalisfiyat.Text = "";
            txtmarka.Text = "";
            txtsatisfiyat.Text = "";
            txtıd.Text = "";
            txtstok.Text = "";
            lookUpEdit1.Text = "";
            }
            catch { MessageBox.Show("Hata"); }
        }
    }
}
