using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
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
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public string? Nama { get; set; }
        public string? Sepatu { get; set; }

        public Page1()
        {
            InitializeComponent();

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Nama = TBNama.Text;
            Sepatu = TBSepatu.Text;
            Page2 p2 = new Page2(Nama,Sepatu);
            this.NavigationService.Navigate(p2);




        }
    }
}
