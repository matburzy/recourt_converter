using Microsoft.Win32;
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
using ReCourtConverter;

namespace ReCourtConverter
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Open { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Open = string.Empty;
            var fileLoadPath = string.Empty;
      
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Protokół audio rozprawy sądowej (*.oga)|*.oga;";
            if (openFileDialog.ShowDialog() == true)
                fileLoadPath = openFileDialog.FileName;
            label.Content = openFileDialog.FileName;
            

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MP3 (*.mp3)|*.mp3;";
            if (saveFileDialog.ShowDialog() == true)
              
             new NReco.VideoConverter.FFMpegConverter().ConvertMedia(Convert.ToString(label.Content), saveFileDialog.FileName, "mp3");
            MessageBox.Show("Konwersja zakończona sukcesem.");
        }
    }
}
