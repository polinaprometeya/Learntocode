using System.ComponentModel;
using System.Windows;
using fwflClassLib;
using Microsoft.Win32;

namespace wordsGUIWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public int _percent = 0; // percent global variable
        bool _IsIndeterminate = false; // ahhhh ?? Is it still going?

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
            //fwflClassLib.FiveWordFiveLetterClass gettingSomeWordSets = new FiveWordFiveLetterClass("C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FiveWordFiveLetters\\newBeta.txt");
            this.DataContext = this; //This is usually forgotten? Husk :D
        }


        ////This is listener? Listen to an event? -- step 4 --
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{

        //    int MaxPercent = 100; // set max value
        //    _IsIndeterminate = true; //is it still going??
        //    //SearchThread searchThread = new SearchThread("TestFile");
        //    //searchThread.SearchIndex += SearchThread_SearchIndex; //Add event handler
        //    //await searchThread.DoWork();
        //}

        // Handle event -- Method that is listening to event? -- step 5 --
        
        private void SearchThread_SearchIndex(object? sender, int e)
        {
            if (_IsIndeterminate) _IsIndeterminate = false; //is it still going??
            Percent = e; //get the percent
        }


        //private async void WordCountSlider_Select(object sender, RoutedEventArgs e)
        //{
        //    int wordLength = 5;

        //}



        // This activates when the buttom clicked File Picker Button Click Handler
        private async void FilePickerButton_Click(object sender, RoutedEventArgs e)
        {
            // Open file dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            int wordCount = 5;


            openFileDialog.Filter = "All Files (*.*)|*.*"; // Specify file filter
            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;
                MessageBox.Show($"File Selected");
                
                fwflClassLib.FiveWordFiveLetterClass gettingSomeWordSets = new FiveWordFiveLetterClass(selectedFilePath);
                gettingSomeWordSets.SearchIndex += SearchThread_SearchIndex;
                await gettingSomeWordSets.DoWork();
                double runtimeSeconds = ((gettingSomeWordSets._runtime) / 1000);
                MessageBox.Show($"{gettingSomeWordSets._solutions.Count} solutions found with: {runtimeSeconds} sekonds runtime");
            }
        }

    }
}
