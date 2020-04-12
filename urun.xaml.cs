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
    /// Interaction logic for urun.xaml
    /// </summary>
    public partial class urun : Window
    {
        public urun()
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
    }
}
