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

        /// <summary>
        /// Read the text file "characters.txt" that contains uppercase alphabets and count each letter.
        /// Write the result in a new text file "character-count.txt".
        /// </summary>
        private static void ReadCharCount2()
        {
            StreamReader reader = new StreamReader("characters.txt");
            StreamWriter sw = new StreamWriter("../../character-count.txt");

            int[] countArray = new int[26];
            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();

                //in ASCII, Uppercase alphabets is equivalent to number 65 to 90. (A is 65, Z is 90)
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
