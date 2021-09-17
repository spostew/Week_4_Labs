/*
 * Lab_2: This program will ask the user a series of questions to determine if they need a new lamp. For each answer the user gives
 *        the program will return a new question until they reach the end
 * Name: Spencer Unitt
 * Module: Week_4_Labs, Lab_2
 * 
 * Algorithm:
 *  1. Show a welcome screen explained to user what the program will do.
 *  2. Ask the user if they need a new lamp
 *  3. Prompt the user for yes or no answer with Y or N
 *  4. If user types N then tell them to plug in the lamp and exit program
 *  5. Otherwise if user types Y then ask if the bulb is burned out
 *  6. If the user enters N again then say it's time to get a new lamp and exit program
 *  7. Otherwise if user types Y then tell them to replace the bulb and exit the program
 *  
 *  If the user enters anything other than "Y" or "N" throw invalid reponse error and exit program*  
 * 
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection;

            // Displays what the program does to the user and prompts for response.
            Console.WriteLine("I'll determine if you need a new lamp or not.");
            Console.WriteLine("Type N for no or Y for yes");
            Console.WriteLine("So your lamp doesn't work? Did you plug it in?");
            selection = Console.ReadLine();
            // If the user types a lower y or n by mistake this will convert it to uppercase
            selection = selection.ToUpper();

            
            if(selection == "Y")
            {
                // If the selection is Y this ask a follow up question
                Console.WriteLine("Is the Lightbulb burned out?");
                selection = Console.ReadLine();
                selection = selection.ToUpper();

                // If the user enters Y or N then display the results in the code block and exit the program
                // The read line will wait for the user to click elsewhere so the program can explain the next step
                if(selection == "Y")
                {
                    Console.WriteLine("Try to replace the bulb first");
                    Console.ReadLine();
                }
                else if(selection == "N")
                {
                    Console.WriteLine("Time to get a new lamp!");
                    Console.ReadLine();
                }

            }
            // If the result is false in the first if then check if value equals "N" 
            else if(selection == "N")
            {
                Console.WriteLine("Try plugging in the lamp first and try again.");
                Console.ReadLine();
            }
            // If "Y" or "N" is not entered then throw error and exit
            else
            {
                Console.WriteLine("That input is not valid, try again.");
                Console.ReadLine();
            }


        }
    }
}
