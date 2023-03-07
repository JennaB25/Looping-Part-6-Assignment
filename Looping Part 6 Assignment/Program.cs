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
        public static void Prompter()
        {
            bool done = false;
            double maxValue, minValue, value;
            Console.Clear();
            Console.WriteLine("Chose two numbers:");
            Console.WriteLine("Min Value:");
            minValue = Convert.ToDouble(Console.ReadLine());

            //max value problem
            Console.WriteLine("Max Value:");          
            maxValue = Convert.ToDouble(Console.ReadLine()); 
            
      
            do
            {
                Console.WriteLine("Enter a number within the previous values:");
                value = Convert.ToDouble(Console.ReadLine());
                if (//a valid number)
                {
                    done = true;
                    Console.WriteLine("Great job");
                }
                else
                {
                    //try again
                }
            }
            while (!done);

            
            //else
            //{
                //Console.WriteLine("Error: Invalid Input");
            //}
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
                int sumOfPScores = 0;
                int sumOfScores = 0;
                if (_score >= 70)
                {                    
                    sumOfPScores = sumOfPScores + 1;
                }
                else
                {
                    sumOfScores = sumOfScores + 1;
                }
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
            //Console.WriteLine($"Final average is: {sumOfPScores / sumOfScores}%");
            //Console.ReadLine();
        }
        public static void oddSum()
        {
            //
        }
            
    }
}