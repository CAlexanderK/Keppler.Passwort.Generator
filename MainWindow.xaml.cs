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

namespace Keppler.Passwort.Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool _numberTrueOrFalse;
        public bool _letterBigTrueOrFalse;
        public bool _letterSmallTrueOrFalse;
        public bool _specialCharacterTrueOrFalse;

        public int _number;
        public string _character;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void cbCaseOne_Checked(object sender, RoutedEventArgs e)
        {
            _numberTrueOrFalse = true;
        }

        public void cbCaseOne_Unchecked(object sender, RoutedEventArgs e)
        {
            _numberTrueOrFalse = false;
        }

        public void cbCaseTwo_Checked(object sender, RoutedEventArgs e)
        {
            _letterBigTrueOrFalse = true;
        }

        public void cbCaseTwo_Unchecked(object sender, RoutedEventArgs e)
        {
            _letterBigTrueOrFalse = false;
        }

        public void cbCaseThree_Checked(object sender, RoutedEventArgs e)
        {
            _letterSmallTrueOrFalse = true;
        }

        public void cbCaseThree_Unchecked(object sender, RoutedEventArgs e)
        {
            _letterSmallTrueOrFalse = false;
        }

        public void cbCaseFour_Checked(object sender, RoutedEventArgs e)
        {
            _specialCharacterTrueOrFalse = true;
        }

        public void cbCaseFour_Unchecked(object sender, RoutedEventArgs e)
        {
            _specialCharacterTrueOrFalse = false;
        }


    }
}