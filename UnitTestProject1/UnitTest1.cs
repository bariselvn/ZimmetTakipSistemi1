using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZimmetTakipSistemi;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Islemler ıs = new Islemler();
        Kullanıcı kk = new Kullanıcı();
        //connection string hatası alındığı için test başarısız gösteriyor bu sorunu da çözemedik
        [TestMethod]
        public void KullanıcıEkleTest()
        {
            kk.Kullanıcıadı = "onat";
            kk.Kullanıcısifre = 5;
            kk.Kullanıcısoyad = "baş";
            kk.Role_ıd = 3;
            kk.Departman_ıd = 1;
            ıs.kullaniciekle(kk);

        }
        [TestMethod]
        public void KullanıcıListeleTest()
        {

            ıs.kullanıcılarılistele();
        }
        [TestMethod]
        public void EsyaListeleTest()
        {

            ıs.UrünleriListele();
        }
        [TestMethod]
        public void atıklarıListele()
        {
            ıs.atıkurunlistele();
          
        }
        [TestMethod]
        public void zimmetlenenUrunleriListele()
        {
            ıs.ZimmetlenenUrunleriListele();
        }
    }
}
