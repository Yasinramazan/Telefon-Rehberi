using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telefon
{
    public partial class Form1 : Form
    {
        BLL.BLL baglanti;
        public Form1()
        {
            InitializeComponent();
            baglanti = new BLL.BLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc=baglanti.kullaniciKontrol(textBox1.Text,textBox2.Text);
            if(sonuc>0)
            {
                AnaForm form2 = new AnaForm();
                form2.Show();
            }
            else if(sonuc==-100)
            {
                MessageBox.Show("Form Elemanlarını eksiksiz olarak doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }
    
    }
}
