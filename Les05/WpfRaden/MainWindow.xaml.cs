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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ncijfer;
        int pogingenOver = 3;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
             ncijfer = rnd.Next(1, 11);
        }

        private void btnControleer_Click(object sender, RoutedEventArgs e) { 
            pogingenOver--;
            int getal = Convert.ToInt32(txtCijfer.Text);
            if (getal > ncijfer) { lblResultaat.Content = $"De gok was te hoog! Je hebt nog {pogingenOver} pogingen over"; }
            if (getal == ncijfer) { lblResultaat.Content = "De gok was correct!"; }
            if (getal < ncijfer) { lblResultaat.Content = $"De gok was te laag! Je hebt nog {pogingenOver}  pogingen over"; }
            if (pogingenOver == 0) { lblResultaat.Content = "Je hebt verloren, herstart het spel!"; }
            if (pogingenOver == 0) { btnControleer.IsEnabled = false; }
            txtCijfer.Text = " ";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            pogingenOver = 3;
            txtCijfer.Text = "";
            Random rnd = new Random();
            ncijfer = rnd.Next(1, 11);
            lblResultaat.Content = "";
            btnControleer.IsEnabled = true;
        }
    }
    }