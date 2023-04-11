using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogruCevap = 0, yanlisCevap = 0;

       

        private void linkCevapla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkCevapla.Text = "Sonraki Soru";
            soruNo++;
            this.Text = "PASSAPAROLA SORU SIRASI : " + soruNo.ToString(); // this.Text formun sol üst yazısını değiştirir.

            if (soruNo==1)
            {
                richTextBox1.Text = "Türkiye'nin başkenti neresidir?";
                buttonA.BackColor = Color.Yellow;
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Sınıfta bir eşya, her ülkede var, Türkiye'nin rengi kırmızı ve beyaz?";
                buttonB.BackColor = Color.Yellow;
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Haftasonunda bir gün?";
                buttonC.BackColor = Color.Yellow;
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Rengi mavi, büyük su topluluğu";
                buttonD.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Bir sıfat , yeni değil , yeninin zıttı";
                buttonE.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Kuzey Afrikada bir ülke";
                buttonF.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Çocuk değil , Yaşlı değil. Çocuk ve yaşlının ortası";
                buttonG.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Doktora giden insanlar";
                buttonH.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Türkiyenin komşusu bir ülke";
                buttonI.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Süt veren, eti yenilen bir çiftlik hayvanı";
                buttonİ.BackColor = Color.Yellow;
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Uzak doğu Asyada bir ülke , Korenin komşusu";
                buttonJ.BackColor = Color.Yellow;
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "İnsanların kitap okuduğu , kitap aldığı yer. Orada insanlar genellikle sessiz olurlar";
                buttonK.BackColor = Color.Yellow;
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Sarı renkli , ekşi bir meyve";
                buttonL.BackColor = Color.Yellow;
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Muzu çok seven bir hayvan";
                buttonM.BackColor = Color.Yellow;
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "En çok kullanılan soru kelimesi";
                buttonN.BackColor = Color.Yellow;
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Öğrencilerin ve öğretmenlerin haftada beş gün gittiği yer";
                buttonO.BackColor = Color.Yellow;
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "İnsanları genelde sevdiği , kahverengi bir sebze. Kızartması yapılıyor";
                buttonP.BackColor = Color.Yellow;
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "İnsana benziyor , makine";
                buttonR.BackColor = Color.Yellow;
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "Haftanın bir günü";
                buttonS.BackColor = Color.Yellow;
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Yumurta yapan, eti güzel olan bir hayvan";
                buttonT.BackColor = Color.Yellow;
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Hatırlamamak";
                buttonU.BackColor = Color.Yellow;
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Türkiyede kedisi çok meşhur bir şehir";
                buttonV.BackColor = Color.Yellow;
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Bir mevsim, hava genellikle çok sıcaktır";
                buttonY.BackColor = Color.Yellow;
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Siyah beyaz bir hayvan";
                buttonZ.BackColor = Color.Yellow;
            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:                                        // Soru 1 olduğunda
                        if (textBox1.Text=="ANKARA")               // cevap ankara ise
                        {                                         
                            buttonA.BackColor = Color.Green;       // butonu yeşil yap
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else                                       // değilse
                        {
                            buttonA.BackColor = Color.Red;         // butonu kırmızı yap
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;                                     // case'ler break ile sonlanır.

                    case 2:
                        if (textBox1.Text=="BAYRAK")
                        {
                            buttonB.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "CUMARTESİ")
                        {
                            buttonC.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "DENİZ")
                        {
                            buttonD.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "ESKİ")
                        {
                            buttonE.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "FAS")
                        {
                            buttonF.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "GENÇ")
                        {
                            buttonG.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "HASTA")
                        {
                            buttonH.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "IRAK")
                        {
                            buttonI.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "İNEK")
                        {
                            buttonİ.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonİ.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "JAPONYA")
                        {
                            buttonJ.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "KÜTÜPHANE")
                        {
                            buttonK.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 13:
                        if (textBox1.Text == "LİMON")
                        {
                            buttonL.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 14:
                        if (textBox1.Text == "MAYMUN")
                        {
                            buttonM.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 15:
                        if (textBox1.Text == "NE")
                        {
                            buttonN.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 16:
                        if (textBox1.Text == "OKUL")
                        {
                            buttonO.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 17:
                        if (textBox1.Text == "PATATES")
                        {
                            buttonP.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 18:
                        if (textBox1.Text == "ROBOT")
                        {
                            buttonR.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 19:
                        if (textBox1.Text == "SALI")
                        {
                            buttonS.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 20:
                        if (textBox1.Text == "TAVUK")
                        {
                            buttonT.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 21:
                        if (textBox1.Text == "UNUTMAK")
                        {
                            buttonU.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 22:
                        if (textBox1.Text == "VAN")
                        {
                            buttonV.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 23:
                        if (textBox1.Text == "YAZ")
                        {
                            buttonY.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                    case 24:
                        if (textBox1.Text == "ZEBRA")
                        {
                            buttonZ.BackColor = Color.GreenYellow;
                            dogruCevap++;
                            labelDogru.Text = dogruCevap.ToString();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlisCevap++;
                            labelYanlis.Text = yanlisCevap.ToString();
                        }
                        break;

                }
            }
        }
    }
}