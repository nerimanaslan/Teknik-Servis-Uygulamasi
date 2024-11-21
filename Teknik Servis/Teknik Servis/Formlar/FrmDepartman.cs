using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis.Formlar
{
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1();
        void metot1()
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA,


                           };

            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            labelControl11.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl13.Text = db.TBLPERSONEL.Count().ToString();
            metot1();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();

            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" && TxtAd.Text.Length >= 1 && TxtAcıklama.Text.Length <= 250 && TxtAcıklama.Text != "" && TxtAcıklama.Text.Length >= 1)
            {
                t.AD = TxtAd.Text;
                t.ACIKLAMA = TxtAd.Text;

                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Kayıt Yapılmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Bilgisi Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" && TxtAd.Text.Length >= 1 && TxtAcıklama.Text.Length <= 250 && TxtAcıklama.Text != "" && TxtAcıklama.Text.Length >= 1)

            {
                int id = int.Parse(TxtId.Text);
                var deger = db.TBLDEPARTMAN.Find(id);
                deger.AD = TxtAd.Text;
                deger.ACIKLAMA = TxtAcıklama.Text;


                db.SaveChanges();
                MessageBox.Show("Departman Bilgisi Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kayıt Yapılmadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();

            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtAcıklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }
    }
}
