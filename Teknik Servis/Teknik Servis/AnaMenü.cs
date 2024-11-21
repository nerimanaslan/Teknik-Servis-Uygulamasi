using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teknik_Servis
{
    public partial class AnaMenü : Form
    {
        public AnaMenü()
        {
            InitializeComponent();
        }
        Formlar.FrmCariler fr;
        Formlar.FrmPersonel fr1;
        Formlar.FrmDepartman fr2;
        Formlar.FrmUrun fr3;
        Formlar.FrmKategori fr4;
        Formlar.SatisYap fr5;
        Formlar.FrmNotlar fr6;
        Formlar.FrmKurlar fr7;
        Formlar.FrmRehper fr8;
        Formlar.FrmAnasayfa fr9;
        //Formlar.FrmNotlar fr10;
        //Formlar.FrmArızaListesi fr11;
        //Formlar.FrmSatislar fr12;
        //Formlar.FrmArizaliÜrünDetayListesi fr13;
        //Formlar.FrmFaturaListesi fr14;
        //Formlar.FrmFaturaKalem fr15;
        //Formlar.FrmFaturaKalemleri fr16;
        //Iletisim.FrmRehper fr17;

        private void BtnCariler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr = new Formlar.FrmCariler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void AnaMenü_Load(object sender, EventArgs e)
        {
            fr9 = new Formlar.FrmAnasayfa();
            fr9.MdiParent = this;
            fr9.Show();

        }

        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr1 = new Formlar.FrmPersonel();
            fr1.MdiParent = this;
            fr1.Show();
        }

        private void BtnDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr2 = new Formlar.FrmDepartman();
            fr2.MdiParent = this;
            fr2.Show();
        }

        private void BtnÜrünler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr3 = new Formlar.FrmUrun();
            fr3.MdiParent = this;
            fr3.Show();
        }

        private void BtnKategoriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr4 = new Formlar.FrmKategori();
            fr4.MdiParent = this;
            fr4.Show();

        }

        private void BtnSatisYap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr5 = new Formlar.SatisYap();
            fr5.MdiParent = this;
            fr5.Show();

        }

        private void BtnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr6 = new Formlar.FrmNotlar();
            fr6.MdiParent = this;
            fr6.Show();
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr7 = new Formlar.FrmKurlar();
            fr7.MdiParent = this;
            fr7.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr8 = new Formlar.FrmRehper();
            fr8.MdiParent = this;
            fr8.Show();
        }

        private void BtnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fr9 = new Formlar.FrmAnasayfa();
            fr9.MdiParent = this;
            fr9.Show();
        }
    }
}
