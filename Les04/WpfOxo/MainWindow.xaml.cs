using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfOxo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool beurt = true; //true = x beurt; false = y beurt
        int beurten = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOxo1_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (beurt) { b.Content = "X"; }

            else { b.Content = "o"; }

            beurt = !beurt;
            b.IsEnabled = false;

            checkWinner();
        }

        private void checkWinner()
        {
            bool winaar = false;

            if (btnOxo1.Content == btnOxo2.Content && btnOxo2.Content == btnOxo3.Content && !btnOxo1.IsEnabled)
                winaar = true;
            if (btnOxo4.Content == btnOxo5.Content && btnOxo5.Content == btnOxo6.Content && !btnOxo4.IsEnabled)
                winaar = true;
            if (btnOxo7.Content == btnOxo8.Content && btnOxo8.Content == btnOxo9.Content && !btnOxo7.IsEnabled)
                winaar = true;
            if (btnOxo1.Content == btnOxo5.Content && btnOxo5.Content == btnOxo9.Content && !btnOxo1.IsEnabled)
                winaar = true;
            if (btnOxo3.Content == btnOxo5.Content && btnOxo5.Content == btnOxo7.Content && !btnOxo3.IsEnabled)
                winaar = true;
            if (btnOxo1.Content == btnOxo4.Content && btnOxo4.Content == btnOxo7.Content && !btnOxo1.IsEnabled)
                winaar = true;
            if (btnOxo2.Content == btnOxo5.Content && btnOxo5.Content == btnOxo8.Content && !btnOxo2.IsEnabled)
                winaar = true;
            if (btnOxo3.Content == btnOxo6.Content && btnOxo6.Content == btnOxo9.Content && !btnOxo3.IsEnabled)
                winaar = true;


            if (winaar)
            {
                string winner = "";
                if (beurt)
                    winner = "speler 2";
                else
                    winner = "speler 1";
                lblWin.Content = $"{winner} heeft gewonnen";
                }
        }

    }
}