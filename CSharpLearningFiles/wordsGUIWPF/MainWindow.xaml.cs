using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using fwflClassLib;
using Microsoft.Win32;

namespace wordsGUIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            fwflClassLib.FiveWordFiveLetterClass gettingSomeWordSets = new FiveWordFiveLetterClass("C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FiveWordFiveLetters\\newBeta.txt");
        }


        // File Picker Button Click Handler
        private void FilePickerButton_Click(object sender, RoutedEventArgs e)
        {
            // Open file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*"; // Specify file filter
            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;
                MessageBox.Show($"File Selected: {selectedFilePath}");
            }
        }

        // Reset Button Click Handler
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset sliders to initial values
            Slider1.Value = 0;
            Slider2.Value = 0;
        }
    }
}
