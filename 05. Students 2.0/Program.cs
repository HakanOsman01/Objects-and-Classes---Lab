using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{

    class Student
    {
        public Student(string firstName,string lastName,int age,string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
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
                bool doesStudentExist = DoesStudentExist(students, firstName, lastName);
                if (doesStudentExist)
                {
                    Student existingStudent = GetExistingStudent(students, firstName, lastName);
                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student newStudnet = new Student(firstName, lastName, age, homeTown);
                    students.Add(newStudnet);
                }
                cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            string cityName = Console.ReadLine();
            List<Student> filterStudents = students.FindAll(student => student.HomeTown == cityName);
            foreach (Student student in filterStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is " +
                    $"{student.Age} years old.");
            }

        }

        static Student GetExistingStudent(List<Student> students,
            string firstName,string lastName)
        {
            foreach(Student student in students)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
               
            }
            return null;
        }

        static bool DoesStudentExist(List<Student>students,string firstName,string lastName)
        {
            foreach (Student student in students)
            {
                if(student.FirstName==firstName && student.LastName == lastName)
                {
                    return true;
                }
               
            }
            return false;
        }
    }

}
