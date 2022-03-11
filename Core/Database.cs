using System;
using System.IO;
using Entities;
using System.Collections.Generic;

namespace Core
{
    public class Database
    {
        public List<Kayit> kayitlarim;
        public Database()
        {
            kayitlarim = new List<Kayit>();
            veritabaniKontrol();
        }

        private void veritabaniKontrol()
        {
            bool kontrol = Directory.Exists(@"C:\\Database");
            bool kontrol2 = File.Exists(@"C:\\Database\\rehber.json");

            

            if (kontrol == false)
                Directory.CreateDirectory(@"C:\\Database");
            if (kontrol2 == false)
                File.Create(@"C:\\Database\\rehber.json");

            Kullanici deneme = new Kullanici();
            deneme.id = Guid.NewGuid();
            deneme.kullaniciAdi = "Yasin";
            deneme.sifre = "123";

            string kullaniciJson= Newtonsoft.Json.JsonConvert.SerializeObject(deneme);
            File.WriteAllText(@"C:\\Database\\veri.json", kullaniciJson);


            List<Kullanici> yeni = new List<Kullanici>();
            string denememe = File.ReadAllText(@"C:\\Database\\veri.json");
            Kullanici kullanicilar = Newtonsoft.Json.JsonConvert.DeserializeObject<Kullanici>(denememe);
            yeni.Add(kullanicilar);
            Kullanici deneme2 = new Kullanici();
            deneme2.id = Guid.NewGuid();
            deneme2.kullaniciAdi = "ben";
            deneme2.sifre = "456";
            yeni.Add(deneme2);
            string yaz = Newtonsoft.Json.JsonConvert.SerializeObject(yeni);
            File.WriteAllText(@"C:\\Database\\veri.json", yaz);
        }
        
        public int yeniKayit(Kayit k)
        {
            int sonuc = 0;
            
            try
            {
                kayitlarim=kayitlariGetir();
                kayitlarim.Add(k);
                jsonGuncelle();
                sonuc = 1;
            }
            catch (Exception)
            {

                
            }
            return sonuc;
        }

        public List<Kayit> kayitlariGetir()
        {
            if(File.Exists(@"C:\\Database\\rehber.json"))
            {
                string jsonText = File.ReadAllText(@"C:\\Database\\rehber.json");
                if(Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kayit>>(jsonText)!=null)
                    kayitlarim = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kayit>>(jsonText);
            }
            
            return kayitlarim;
          
        }

        private void jsonGuncelle()
        {
            if(kayitlarim!=null && kayitlarim.Count>0)
            {
                string jsonDB= Newtonsoft.Json.JsonConvert.SerializeObject(kayitlarim);
                File.WriteAllText(@"C:\\Database\\rehber.json", jsonDB);
            }
        }

        public int kullaniciKontrol(Kullanici kullanici)
        {
            int sonuc = 0;
            if(File.Exists(@"C:\\Database\\veri.json"))
            {
                string jsonKullanici = File.ReadAllText(@"C:\\Database\\veri.json");
                List<Kullanici> kullanicilar= Newtonsoft.Json.JsonConvert.DeserializeObject<List<Kullanici>>(jsonKullanici);
                //List<Kullanici> kullaniciListesi = new List<Kullanici>();
                //kullaniciListesi.Add(kullanicilar);
                sonuc=kullanicilar.FindAll(i => i.kullaniciAdi == kullanici.kullaniciAdi && i.sifre == kullanici.sifre).Count;
                
            }
            return sonuc;
        }

        public int kayitGuncelle(Kayit k)
        {
            int sonuc = 0;

            try
            {
                kayitlariGetir();
                int index = kayitlarim.FindIndex(i => i.id == k.id);
                
                if(index>-1)
                {
                    kayitlarim[index].id = k.id;
                    kayitlarim[index].ad = k.ad;
                    kayitlarim[index].soyad = k.soyad;
                    kayitlarim[index].tel1 = k.tel1;
                    kayitlarim[index].tel2 = k.tel2;
                    kayitlarim[index].adres = k.adres;
                    kayitlarim[index].webSite = k.webSite;
                    kayitlarim[index].emailAdres = k.emailAdres;
                    kayitlarim[index].aciklama = k.aciklama;
                    sonuc = 1;
                }
                jsonGuncelle();
            }
            catch (Exception)
            {

                throw;
            }
            return sonuc;
        }

    }
}
