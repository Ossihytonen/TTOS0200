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

namespace Labra11._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void butBuy_Click(object sender, RoutedEventArgs e)
        {
            string Spl = "";
            if (checkMilk.IsChecked == true)
            {
                Spl += "Milk, ";
                txtShopping_list.Text = Spl;
            }
            if (checkButter.IsChecked == true)
            {
                Spl += "Butter, ";
                txtShopping_list.Text = Spl;
            }
            if (checkBeer.IsChecked == true)
            {
                Spl += "Beer, ";
                txtShopping_list.Text = Spl;
            }
            if (checkChicken.IsChecked == true)
            {
                Spl += "Chicken, ";
                txtShopping_list.Text = Spl;
            }
            if (checkLemonade.IsChecked == true)
            {
                Spl += "Lemonade,";
                txtShopping_list.Text = Spl;
            }
        }
    }
}
