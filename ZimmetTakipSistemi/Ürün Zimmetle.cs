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
    public partial class Ürün_Zimmetle : Form
    {
        Islemler ıs = new Islemler();
        public Ürün_Zimmetle()
        {
            InitializeComponent();
            dataGridView1.DataSource = ıs.kullanıcılarılistele();
            dataGridView2.DataSource = ıs.UrünleriListele();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

   

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (globaluser.Kulıd.Role_ıd == 1)
            {
                MANAGER mnn = new MANAGER();
                mnn.Show();
                this.Hide();
            }
            if (globaluser.Kulıd.Role_ıd == 2)
            {
                CHEF ch = new CHEF();
                ch.Show();
                this.Hide();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Islemler islem2 = new Islemler();

            int kullanıcıId = Convert.ToInt32(textBox1.Text);
            int urunıd = Convert.ToInt32(textBox2.Text);
            islem2.urunZimmetle(kullanıcıId, urunıd);
            MessageBox.Show("Ürün Zimmetleme Başarılı !");
        }
    }
}
