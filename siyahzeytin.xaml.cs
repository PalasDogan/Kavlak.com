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
    /// Interaction logic for siyahzeytin.xaml
    /// </summary>
    public partial class siyahzeytin : Window
    {
        public siyahzeytin()
        {
            InitializeComponent();
        }

        private void uye_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.uyeol uye = new uyeol();
            uye.ShowDialog();
        }

        private void uye1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.uyeol uye = new uyeol();
            uye.ShowDialog();
        }

        private void giris1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.girisyap giris = new girisyap();
            giris.ShowDialog();
        }

        private void ara1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.girisyap giris = new girisyap();
            giris.ShowDialog();
        }

        
     
        private void Geribtnn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ileribtnn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ara1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void jumbo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void star_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void tas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void gold_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void uclu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void iri_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void special_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }

        private void baski_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApp7.urun urun = new urun();
            urun.ShowDialog();
        }
    }
}
