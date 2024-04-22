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

            /*Calculator flow
             * Intro message
             * Asks for operation to be completed
             * Asks for first number
             * Asks for second number
             * presents answer and offers second operation on this number
             */

            Console.WriteLine("Welcome to the Calculator\n");

            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");

            Console.Write    ("What operation would you like to complete: ");
            int operation = int.Parse(Console.ReadLine());

            Console.Write    ("What is the first number: ");
            // ADD TRYPARSE TO CATCH ERRORS
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write    ("What is the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            float result = 0F;

            switch (operation)
            {
                case 1: // Addition
                    result = firstNumber + secondNumber;
                    break;
                case 2: // Subtraction
                    result = firstNumber - secondNumber;
                    break;
                case 3: // Multiplication
                    result = firstNumber * secondNumber;
                    break;
                case 4: // Division
                    result = firstNumber / secondNumber;
                    break;

            }
            string message = $"The final result is {result}";
            Console.WriteLine(message);
            Console.ReadLine();
            /*TODO
             * Create separate function to bound areas in box for display
            */
        }
    }
}
