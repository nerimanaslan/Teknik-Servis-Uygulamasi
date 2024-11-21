namespace Teknik_Servis
{
    partial class AnaMenü
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenü));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCariler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnÜrünler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSatisYap = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKategoriler = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFatura = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDepartman = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAjanda = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKurlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnAnasayfa,
            this.barButtonItem2,
            this.barButtonItem3,
            this.BtnCariler,
            this.BtnÜrünler,
            this.BtnSatisYap,
            this.BtnKategoriler,
            this.barButtonItem8,
            this.BtnPersoneller,
            this.BtnFatura,
            this.BtnDepartman,
            this.BtnAjanda,
            this.BtnKurlar,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 183);
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.ActAsDropDown = true;
            this.BtnAnasayfa.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.BtnAnasayfa.Caption = "Ana Sayfa";
            this.BtnAnasayfa.DropDownControl = this.popupMenu1;
            this.BtnAnasayfa.Id = 1;
            this.BtnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            this.BtnAnasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAnasayfa_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // BtnCariler
            // 
            this.BtnCariler.Caption = "Cariler";
            this.BtnCariler.Id = 4;
            this.BtnCariler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnCariler.ImageOptions.LargeImage")));
            this.BtnCariler.Name = "BtnCariler";
            this.BtnCariler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCariler_ItemClick);
            // 
            // BtnÜrünler
            // 
            this.BtnÜrünler.Caption = "Ürünler";
            this.BtnÜrünler.Id = 5;
            this.BtnÜrünler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnÜrünler.ImageOptions.LargeImage")));
            this.BtnÜrünler.Name = "BtnÜrünler";
            this.BtnÜrünler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnÜrünler_ItemClick);
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Caption = "Satış Yap";
            this.BtnSatisYap.Id = 6;
            this.BtnSatisYap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnSatisYap.ImageOptions.LargeImage")));
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnSatisYap_ItemClick);
            // 
            // BtnKategoriler
            // 
            this.BtnKategoriler.Caption = "Kategoriler";
            this.BtnKategoriler.Id = 7;
            this.BtnKategoriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKategoriler.ImageOptions.LargeImage")));
            this.BtnKategoriler.Name = "BtnKategoriler";
            this.BtnKategoriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKategoriler_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Ma";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Caption = "Personel";
            this.BtnPersoneller.Id = 9;
            this.BtnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersoneller.ImageOptions.LargeImage")));
            this.BtnPersoneller.Name = "BtnPersoneller";
            this.BtnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPersoneller_ItemClick);
            // 
            // BtnFatura
            // 
            this.BtnFatura.Caption = "Fatura İşlemleri";
            this.BtnFatura.Id = 10;
            this.BtnFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFatura.ImageOptions.LargeImage")));
            this.BtnFatura.Name = "BtnFatura";
            // 
            // BtnDepartman
            // 
            this.BtnDepartman.Caption = "Departman";
            this.BtnDepartman.Id = 11;
            this.BtnDepartman.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartman.ImageOptions.LargeImage")));
            this.BtnDepartman.Name = "BtnDepartman";
            this.BtnDepartman.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDepartman_ItemClick);
            // 
            // BtnAjanda
            // 
            this.BtnAjanda.Caption = "Ajandam";
            this.BtnAjanda.Id = 12;
            this.BtnAjanda.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAjanda.ImageOptions.LargeImage")));
            this.BtnAjanda.Name = "BtnAjanda";
            this.BtnAjanda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAjanda_ItemClick);
            // 
            // BtnKurlar
            // 
            this.BtnKurlar.Caption = "Kurlar";
            this.BtnKurlar.Id = 13;
            this.BtnKurlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKurlar.ImageOptions.LargeImage")));
            this.BtnKurlar.Name = "BtnKurlar";
            this.BtnKurlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKurlar_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Rehper";
            this.barButtonItem4.Id = 14;
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnasayfa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnCariler);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnPersoneller);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnDepartman);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnÜrünler);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnKategoriler);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnSatisYap);
            this.ribbonPageGroup4.ItemLinks.Add(this.BtnFatura);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnAjanda);
            this.ribbonPageGroup5.ItemLinks.Add(this.BtnKurlar);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1175);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "AnaMenü";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaMenü_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnAnasayfa;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem BtnCariler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BtnÜrünler;
        private DevExpress.XtraBars.BarButtonItem BtnSatisYap;
        private DevExpress.XtraBars.BarButtonItem BtnKategoriler;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BtnPersoneller;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem BtnFatura;
        private DevExpress.XtraBars.BarButtonItem BtnDepartman;
        private DevExpress.XtraBars.BarButtonItem BtnAjanda;
        private DevExpress.XtraBars.BarButtonItem BtnKurlar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}

