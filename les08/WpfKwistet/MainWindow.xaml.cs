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

namespace WpfKwistet
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

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = txtGroep.Text;
            ltbLijst.Items.Add(item);
            txtGroep.Text = "";
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = (ListBoxItem)ltbLijst.SelectedItem;
            ltbLijst.Items.Remove(item);
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            int index = ltbLijst.SelectedIndex;
            ltbLijst.Items.RemoveAt(index);
            ltbLijst.Items.Insert(index, txtGroep.Text);
        }

        private void btnVerwijderAlles_Click(object sender, RoutedEventArgs e)
        {
            ltbLijst.Items.Clear();
        }
    }
}
