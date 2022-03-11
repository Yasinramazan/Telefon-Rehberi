using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace telefon
{
    public partial class AnaForm : Form
    {
        BLL.BLL olustur;
        public AnaForm()
        {
            InitializeComponent();
            olustur = new BLL.BLL();
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            
            int sonuc=olustur.yeniKayit(Guid.NewGuid(),adText.Text,soyadText.Text,tel1Text.Text,tel2Text.Text,
                adresText.Text,eText.Text,websiteText.Text,aciklamaText.Text);

            if(sonuc>0)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(sonuc==-100)
            {
                MessageBox.Show("Doldurulmayan yerler var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void doldur()
        {
            List<Kayit> kayitlar = olustur.kayitlariGetir();
            if(kayitlar!=null && kayitlar.Count!=0)
            {
                Liste.DataSource = kayitlar;

            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            ListBox ls = (ListBox)sender;
            Kayit kayit = ls.SelectedItem as Kayit;
            adText.Text = kayit.ad;
            soyadText.Text = kayit.soyad;
            tel1Text.Text = kayit.tel1;
            tel2Text.Text = kayit.tel2;
            adresText.Text = kayit.adres;
            websiteText.Text = kayit.webSite;
            eText.Text = kayit.emailAdres;
            aciklamaText.Text = kayit.aciklama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            Kayit guncelle = new Kayit();
            if(Liste.SelectedItem!=null&&!string.IsNullOrEmpty(adText.Text)&&!string.IsNullOrEmpty(soyadText.Text)&&
               !string.IsNullOrEmpty(tel1Text.Text))
            {
                Kayit ks = (Kayit)Liste.SelectedItem;
                guncelle.id = ks.id;
                guncelle.ad=adText.Text;
                guncelle.soyad = soyadText.Text;
                guncelle.tel1 = tel1Text.Text;
                guncelle.tel2 = tel2Text.Text;
                guncelle.adres = adresText.Text;
                guncelle.webSite = websiteText.Text;
                guncelle.emailAdres = eText.Text;
                guncelle.aciklama = aciklamaText.Text;
                sonuc =olustur.kayitGuncelle(guncelle);
            }
            else
            {
                sonuc = -100;
            }

            if (sonuc > 0)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde guncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(sonuc==-100)
            {
                MessageBox.Show("Doldurulmayan yerler var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
