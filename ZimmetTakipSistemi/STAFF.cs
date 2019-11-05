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
    public partial class STAFF : Form
    {
        Islemler ıslem3 = new Islemler();
        public STAFF()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = ıslem3.kullanıcılarılistele();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = ıslem3.UzerimezimmetliUrünleriListele();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            WASTE ws = new WASTE();
            ws.Show();
            this.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }
    }
}
