using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// Hotel Booking
        /// Display the total price for staying in a room in the hotel based on the user inputs (a type of room and how many nights they like to stay).
        /// </summary>
        static void Main(string[] args)
        {
            string[] roomTypes = new string[4] { "Single", "Double", "Luxury", "Penthouse" };
            double[] price = new double[4] { 45.50, 99.99, 165.25, 1095.50 };

            Console.WriteLine("Room Types\n1. Single $45.50 per night\n2. Double $99.99 per night\n3. Luxury $165.25 per night\n4. Penthouse $1,095.50 per night");
            Console.Write("\nPlease select a room type 1, 2, 3 or 4: ");
            int roomNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHow many nights would you like to stay?: ");
            int nights = int.Parse(Console.ReadLine());

            double total = price[roomNum - 1] * nights;
            Console.WriteLine($"\nThank you, the total cost for staying in {roomTypes[roomNum - 1]} room for {nights} nights is ${total.ToString("#,0.00")}");

            Console.ReadKey();
        }
    }
}
