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

namespace Labra11._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeGames();
        }
        private void InitializeGames()
        {
            listGames.Items.Add(new Lotto());
            listGames.Items.Add(new Vikinglotto());
            listGames.Items.Add(new Eurojackpot());
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listGames.SelectedIndex >= 0)
                {
                    Lottery peli = (Lottery)listGames.SelectedItem;
                    Results.Text = "";
                    int number = int.Parse(textDraws.Text);
                    for (int x = 0; x < number; x++)
                    {
                        peli.Arvonta();
                        Results.Text += String.Format("Rivi {0}: -- ", x + 1) + peli.Tulostus() + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                Results.Text = ex.Message;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Results.Text = String.Empty;
        }
    }
}
