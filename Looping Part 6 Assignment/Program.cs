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
                Console.WriteLine("3 - Odd Sum");
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
                    Prompter();
                }
                else if (choice == "2")
                {                    
                    Console.WriteLine("You chose Precent Passing");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    PrecentPassing();
                }  
                else if (choice == "3")
                {
                    Console.WriteLine("You chose Odd Sum");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    OddSum();
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
            double maxValue, value;
            string _minValue;
            double minValue;
            Console.Clear();
            Console.WriteLine("Chose two numbers:");
            Console.WriteLine("Min Value:");
            _minValue = Console.ReadLine();
            if (Int32.TryParse(_minValue, out int result))
            {
                minValue = Convert.ToDouble(_minValue);
                do
                {
                    Console.WriteLine("Max Value:");
                    maxValue = Convert.ToDouble(Console.ReadLine());
                    if (maxValue >= minValue)
                    {
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number above min value");
                    }
                }
                while (!done);
                done = false;
                do
                {
                    Console.WriteLine($"Enter a number within {minValue} and {maxValue}");
                    value = Convert.ToDouble(Console.ReadLine());
                    if (value <= maxValue && value >= minValue)
                    {                     
                        Console.WriteLine("Great job");
                        Console.ReadLine();
                        done = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }
                }
                while (!done);
            }
            else
            {
                Console.WriteLine("Error: Run Program Again");
                Console.ReadLine();
            }                      
        }

        public static void PrecentPassing()
        {
            Console.Clear();
            bool done = false;
            string score;
            int _score;
                Console.WriteLine("                       ----Precent-Passing----                    ");
                Console.WriteLine("Enter a set of scores and I will tell you the precentage above 70%");
            int sumOfPScores = 0;
            int sumOfScores = 0;
            while (!done)
            {
                Console.WriteLine("Enter a score:");
                score = (Console.ReadLine());
                score = score.Replace("%", "");
                _score = Convert.ToInt32(score);               
                if (_score >= 70)
                {                    
                    sumOfPScores = sumOfPScores + 1;
                }
                else
                {
                    sumOfScores = sumOfScores + 1;
                }
                Console.WriteLine("Done entering scores: 1");
                Console.WriteLine("Not done entering scores: 2");
                string input = Console.ReadLine();
                
                if (input == "1")
                {
                    done = true;
                }                   
                else if (input == "2")
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
        public static void OddSum()
        {
            Console.Clear();
            bool done = false;
            string _number;
            int number;
            int numOfNumbers = 0;
            Console.WriteLine("----Odd-Sum----");
            Console.WriteLine("Enter a number:");
            _number = Console.ReadLine();
            if (Int32.TryParse(_number, out int result))
            {
                number = Convert.ToInt32(_number);
                if (number % 2 != 0)
                {
                    numOfNumbers = number + numOfNumbers;
                    while (done == false)
                    {
                        number = number - 2;
                        numOfNumbers = number + numOfNumbers;
                        if (number != 0)
                        {
                            done = true;
                        }
                    }                    
                    Console.WriteLine(numOfNumbers);
                    Console.ReadLine();
                }
                else if (number % 2 == 0)
                {
                    numOfNumbers = number - 1;
                    numOfNumbers = number + numOfNumbers;
                    while (done == false)
                    {
                        number = number - 2;
                        numOfNumbers = number + numOfNumbers;
                        if (number != 0)
                        {
                            done = true;
                        }
                    }
                    Console.WriteLine(numOfNumbers);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Error: Run Program Again");
                } 
            }
            else
            {
                Console.WriteLine("Error: Run Program Again");
                Console.ReadLine();
            }
        }
        public static void RandomNumbers()
        {
            Console.Clear();
            Random generator = new Random();
            bool done = false;
            double maxValue;
            string _minValue;
            double minValue;
            Console.WriteLine("----Random-Numbers----");
            Console.WriteLine("Enter a minimum value:");
            _minValue = Console.ReadLine();
            if (Int32.TryParse(_minValue, out int result))
            {
                minValue = Convert.ToDouble(_minValue);
                do
                {
                Console.WriteLine("Max Value:");
                maxValue = Convert.ToDouble(Console.ReadLine());
                if (maxValue >= minValue)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("Enter a number above min value");
                }
            }
            while (!done);

        }
    }
}