/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........: 
** ÖĞRENCİ ADI............: MERT BATIKAN KIRILAN
** ÖĞRENCİ NUMARASI.......: B181200019
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndp_Projesi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;             //Toplam hastayı saydırabilmek için sayaçları tanımladım.
        int sayacTest = 0;
        int sayacKarantina = 0;


        private void butSil_Click(object sender, EventArgs e)     // Ad listbox'ına tıklayınca satır halinde silebiliyoruz.
        {

            int ad = listAd.SelectedIndex;
            listSonuc.SelectedIndex = ad;
            if (ad > -1)
            {
                if (listSonuc.Text == "Test")                          // Aynı zamanda sayaçlar hastanın durumuna bağlı olarak azalıyor.
                {
                    sayac = sayac - 1;
                    lblSayac.Text = sayac.ToString();

                    sayacTest = sayacTest - 1;
                    lblSayacTest.Text = sayacTest.ToString();
                }
                else if (listSonuc.Text == "Karantina")
                {
                    sayac = sayac - 1;
                    lblSayac.Text = sayac.ToString();

                    sayacKarantina = sayacKarantina - 1;
                    lblSayacKarantina.Text = sayacKarantina.ToString();

                }
                listAd.Items.RemoveAt(ad);
                listSoyad.Items.RemoveAt(ad);
                listTC.Items.RemoveAt(ad);
                listTelefon.Items.RemoveAt(ad);
                listSonuc.Items.RemoveAt(ad);

            }


        }

        private void butTest_Click(object sender, EventArgs e)   
        {
            if (checkAtes.Checked == true & checkOksuruk.Checked == false & checkNefesDarligi.Checked == false)  // 8 ihtimal var, karantina durumu dışındaki kodlar bu şekilde olacak.
            {
                MessageBox.Show("Hasta teste alinmali");                   // Belirtiler doğrultusunda hastanın durum mesajı geliyor.

                if (String.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen TC noyu girip tekrar deneyiniz.");             // Kişinin TC'si önemli olduğundan eğer boşsa TC girmek zorunlu mesajı veriliyor.
                }
                else
                {
                    listAd.Items.Add(txtAd.Text);                          // TextBox'tan girilen veri, listBox'a kaydediliyor.
                    listSoyad.Items.Add(txtSoyad.Text);
                    listTC.Items.Add(txtTC.Text);
                    listTelefon.Items.Add(txtTelefon.Text);
                    listSonuc.Items.Add("Test");

                    txtAd.Text = "";                                 // Kayıt işlemi tamamlandığında textBox'ı da tekrar girilebilmesi için temizliyor.
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtTelefon.Text = "";
                }
                sayac = sayac + 1;                               // Her bir hasta kaydolduğunda sayaç bir artıyor.
                lblSayac.Text = sayac.ToString();

                sayacTest = sayacTest + 1;                       // Belirtiler doğrultusunda teste girecek hasta sayısı bir artıyor.
                lblSayacTest.Text = sayacTest.ToString();

            }
            else if (checkAtes.Checked == false & checkOksuruk.Checked == true & checkNefesDarligi.Checked == false)

            {  // Hasta teste alınmalı mesajı gelen durumlara tekrardan açıklama satırını ilk durumda yazdığım yinelemedim ancak aşağıdaki farklı uyarılar veren durumlar için yazdım.

                MessageBox.Show("Hasta teste alinmali");

                if (String.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen TC noyu girip tekrar deneyiniz.");
                }
                else
                {
                    listAd.Items.Add(txtAd.Text);
                    listSoyad.Items.Add(txtSoyad.Text);
                    listTC.Items.Add(txtTC.Text);
                    listTelefon.Items.Add(txtTelefon.Text);
                    listSonuc.Items.Add("Test");

                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtTelefon.Text = "";
                }
                sayac = sayac + 1;
                lblSayac.Text = sayac.ToString();

                sayacTest = sayacTest + 1;
                lblSayacTest.Text = sayacTest.ToString();

            }
            else if (checkAtes.Checked == false & checkOksuruk.Checked == false & checkNefesDarligi.Checked == true)
            { 
                MessageBox.Show("Hasta teste alinmali");

                if (String.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen TC noyu girip tekrar deneyiniz.");
                }
                else
                {
                    listAd.Items.Add(txtAd.Text);
                    listSoyad.Items.Add(txtSoyad.Text);
                    listTC.Items.Add(txtTC.Text);
                    listTelefon.Items.Add(txtTelefon.Text);
                    listSonuc.Items.Add("Test");

                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtTelefon.Text = "";
                }
                sayac = sayac + 1;
                lblSayac.Text = sayac.ToString();

                sayacTest = sayacTest + 1;
                lblSayacTest.Text = sayacTest.ToString();

            }
            else if (checkAtes.Checked == true & checkOksuruk.Checked == true & checkNefesDarligi.Checked == true)  
            {
                MessageBox.Show( "HASTA DERHAL 14 GUN KARANTINA ALTINA ALINMALI!");       //Belirtilerin hepsi var hastanın durum mesajı geliyor.

                if (String.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen TC noyu girip tekrar deneyiniz.");
                }
                else
                {
                    listAd.Items.Add(txtAd.Text);                              // textBox'tan alınan veri listBox'a kaydediliyor.
                    listSoyad.Items.Add(txtSoyad.Text);
                    listTC.Items.Add(txtTC.Text);
                    listTelefon.Items.Add(txtTelefon.Text);
                    listSonuc.Items.Add("Karantina");

                    txtAd.Text = "";                                           // işlem tamamlandıktan sonra tekrar kayıt alınabilmesi için textBox'ın içi temizleniyor.
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtTelefon.Text = "";
                }
                sayac = sayac + 1;                                              // Her bir hasta kaydolduğunda sayaç 1 artıyor.
                lblSayac.Text = sayac.ToString();

                sayacKarantina = sayacKarantina + 1;                            // Belirtiler doğrultusunda karantinaya alınması gereken hasta sayısı 1 artıyor.
                lblSayacKarantina.Text = sayacKarantina.ToString();


            }
            else if (checkAtes.Checked == true & checkOksuruk.Checked == true & checkNefesDarligi.Checked == false)
            { 
                MessageBox.Show("Hasta teste alinmali");

                if (String.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen TC noyu girip tekrar deneyiniz.");
                }
                else
                {
                    listAd.Items.Add(txtAd.Text);
                    listSoyad.Items.Add(txtSoyad.Text);
                    listTC.Items.Add(txtTC.Text);
                    listTelefon.Items.Add(txtTelefon.Text);
                    listSonuc.Items.Add("Test");

                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtTelefon.Text = "";
                }
                sayac = sayac + 1;
                lblSayac.Text = sayac.ToString();

                sayacTest = sayacTest + 1;
                lblSayacTest.Text = sayacTest.ToString();

            }
            else if (checkAtes.Checked == true & checkOksuruk.Checked == false & checkNefesDarligi.Checked == true)
            { 
                MessageBox.Show("Hasta teste alinmali");

                if (String.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen TC noyu girip tekrar deneyiniz.");
                }
                else
                {
                    listAd.Items.Add(txtAd.Text);
                    listSoyad.Items.Add(txtSoyad.Text);
                    listTC.Items.Add(txtTC.Text);
                    listTelefon.Items.Add(txtTelefon.Text);
                    listSonuc.Items.Add("Test");

                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtTelefon.Text = "";
                }
                sayac = sayac + 1;
                lblSayac.Text = sayac.ToString();

                sayacTest = sayacTest + 1;
                lblSayacTest.Text = sayacTest.ToString();

            }
            else if (checkAtes.Checked == false & checkOksuruk.Checked == true & checkNefesDarligi.Checked == true)
            {
                MessageBox.Show("Hasta teste alinmali");

                if (String.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen TC noyu girip tekrar deneyiniz.");
                }
                else
                {
                    listAd.Items.Add(txtAd.Text);
                    listSoyad.Items.Add(txtSoyad.Text);
                    listTC.Items.Add(txtTC.Text);
                    listTelefon.Items.Add(txtTelefon.Text);
                    listSonuc.Items.Add("Test");

                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTC.Text = "";
                    txtTelefon.Text = "";
                }
                sayac = sayac + 1;
                lblSayac.Text = sayac.ToString();

                sayacTest = sayacTest + 1;
                lblSayacTest.Text = sayacTest.ToString();
            }
            else
            {
                // Belirtilerin hiçbiri olmadığından kayıt açmaya gerek yok mesajı geliyor.
                MessageBox.Show("Hastada herhangi bir problem gorulmemistir. Evden takip edilecektir. Kayda gerek yoktur.");  

                txtAd.Text = "";                                  // Daha sonrasında tekrar hasta kaydı alabilmek için textBox'ı temizliyor.
                txtSoyad.Text = "";
                txtTC.Text = "";
                txtTelefon.Text = "";

            }
        }

    }
}