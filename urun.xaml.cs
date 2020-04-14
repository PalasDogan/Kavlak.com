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
    
    public partial class Urun : Window
    {
       public static int fav_ekleme = 0;
       public  static int urun_sayisi=0;
        public static double toplamfiyat = 0;
        public static double urun_fiyat;
        public static string urunadi;
        public static string urunaciklama;
        public static ImageSource urunfoto;
        public static int adetsayisi=1;
       public void urungetir()
        {
            urunadi = urunaditxt.Text;
            urunaciklama = urunaciklamatxt.Text;
            urunfoto = urunresimtxt.Source;

        }
        public Urun()
        {
            
            InitializeComponent();
            
        }

        private void ara_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ara.Text = "";
        }

        private void ara_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void uyeollbl1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.uyeol uye = new uyeol();
            uye.ShowDialog();
        }

        private void girisyaplbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.girisyap giris = new girisyap();
            giris.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
         
        private void favori_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fav_ekleme == 0)
            {
                MessageBox.Show("Ürün Favorilere Eklendi!", "İşlem Başarılı");
                fav_ekleme++;
            }
            else
            {
                MessageBox.Show("!! Ürün Zaten Favorilere Ekli !!", "UPS!!");
            }
        }

        private void sepete_eklebtn_Click(object sender, RoutedEventArgs e)
        {
                adetsayisi = Convert.ToInt32(adet.Text);
                urun_fiyat = 289.90;
                urun_sayisi=adetsayisi+urun_sayisi;
                MessageBox.Show("Ürün Sepete Eklendi "+Environment.NewLine+ "Sepette " + urun_sayisi+" Adet Ürün Var", "işlem Başarılı");
                toplamfiyat = toplamfiyat+urun_fiyat*adetsayisi;
                urungetir();
                adetsayisi = 1;
                adet.Text = "1";
               
            


            
        }

        private void hemen_albtn_Click(object sender, RoutedEventArgs e)
        {
            urun_fiyat = 289.90;
            toplamfiyat = toplamfiyat + urun_fiyat * adetsayisi;
            urun_sayisi = adetsayisi + urun_sayisi;

            urungetir();
  
            WpfApp7.Window1 sepet = new Window1();
            sepet.ShowDialog();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            WpfApp7.Window1 sepet = new Window1();
            this.Close();
            sepet.ShowDialog();
        }

        private void anasayfaa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            WpfApp7.MainWindow main = new MainWindow();
            this.Close();
            main.ShowDialog();
        }

        private void adet_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void adet_MouseDown(object sender, MouseButtonEventArgs e)
        {
            adet.Text = "";
        }
    }
}
