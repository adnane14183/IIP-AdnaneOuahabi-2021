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
using WMPLib;
using Microsoft.Win32;

namespace WpfMusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // laten afspelen wat er in uw listbox staat
            ListBoxItem selected = (ListBoxItem)ltbAfspeellijst.SelectedItem;
            player.URL = selected.Content.ToString();

            // naam en artiest laten zien
            //gevonden dankzij stackoverflow (lastindex gebruiken)
            string name = "";
            string artistName = ""; 
            string songName = "";
            name = ltbAfspeellijst.SelectedItem.ToString().Substring(ltbAfspeellijst.SelectedItem.ToString().LastIndexOf('\\')); // alles tonen na de laatste (/)
            artistName = name.Substring(1, name.IndexOf('-')) ; //toon je alles voor (-)
            songName = ltbAfspeellijst.SelectedItem.ToString().Substring(ltbAfspeellijst.SelectedItem.ToString().LastIndexOf('-')); //tonen van alles na de (-)

            lblPlaying.Content = "playing: " + artistName + "" + songName;
            
        }

        private void sldMuziek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //slider instellen
                int Volumegeluid = Convert.ToInt32(Math.Round(sldMuziek.Value, 0));
                lblVolume.Content = "Volume: " + Volumegeluid;
                player.settings.volume = Volumegeluid;
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            // code gevonden met behulp van stackoverflow
            // maken van de file dialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // filter 
            dlg.DefaultExt = ".mp3";
            dlg.Filter = "MP3 Audio File (*.mp3)|*.mp3| Windows Media File (*.wma)|*.wma|WAV Audio File (*.wav)|*.wav|All Files (*.*)|*.*";
              
            // openen
            Nullable<bool> result = dlg.ShowDialog();

            //  bestand in listbox zetten 
            if (result == true)
            {
                // Open document
               
                  ListBoxItem item = new ListBoxItem();
                  item.Content = dlg.FileName;
                  ltbAfspeellijst.Items.Add(item);
            }

        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            // button pause instellen
            player.controls.pause();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            //button afspelen instellen
            player.controls.play();
        }

        private void btnMute_Click(object sender, RoutedEventArgs e)
        {
            //mute button instellen
            player.settings.mute = true;
            sldMuziek.Value = 0;
        }

        private void btnUnmute_Click(object sender, RoutedEventArgs e)
        {
            //unmute button instellen
            player.settings.mute = false;
            sldMuziek.Value = 100;
        }

        private void btnVolgende_Click(object sender, RoutedEventArgs e)
        {
            //volgende liedje in de afspeellijst
            ltbAfspeellijst.SelectedIndex += + 1;
        }

        private void btnVorige_Click(object sender, RoutedEventArgs e)
        {
            //vorige liedje in de afspeellijst
            ltbAfspeellijst.SelectedIndex += - 1;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem delete = new ListBoxItem();
            ltbAfspeellijst.SelectedItems.Remove(delete);
            player.settings.mute = true;
        }
            
    }
}
