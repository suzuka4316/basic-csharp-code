using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //add logic here
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

            //if (op == '-')
            //{
            //    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //}
            //else if (op == '+')
            //{
            //    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            //}
            //else if (op == '*')
            //{
            //    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //}
            //else if (op == '/')
            //{
            //    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //}
            //else
            //{
            //    Console.WriteLine($"{op} is an invalid input.");
            //}

            Console.ReadKey();
        }
    }
}
