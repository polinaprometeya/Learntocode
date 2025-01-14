using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using fwflClassLib;
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;

namespace wordsGUIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int _percent = 0; // percent global variable

        ////nedarv INotifyPropertyChanged -PropertyChanged is event name -- step 2 --
        public event PropertyChangedEventHandler? PropertyChanged;

        ////Call the event -- step 3 --
        protected void NotifyPropertyChnage(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        ////This binding to to percent bar. Binding method called . Value = "{Binding Percent, UpdateSourceTrigger=PropertyChnaged}"
        public int Percent
        {
            get { return _percent; }
            set { _percent = value; NotifyPropertyChnage("Percent"); }
        }


        public MainWindow()
        {
            InitializeComponent();

            fwflClassLib.FiveWordFiveLetterClass gettingSomeWordSets = new FiveWordFiveLetterClass("C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FiveWordFiveLetters\\newBeta.txt");
            this.DataContext = this; //This is usually forgotten? Husk :D
        }



        ////This is listener? Listen to an event? -- step 4 --
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{

        //    MaxPercent = 100; // set max value
        //    IsIndeterminate = true; //there is 
        //    SearchThread searchThread = new SearchThread("TestFile");
        //    searchThread.SearchIndex += SearchThread_SearchIndex; //Add event handler
        //    await searchThread.DoWork();
        //}

        //// Handle event -- Method that is listening to event? -- step 5 --
        //private void SearchThread_SearchIndex(object? sender, int e)
        //{
        //    if (IsIndeterminate) IsIndeterminate = false;
        //    Percent = e;
        //}




        // Deal with this -- File Picker Button Click Handler
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

        //// Deal with this -- Reset Button Click Handler
        //private void ResetButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Reset sliders to initial values
        //    Slider1.Value = 0;
        //    Slider2.Value = 0;
        //}
    }
}
