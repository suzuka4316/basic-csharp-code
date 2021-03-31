using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //add logic here
            int i = 50;
            string info;
            do
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    info = "[3 & 5]";
                    Console.WriteLine($"{i} {info}");
                }
                else if (i % 3 == 0)
                {
                    info = "[3]";
                    Console.WriteLine($"{i} {info}");
                }
                else if (i % 5 == 0)
                {
                    info = "[5]";
                    Console.WriteLine($"{i} {info}");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
                i--;
            } while (i >= 25);

            Console.ReadKey();
        }
    }
}
