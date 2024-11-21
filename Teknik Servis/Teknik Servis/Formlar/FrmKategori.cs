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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1    ();
        DataSet daset = new DataSet();
        public void metot1()
        {

            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD,
                           };
            gridControl1.DataSource = degerler.ToList();

        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            metot1();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtad.Text.Length <= 50)
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = txtad.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                metot1();

                MessageBox.Show("Kategori Başarıyla Kaydededildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kaydetmek İstediğiniz Kategori Adı Aynı, Boş ve 50 Karakterden Uzun Olamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            metot1();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtad.Text.Length <= 50)
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBLKATEGORİ.Find(id);
                deger.AD = txtad.Text;
                db.SaveChanges();

                metot1();
                MessageBox.Show("Kategori Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            else
            {
                MessageBox.Show("Güncellemek İstediğiniz Kategori Adı Aynı, Boş ve 50 Karakterden Uzun Olamaz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "")
            {
                int id = int.Parse(txtıd.Text);
                var deger = db.TBLKATEGORİ.Find(id);
                db.TBLKATEGORİ.Remove(deger);
                db.SaveChanges();

                metot1();
                MessageBox.Show("Kategori Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Silmek İçin Herhangi Bir Katgegori Seçmediniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtıd.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }
    }
}
