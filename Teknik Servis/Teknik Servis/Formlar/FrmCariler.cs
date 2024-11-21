using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;

namespace Teknik_Servis.Formlar
{
    public partial class FrmCariler : Form
    {
        public FrmCariler()
        {
            InitializeComponent();
        }
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1();
        int secilen;
        bool durum;
        private void metod1()

        {
            var degerler = from u in db.TBLCARİ
                           select new
                           {
                               u.ID,
                               u.ADSOYAD,
                             
                               u.TELEFON,
                               u.MAİL,
                               u.VERGINO,
                               u.STATU,
                               u.ADRES,
                               u.IL,
                               u.ILCE

                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariler_Load(object sender, EventArgs e)
        {
            
            metod1();
            gridControl1.DataSource = db.TBLCARİ.ToList();
            labelControl11.Text = db.TBLCARİ.Count().ToString();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLILLER
                                            select new
                                            {
                                                x.id,
                                                x.sehir
                                            }).ToList();
            labelControl15.Text = db.TBLCARİ.Select(z => z.IL).Distinct().Count().ToString();
            labelControl17.Text = db.TBLCARİ.Select(z => z.ILCE).Distinct().Count().ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" &&  TxtMail.Text != "" && TxtTelefon.Text != "" && TxtStatü.Text != ""  && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && TxtVergiNo.Text != "" && TxtAdres.Text != "" )
            {
                TBLCARİ t = new TBLCARİ();
                t.ADSOYAD = TxtAd.Text;
              
                t.MAİL = textMail.Text;
                t.TELEFON = TxtTelefon.Text;
                t.IL = lookUpEdit1.Text;
                t.ILCE = lookUpEdit2.Text;
                t.VERGINO = TxtVergiNo.Text;
                t.STATU = TxtStatü.Text;
                t.ADRES = TxtAdres.Text;

                db.TBLCARİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Bilgisi Başarıyla Kaydededildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metod1();

            }
            else
            { MessageBox.Show("Aynı Cari Veya Boşluk Olamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLCARİ.Find(id);
            db.TBLCARİ.Remove(deger);
            db.SaveChanges();
            metod1();
            MessageBox.Show("Cari Bilgisi Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && textMail.Text != "" && TxtTelefon.Text != "" && TxtStatü.Text != "" && lookUpEdit1.Text != "" && lookUpEdit2.Text != "" && TxtVergiNo.Text != "" && TxtAdres.Text != "" )
            {


                int id = int.Parse(TxtId.Text);
                var t = db.TBLCARİ.Find(id);
                t.ADSOYAD = TxtAd.Text;
              
                t.MAİL = textMail.Text;
                t.TELEFON = TxtTelefon.Text;
                t.IL = lookUpEdit1.Text;
                t.ILCE = lookUpEdit2.Text;
              
                t.VERGINO = TxtVergiNo.Text;
                t.STATU = TxtStatü.Text;
                t.ADRES = TxtAdres.Text;

                db.SaveChanges();
                metod1();
                MessageBox.Show("Cari Bilgisi Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            { MessageBox.Show("Aynı Cari Veya Boşluk Olamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metod1();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }




        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                TxtId.Text = "";
                TxtAd.Text = "";

                textMail.Text = "";
                TxtTelefon.Text = "";
                TxtStatü.Text = "";
                lookUpEdit1.EditValue = "";
                lookUpEdit2.EditValue = "";
                TxtVergiNo.Text = "";
                TxtAdres.Text = "";
                }
            catch { MessageBox.Show("Hata!"); }
    }





            private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("ADSOYAD").ToString();
            
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            textMail.Text = gridView1.GetFocusedRowCellValue("MAİL").ToString();

            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lookUpEdit2.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            TxtVergiNo.Text = gridView1.GetFocusedRowCellValue("VERGINO").ToString();
            TxtStatü.Text = gridView1.GetFocusedRowCellValue("STATU").ToString();
            TxtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try { 
            secilen = int.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TBLILCELER
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir



                                                 }).Where(z => z.sehir == secilen).ToList();
            }
            catch { }
        }
    }

}
