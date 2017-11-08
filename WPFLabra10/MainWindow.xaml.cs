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

namespace WPFLabra10
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

        private void btnRekat_Click(object sender, RoutedEventArgs e)
        {
            String add = (Convert.ToInt32(txtRekat.Text) + 1).ToString();
            txtRekat.Text = add;

        }

        private void btnAutot_Click(object sender, RoutedEventArgs e)
        {
            String add = (Convert.ToInt32(txtAutot.Text) + 1).ToString();
            txtAutot.Text = add;
        }
    }
}
