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

namespace WpfPriemgetal
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

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            int nummer = Convert.ToInt32(txtGetal.Text);
            int delers = 0;

            for(int i =1; i <= nummer; i++)
            {
                if ( nummer % i == 0)
                {
                    delers++;
                }
            }

            Brush color1 = Brushes.Green;
            Brush color2 = Brushes.Red;

            if(delers == 2)
            {
                lblResultaat.Content = $"{nummer} is een priem getal";
                lblResultaat.Foreground = color1;
            }
            else
            {
                lblResultaat.Content = $"{nummer} is geen priem getal";
                lblResultaat.Foreground = color2;
            }
        }
    }
}
