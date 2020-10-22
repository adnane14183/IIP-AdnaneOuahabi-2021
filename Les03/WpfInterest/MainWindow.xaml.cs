using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfIngredienten
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

        private void sldJaar_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblJaar.Content = Math.Round(sldJaar.Value, 0);
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double waarde = Convert.ToDouble(txtBedrag.Text);
            double interest = Convert.ToDouble(txtInterest.Text);
            double jaar = Convert.ToDouble(lblJaar.Content);
            double Totaal = (interest / 100) + 1;
            double totaal1 = Math.Pow(Totaal, jaar);
            double resultaat = waarde * totaal1;
            txtTotaal.Text = $"De waarde na {jaar} jaar bedraag € {Math.Round(resultaat, 2)}";

        }
    }
}
