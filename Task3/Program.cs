using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var people = new List<Person>();

            string[] subjects = { "Math", "Science", "English" };
            string studentName = "Sue";

            //instantiate student and add to people collection
            Student student1 = new Student(studentName, subjects);
            people.Add(student1);
            
            string faculty = "Computer Science";
            string teacherName = "Tim";

            //instantiate teacher and add to people collection
            Teacher teacher1 = new Teacher(teacherName, faculty);
            people.Add(teacher1);

            //iterate through people collection and invoke PrintDetails for each element
            foreach (var i in people)
            {
                i.PrintDetails();
            }

            Console.ReadKey(); 
        }
    }
}
