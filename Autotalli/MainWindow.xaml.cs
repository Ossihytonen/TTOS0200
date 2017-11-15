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

namespace Autotalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot; //muuttuja on käytettävissä kaikissa luokan metodeissa ja tapahtumankäsittelijöissä
        private const string polku = @"D:\K9447\kuvat\";
        public MainWindow()
        {
            //Tänne koodi, joka suoritetaan ikkunan avauksen luonnissa 
            InitializeComponent();
            autot = AutoTalli.HaeAuto();
            NäytäKuva("autotalli.png");
            //aasetetaan comboboxiin kaikki eri automerkit
            //Ve1: käsin koodaamalla
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
            //Ve2: Kysytään LING:lla datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            //pyydetään BL-kerrkoselta autot, ja näytetään käyttäjälle
            autot = AutoTalli.HaeAuto();
            dgAutot.ItemsSource = autot;
        }
        private void NäytäKuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //lisätään vakiopolku
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill;
                imgAuto.Source = pic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom, olemme itse populoineet DataGridin Auto-oliotta , joten kukin data gridin jäsen/alkio on itseasiassa auto-olio.
            object obj = dgAutot.SelectedItem;
            if (obj!=null)
            {
                Auto valittu = (Auto)obj;
                NäytäKuva(valittu.URL);
            }
        }

        private void btnHAeAudit_Click(object sender, RoutedEventArgs e)
        {
            //Näkyviin pelkästää audi merkkiset autot
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Suodatetaan DataGridiin näkyviin vain valittu automerkki 
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
        }
    }
}
