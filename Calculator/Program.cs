using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {

            while (true)
            {
                Console.WriteLine("Welcome to the Calculator\n");
                int operation = GetOperationFromUser();
                Console.Clear();
                double firstNumber = GetIntegerFromUser("Please enter the first number: ");
                Console.Clear();
                double secondNumber = GetIntegerFromUser("Please enter the second number: ", operation);
                Console.Clear();
                var result = CalculateResult(firstNumber, secondNumber, operation);


                if (result.Symbol != '?') // checks if errors has occured in previous step
                {
                    DisplayResult(firstNumber, result.Symbol, secondNumber, result.Result);
                }
            }

        }
        static void DisplayResult(double firstNumber, char symbol, double secondNumber, double result)
        {
            Console.Clear();
            string message = $"The result of {firstNumber} {symbol} {secondNumber} = {result:0..##}";
            Console.WriteLine(message);
            Console.WriteLine("\n\nPress any key to perform a new sum");
            Console.ReadLine();
            Console.Clear();
        }

        static int GetIntegerFromUser(string prompt, int operation = 0)
        {

            while (true)
            {
                Console.WriteLine(prompt);
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Please enter an integer.");
                }
                else if (number == 0 && operation == 4)
                {
                    Console.WriteLine("Cannot divide by 0, please select a different number.");
                }
                else
                {
                    return number;
                }
            }
        }

        static int GetOperationFromUser()
        {
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");


            while (true)
            {
                Console.WriteLine("What operation would you like to complete: ");
                if (!int.TryParse(Console.ReadLine(), out int operation))
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                }
                else if (operation < 1 || operation > 4)
                {
                    Console.WriteLine("Please enter a number between 1 and 4");
                }
                else
                {
                    return operation;
                }

            }
        }

        static (double Result, char Symbol) CalculateResult(double firstNumber, double secondNumber, int operation)
        {
            double result = 0D;
            char symbol;

            switch (operation)
            {
                case 1: // Addition
                    result = firstNumber + secondNumber;
                    symbol = '+';
                    break;
                case 2: // Subtraction
                    result = firstNumber - secondNumber;
                    symbol = '-';
                    break;
                case 3: // Multiplication
                    result = firstNumber * secondNumber;
                    symbol = '*';
                    break;
                case 4: // Division
                    result = firstNumber / secondNumber;
                    symbol = '/';
                    break;
                default:
                    Console.WriteLine("Some error has occured, please try again\n\n");
                    symbol = '?';
                    break;

            }
            return (result, symbol);
        }
    }
}
