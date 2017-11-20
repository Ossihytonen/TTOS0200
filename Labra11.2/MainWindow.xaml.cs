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

namespace Labra11._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Pelaaja> pelaajat2;
        public MainWindow()
        {
            InitializeComponent();
            pelaajat2 = PeliSeura.HaePelaajat();
        }

        private void btnHae_Click(object sender, RoutedEventArgs e)
        {
            pelaajat2 = PeliSeura.HaePelaajat();
            dataGridPelaajat.ItemsSource = pelaajat2;
        }
    }
}
