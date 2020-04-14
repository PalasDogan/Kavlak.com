using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Window1.xaml etkileşim mantığı
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {

            InitializeComponent();

            if (Urun.urun_sayisi != 0)
            {
                imgsil.Source= new BitmapImage(new Uri(@"images/trash-icon.png", UriKind.Relative));
                sil.Text = "Sil";
                urunadisayfa.Text = Urun.urunadi;
                urunaciklamasayfa.Text = Urun.urunaciklama;
                urunfiyatsayfa.Text = Urun.urun_fiyat.ToString()+" TL";
                urunresmisayfa.Source = Urun.urunfoto;
                urunadetsayfa.Text = Urun.urun_sayisi.ToString()+" Adet";
                toplamurunsayisisayfa.Text = Urun.urun_sayisi.ToString();
                toplamsayfa.Text = Urun.toplamfiyat.ToString()+ " TL";
                toplamurunfiyat.Text = Urun.toplamfiyat.ToString() +" TL";
                Urun.adetsayisi = 0;


            }
          
        }

        private void uyeolimg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void girisimg_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void arabutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void aramatxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void aramatxt_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        
        
        private void mesaj_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mesaj.Text = "";
        }

        private void anasayfa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            WpfApp7.MainWindow urun = new MainWindow();
            this.Close();
            urun.ShowDialog();
        }

        private void onay_Click(object sender, RoutedEventArgs e)
        {
            if (Urun.urun_sayisi == 0)
            {
                MessageBox.Show("Sepetiniz Boş !!", "UPSS!!");

            }
            else
            {
                if (adres.Text == "" || adres.Text== "Lütfen adres giriniz.")
                {
                    MessageBox.Show("Adres bilgilerinizde bir yanlışlık var !!", "UPSS!!");

                }
                else
                {
                    MessageBox.Show("Teşekkürler", "İşlem Başarılı");
                }
            
            
            }
           
            
        }

        private void adres_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adres.Text = "";
        }
       

        private void imgsil_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Urun.urun_sayisi != 0)
            {
                imgsil.Source = new BitmapImage(new Uri(@"", UriKind.Relative));
                sil.Text = "";
                urunadisayfa.Text = "Sepette Ürün Yok!!";
                urunaciklamasayfa.Text = "";
                urunfiyatsayfa.Text = "";
                urunresmisayfa.Source = new BitmapImage(new Uri(@"", UriKind.Relative));
                urunadetsayfa.Text = "";
                toplamurunsayisisayfa.Text = "0";
                toplamsayfa.Text = "0 TL";
                toplamurunfiyat.Text = "0 TL"; ;
                Urun.urun_sayisi = 0;
                Urun.toplamfiyat = 0;
               



            }
        }

        private void mesaj_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.siyahzeytin zeytin = new siyahzeytin();
            this.Close();
            zeytin.ShowDialog();
        }
    }
}
