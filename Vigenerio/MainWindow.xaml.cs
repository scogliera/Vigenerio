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

namespace Vigenerio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Setting string Placeholders and a text/password variable
        string enterPassword = "Enter a password!";
        string enterText = "Enter some text!";
        string typeText = "Enter a sentence to encrypt/decrypt...";
        string typePassword = "Password";

        string text = "";
        string password = "";
        string result = "";

        //Setting booleons to figure out if the program has just started (notAutoStart) and what mode does the user want (encryption)
        private bool notAutoStart = false;
        private bool encryption = true;

        //Setting booleons for visual XAML part of app
        private bool textPlaceholder = true;
        private bool textLostFocus = false;
        private bool passwordPlaceholder = true;
        private bool passwordLostFocus = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindColor(bool placeholder, TextBox textBox)
        {
            //Code to color text dark grey if placeholder appears and white when user starts typing
            BrushConverter bc = new BrushConverter();
            textBox.Foreground = placeholder ? (Brush)bc.ConvertFrom("#777777") : (Brush)bc.ConvertFrom("#ffffff");
        }

        private void Kouzlo(bool encryption)
        {
            //Crating new variables for edited password and calculating how many times should password repeat until the length is the same as the text length
            string newPass = "";
            double completePass = text.Length / password.Length;
            
            //Repeating password until length matches text length
            for (int i = 0; i < Math.Floor(completePass); i++)
            {
                for (int x = 0; x < password.Length; x++)
                {
                    newPass += password[x];
                }
            }

            //If edited password length still doesn't match text length (completePass had a non 0 floating point), adding characters one by one to newPass until length matches
            if (newPass.Length != text.Length && newPass.Length < text.Length)
            {
                for (int i = 0; newPass.Length < text.Length; i++)
                {
                    newPass += password[i];
                    if (i == password.Length)
                    {
                        break;
                    }
                }
            }

            

            //Setting a string variable to store the result text and int variable to store ASCII values
            result = "";
            int key;

            //Calculating ASCII values depending on if encryption or decryption radio button is selected, then showing the result on screen
            for (int i = 0; i < text.Length; i++)
            {
                key = encryption ? (int)text[i] + (int)newPass[i] - 96 : (int)text[i] - (int)newPass[i] + 96;
                result += (char)key;
            }
            ResultTextBlock.Text = result;
        }

        private void TextTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            //Deleting placeholder text when TextBox clicked
            notAutoStart = true;

            if (textPlaceholder)
            {
                TextTextBox.Text = "";
            }
        }

        private void TextTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            //Copy pasting TextBox contents to the TextBlock display and encryption/decryption starter
            if (notAutoStart && TextTextBox.Text != "" && textLostFocus != true)
            {
                TextTextBlock.Text = TextTextBox.Text;
                text = TextTextBox.Text;
                textPlaceholder = false;
            }
            else if (notAutoStart && textLostFocus != true)
            {
                TextTextBlock.Text = "";
            }

            textLostFocus = false;
            FindColor(textPlaceholder, TextTextBox);

            if (text.Length != 0 && password.Length != 0)
            {
                Kouzlo(encryption);
            }
        }

        private void TextTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //Checking if TextTextBox is empty to enter placeholders
            textLostFocus = true;

            if (TextTextBox.Text == "")
            {
                TextTextBlock.Text = enterText;
                TextTextBox.Text = typeText;
                text = "";
                textPlaceholder = true;
            }
            FindColor(textPlaceholder, TextTextBox);
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            //Deleting placeholder text when TextBox clicked
            notAutoStart = true;

            if (passwordPlaceholder)
            {
                PasswordTextBox.Text = "";
            }
        }

        private void PasswordTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            if (notAutoStart && PasswordTextBox.Text != "" && passwordLostFocus != true)
            {
                PasswordTextBlock.Text = PasswordTextBox.Text;
                password = PasswordTextBox.Text;
                passwordPlaceholder = false;
            }
            else if (notAutoStart && passwordLostFocus != true)
            {
                PasswordTextBlock.Text = "";
            }

            passwordLostFocus = false;
            FindColor(passwordPlaceholder, PasswordTextBox);

            if (text.Length != 0 && password.Length != 0)
            {
                Kouzlo(encryption);
            }
        }

        private void PasswordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            ////Checking if PasswordTextBox is empty to enter placeholders
            passwordLostFocus = true;

            if (PasswordTextBox.Text == "")
            {
                PasswordTextBlock.Text = enterPassword;
                PasswordTextBox.Text = typePassword;
                password = "";
                passwordPlaceholder = true;
            }
            FindColor(passwordPlaceholder, PasswordTextBox);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Enabling clicking out of Text Boxes
            Border.Focus();
        }

        private void EncryptRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //When Encryption radio button checked, everyting gets resetted to default values and user can encrypt text
            encryption = true;

            if (notAutoStart)
            {
                TextTextBlock.Text = enterText;
                TextTextBox.Text = typeText;
                PasswordTextBlock.Text = enterPassword;
                PasswordTextBox.Text = typePassword;
                text = "";
                password = "";
                ResultTextBlock.Text = "";
                textPlaceholder = true;
                passwordPlaceholder = true;
                FindColor(textPlaceholder, TextTextBox);
                FindColor(passwordPlaceholder, PasswordTextBox);
            }
        }

        private void DecryptRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //When Decryption radio button checked, everyting gets resetted to default values and user can decrypt text
            encryption = false;

            if (notAutoStart)
            {
                TextTextBlock.Text = enterText;
                TextTextBox.Text = typeText;
                PasswordTextBlock.Text = enterPassword;
                PasswordTextBox.Text = typePassword;
                text = "";
                password = "";
                ResultTextBlock.Text = "";
                textPlaceholder = true;
                passwordPlaceholder = true;
                FindColor(textPlaceholder, TextTextBox);
                FindColor(passwordPlaceholder, PasswordTextBox);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(result);
        }
    }
}
