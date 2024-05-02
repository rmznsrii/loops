using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValue.ReadOnly = true; //Kullanıcı veri girmemes için txt'lere readonly true 
            txtDongu.ReadOnly = true;
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen tuşu kontrol et
            // Eğer girilen tuş sayı değilse ve silme, geri alma veya negatif işareti değilse, işlemi iptal et
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            // Eğer negatif işaret zaten varsa ve '-' tuşuna basılırsa işlemi iptal et
            else if (e.KeyChar == '-' && ((System.Windows.Forms.TextBox)sender).Text.Contains("-"))
            {
                e.Handled = true;
            }
        }

        private void txtArtAz_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayı girişi 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); 

        }

        private void txtDonguMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece sayı girişi 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }


        private void btnWhile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSayi.Text))
            {
                // txt.Sayi boşsa kullanıcıya uyarı ver
                MessageBox.Show("Lütfen bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtArtAz.Text))
            {
                // txt.Artaz boşsa kullanıcıya uyarı ver
                MessageBox.Show("Lütfen bir artış veya azalış değeri girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtDonguMax.Text))
            {
                // txtDonguMax boşsa kullanıcıya uyarı ver
                MessageBox.Show("Lütfen döngünün kaçta duracağını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //Textboxların hepsine veri girişi yapılmış demektir. Kodlarımız devreye bu blokta girer.
            {
                int sayi = Convert.ToInt32(txtSayi.Text);         //textbox'lara girilen string değerleri int değere dönüştürüp değişkenlere aktar
                int artAz = Convert.ToInt32(txtArtAz.Text);
                int donguDur = Convert.ToInt32(txtDonguMax.Text);
                int donguSayac = 0;

                txtValue.Text = "Başlangıç Değeri = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;

                if (rdArt.Checked) //Bu bloklar, artsın mı? azalsın mı? diye soran radio butonların hangisinin seçili olduğunu kontrol eder ve işleme alır. Seçilmemişlerse uyarı verir.
                {
                    while (donguSayac < donguDur) // dongusayac'ı sıfırdan başlatıp kullanıcı döngüyü tekrar etmesini istediği sayıya kadar döndürmek için olan komut bloğu.
                    {
                        donguSayac++;
                        sayi += artAz; //Sayıyı kullanıcının isteğine göre artması için döngü başına ekleme yapar
                        txtValue.Text += "Sayı = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine; //txt.Value textboxx'ına her döngüdeki işlemin sonucunu yazdır.
                    }
                    txtValue.Text += donguSayac.ToString() + ". döngüde oluşan yeni sayı = " + sayi.ToString(); // döngü bitişi kullanıcıya bilgi
                    txtDongu.Text = donguSayac.ToString(); //toplam döngüyü gösteren textbox'a aktarılan bilgi
                }
                else if (rdAz.Checked) //azalsın butonu seçiliyse gerçekleşecek işlemler...
                {
                    while (donguSayac < donguDur) //sayi değişkenini azaltmamızdan başka üssteki kod bloğundan bir farkı yok
                    {
                        donguSayac++;
                        sayi -= artAz;
                        txtValue.Text += "Sayı = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;
                    }
                    txtValue.Text += donguSayac.ToString() + ". döngüde oluşan yeni sayı = " + sayi.ToString();
                    txtDongu.Text = donguSayac.ToString();
                }
                else
                {
                    // radiobutonlar seçilmemişse kullanıcıya uyarı verir if blokları etkin olunca program çalışır.
                    MessageBox.Show("Sayının artış veya azalış durumunu seçiniz!", "Buton Seçilmedi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //En Yukarıdaki while butonun click eventine basılınca olan olayların aynısı geçerlidir. Tek farkı Do While döngüsü ile yapılmasıdır. Amacım aynı komutları farklı döngülerde çalıştırmak ve döngüleri anlamak.
            if (string.IsNullOrWhiteSpace(txtSayi.Text))
            {
                MessageBox.Show("Lütfen bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtArtAz.Text))
            {
                MessageBox.Show("Lütfen bir artış veya azalış değeri girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtDonguMax.Text))
            {
                MessageBox.Show("Lütfen döngünün kaçta duracağını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sayi = Convert.ToInt32(txtSayi.Text);
                int artAz = Convert.ToInt32(txtArtAz.Text);
                int donguDur = Convert.ToInt32(txtDonguMax.Text);
                int donguSayac = 0;

                txtValue.Text = "Başlangıç Değeri = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;

                if (rdArt.Checked)
                {
                    do
                    {
                        sayi += artAz;
                        donguSayac++;
                        txtValue.Text += "Sayı = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;
                    }
                    while (donguSayac < donguDur);
                    txtValue.Text += donguSayac.ToString() + ". döngüde oluşan yeni sayı = " + sayi.ToString();
                    txtDongu.Text = donguSayac.ToString();
                }
                else if (rdAz.Checked)
                {
                    do
                    {
                        sayi -= artAz;
                        donguSayac++;
                        txtValue.Text += "Sayı = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;
                    }
                    while (donguSayac < donguDur);
                    txtValue.Text += donguSayac.ToString() + ". döngüde oluşan yeni sayı = " + sayi.ToString();
                    txtDongu.Text = donguSayac.ToString();
                }
                else
                {
                    MessageBox.Show("Sayının artış veya azalış durumunu seçiniz!", "Buton Seçilmedi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            



            }

        private void btnFor_Click(object sender, EventArgs e)
        {
            //En Yukarıdaki while butonun click eventine basılınca olan olayların benzerini içerir. For döngüsü kullanımından dolayı bazı değişiklikleri yorum satırında belirttim.
            if (string.IsNullOrWhiteSpace(txtSayi.Text))
            {
                MessageBox.Show("Lütfen bir sayı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtArtAz.Text))
            {
                MessageBox.Show("Lütfen bir artış veya azalış değeri girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtDonguMax.Text))
            {
                MessageBox.Show("Lütfen döngünün kaçta duracağını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sayi = Convert.ToInt32(txtSayi.Text);
                int artAz = Convert.ToInt32(txtArtAz.Text);
                int donguDur = Convert.ToInt32(txtDonguMax.Text);
                int donguSayac = 0;

                txtValue.Text = "Başlangıç Değeri = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;
                
                if (rdArt.Checked)
                {
                    donguSayac++; //for döngüsü ilk defa çalışırken, koşulu kontrol edip içindeki bloğu çalıştırdığı için her döngüye girildiğinde dongusayacın 1 artmasını istediğimizden donguSayac'ı başlangıç için 1 arttırıyoruz.
                    donguDur++;   //donguSayac'ı 1 arttırdığımız için koşulun sağlıklı sağlanması ve döngünün kullanıcının istediği sayı kadar dönmesi için donguDur'u da 1 arttırıyoruz.
                    for (; donguSayac < donguDur; donguSayac++) //2. parametre yani koşula bakıp direkt döngüyü başlatır. 2. kontrol etmesinden önce donguSayac'ı ilk defa 1 arttıracağı için başlangıçta donguSayac ve donguDur'u birer arttırdık. 
                    {
                        sayi += artAz;
                        txtValue.Text += "Sayı = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;//Böylece textbox'a doğru verileri gösterecek. Aslında 
                        //aslında her şey döngü içinde txtValue textboxına 
                    }
                    donguSayac--; //döngü bittiğinde haliyle sayacımızı 1 arttırdığımız için işlem sonunda doğru sonuç vermesi için 1 eksiltiyoruz. donguDur değişkeni işlem sonunda kullanıcıya bilgi vermediği için azaltmamıza gerek yok.
                    txtValue.Text += donguSayac.ToString() + ". döngüde oluşan yeni sayı = " + sayi.ToString(); 
                    txtDongu.Text = donguSayac.ToString();
                }
                else if (rdAz.Checked) 
                {
                    donguSayac++;
                    donguDur++; 
                    
                    for (; donguSayac < donguDur; donguSayac++) 
                    {
                        sayi -= artAz; // üstteki if bloğundan tek farkı bu botonda azalma seçildiğinden += yerine -= ile azaltmamız.
                        txtValue.Text += "Sayı = " + sayi.ToString() + "  Döngü = " + donguSayac.ToString() + Environment.NewLine;
                        if (donguSayac == donguDur - 1) break; //burada da break komutunu kullanabilmek için yazdım. Normalde şart bir şey değil döngü çıkışı direkt donguSayac'ı 1 azaltarak da aynı sonuca varabilirdik. 
                    }
                    
                    txtValue.Text += donguSayac.ToString() + ". döngüde oluşan yeni sayı = " + sayi.ToString();
                    txtDongu.Text = donguSayac.ToString();

                }
                else 
                {
                    MessageBox.Show("Sayının artış veya azalış durumunu seçiniz!", "Buton Seçilmedi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
