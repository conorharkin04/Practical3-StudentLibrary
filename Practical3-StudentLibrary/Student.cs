using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_StudentLibrary
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        public Student()
        {
            this.name = "John Doe";
            this.age = 16;
            this.id = studentCount++;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.id = studentCount++;
        }

        public void Display()
        {
            Console.WriteLine($"Student ID:  {id}");
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Student Age: {Age}");
        }

        public int GetOlder()
        {
            return age++;
        }
    }
}
