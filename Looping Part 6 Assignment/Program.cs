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
                Console.WriteLine("4 - Random Numbers");
                Console.WriteLine("5 - Dice Game");
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
                else if (choice == "4")
                {
                    Console.WriteLine("You chose Random Numbers");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    RandomNumbers();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("You chose Dice Game");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    DiceGame();
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
            Console.WriteLine("----Prompter----");
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
            double sumOfPScores = 0;
            double sumOfScores = 0;
            while (!done)
            {
                Console.WriteLine("Enter a score:");
                score = (Console.ReadLine());
                score = score.Replace("%", "");
                if (Int32.TryParse(score, out int result))
                {
                    _score = Convert.ToInt32(score);
                    if (_score >= 70)
                    {
                        sumOfPScores = sumOfPScores + 1;
                    }
                    sumOfScores = sumOfScores + 1;
                    Console.WriteLine("Done entering scores: 1");
                    Console.WriteLine("Not done entering scores: 2");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        Console.WriteLine($"Final average is: {(sumOfPScores / sumOfScores) * 100}%");
                        Console.ReadLine();
                        done = true;
                    }
                    else if (input == "2")
                    {
                        //
                    }
                }
                else
                {
                    Console.WriteLine("Error: Run Program Again");
                    Console.ReadLine();
                }   
            }                 
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
                    Console.WriteLine("Odd Sum:");
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
            int maxValue;
            string _minValue;
            int minValue;
            int randomNum;
            Console.WriteLine("----Random-Numbers----");
            Console.WriteLine("Enter a minimum value:");
            _minValue = Console.ReadLine();
            if (Int32.TryParse(_minValue, out int result))
            {
                minValue = Convert.ToInt32(_minValue);
                do
                {
                    Console.WriteLine("Max Value:");
                    maxValue = Convert.ToInt32(Console.ReadLine());
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
                maxValue = maxValue + 1;
                Console.WriteLine("Random Numbers:");
                for (int i = 1; i <= 25; i++)
                {                   
                    randomNum = generator.Next(minValue, maxValue);                   
                    Console.Write(randomNum + " ");
                }
                Console.ReadLine();
            }
        }
        public static void DiceGame()
        {
            Console.Clear();
            bool done = false;
            double bankAccount = 100.00;
            Console.WriteLine("Dice Betting Game");
            Console.WriteLine("-----------------");
            Console.WriteLine("");           
            while (!done)
            {         
                if (bankAccount == 0)
                {
                    done = true;
                }
                Console.WriteLine("How much do you bet?");
                Console.WriteLine($"Bank Account: ${bankAccount}");
                Console.WriteLine("(If you want to quit type 'q')");
                string bet1 = Console.ReadLine();
                if (bet1 == "q")
                {
                    done = true;
                }
                bet1 = bet1.Replace("$", "");
                if (Int32.TryParse(bet1, out int result))
                {
                    double _bet1 = Convert.ToDouble(bet1);
                    if (_bet1 > bankAccount)
                    {
                        _bet1 = bankAccount;
                        Console.WriteLine($"Max fee reached: Bet set to ${bankAccount}");
                    }
                    else if (_bet1 < 0)
                    {
                        _bet1 = 0;
                        Console.WriteLine($"Invalid Number: Bet set to $0.00");
                    }
                    Console.WriteLine("Pick One:");
                    Console.WriteLine("      (Doubles)           (Not Doubles)       (Even Sum)      (Odd Sum)");
                    Console.WriteLine("(Win double your bet)  (Win half your bet)  (Win your bet)  (Win your bet)");
                    string optionOne = Console.ReadLine().ToUpper();
                    string doubles = "DOUBLES";
                    string notDoubles = "NOT DOUBLES";
                    string evenSum = "EVEN SUM";
                    string oddSum = "ODD SUM";                   
                    if (optionOne == doubles)
                    {
                        Console.WriteLine("Press Enter to roll the dice:");
                        Console.ReadLine();
                        Die die1 = new Die();
                        die1.DrawRoll();
                        Die die2 = new Die();
                        die2.DrawRoll();
                        if (die1.Equals(die2))
                        {
                            Console.WriteLine("Congratulations!");
                            Console.WriteLine($"You won: ${_bet1}");
                            bankAccount = (_bet1 * 2) + bankAccount;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Oh no you lost, try again.");
                            Console.WriteLine($"You lost: ${_bet1}");
                            bankAccount = bankAccount - _bet1;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (optionOne == notDoubles)
                    {
                        Console.WriteLine("Press Enter to roll the dice:");
                        Console.ReadLine();
                        Die die1 = new Die();
                        die1.DrawRoll();
                        Die die2 = new Die();
                        die2.DrawRoll();
                        if (die1.Roll != die2.Roll)
                        {
                            Console.WriteLine("Congratulations!");
                            Console.WriteLine($"You won: ${_bet1}");
                            bankAccount = (_bet1 / 2) + bankAccount;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Oh no you lost, try again.");
                            Console.WriteLine($"You lost: ${_bet1}");
                            bankAccount = bankAccount - _bet1;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (optionOne == evenSum)
                    {
                        Console.WriteLine("Press Enter to roll the dice:");
                        Console.ReadLine();
                        Die die1 = new Die();
                        die1.DrawRoll();
                        Die die2 = new Die();
                        die2.DrawRoll();
                        int _die1 = Convert.ToInt32(die1.Roll);
                        int _die2 = Convert.ToInt32(die2.Roll);
                        int sumOfDie = _die1 + _die2;
                        if (sumOfDie % 2 == 0)
                        {
                            Console.WriteLine("Congratulations!");
                            Console.WriteLine($"You won: ${_bet1}");
                            bankAccount = _bet1 + bankAccount;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Oh no you lost, try again.");
                            Console.WriteLine($"You lost: ${_bet1}");
                            bankAccount = bankAccount - _bet1;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (optionOne == oddSum)
                    {
                        Console.WriteLine("Press Enter to roll the dice:");
                        Console.ReadLine();
                        Die die1 = new Die();
                        die1.DrawRoll();
                        Die die2 = new Die();
                        die2.DrawRoll();
                        int _die1 = Convert.ToInt32(die1.Roll);
                        int _die2 = Convert.ToInt32(die2.Roll);
                        int sumOfDie = _die1 + _die2;
                        if (sumOfDie % 2 != 0)
                        {
                            Console.WriteLine("Congratulations!");
                            Console.WriteLine($"You won: ${_bet1}"); 
                            bankAccount = _bet1 + bankAccount;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Oh no you lost, try again.");
                            Console.WriteLine($"You lost: ${_bet1}");
                            bankAccount = bankAccount - _bet1;
                            Console.WriteLine($"Bank Account: ${bankAccount}");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid Input");
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid Input");
                    Console.Clear();
                }
            }
            
        }
    }
}