using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        /// <summary>
        /// Calculator
        /// Display a result of calculation based on 2 numbers and an operator a user inputs.
        /// A user can input either '-'(subtraction), '+'(addition), '*'(multiplication), '/'(division).
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("\nEnter an operator[-, +, *, /]: ");
            char op = (Console.ReadKey().KeyChar);
            Console.Write("\nEnter another integer number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine($"{op} is an invalid operator input.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
