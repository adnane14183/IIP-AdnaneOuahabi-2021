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

namespace WpfPizza
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

        private void RdnHot_Checked(object sender, RoutedEventArgs e)
        {
            LblMassege.Content = "Tomatensaus, mozzarella en oregano";
            ImgPizza.Source = new BitmapImage(new Uri("Images/hot.PNG", UriKind.Relative));
        }

        private void Rdn4_Checked(object sender, RoutedEventArgs e)
        {
            LblMassege.Content = "Tomatensaus, mozzarella, gorgonzola, emmentaler & geitenkaas";
            ImgPizza.Source = new BitmapImage(new Uri("Images/4.PNG", UriKind.Relative));
        }

        private void RdnHawai_Checked(object sender, RoutedEventArgs e)
        {
            LblMassege.Content = "Tomatensaus, mozarella, rode ui, kip" + Environment.NewLine + "paprika, pepperoni en soaanse peper";
            ImgPizza.Source = new BitmapImage(new Uri("Images/hawa.PNG", UriKind.Relative));
        }
    }
}
