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

        public int _number = 0;
        public string _character = "";

        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        public string GeneratingPasswordCharacterASCII(int number) 
        {
            // Anfang der Abfragen mit den Zahlen
            if (number == 48)
            {
                return "0";
            }
            else if (number == 49)
            {
                return "1";
            }
            else if (number == 50)
            {
                return "2";
            }
            else if (number == 51)
            {
                return "3";
            }
            else if (number == 52)
            {
                return "4";
            }
            else if (number == 53)
            {
                return "5";
            }
            else if (number == 54)
            {
                return "6";
            }
            else if (number == 55)
            {
                return "7";
            }
            else if (number == 56)
            {
                return "8";
            }
            else if (number == 57)
            {
                return "9";
            }
            // Ende Zahlen Anfang Großbuchstaben
            else if (number == 65)
            {
                return "A";
            }
            else if (number == 66)
            {
                return "B";
            }
            else if (number == 67)
            {
                return "C";
            }
            else if (number == 68)
            {
                return "D";
            }
            else if (number == 69)
            {
                return "E";
            }
            else if (number == 70)
            {
                return "F";
            }
            else if (number == 71)
            {
                return "G";
            }
            else if (number == 72)
            {
                return "H";
            }
            else if (number == 73)
            {
                return "I";
            }
            else if (number == 74)
            {
                return "J";
            }
            else if (number == 75)
            {
                return "K";
            }
            else if (number == 76)
            {
                return "L";
            }
            else if (number == 77)
            {
                return "M";
            }
            else if (number == 78)
            {
                return "N";
            }
            else if (number == 79)
            {
                return "O";
            }
            else if (number == 80)
            {
                return "P";
            }
            else if (number == 81)
            {
                return "Q";
            }
            else if (number == 82)
            {
                return "R";
            }
            else if (number == 83)
            {
                return "S";
            }
            else if (number == 84)
            {
                return "T";
            }
            else if (number == 85)
            {
                return "U";
            }
            else if (number == 86)
            {
                return "V";
            }
            else if (number == 87)
            {
                return "W";
            }
            else if (number == 88)
            {
                return "X";
            }
            else if (number == 89)
            {
                return "Y";
            }
            else if (number == 90)
            {
                return "Z";
            }
            // Ende Großbuchstaben Anfang Kleinbuchstaben
            else if (number == 97)
            {
                return "a";
            }
            else if (number == 98)
            {
                return "b";
            }
            else if (number == 99)
            {
                return "c";
            }
            else if (number == 100)
            {
                return "d";
            }
            else if (number == 101)
            {
                return "e";
            }
            else if (number == 102)
            {
                return "f";
            }
            else if (number == 103)
            {
                return "g";
            }
            else if (number == 104)
            {
                return "h";
            }
            else if (number == 105)
            {
                return "i";
            }
            else if (number == 106)
            {
                return "j";
            }
            else if (number == 107)
            {
                return "k";
            }
            else if (number == 108)
            {
                return "l";
            }
            else if (number == 109)
            {
                return "m";
            }
            else if (number == 110)
            {
                return "n";
            }
            else if (number == 111)
            {
                return "o";
            }
            else if (number == 112)
            {
                return "p";
            }
            else if (number == 113)
            {
                return "q";
            }
            else if (number == 114)
            {
                return "r";
            }
            else if (number == 115)
            {
                return "s";
            }
            else if (number == 116)
            {
                return "t";
            }
            else if (number == 117)
            {
                return "u";
            }
            else if (number == 118)
            {
                return "v";
            }
            else if (number == 119)
            {
                return "w";
            }
            else if (number == 120)
            {
                return "x";
            }
            else if (number == 121)
            {
                return "y";
            }
            else if (number == 122)
            {
                return "z";
            }
            // Ende Kleinbuchstaben Anfang Sonderzeichen
            else if (number == 33)
            {
                return "!";
            }
            else if (number == 34)
            {
                // Fall nachfragen "
                return "";
            }
            else if (number == 35)
            {
                return "#";
            }
            else if (number == 36)
            {
                return "$";
            }
            else if (number == 37)
            {
                return "%";
            }
            else if (number == 38)
            {
                return "&";
            }
            else if (number == 39)
            {
                return "'";
            }
            else if (number == 40)
            {
                return "(";
            }
            else if (number == 41)
            {
                return ")";
            }
            else if (number == 42)
            {
                return "*";
            }
            else if (number == 43)
            {
                return "+";
            }
            else if (number == 44)
            {
                return ",";
            }
            else if (number == 45)
            {
                return "-";
            }
            else if (number == 46)
            {
                return ".";
            }
            else if (number == 47)
            {
                return "/";
            }
            else if (number == 58)
            {
                return ":";
            }
            else if (number == 59)
            {
                return ";";
            }
            else if (number == 60)
            {
                return "<";
            }
            else if (number == 61)
            {
                return "=";
            }
            else if (number == 62)
            {
                return ">";
            }
            else if (number == 63)
            {
                return "?";
            }
            else if (number == 64)
            {
                return "@";
            }
            else if (number == 91)
            {
                return "[";
            }
            else if (number == 92)
            {
                // Fall nachfragen \
                return "";
            }
            else if (number == 93)
            {
                return "]";
            }
            else if (number == 94)
            {
                return "^";
            }
            else if (number == 95)
            {
                return "_";
            }
            else if (number == 96)
            {
                return "`";
            }
            else if (number == 123)
            {
                return "{";
            }
            else if (number == 124)
            {
                return "|";
            }
            else if (number == 125)
            {
                return "}";
            }
            else if (number == 126)
            {
                return "~";
            }
            else
            {
                // Abschlussfall, damit alle möglichen Fälle einen Wert liefern, auch wenn dieser leer ist.
                return "";
            }
        }

        public string GeneratePasswort(int _switch) 
        {
            string _character = "";

            switch (_switch)
            {
                case 0: // 0000
                    break;
                case 1: // 0001
                    int number1 = random.Next(1,5);
                    if (number1 == 1)
                    {
                        number1 = random.Next(33,48);
                        _character = GeneratingPasswordCharacterASCII(number1);
                    }
                    else if (number1 == 2)
                    {
                        number1 = random.Next(58,65);
                        _character = GeneratingPasswordCharacterASCII(number1);
                    }
                    else if (number1 == 3)
                    {
                        number1 = random.Next(91,97);
                        _character = GeneratingPasswordCharacterASCII(number1);
                    }
                    else if (number1 == 4)
                    {
                        number1 = random.Next(123,127);
                        _character = GeneratingPasswordCharacterASCII(number1);
                    }
                    break;
                case 2: // 0010
                    int number2 = random.Next(97,123);
                    _character = GeneratingPasswordCharacterASCII(number2);
                    break;
                case 3: // 0011
                    int number3 = random.Next(1, 4);
                    if (number3 == 1)
                    {
                        int number31 = random.Next(33,48);
                        _character = GeneratingPasswordCharacterASCII(number31);
                    }
                    else if (number3 == 2)
                    {
                        int number32 = random.Next(58,65);
                        _character = GeneratingPasswordCharacterASCII(number32);
                    }
                    else if (number3 == 3)
                    {
                        int number33 = random.Next(91,127);
                        _character = GeneratingPasswordCharacterASCII(number33);
                    }
                    break;
                case 4: // 0100
                    int number4 = random.Next(65,91);
                    _character = GeneratingPasswordCharacterASCII(number4);
                    break;
                case 5: // 0101
                    int number5 = random.Next(1,4);
                    if (number5 == 1)
                    {
                        int number51 = random.Next(33,48);
                        _character = GeneratingPasswordCharacterASCII(number51);
                    }
                    else if (number5 == 2)
                    {
                        int number52 = random.Next(58,97);
                        _character = GeneratingPasswordCharacterASCII(number52);
                    }
                    else if (number5 == 3)
                    {
                        int number53 = random.Next(123,127);
                        _character = GeneratingPasswordCharacterASCII(number53);
                    }
                    break;
                case 6: // 0110
                    int number6 = random.Next(1, 3);
                    if (number6 == 1)
                    {
                        int number61 = random.Next(65, 91);
                        _character = GeneratingPasswordCharacterASCII(number61);
                    }
                    else if (number6 == 2)
                    {
                        int number62 = random.Next(97, 123);
                        _character = GeneratingPasswordCharacterASCII(number62);
                    }
                    break;
                case 7: // 0111
                    int number7 = random.Next(1,3);
                    if (number7 == 1)
                    {
                        int number71 = random.Next(33,48);
                        _character = GeneratingPasswordCharacterASCII(number71);
                    }
                    else if (number7 == 2)
                    {
                        int number72 = random.Next(58,127);
                        _character = GeneratingPasswordCharacterASCII(number72);
                    }
                    break;
                case 8: // 1000
                    int number8 = random.Next(48,58);
                    _character = GeneratingPasswordCharacterASCII(number8);
                    break;
                case 9: // 1001
                    int number9 = random.Next(1, 4);
                    if (number9 == 1)
                    {
                        int number91 = random.Next(33,65);
                        _character = GeneratingPasswordCharacterASCII(number91);
                    }
                    else if (number9 == 2)
                    {
                        int number92 = random.Next(91,97);
                        _character = GeneratingPasswordCharacterASCII(number92);
                    }
                    else if (number9 == 3)
                    {
                        int number93 = random.Next(123,127);
                        _character = GeneratingPasswordCharacterASCII(number93);
                    }
                    break;
                case 10: // 1010
                    int number10 = random.Next(1, 3);
                    if (number10 == 1)
                    {
                        int number101 = random.Next(48,58);
                        _character = GeneratingPasswordCharacterASCII(number101);
                    }
                    else if (number10 == 2)
                    {
                        int number102 = random.Next(97,123);
                        _character = GeneratingPasswordCharacterASCII(number102);
                    }
                    break;
                case 11: // 1011
                    int number11 = random.Next(1, 3);
                    if (number11 == 1)
                    {
                        int number111 = random.Next(33,65);
                        _character = GeneratingPasswordCharacterASCII(number111);
                    }
                    else if (number11 == 2)
                    {
                        int number112 = random.Next(91,127);
                        _character = GeneratingPasswordCharacterASCII(number112);
                    }
                    break;
                case 12: // 1100
                    int number12 = random.Next(1, 3);
                    if (number12 == 1)
                    {
                        int number121 = random.Next(48,58);
                        _character = GeneratingPasswordCharacterASCII(number121);
                    }
                    else if (number12 == 2)
                    {
                        int number122 = random.Next(65,91);
                        _character = GeneratingPasswordCharacterASCII(number122);
                    }
                    break;
                case 13: // 1101
                    int number = random.Next(1, 3);
                    if (number == 1)
                    {
                        number = random.Next(33,97);
                        _character = GeneratingPasswordCharacterASCII(number);
                    }
                    else if (number == 2)
                    {
                        number = random.Next(123,127);
                        _character = GeneratingPasswordCharacterASCII(number);
                    }
                    break;
                case 14: // 1110
                    int number14 = random.Next(1, 4);
                    if (number14 == 1)
                    {
                        int number141 = random.Next(48,58);
                        _character = GeneratingPasswordCharacterASCII(number141);
                    }
                    else if (number14 == 2)
                    {
                        int number142 = random.Next(65,91);
                        _character = GeneratingPasswordCharacterASCII(number142);
                    }
                    else if (number14 == 3)
                    {
                        int number143 = random.Next(97,123);
                        _character = GeneratingPasswordCharacterASCII(number143);
                    }
                    break;
                case 15: // 1111
                    int number15 = random.Next(33,127);
                    _character = GeneratingPasswordCharacterASCII(number15);
                    break;
                default:

                    break;
            }
            return _character;
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

        private void btn_Generate_Click(object sender, RoutedEventArgs e)
        {
            int _amount = Convert.ToInt32(txt_Amount.Text);

            txt_GeneratedPassword.Text = string.Empty;

            if (false) // noch überarbeiten!!!
            {
                
            }
            else 
            {
                for (int index = 0; index < _amount; index++)
                {
                    int _switch = 0;   
                    
                    if (!_numberTrueOrFalse && !_letterBigTrueOrFalse && !_letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse) // 0000 = 0
                    {
                        _switch = 0;
                    }
                    else if (!_numberTrueOrFalse && !_letterBigTrueOrFalse && !_letterSmallTrueOrFalse && _specialCharacterTrueOrFalse) // 0001 = 1
                    {
                        _switch = 1;
                    }
                    else if (!_numberTrueOrFalse && !_letterBigTrueOrFalse && _letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse) // 0010 = 2
                    {
                        _switch = 2;
                    }
                    else if (!_numberTrueOrFalse && !_letterBigTrueOrFalse && _letterSmallTrueOrFalse && _specialCharacterTrueOrFalse)
                    {
                        _switch = 3;
                    }
                    else if (!_numberTrueOrFalse && _letterBigTrueOrFalse && !_letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse)
                    {
                        _switch = 4;
                    }
                    else if (!_numberTrueOrFalse && _letterBigTrueOrFalse && !_letterSmallTrueOrFalse && _specialCharacterTrueOrFalse)
                    {
                        _switch = 5;
                    }
                    else if (!_numberTrueOrFalse && _letterBigTrueOrFalse && _letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse)
                    {
                        _switch = 6;
                    }
                    else if (!_numberTrueOrFalse && _letterBigTrueOrFalse && _letterSmallTrueOrFalse && _specialCharacterTrueOrFalse)
                    {
                        _switch = 7;
                    }
                    else if (_numberTrueOrFalse && !_letterBigTrueOrFalse && !_letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse)
                    {
                        _switch = 8;
                    }
                    else if (_numberTrueOrFalse && !_letterBigTrueOrFalse && !_letterSmallTrueOrFalse && _specialCharacterTrueOrFalse)
                    {
                        _switch = 9;
                    }
                    else if (_numberTrueOrFalse && !_letterBigTrueOrFalse && _letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse)
                    {
                        _switch = 10;
                    }
                    else if (_numberTrueOrFalse && _letterBigTrueOrFalse && _letterSmallTrueOrFalse && _specialCharacterTrueOrFalse)
                    {
                        _switch = 11;
                    }
                    else if (_numberTrueOrFalse && _letterBigTrueOrFalse && !_letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse)
                    {
                        _switch = 12;
                    }
                    else if (_numberTrueOrFalse && _letterBigTrueOrFalse && !_letterSmallTrueOrFalse && _specialCharacterTrueOrFalse)
                    {
                        _switch = 13;
                    }
                    else if (_numberTrueOrFalse && _letterBigTrueOrFalse && _letterSmallTrueOrFalse && !_specialCharacterTrueOrFalse)
                    {
                        _switch = 14;
                    }
                    else if (_numberTrueOrFalse && _letterBigTrueOrFalse && _letterSmallTrueOrFalse && _specialCharacterTrueOrFalse)
                    {
                        _switch = 15;
                    }

                    string _character = GeneratePasswort(_switch);
                    txt_GeneratedPassword.Text = txt_GeneratedPassword.Text + _character;
                }

            }
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            _numberTrueOrFalse = false;
            _letterBigTrueOrFalse = false;
            _letterSmallTrueOrFalse = false;
            _specialCharacterTrueOrFalse = false;
            cb_CaseOne.IsChecked = false;
            cb_CaseTwo.IsChecked = false;
            cb_CaseThree.IsChecked = false;
            cb_CaseFour.IsChecked = false;
            txt_GeneratedPassword.Text = "";
        }

        public bool _errorMessageCheck()
        {
            bool _error = true;

            try 
            {
                
            }
            catch
            { }

            return _error;
        }
    }
}