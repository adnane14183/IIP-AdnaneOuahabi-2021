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

namespace WpfEllipsen
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

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            for (int teller = 50; teller <= teller++;) 
            {
                Ellipse newEllipse = new Ellipse();
                newEllipse.Width = rnd.Next(0, 250);
                newEllipse.Height = rnd.Next(0, 250);
                newEllipse.Fill = new SolidColorBrush(Color.FromRgb(122, 78, 200));
                double xPos = rnd.Next(0, 500);
                double yPos = rnd.Next(0, 500);
                newEllipse.SetValue(Canvas.LeftProperty, xPos);
                newEllipse.SetValue(Canvas.TopProperty, yPos);
                //voeg ellips toe aan het canvas
                canvas1.Children.Add(newEllipse);
            }
        }
    }
}
