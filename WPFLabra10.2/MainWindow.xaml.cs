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
            try
            {
                double L, H, W, Ipa, Lpa, Kp;
                if (double.Parse(ValueL.Text) < 300 && double.Parse(ValueL.Text) > 0 )
                {
                    L = 300;
                    ValueL.Text = "300";
                }
                if (double.Parse(ValueL.Text) > 3000)
                {
                    L = 3000;
                    ValueL.Text = "3000";
                }
                else
                {
                    L = double.Parse(ValueL.Text);
                }
                if (double.Parse(ValueH.Text) < 300 && double.Parse(ValueH.Text) > 0)
                {
                    H = 300;
                    ValueH.Text = "300";
                }
                if (double.Parse(ValueH.Text) > 3000)
                {
                    H = 3000;
                    ValueH.Text = "3000";
                }
                else
                {
                    H = double.Parse(ValueL.Text);
                }
                W = double.Parse(ValueW.Text);
                Lpa = ((H - 2 * W) * (L - 2 * W)) / 1000;
                Kp = (H + H + L + L) / 1000;
                Ipa = (H * L) / 1000;
                Ikkuna.Width = L / 10;
                Ikkuna.Height = H / 10;
                txtLpa.Text = Lpa.ToString("0.00") + "m²";
                txtKp.Text = Kp.ToString("0.00") + "m²";
                txtIpa.Text = Ipa.ToString("0.00") + "m";
            }
            catch (Exception)
            {
                ValueH.Text = "0";
                ValueL.Text="0";
                ValueW.Text="45";
            }

        }
    }
}
