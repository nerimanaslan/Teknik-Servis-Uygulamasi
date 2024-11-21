using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis.Formlar
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknıkServisEntities1 db = new    DbTeknıkServisEntities1    ();
        void metot1()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.BAKİYE,
                               u.TELEFON,
                               u.DEPARTMAN



                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {

            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4, ad5, soyad5;

            TxtDepartman.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD
                                                  }).ToList();
            //personel1

            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;

            labelControl5.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl4.Text = ad1 + " " + soyad1;

            ////personel2

            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl12.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;

            labelControl14.Text = ad2 + " " + soyad2;

            ////personel3

            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;

            labelControl20.Text = ad3 + " " + soyad3;

            //personel4

            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl24.Text = db.TBLPERSONEL.First(x => x.ID == 4).TBLDEPARTMAN.AD;

            labelControl26.Text = ad4 + " " + soyad4;

            ////personel5

            ad5 = db.TBLPERSONEL.First(x => x.ID == 5).AD;
            soyad5 = db.TBLPERSONEL.First(x => x.ID == 5).SOYAD;
            labelControl30.Text = db.TBLPERSONEL.First(x => x.ID == 5).TBLDEPARTMAN.AD;

            labelControl32.Text = ad5 + " " + soyad5;
            metot1();
        

    }

    private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLPERSONEL t = new TBLPERSONEL();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.DEPARTMAN = byte.Parse(TxtDepartman.EditValue.ToString());
                t.BAKİYE = TxtMaill.Text;
                t.TELEFON = TxtTelefon.Text;
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metot1();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(TxtId.Text);
                var deger = db.TBLPERSONEL.Find(id);
                deger.AD = TxtAd.Text;
                deger.SOYAD = TxtSoyad.Text;
                deger.BAKİYE = TxtMaill.Text;
                deger.TELEFON = TxtTelefon.Text;
                deger.DEPARTMAN = byte.Parse(TxtDepartman.EditValue.ToString());


                db.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();
            }
            catch (Exception)

            {
                MessageBox.Show("Hata!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TxtMaill.Text = gridView1.GetFocusedRowCellValue("BAKİYE").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();

            TxtDepartman.EditValue = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
           
        }
       
        Formlar.FrmBakiye fr1;
        private void Btn1_Click(object sender, EventArgs e)
        {
            fr1 = new Formlar.FrmBakiye();
           
            fr1.Show();
        }
    }
    
}
