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

namespace WpfCalcutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double Value  = 0;
        string operation = "";
        bool operation2 = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (txtCijfers.Text == "0" || operation2)
                txtCijfers.Clear();
                
                
            Button b = (Button)sender;
            txtCijfers.Text += b.Content;
        }

        
        private void btnPLus_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            operation = Convert.ToString(b.Content);
            Value = Convert.ToDouble(txtCijfers.Text);
            operation2 = true;
        }
        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtCijfers.Text = " ";
        }

        private void btnIs_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtCijfers.Text = Value + Convert.ToDouble(txtCijfers.Text).ToString();
                    break;
                case "-":
                    txtCijfers.Text = value - Convert.ToDouble(txtCijfers.Text).ToString();
                    break;
                case "*":
                    txtCijfers.Text = Value * Convert.ToDouble(txtCijfers.Text).ToString();
                    break;
                case "/":
                    txtCijfers.Text = Value / Convert.ToDouble(txtCijfers.Text).ToString();
                    break;
                default:
                    break;
            }
            operation2 = false;
        }
    }
}












