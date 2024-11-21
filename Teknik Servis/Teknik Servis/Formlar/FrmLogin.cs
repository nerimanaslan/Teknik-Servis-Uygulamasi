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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbTeknıkServisEntities1 db = new DbTeknıkServisEntities1();
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN where x.KULLANICIAD == textBox1.Text & x.SIFRE == textBox2.Text select x;
            if (sorgu.Any())
            {
                AnaMenü frm = new AnaMenü();
                frm.ShowDialog();
                this.Hide();

            }
            else
            { MessageBox.Show("Hatalı Giriş Yaptınız!"); }
        }
    } }