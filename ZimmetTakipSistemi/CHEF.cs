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
    public partial class CHEF : Form
    {
        Islemler islem = new Islemler();
        public CHEF()
        {
            InitializeComponent();
            
        }
        zimmetsistemEntities db = new zimmetsistemEntities();
        

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Islemler islem = new Islemler();
            string urunAd;
            int urunMik = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex==0)
            {
                urunAd = "MOUSE";
                islem.SatınAl(urunAd, urunMik);
            }
            else if (comboBox1.SelectedIndex==1)
            {
                urunAd = "KEYBOARD";
                islem.SatınAl(urunAd, urunMik);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                urunAd = "MONITOR";
                islem.SatınAl(urunAd, urunMik);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                urunAd = "MOUSE PAD";
                islem.SatınAl(urunAd, urunMik);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                urunAd = "USB";
                islem.SatınAl(urunAd,urunMik);
            }
            else
            {
                MessageBox.Show("Urun Seciniz!!!!");
            }
            MessageBox.Show("Satın Alma Başarılı");
            var liste = db.Market;
     
        }
        Ürün_Zimmetle uz = new Ürün_Zimmetle();
       

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            uz.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = false;
            bunifuGradientPanel3.Visible = true;
            dataGridView5.Visible = true;
            dataGridView5.ClearSelection();
            dataGridView5.DataSource = islem.kullanıcılarılistele();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = false;
            bunifuGradientPanel3.Visible = true;
            dataGridView5.Visible = true;
            dataGridView5.ClearSelection();
            dataGridView5.DataSource = islem.atıkurunlistele();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = false;
            bunifuGradientPanel3.Visible = true;
            dataGridView5.Visible = true;
            dataGridView5.ClearSelection();
            dataGridView5.DataSource = islem.ZimmetlenenUrunleriListele();
           
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Visible = false;
            bunifuGradientPanel2.Visible = true;
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
