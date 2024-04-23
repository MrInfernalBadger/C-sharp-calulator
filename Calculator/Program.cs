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
            int operation;
            int firstNumber;
            int secondNumber;

            while (true)
                {Console.WriteLine("Welcome to the Calculator\n");

                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiplication");
                Console.WriteLine("4: Division");


                while (true)
                {
                    Console.WriteLine("What operation would you like to complete: ");
                    if (!int.TryParse(Console.ReadLine(), out operation))
                    {
                        Console.WriteLine("Please enter a number between 1 and 4");
                    } else if (operation < 1 || operation > 4)
                    {
                        Console.WriteLine("Please enter a number between 1 and 4");
                    }
                    else
                    {
                        break;
                    }

                }

                Console.Clear();
                while (true)
                {
                    Console.WriteLine("What is the first number: ");
                    if (!int.TryParse(Console.ReadLine(), out firstNumber)) 
                    {
                        Console.WriteLine("Please enter an integer.");
                    } 
                    else
                    {
                    break;
                    }
                }
                Console.Clear();

                while (true)
                {
                    Console.Write("What is the second number: ");
                    if (!int.TryParse(Console.ReadLine(), out secondNumber))
                    {
                        Console.WriteLine("Please enter an integer.");
                    }
                    else if (secondNumber == 0 && operation == 4)
                    {
                        Console.WriteLine("Cannot divide by 0, please select a different number.");
                    }
                    else
                    {
                        break;
                    }

                }


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
                if (symbol != '?')
                {
                Console.Clear();
                string message = $"The result of {firstNumber} {symbol} {secondNumber} = {result}";
                Console.WriteLine(message);
                Console.WriteLine("\n\nPress any key to perform a new sum");
                Console.ReadLine();
                Console.Clear();
                }
            }

        }
    }
}
