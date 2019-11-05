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
    public partial class WASTE : Form
    {
        Islemler ıslem = new Islemler();
   
        public WASTE()
        {
            
            InitializeComponent();

            bunifuCustomDataGrid1.DataSource = ıslem.UzerimezimmetliUrünleriListele();
             
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int urunId;
            urunId = Convert.ToInt32(uutxt.Text);

            ıslem.atıgaürünYolla(urunId);
            MessageBox.Show("Atığa Eşya Yollama Başarılı");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            STAFF st = new STAFF();
            st.Show();
            this.Hide();
        }
    }
}
