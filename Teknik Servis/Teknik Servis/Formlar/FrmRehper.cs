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
    public partial class FrmRehper : Form
    {
        public FrmRehper()
        {
            InitializeComponent();
        }
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1();
        private void FrmRehper_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLCARİ
                                       select new
                                       {
                                           x.ADSOYAD,
                                           
                                           x.TELEFON,
                                           x.MAİL

                                       }).ToList();
        }
    }
}
