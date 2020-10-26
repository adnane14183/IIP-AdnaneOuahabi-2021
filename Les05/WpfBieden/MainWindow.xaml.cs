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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hoogstebod = 0;
        string bieder;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlaats_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNaam.Text;
            string bod1 = txtBod.Text;
            int bod = Convert.ToInt32(bod1);

            if (bod > hoogstebod)
            {
                lblMessage.Content = $" {name} heeft met {bod} het hoogste bod.";
                hoogstebod = bod;
            }
            else
            {
                lblMessage.Content = $"Sorry, {name} heeft een hogere bod";
                bieder = name;
            }
        }
    }
}
