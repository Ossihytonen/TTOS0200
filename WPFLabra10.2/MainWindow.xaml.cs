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

namespace WPFLabra10._2
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double L, H, W, Ipa, Lpa, Kp;
            L = double.Parse(ValueL.Text);
            H = double.Parse(ValueH.Text);
            W = double.Parse(ValueW.Text);
            Lpa = ((H - 2 * W) * (L - 2 * W))/1000;
            Kp = (H+H+L+L)/1000;
            Ipa = (H * L)/1000;
            txtLpa.Text = Lpa.ToString("0.00")+"m^2";
            txtKp.Text = Kp.ToString("0.00")+"m^2";
            txtIpa.Text = Ipa.ToString("0.00")+"m";

        }
    }
}
