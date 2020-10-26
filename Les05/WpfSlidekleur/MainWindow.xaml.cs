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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfSlidekleur
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

        private void sdrKleur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
             Brush newColor = Brushes.Green;
            Brush newColor1 = Brushes.Yellow;
            Brush newColor2 = Brushes.Orange;
            Brush newcolor3 = Brushes.Brown;

            lblGetal.Content = Math.Round(sldKleur.Value, 0);
            double getal1 = Convert.ToDouble(lblGetal.Content);
            
            if (getal1 <= 33) {
                lblGetal.Foreground = newColor; 
            }
            if(getal1 >= 34 && getal1 < 73) {
                lblGetal.Foreground = newColor1;
                    }
            if (getal1 >= 73 && getal1 < 90) { lblGetal.Foreground = newColor2;  }

            if (getal1 >= 90) {
                lblGetal.Foreground = newcolor3;
            }
        }
    }
}
