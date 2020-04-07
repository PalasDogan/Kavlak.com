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



namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
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
    }
}
