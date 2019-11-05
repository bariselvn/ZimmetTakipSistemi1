using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZimmetTakipSistemi
{
    public class Islemler
    {


        zimmetsistemEntities db = new zimmetsistemEntities();
        Kullanıcı kul = new Kullanıcı();

       
        public Islemler()
        {
           
        }
        public void kullaniciekle(Kullanıcı personel)
        {

            db.Kullanıcı.Add(personel);
            db.SaveChanges();

        }
        public List<Kullanıcı> kullanıcılarılistele()
        {
            var kullanıcılar1 = db.Kullanıcı;
            List<Kullanıcı> kullanıcılar = new List<Kullanıcı>();
            foreach (var kullanıcı in kullanıcılar1)
            {
                kullanıcılar.Add(kullanıcı);
            }

            return kullanıcılar;
        }
        public List<Atık> atıkurunlistele()
        {
            var atıklar = db.Atık;
            List<Atık> atıklar1 = new List<Atık>();
            foreach (var atık in atıklar)
            {
                atıklar1.Add(atık);

            }
            return atıklar1;
        }

       
        public List<Zimmet> UzerimezimmetliUrünleriListele()
        {
       
            var zimmetler = db.Zimmet;
            List<Zimmet> zimmetler1 = new List<Zimmet>();
            foreach (var zimmet in zimmetler)
            {
                if (zimmet.Kullanıcı_ıd == globaluser.Kulıd.Kullanıcı_ıd) 
                {
                    zimmetler1.Add(zimmet);

                }
            }
            

            return zimmetler1;


        }
        public List<Urunler> UrünleriListele()
        {
            var urunler = db.Urunler;
            List<Urunler> urunler1 = new List<Urunler>();
            foreach (var urun in urunler)
            {
      
                  urunler1.Add(urun);
            }

            return urunler1;


        }

        public void atıgaürünYolla(int urunId)
        {
            Atık att = new Atık();
            att.kullanıcı_ıd = globaluser.Kulıd.Kullanıcı_ıd;
            att.urun_ıd = urunId;
            var urunn = db.Urunler.Find(urunId);
            urunn.Miktar -= 1;
            db.Atık.Add(att);
            db.SaveChanges();
           

        }
        
        public void SatınAl(string urunAd,int miktar)
        {
            CHEF ch = new CHEF();
            Urunler eklenecek = new Urunler();
            eklenecek.Urunadı = urunAd;

            eklenecek.Miktar = miktar;

            db.Urunler.Add(eklenecek);
            db.SaveChanges();
            
        }
        public void urunZimmetle(int kullanıcıId,int urunId)
        {
            Zimmet zim = new Zimmet();
            zim.Kullanıcı_ıd = kullanıcıId;
            zim.Urun_ıd = urunId;
            zim.Tarih = DateTime.Now;
            db.Zimmet.Add(zim);
            db.SaveChanges();

        }
        public List<Zimmet> ZimmetlenenUrunleriListele()
        {
            var zimmet = db.Zimmet;
            List<Zimmet> zmm = new List<Zimmet>();
            foreach (var zimmet3 in zimmet)
            {

                zmm.Add(zimmet3);
            }

            return zmm;

         
        }
    }
}
