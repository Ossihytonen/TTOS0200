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

namespace WPFLabra10._1
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

        private void txtOstan_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                ListBoxItem li = (ListBoxItem)ValintaOstan.SelectedItem;
                string testi = li.Content.ToString();
                if (testi == "USD")
                {
                    double f, g;
                    f = double.Parse(txtOstan.Text);
                    g = (f * 0.8997);
                    txtMyyn.Text = g.ToString("0.00");
                }
                else
                {
                    double f, g;
                    f = double.Parse(txtOstan.Text);
                    g = (f / 0.8997);
                    txtMyyn.Text = g.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                txtMyyn.Text = ex.Message;
            }
        }
    }
}
