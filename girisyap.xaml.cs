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
    /// Interaction logic for girisyap.xaml
    /// </summary>
    public partial class girisyap : Window
    {
        public girisyap()
        {
            InitializeComponent();
        }

        

        private void uyeolbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WpfApp7.uyeol uye = new uyeol();
            uye.ShowDialog();
        }

      
        private void girisyapbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
