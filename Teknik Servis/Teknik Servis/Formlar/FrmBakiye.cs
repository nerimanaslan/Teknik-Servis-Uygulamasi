using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Reflection.Emit;
using DevExpress.XtraGrid;
using DevExpress.Data;


namespace Teknik_Servis.Formlar
{
    public partial class FrmBakiye : Form
    {
        public FrmBakiye()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=aslan;Initial Catalog=DbTeknıkServis;Integrated Security=True;Encrypt=False");
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1();
       
        private void hesapla()
        {

            //try
            //{
            //    baglanti.Open();
            //    SqlCommand komut = new SqlCommand("select sum(BAKIYE) from TBLBAKIYE", baglanti);
            //    labelControl6.Text = komut.ExecuteScalar() + "TL";
            //    baglanti.Close();

            //}
            //catch (Exception)
            //{

            //}
        }
        void metot1()
        {
            var degerler = from u in db.TBLBAKIYE
                           select new
                           {
                               u.ID,
                               PERSONEL = u.TBLPERSONEL.AD,
                               u.BAKIYE,
                               u.TARIH,




                           };

            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmBakiye_Load(object sender, EventArgs e)
        {
            //    DataTable tbl = new DataTable();
            //    SqlDataAdapter adtr = new SqlDataAdapter("Select s.ID, S.PERSONEL,s.BAKIYE,s.TARIH FROM TBLBAKIYE s WHERE s.ID=ID =", baglanti);
            //    adtr.Fill(tbl);
            //    gridControl1.DataSource = tbl;

            //gridView1.Columns["BAKIYE"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "BAKIYE", "Sum={0:C2}");
            //gridView1.Columns["BAKIYE"].Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "BAKIYE", "Max={0}"));
            gridView1.OptionsView.ShowFooter = true;

           
            TxtPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
            
            metot1();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtBakiye.Text != "" && TxtPersonel.Text != ""  && textEdit3.Text != ""  )
            {
                TBLBAKIYE t = new TBLBAKIYE();
                t.PERSONEL = byte.Parse(TxtPersonel.EditValue.ToString());
                //t.PERSONEL =byte.Parse(TxtPersonel.EditValue.ToString());
                t.BAKIYE = TxtBakiye.Text;
                t.TARIH = textEdit3.Text;


                db.TBLBAKIYE.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Bilgisi Başarıyla Kaydededildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                metot1();

            }
            else
            { MessageBox.Show("Aynı Cari Veya Boşluk Olamaz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {

                int id = int.Parse(TxtId.Text);
                var deger = db.TBLBAKIYE.Find(id);
                deger.PERSONEL = byte.Parse(TxtPersonel.EditValue.ToString());
                deger.BAKIYE = TxtBakiye.Text;
                deger.TARIH = textEdit3.Text;



                db.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gridView1_FocusedRowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {


        }

        private void TxtMail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtPersonel.Text = gridView1.GetFocusedRowCellValue("PERSONEL").ToString();
                TxtBakiye.Text = gridView1.GetFocusedRowCellValue("BAKIYE").ToString();
                textEdit3.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();

            }
            catch
             
            {
                MessageBox.Show("Değer Seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }




        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            textEdit3.Text = DateTime.Now.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try { 
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLBAKIYE.Find(id);
            db.TBLBAKIYE.Remove(deger);
            db.SaveChanges();
            metot1();
            MessageBox.Show("Departman Bilgisi Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch
            {
                MessageBox.Show("Değer Seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtPersonel.Text = "";
            TxtBakiye.Text = "";
            textEdit3.Text = "";
           
        }

       

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            //gridView1.Columns["BAKIYE"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "BAKIYE", "Sum={0:C2}");
            //gridView1.Columns["BAKIYE"].Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "BAKIYE", "Max={0}"));

        }

        private void gridView1_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            //gridView1.Columns["BAKIYE"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "BAKIYE", "Sum={0:C2}");
            ////   //gridView1.Columns["BAKIYE"].Summary.Add(new GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "BAKIYE", "Max={0}"));
            //GridGroupSummaryItem item = new GridGroupSummaryItem();
            //item.ShowInGroupColumnFooter = gridView1.Columns["BAKIYE"];
            //item.FieldName = "BAKIYE";
            //item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //item.DisplayFormat = "BAKIYE = {0:n2}";
            //gridView1.GroupSummary.Add(item);
        }
    }
}
