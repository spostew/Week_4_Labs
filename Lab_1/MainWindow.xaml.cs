/*
    Lab_2: This program will take a standard name and convert it to pig latin
    Name: Spencer Unitt
    Module: Lab_2, Part1
    Problem Statement: Use pig latin to alter your first and last name
    Algorithm:
        1. Create two strings named first and last and set them = to your name
        2. Move the first char from the first string and last string to the back
        3. In a new string named full, concatinate the strings together and set the
           first char to uppercase
        4. Write the result to the console.
        
*/

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

  

        private void pigLatinButton_Click(object sender, RoutedEventArgs e)
        {
            // Returns the data from the textboxes 
            String first_name = firstNameTextBox.Text,
                   last_name = lastNameTextbox.Text, 
                   pig_First, pig_Last, pig = "ay";
            // Sets the strings to lowercase
            first_name = first_name.ToLower();
            last_name = last_name.ToLower();

            // Takes in the first name and rearranges the letters while also adding "ay" to the end
            pig_First = first_name.Substring(1, first_name.Length - 1) + first_name.Substring(0, 1) + pig;
            pig_First = pig_First.Substring(0, 1).ToUpper() + pig_First.Substring(1, pig_First.Length - 1);

            // Does the same thing as the first name but to the last name instead
            pig_Last = last_name.Substring(1, last_name.Length - 1) + last_name.Substring(0, 1) + pig;
            pig_Last = pig_Last.Substring(0, 1).ToUpper() + pig_Last.Substring(1, pig_Last.Length - 1);

            // Displays the results in a messagebox
            MessageBox.Show("Your name in piglatin is: " + pig_First + " " + pig_Last);

        }
    }
}
