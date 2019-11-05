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
    public partial class Form1 : Form
    {
        Kullanıcı girisyapanKullanıcı = new Kullanıcı();
        zimmetsistemEntities db = new zimmetsistemEntities();
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


        }
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string Kullanıcıadı = btxtkad.text;
            int kullanıcısifre = Convert.ToInt32(btxtsifre.text);
            var kullanıcılar = db.Kullanıcı;
            MANAGER man = new MANAGER();
            globaluser.Kulıd = girisyapanKullanıcı;
            foreach (var kullanıcı in kullanıcılar)
            {
                if (Kullanıcıadı == kullanıcı.Kullanıcıadı && kullanıcısifre == kullanıcı.Kullanıcısifre)
                {
                    girisyapanKullanıcı.Kullanıcıadı = kullanıcı.Kullanıcıadı;
                    girisyapanKullanıcı.Kullanıcı_ıd = kullanıcı.Kullanıcı_ıd;
                    girisyapanKullanıcı.Role_ıd = kullanıcı.Role_ıd;
                    girisyapanKullanıcı.Kullanıcısifre = kullanıcı.Kullanıcısifre;
                    girisyapanKullanıcı.Kullanıcı_ıd = kullanıcı.Kullanıcı_ıd;

                    if (kullanıcı.Role_ıd == 1)
                    {
                        MessageBox.Show("Giriş Başarılı Hoşgeldiniz  " + kullanıcı.Kullanıcıadı);
                        man.Show();
                        this.Hide();
                    }
                    else if (kullanıcı.Role_ıd == 2)
                    {
                        CHEF CF = new CHEF();
                        MessageBox.Show("Giriş Başarılı Hoşgeldiniz  " + kullanıcı.Kullanıcıadı);
                        CF.Show();
                        this.Hide();
                    }
                    else if (kullanıcı.Role_ıd == 3)
                    {
                        STAFF st = new STAFF();
                        MessageBox.Show("Giriş Başarılı Hoşgeldiniz   " + kullanıcı.Kullanıcıadı);
                        st.Show();
                        this.Hide();

                    }
                }

            }

        }

       
    }
}
