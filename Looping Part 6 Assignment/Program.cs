using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace Looping_Part_6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Precent Passing");
                Console.WriteLine("---------------");                
                Console.WriteLine("Q - Quit");
                Console.WriteLine();

                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                if (choice == "1")
                {                   
                    Console.WriteLine("You chose Prompter");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    prompter();
                }
                else if (choice == "2")
                {                    
                    Console.WriteLine("You chose Precent Passing");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    precentPassing();
                }                
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }         
        }
        public static void prompter()
        {
            Console.Clear();
            Console.WriteLine("Chose two numbers:");
            Console.WriteLine("Min Value:");
            double minValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Max Value:");
       //check that the max is bigger than min
       //add do while loop
            double maxValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number within the previous values:");
            double value = Convert.ToDouble(Console.ReadLine());
            while (value < minValue || value > maxValue)
            {
                Console.WriteLine("Try Again");
                //double value = Convert.ToDouble(Console.ReadLine());
            }
            if (value > minValue || value < maxValue)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Error: Invalid Input");
            }
        }

        public static void precentPassing()
        {
            Console.Clear();
            bool done = false;      
                Console.WriteLine("                       ----Precent-Passing----                    ");
                Console.WriteLine("Enter a set of scores and I will tell you the precentage above 70%");
            while (!done)
            {
                Console.WriteLine("Enter a score:");
                string score = (Console.ReadLine());
                score = score.Replace("%", "");
                int _score = Convert.ToInt32(score);
                Console.WriteLine("Done entering scores: One");
                Console.WriteLine("Not done entering scores: Two");
                string input = Console.ReadLine().ToUpper();
                
                if (input == "ONE")
                {
                    done = true;
                }                   
                else if (input == "TWO")
                {
                    while (false);
                }              
                else
                {
                    Console.WriteLine("Error: Invalid Input");
                }               
            }
            int sumOfScores;
            Console.WriteLine("test");
        }
    }
}