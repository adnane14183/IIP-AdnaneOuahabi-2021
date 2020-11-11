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

namespace WpfCarConfigurator
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

        private void cbxModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int prijs = 0;
            ComboBoxItem selected = (ComboBoxItem)cmxModel.SelectedItem;
            string item = Convert.ToString(selected.Content);
           
            if ( item == "continental v8 8500 euro")
            {
                prijs = prijs + 8500;
            }
            if (item == "convertible  72000")
            {
                prijs += 72000;
            }
            if (item == "mulsanne 65300")
            {
                prijs += 65300;
            }

            lblPrijs.Content = prijs;
        }

        private void rbnBlauw_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void rbnRood_Checked(object sender, RoutedEventArgs e)
        {
            cbxModel_SelectionChanged();

        }

    }
}
