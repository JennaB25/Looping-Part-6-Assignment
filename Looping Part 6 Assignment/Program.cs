using System.Transactions;

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
            double maxValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a number within the previous values:");
            double value = Convert.ToDouble(Console.ReadLine());
            while (value < minValue || value > maxValue)
            {
                Console.WriteLine("Try Again");
            }            
        }
    }
}