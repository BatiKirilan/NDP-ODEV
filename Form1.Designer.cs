namespace Ndp_Projesi_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listAd = new System.Windows.Forms.ListBox();
            this.listSoyad = new System.Windows.Forms.ListBox();
            this.listTC = new System.Windows.Forms.ListBox();
            this.listTelefon = new System.Windows.Forms.ListBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.butSil = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAtes = new System.Windows.Forms.Label();
            this.lblOksuruk = new System.Windows.Forms.Label();
            this.lblNefesDarligi = new System.Windows.Forms.Label();
            this.checkAtes = new System.Windows.Forms.CheckBox();
            this.checkOksuruk = new System.Windows.Forms.CheckBox();
            this.checkNefesDarligi = new System.Windows.Forms.CheckBox();
            this.butTest = new System.Windows.Forms.Button();
            this.listSonuc = new System.Windows.Forms.ListBox();
            this.lblKarantina = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplamHasta = new System.Windows.Forms.Label();
            this.lblSayac = new System.Windows.Forms.Label();
            this.lblKarantna = new System.Windows.Forms.Label();
            this.lblSayacKarantina = new System.Windows.Forms.Label();
            this.lblTesteAlinan = new System.Windows.Forms.Label();
            this.lblSayacTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listAd
            // 
            this.listAd.FormattingEnabled = true;
            this.listAd.Location = new System.Drawing.Point(47, 46);
            this.listAd.Name = "listAd";
            this.listAd.Size = new System.Drawing.Size(110, 173);
            this.listAd.TabIndex = 0;
            // 
            // listSoyad
            // 
            this.listSoyad.FormattingEnabled = true;
            this.listSoyad.Location = new System.Drawing.Point(163, 46);
            this.listSoyad.Name = "listSoyad";
            this.listSoyad.Size = new System.Drawing.Size(104, 173);
            this.listSoyad.TabIndex = 1;
            // 
            // listTC
            // 
            this.listTC.FormattingEnabled = true;
            this.listTC.Location = new System.Drawing.Point(273, 46);
            this.listTC.Name = "listTC";
            this.listTC.Size = new System.Drawing.Size(103, 173);
            this.listTC.TabIndex = 2;
            // 
            // listTelefon
            // 
            this.listTelefon.FormattingEnabled = true;
            this.listTelefon.Location = new System.Drawing.Point(382, 46);
            this.listTelefon.Name = "listTelefon";
            this.listTelefon.Size = new System.Drawing.Size(107, 173);
            this.listTelefon.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(47, 243);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(103, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(163, 243);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(104, 20);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(273, 243);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(103, 20);
            this.txtTC.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(382, 243);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(107, 20);
            this.txtTelefon.TabIndex = 7;
            // 
            // butSil
            // 
            this.butSil.Location = new System.Drawing.Point(756, 255);
            this.butSil.Name = "butSil";
            this.butSil.Size = new System.Drawing.Size(106, 23);
            this.butSil.TabIndex = 9;
            this.butSil.Text = "Sil";
            this.butSil.UseVisualStyleBackColor = true;
            this.butSil.Click += new System.EventHandler(this.butSil_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(82, 24);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 19);
            this.lblAd.TabIndex = 10;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(184, 24);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(52, 19);
            this.lblSoyad.TabIndex = 11;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(274, 24);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(98, 19);
            this.lblTC.TabIndex = 12;
            this.lblTC.Text = "TC Kimlik No";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(369, 24);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(131, 19);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Telefon Numarası";
            // 
            // lblAtes
            // 
            this.lblAtes.AutoSize = true;
            this.lblAtes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAtes.Location = new System.Drawing.Point(537, 69);
            this.lblAtes.Name = "lblAtes";
            this.lblAtes.Size = new System.Drawing.Size(41, 19);
            this.lblAtes.TabIndex = 14;
            this.lblAtes.Text = "Ates";
            // 
            // lblOksuruk
            // 
            this.lblOksuruk.AutoSize = true;
            this.lblOksuruk.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOksuruk.Location = new System.Drawing.Point(537, 114);
            this.lblOksuruk.Name = "lblOksuruk";
            this.lblOksuruk.Size = new System.Drawing.Size(68, 19);
            this.lblOksuruk.TabIndex = 15;
            this.lblOksuruk.Text = "Oksuruk";
            // 
            // lblNefesDarligi
            // 
            this.lblNefesDarligi.AutoSize = true;
            this.lblNefesDarligi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNefesDarligi.Location = new System.Drawing.Point(537, 157);
            this.lblNefesDarligi.Name = "lblNefesDarligi";
            this.lblNefesDarligi.Size = new System.Drawing.Size(98, 19);
            this.lblNefesDarligi.TabIndex = 16;
            this.lblNefesDarligi.Text = "Nefes Darligi";
            // 
            // checkAtes
            // 
            this.checkAtes.AutoSize = true;
            this.checkAtes.Location = new System.Drawing.Point(681, 72);
            this.checkAtes.Name = "checkAtes";
            this.checkAtes.Size = new System.Drawing.Size(42, 17);
            this.checkAtes.TabIndex = 17;
            this.checkAtes.Text = "Var";
            this.checkAtes.UseVisualStyleBackColor = true;
            // 
            // checkOksuruk
            // 
            this.checkOksuruk.AutoSize = true;
            this.checkOksuruk.Location = new System.Drawing.Point(681, 117);
            this.checkOksuruk.Name = "checkOksuruk";
            this.checkOksuruk.Size = new System.Drawing.Size(42, 17);
            this.checkOksuruk.TabIndex = 17;
            this.checkOksuruk.Text = "Var";
            this.checkOksuruk.UseVisualStyleBackColor = true;
            // 
            // checkNefesDarligi
            // 
            this.checkNefesDarligi.AutoSize = true;
            this.checkNefesDarligi.Location = new System.Drawing.Point(681, 160);
            this.checkNefesDarligi.Name = "checkNefesDarligi";
            this.checkNefesDarligi.Size = new System.Drawing.Size(42, 17);
            this.checkNefesDarligi.TabIndex = 17;
            this.checkNefesDarligi.Text = "Var";
            this.checkNefesDarligi.UseVisualStyleBackColor = true;
            // 
            // butTest
            // 
            this.butTest.Location = new System.Drawing.Point(619, 255);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(104, 23);
            this.butTest.TabIndex = 18;
            this.butTest.Text = "Test";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.butTest_Click);
            // 
            // listSonuc
            // 
            this.listSonuc.FormattingEnabled = true;
            this.listSonuc.Location = new System.Drawing.Point(755, 46);
            this.listSonuc.Name = "listSonuc";
            this.listSonuc.Size = new System.Drawing.Size(107, 173);
            this.listSonuc.TabIndex = 19;
            // 
            // lblKarantina
            // 
            this.lblKarantina.AutoSize = true;
            this.lblKarantina.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarantina.Location = new System.Drawing.Point(756, 24);
            this.lblKarantina.Name = "lblKarantina";
            this.lblKarantina.Size = new System.Drawing.Size(106, 19);
            this.lblKarantina.TabIndex = 20;
            this.lblKarantina.Text = "Test Sonuçları";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 224);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lblToplamHasta
            // 
            this.lblToplamHasta.AutoSize = true;
            this.lblToplamHasta.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamHasta.Location = new System.Drawing.Point(624, 344);
            this.lblToplamHasta.Name = "lblToplamHasta";
            this.lblToplamHasta.Size = new System.Drawing.Size(115, 19);
            this.lblToplamHasta.TabIndex = 22;
            this.lblToplamHasta.Text = "Toplam Hasta =";
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(745, 344);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(17, 19);
            this.lblSayac.TabIndex = 23;
            this.lblSayac.Text = "0";
            // 
            // lblKarantna
            // 
            this.lblKarantna.AutoSize = true;
            this.lblKarantna.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarantna.Location = new System.Drawing.Point(624, 374);
            this.lblKarantna.Name = "lblKarantna";
            this.lblKarantna.Size = new System.Drawing.Size(237, 19);
            this.lblKarantna.TabIndex = 24;
            this.lblKarantna.Text = "Karantinaya Alinan Hasta Sayisi =";
            // 
            // lblSayacKarantina
            // 
            this.lblSayacKarantina.AutoSize = true;
            this.lblSayacKarantina.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayacKarantina.Location = new System.Drawing.Point(867, 374);
            this.lblSayacKarantina.Name = "lblSayacKarantina";
            this.lblSayacKarantina.Size = new System.Drawing.Size(17, 19);
            this.lblSayacKarantina.TabIndex = 25;
            this.lblSayacKarantina.Text = "0";
            // 
            // lblTesteAlinan
            // 
            this.lblTesteAlinan.AutoSize = true;
            this.lblTesteAlinan.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTesteAlinan.Location = new System.Drawing.Point(625, 407);
            this.lblTesteAlinan.Name = "lblTesteAlinan";
            this.lblTesteAlinan.Size = new System.Drawing.Size(190, 19);
            this.lblTesteAlinan.TabIndex = 26;
            this.lblTesteAlinan.Text = "Teste Alinan Hasta Sayisi =";
            // 
            // lblSayacTest
            // 
            this.lblSayacTest.AutoSize = true;
            this.lblSayacTest.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayacTest.Location = new System.Drawing.Point(821, 407);
            this.lblSayacTest.Name = "lblSayacTest";
            this.lblSayacTest.Size = new System.Drawing.Size(17, 19);
            this.lblSayacTest.TabIndex = 27;
            this.lblSayacTest.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(928, 523);
            this.Controls.Add(this.lblSayacTest);
            this.Controls.Add(this.lblTesteAlinan);
            this.Controls.Add(this.lblSayacKarantina);
            this.Controls.Add(this.lblKarantna);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.lblToplamHasta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblKarantina);
            this.Controls.Add(this.listSonuc);
            this.Controls.Add(this.butTest);
            this.Controls.Add(this.checkNefesDarligi);
            this.Controls.Add(this.checkOksuruk);
            this.Controls.Add(this.checkAtes);
            this.Controls.Add(this.lblNefesDarligi);
            this.Controls.Add(this.lblOksuruk);
            this.Controls.Add(this.lblAtes);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.butSil);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.listTelefon);
            this.Controls.Add(this.listTC);
            this.Controls.Add(this.listSoyad);
            this.Controls.Add(this.listAd);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAd;
        private System.Windows.Forms.ListBox listSoyad;
        private System.Windows.Forms.ListBox listTC;
        private System.Windows.Forms.ListBox listTelefon;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button butSil;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAtes;
        private System.Windows.Forms.Label lblOksuruk;
        private System.Windows.Forms.Label lblNefesDarligi;
        private System.Windows.Forms.CheckBox checkAtes;
        private System.Windows.Forms.CheckBox checkOksuruk;
        private System.Windows.Forms.CheckBox checkNefesDarligi;
        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.ListBox listSonuc;
        private System.Windows.Forms.Label lblKarantina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblToplamHasta;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Label lblKarantna;
        private System.Windows.Forms.Label lblSayacKarantina;
        private System.Windows.Forms.Label lblTesteAlinan;
        private System.Windows.Forms.Label lblSayacTest;
    }
}

