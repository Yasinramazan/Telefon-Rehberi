
namespace telefon
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Liste = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kayit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.eText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.websiteText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adresText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tel2Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel1Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aciklamaText = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Liste);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber";
            // 
            // Liste
            // 
            this.Liste.FormattingEnabled = true;
            this.Liste.ItemHeight = 15;
            this.Liste.Location = new System.Drawing.Point(8, 27);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(367, 574);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.kayit);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(418, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 612);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni kayıt";
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(25, 305);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(704, 28);
            this.kayit.TabIndex = 1;
            this.kayit.Text = "Kayıt Ekle";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 230);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.eText);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.websiteText);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.adresText);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.adText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tel2Text);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tel1Text);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.soyadText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // eText
            // 
            this.eText.Location = new System.Drawing.Point(443, 143);
            this.eText.Name = "eText";
            this.eText.Size = new System.Drawing.Size(199, 23);
            this.eText.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(336, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "E mail Adres:";
            // 
            // websiteText
            // 
            this.websiteText.Location = new System.Drawing.Point(443, 101);
            this.websiteText.Name = "websiteText";
            this.websiteText.Size = new System.Drawing.Size(199, 23);
            this.websiteText.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(336, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Website:";
            // 
            // adresText
            // 
            this.adresText.Location = new System.Drawing.Point(443, 14);
            this.adresText.Multiline = true;
            this.adresText.Name = "adresText";
            this.adresText.Size = new System.Drawing.Size(199, 66);
            this.adresText.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(336, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adres:";
            // 
            // adText
            // 
            this.adText.Location = new System.Drawing.Point(83, 14);
            this.adText.Name = "adText";
            this.adText.Size = new System.Drawing.Size(199, 23);
            this.adText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // tel2Text
            // 
            this.tel2Text.Location = new System.Drawing.Point(83, 143);
            this.tel2Text.Name = "tel2Text";
            this.tel2Text.Size = new System.Drawing.Size(199, 23);
            this.tel2Text.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tel2:";
            // 
            // tel1Text
            // 
            this.tel1Text.Location = new System.Drawing.Point(83, 101);
            this.tel1Text.Name = "tel1Text";
            this.tel1Text.Size = new System.Drawing.Size(199, 23);
            this.tel1Text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel1:";
            // 
            // soyadText
            // 
            this.soyadText.Location = new System.Drawing.Point(83, 57);
            this.soyadText.Name = "soyadText";
            this.soyadText.Size = new System.Drawing.Size(199, 23);
            this.soyadText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aciklamaText);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aciklamaText
            // 
            this.aciklamaText.Location = new System.Drawing.Point(14, 12);
            this.aciklamaText.Name = "aciklamaText";
            this.aciklamaText.Size = new System.Drawing.Size(680, 174);
            this.aciklamaText.TabIndex = 0;
            this.aciklamaText.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 295);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(240, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(703, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox adText;
        private System.Windows.Forms.TextBox tel2Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel1Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adresText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox websiteText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.RichTextBox aciklamaText;
        private System.Windows.Forms.ListBox Liste;
        private System.Windows.Forms.Button button1;
    }
}