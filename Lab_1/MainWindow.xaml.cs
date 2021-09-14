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

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            // Returns the data from the textboxes 
            String first_name = firstNameTextBox.Text,
                   last_name = lastNameTextbox.Text, 
                   pig_First, pig_Last;
            // Sets the strings to lowercase
            first_name = first_name.ToLower();
            last_name = last_name.ToLower();

            pig_First = first_name.Substring(1, first_name.Length - 1) + first_name.Substring(0, 1) + "ay";
            pig_First = pig_First.Substring(0, 1).ToUpper() + pig_First.Substring(1, pig_First.Length - 1);

            pig_Last = last_name.Substring(1, last_name.Length - 1) + last_name.Substring(0, 1) + "ay";
            pig_Last = pig_Last.Substring(0, 1).ToUpper() + pig_Last.Substring(1, pig_Last.Length - 1);

            MessageBox.Show("Your name in piglatin is: " + pig_First + " " + pig_Last);

        }
    }
}
