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

namespace WpfFormChecking
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

        private void btnRegistreren_Click(object sender, RoutedEventArgs e)
        {
            int aantalFouten = 0;
            
           
            lblFout1.Content = "";
            
            if (txtNaam.Text == "")
            {
                lblFout1.Content = "naam moet ingevuld zijn";
                aantalFouten++;
            }

            lblFout2.Content = "";

            if (txtEmail.Text == "")
            {
                lblFout2.Content = "e-mail moet ingevuld zijn";
                aantalFouten++;
            }


            lblFout3.Content = "";

            if (DprGeboorte.SelectedDate == null)
            {
                lblFout3.Content = "Kies een geboortedatum";
                aantalFouten++;
            }


            lblFout4.Content = "";

            if (cbxProfiel.SelectedItem == null)
            {
                lblFout4.Content = "Kies een profiel";
                aantalFouten++;
            }

            lblFout5.Content = "";

            if (psbPasswoord.Password == "")
            {
                lblFout5.Content = "Kies een wachtwoord";
                aantalFouten++;
            }

            lblFout6.Content = "";

            if (rbnMan.IsChecked == false && rbnVrouw.IsChecked == false)
            {
                lblFout6.Content = "Kies tussen man en vrouw";
                aantalFouten++;
            }

            lblFout7.Content = "";

            if (cbxBus.IsChecked == false && cbxNet.IsChecked == false && cbxProg.IsChecked == false)
            {
                lblFout7.Content = "Kies uw interesses";
                aantalFouten++;
            }
            lblMessage.Content = aantalFouten;
        }
    }
}
