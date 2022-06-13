using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //{  •	first name
            //   •	last name
            //   •	age
            //   •	home town
            string[] cmdArgs = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .ToArray();
            List<Student> students = new List<Student>();
            while (cmdArgs[0] != "end")
            {
                string firstName = cmdArgs[0];
                string lastName = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                string homeTown = cmdArgs[3];
                Student newStudnet = new Student()
                {
                    FirstName = firstName,
                    LastName=lastName,
                    Age=age,
                    HomeTown=homeTown
                };
                students.Add(newStudnet);
                cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            string cityName = Console.ReadLine();
            List<Student> filterStudents = students.FindAll(student => student.HomeTown == cityName);
            foreach(Student student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is " +
                    $"{student.Age} years old.");
            }

        }
    }
}
