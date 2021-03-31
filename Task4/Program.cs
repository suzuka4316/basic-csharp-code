using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //add logic here
            //ReadCharCount1();
            ReadCharCount2();
            Console.ReadKey();           
        }
        private static void ReadCharCount1()
        {
            StreamReader reader = new StreamReader("characters.txt");
            StreamWriter sw = new StreamWriter("../../character-count.txt");
            
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                int i = 65;
                do
                {
                    int count = 0;
                    foreach (char c in line)
                    {
                        if (c == (char)i)
                        {
                            count++;
                        }
                    }
                    //Console.WriteLine($"{(char)i} {count}");
                    sw.WriteLine($"{(char)i} {count}");
                    i++;
                } while (i <= 90);
            }
            reader.Dispose();
            sw.Dispose();
        }

        private static void ReadCharCount2()
        {
            StreamReader reader = new StreamReader("characters.txt");
            StreamWriter sw = new StreamWriter("../../character-count.txt");

            int[] countArray = new int[26];
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();

                int index = 0;
                int i = 65;
                do
                {
                    foreach (char c in line)
                    {
                        if (c == (char)i)
                        {
                            countArray[index]++;
                        }
                    }
                    sw.WriteLine($"{(char)i} {countArray[index]}");
                    index++;
                    i++;
                } while (i <= 90);

            }
            reader.Dispose();
            sw.Dispose();
        }
    }
}
