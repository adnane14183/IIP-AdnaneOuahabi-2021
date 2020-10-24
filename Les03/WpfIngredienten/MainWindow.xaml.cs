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

namespace WpfApp1
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

       

        private void btnMaken_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem personen = (ComboBoxItem)cbxPersonen.SelectedItem;

            int H1 = Convert.ToInt32(txtHoeveelheid1.Text) * Convert.ToInt32(personen.Content);
            int H2 = Convert.ToInt32(txtHoevelheid2.Text) * Convert.ToInt32(personen.Content);
            int H3 = Convert.ToInt32(txtHoeveelheid3.Text) * Convert.ToInt32(personen.Content);
            int H4 = Convert.ToInt32(TxtHoeveelheid4.Text) * Convert.ToInt32(personen.Content);

            ComboBoxItem EE1 = (ComboBoxItem)cbxEenheid1.SelectedItem;
            ComboBoxItem EE2 = (ComboBoxItem)cbxEenheid1.SelectedItem;
            ComboBoxItem EE3 = (ComboBoxItem)cbxEenheid1.SelectedItem;
            ComboBoxItem EE4 = (ComboBoxItem)cbxEenheid1.SelectedItem;

            string E1 = Convert.ToString(EE1.Content); 
            string E2= Convert.ToString(EE2.Content);
            string E3 = Convert.ToString(EE3.Content);
            string E4 = Convert.ToString(EE4.Content);

            string I1 = txtIngredient1.Text; 
            string I2 = txtIngredient2.Text;
            string I3 = txtIngredient3.Text;
            string I4 = txtIngredient4.Text;

            txtLijst.Text = $"- {H1} {E1} {I1} {Environment.NewLine} " +
                $"- {H2} {E2} {I2} {Environment.NewLine}" +
                $"- {H3} {E3} {I4} {Environment.NewLine}" +
                $"- {H4} {E4} {I4} {Environment.NewLine}";
        }
    }
}
