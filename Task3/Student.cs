using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Student
    {
        // Создаем конструктор
        public Student(string firstName, string lastName, int course, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.course = course;
            this.age = age;
        }

        public string lastName;
        public string firstName;
        public int course;
        public int age;

        public override string ToString()
        {
            return $"{this.lastName,10 } {this.firstName,15} {this.course,3} {this.age,3}";
        }
    }
}
