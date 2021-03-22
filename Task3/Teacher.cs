using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Teacher : Person
    {
        private string _faculty;

        public Teacher(string name, string faculty):base(name)
        {
            _faculty = faculty;
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Hi my name is {_name} and I teach in the {_faculty} faculty");
        }
    }
}
