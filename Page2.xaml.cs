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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    
    public partial class Page2 : Page
    {
        string nama;
        string sepatu;
        string? paket, waktu, harga;

        public Page2(string cNama, string cSepatu)
        {
            InitializeComponent();
            nama = cNama;
            sepatu = cSepatu;
            
            Namam.Content = $"hello, {nama}";
            FSepatu.Content= $"Sepatu {sepatu} anda ingin dicuci dengan paket apa?";
        }

        private void PHemat(object sender, RoutedEventArgs e)
        {
            paket = "Paket Hemat";
            waktu = "12 Jam";
            harga = "Rp. 10,000";
            Page3 p3 = new Page3(nama, sepatu, paket, waktu,harga);
            this.NavigationService.Navigate(p3);
        }
        private void PReguler(object sender, RoutedEventArgs e)
        {
            paket = "Paket Reg";
            waktu = "8 Jam";
            harga = "Rp. 20,000";
            Page3 p3 = new Page3(nama, sepatu, paket, waktu, harga);
            this.NavigationService.Navigate(p3);
        }
        private void PCepat(object sender, RoutedEventArgs e)
        {
            paket = "Paket Cepat";
            waktu = "4 Jam";
            harga = "Rp. 50,000";
            Page3 p3 = new Page3(nama, sepatu, paket, waktu, harga);
            this.NavigationService.Navigate(p3);
        }
    }
}
