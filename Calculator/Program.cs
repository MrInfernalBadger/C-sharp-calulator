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
                Console.Clear();
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

        /// <summary>
        /// Takes the result of the calculation and displays it for the user
        /// </summary>
        /// <param name="firstNumber">First number entered by the user</param>
        /// <param name="symbol">Symbol representing the operation performed</param>
        /// <param name="secondNumber">Second number entered by the user</param>
        /// <param name="result">The result of the calculation</param>
        static void DisplayResult(double firstNumber, char symbol, double secondNumber, double result)
        { 
            string message = $"The result of {firstNumber} {symbol} {secondNumber} = {result:0..##}";
            Console.WriteLine(message);
            Console.WriteLine("\n\nPress any key to perform a new sum");
            Console.ReadLine();
        }

        /// <summary>
        /// Prompts the user to enter a number for the calculation
        /// </summary>
        /// <param name="prompt">Informs the user which parameter they are entering</param>
        /// <param name="operation">This is used to check whether divide by 0 should be avoided, 4 is division and so an extra check takes place</param>
        /// <returns>Returns int of users selection</returns>
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

        /// <summary>
        /// Prompts the user to select an operation
        /// </summary>
        /// <returns>Returns an int from 1-4 according to the operators chart</returns>
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

        /// <summary>
        /// Calculates the result using a switch statement and assigns the symbol for use in DisplayResult()
        /// </summary>
        /// <param name="firstNumber">First number the user selected</param>
        /// <param name="secondNumber">Second number the user selected</param>
        /// <param name="operation">Operation the user selected</param>
        /// <returns>Returns tuple containing the final result and the symbol of the calculation to be used in DisplayResult()</returns>
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
