using System;
using Entities;
using System.Collections.Generic;

namespace BLL
{
    public class BLL
    {
        Core.Database DLL;

        public BLL()
        {
            DLL = new Core.Database();
        }

        public int kullaniciKontrol(string kullaniciAdi,string sifre)
        {
            int sonuc = 0;
            if(!string.IsNullOrEmpty(kullaniciAdi)&&!string.IsNullOrEmpty(sifre))
            {
                Kullanici kullaniciKontrol = new Kullanici();
                kullaniciKontrol.kullaniciAdi = kullaniciAdi;
                kullaniciKontrol.sifre = sifre;
                sonuc = DLL.kullaniciKontrol(kullaniciKontrol);
            }
            else
            {
                sonuc = -100;
            }
            return sonuc;
        }

        public int yeniKayit(Guid id, string ad, string soyad,string tel1,string tel2,
            string adres, string emailadres,string website,string aciklama)
        {
            int sonuc = 0;
            if(id!=Guid.Empty && !string.IsNullOrEmpty(ad)&&!string.IsNullOrEmpty(soyad)&&!string.IsNullOrEmpty(tel1)&&
                !string.IsNullOrEmpty(tel2))
            {
                Kayit yeni = new Kayit();
                yeni.id = id;
                yeni.ad = ad;
                yeni.soyad = soyad;
                yeni.tel1 = tel1;
                yeni.tel2 = tel2;
                yeni.adres = adres;
                yeni.emailAdres = emailadres;
                yeni.webSite = website;
                yeni.aciklama = aciklama;
                sonuc = DLL.yeniKayit(yeni);
            }
            else 
            {
                sonuc = -100;

            }
            return sonuc;
        }

        public List<Kayit> kayitlariGetir()
        {
            return DLL.kayitlariGetir();
        }

        public int kayitGuncelle(Kayit k)
        {
            int sonuc = DLL.kayitGuncelle(k);
            
            return sonuc;
        }

    }
}
