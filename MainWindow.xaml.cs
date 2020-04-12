using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;



namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ImageSource birinci = new BitmapImage(new Uri(@"images\R1.jpg", UriKind.Relative));
        public ImageSource ikinci = new BitmapImage(new Uri(@"images\R2.jpg", UriKind.Relative));
        public ImageSource ucuncu = new BitmapImage(new Uri(@"images\R3.jpg", UriKind.Relative));
        public ImageSource dorduncu = new BitmapImage(new Uri(@"images\R4.jpg", UriKind.Relative));
        static int i = 1;
        
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private void test()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            ileri();
        }
        public MainWindow()
        {


            test();
            InitializeComponent();
    }
        public void ileri()
        {
          
            if (i == 1)
            {   i++; 
                AnaResim.Source = ikinci;   }
            else if (i == 2)
            {   i++;
                AnaResim.Source = ucuncu ;
            }
            else if (i == 3)
            {  i++;
               AnaResim.Source = dorduncu;
            }
            else {
                i=1;
                AnaResim.Source = birinci;
            }
           
        }
        public void Geri()
        {
            if (i == 1)
            {  i=4;
               AnaResim.Source = dorduncu;
            }
            else if (i == 4)
            {     i--;
                AnaResim.Source = ucuncu;
            }
            else if (i == 3)
            {   i--;
                AnaResim.Source = ikinci;
            }
            else
            {
                 i = 1;
                AnaResim.Source = birinci;
            }

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void chan_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
       
       
        private void chan_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            chan.Text = "";
        }

        private void kampanyalar_MouseEnter(object sender, MouseEventArgs e)
        {
            kampanyalar.Background = new SolidColorBrush(Colors.ForestGreen);
            kampanyalar.Foreground = new SolidColorBrush(Colors.White);
            kampanyalar.Height = kampanyalar.Height + 5;
            kampanyalar.Width = kampanyalar.Width + 5;
            kampanyalar.FontSize = kampanyalar.FontSize +4;
        }

        private void kampanyalar_MouseLeave(object sender, MouseEventArgs e)
        {
            kampanyalar.Background = new SolidColorBrush(Colors.White);
            kampanyalar.Foreground = new SolidColorBrush(Colors.Black);
            kampanyalar.Height = kampanyalar.Height -5;
            kampanyalar.Width = kampanyalar.Width - 5;
            kampanyalar.FontSize = kampanyalar.FontSize - 4;
        }

        
        private void cokSatanlar_MouseLeave(object sender, MouseEventArgs e)
        {
            cokSatanlar.Background = new SolidColorBrush(Colors.White);
            cokSatanlar.Foreground = new SolidColorBrush(Colors.Black);
            cokSatanlar.Height = cokSatanlar.Height - 5;
            cokSatanlar.Width = cokSatanlar.Width - 5;
            cokSatanlar.FontSize = cokSatanlar.FontSize - 4;
        }

        private void cokSatanlar_MouseEnter(object sender, MouseEventArgs e)
        {
            cokSatanlar.Background = new SolidColorBrush(Colors.ForestGreen);
            cokSatanlar.Foreground = new SolidColorBrush(Colors.White);
            cokSatanlar.Height = cokSatanlar.Height + 5;
            cokSatanlar.Width = cokSatanlar.Width + 5;
            cokSatanlar.FontSize = cokSatanlar.FontSize + 4;
        }

        private void firsat_MouseLeave(object sender, MouseEventArgs e)
        {
            firsat.Background = new SolidColorBrush(Colors.White);
            firsat.Foreground = new SolidColorBrush(Colors.Black);
            firsat.Height = firsat.Height - 5;
            firsat.Width = firsat.Width - 5;
            firsat.FontSize = firsat.FontSize - 4;
        }

        private void firsat_MouseEnter(object sender, MouseEventArgs e)
        {
            firsat.Background = new SolidColorBrush(Colors.ForestGreen);
            firsat.Foreground = new SolidColorBrush(Colors.White);
            firsat.Height = firsat.Height + 5;
            firsat.Width = firsat.Width + 5;
            firsat.FontSize = firsat.FontSize + 4;
        }

        private void yeni_MouseLeave(object sender, MouseEventArgs e)
        {
            yeni.Background = new SolidColorBrush(Colors.White);
            yeni.Foreground = new SolidColorBrush(Colors.Black);
            yeni.Height = yeni.Height - 5;
            yeni.Width = yeni.Width - 5;
            yeni.FontSize = yeni.FontSize -4;
        }

        private void yeni_MouseEnter(object sender, MouseEventArgs e)
        {
            yeni.Background = new SolidColorBrush(Colors.ForestGreen);
            yeni.Foreground = new SolidColorBrush(Colors.White);
            yeni.Height = yeni.Height + 5;
            yeni.Width = yeni.Width + 5;
            yeni.FontSize = yeni.FontSize + 4;
            
        }

       
        private void Geri_Click(object sender, RoutedEventArgs e)
        {
            Geri();
        }

        private void ileri_Click(object sender, RoutedEventArgs e)
        {
            ileri();

        }

        private void uyeollbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.uyeol uye = new uyeol();
            uye.ShowDialog();
        }

        private void girisyaplbl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.girisyap giris = new girisyap();
            giris.ShowDialog();
        }

        private void ilkfoto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        

        private void siyahzeytin_Click(object sender, RoutedEventArgs e)
        {
                
                WpfApp7.siyahzeytin zeytin = new siyahzeytin();
                zeytin.ShowDialog();
   



        }

        private void ilk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void iki_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void uc_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void dort_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void bes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void alti_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void yedi_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void sekiz_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }
    }
    
}
