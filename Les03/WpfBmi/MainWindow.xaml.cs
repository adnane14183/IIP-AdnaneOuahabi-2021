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
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBmi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double lengte;
        Double gewicht;
        Double total1;
        Double total2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBmi_Click(object sender, RoutedEventArgs e)
        {
            lengte = Convert.ToDouble(txtLengte.Text);
            gewicht = Convert.ToDouble(TxtGewicht.Text);

            total1 = Convert.ToDouble(lengte) / Convert.ToDouble(100);
            total2 = Convert.ToDouble(gewicht) / (Convert.ToDouble(total1) * total1);
            LblBmi.Content = "Jouw BMI is " + Math.Round(total2, 1);

        }
    }
}
