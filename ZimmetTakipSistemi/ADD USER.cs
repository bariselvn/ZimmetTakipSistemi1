using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZimmetTakipSistemi
{
    public partial class ADD_USER : Form
    {
        public ADD_USER()
        {
            InitializeComponent();
        }
        
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Kullanıcı eklenecek = new Kullanıcı();
            eklenecek.Kullanıcıadı = bunifuCustomTextbox1.Text;
            eklenecek.Kullanıcısoyad = bunifuCustomText2.Text;
            eklenecek.Kullanıcısifre = Convert.ToInt32(bunifuCustomTextbox3.Text);
            eklenecek.Departman_ıd = Convert.ToInt32(bunifuCustomTextbox4.Text);
            eklenecek.Role_ıd = Convert.ToInt32(bunifuCustomTextbox5.Text);
            Islemler a = new Islemler();
            a.kullaniciekle(eklenecek);
            MessageBox.Show("Kullanıcı Ekleme Başarılı");

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            MANAGER mg = new MANAGER();
            mg.Show();
            this.Hide();
        }
    }
}
