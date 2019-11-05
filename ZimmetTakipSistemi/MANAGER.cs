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
    public partial class MANAGER : Form
    {
        Islemler islem = new Islemler();
        Kullanıcı girisyapan = new Kullanıcı();
        public MANAGER()
        {
            InitializeComponent();
      
        }

        Ürün_Zimmetle uz = new Ürün_Zimmetle();
      
    
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ADD_USER ad = new ADD_USER();
            ad.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = islem.kullanıcılarılistele();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = islem.UrünleriListele();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            uz.Show();
            this.Hide();
            
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = islem.ZimmetlenenUrunleriListele();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = islem.atıkurunlistele();

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
