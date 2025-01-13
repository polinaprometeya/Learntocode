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

namespace wordListGUIWithWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //this is from interface name INotifyPropertyCHnaged -- find out where it is from
        protected void NotifyPropertyChange( string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //this is for the process bar. Global variable? Why though?
        private int _percent = 0;

        public int Percent {
            get { return _percent; } set { _percent = value; NotifyPropertyChnage("Percent"); }
}
        public MainWindow()
        {
            InitializeComponent(); //this is out of the box constructor stuff I guess
            this.DataContext = this; // this to pass some data and stuff.
        }

    }
}