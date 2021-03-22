using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Student : Person
    {
        private string[] _subjects;

        public Student(string name, string[] subjects) : base (name)
        {
            _subjects = subjects;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Hi my name is {_name} and I am studying {string.Join(", ", _subjects)}"); 
        }
    }
}
