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

namespace WpfGebruikersnaam
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

        private void txtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            Brush newColor = Brushes.Red;
            Brush newcolor1 = Brushes.Green;
            Brush newColor2 = Brushes.Black;
            Brush newcolor3 = Brushes.White;
            
            string Gebruikersnaam = txtNaam.Text;

            if (Gebruikersnaam.Contains(" "))
            {
                lblFout.Content = "bevat een spatie!";
                lblFout.Foreground = newColor;
                txtNaam.Background = newColor;
            }
            else if (Gebruikersnaam != "")
            {
                lblFout.Content = "Bevat geen spaties";
                lblFout.Foreground = newColor2;
                txtNaam.Background = newcolor3;

            }
            else
            {
                lblFout.Content = "";
                txtNaam.Background = newcolor1;
            }
        }
    }
}
