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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1();
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {

                                           x.AD,
                                           x.STOK

                                       }).Where(x => x.STOK < 50).ToList();


            gridControl3.DataSource = (from y in db.TBLCARİ
                                       select new
                                       {

                                           y.ADSOYAD,
                                         
                                           y.IL

                                       }).ToList();
            gridControl7.DataSource = db.urunkategori().ToList();
            DateTime bugün = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugün)
                         select new { x.BASLIK, x.ICERIK });
            gridControl5.DataSource = deger.ToList();


        }
    }
}
