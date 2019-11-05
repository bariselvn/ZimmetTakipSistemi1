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
    public partial class LİST : Form
    {
        Islemler ıslem = new Islemler();
        public LİST()
        {
            InitializeComponent();
            
            dataGridView.DataSource = ıslem.kullanıcılarılistele();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void bgeri_Click(object sender, EventArgs e)
        {
            MANAGER mg = new MANAGER();
            mg.Show();
            this.Hide();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
