using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
//Алексей Сазонов
//3. Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
//в) отсортировать список по возрасту студента;
//г) * отсортировать список по курсу и возрасту студента;

    class Program
    {
            static void Main(string[] args)
        {
            Console.WriteLine("Список студентов:");
            List<Student> students = GenerateStudentsList.Generate(30); SortStudents.Print(students);
            //a)
            Console.WriteLine($"Rоличество студентов учащихся на 5 и 6 курсах: {SortStudents.A(students)}");
            //б)           
            Console.WriteLine("\nРаспределение студентов в возрасте от 18 до 20 лет по курсам:");
            foreach (var e in SortStudents.B(students)) Console.WriteLine(e);
            //в)
            students.Sort(new Comparison<Student>(SortStudents.AgeCompare)); Console.WriteLine("\nСортировка студентов по возрасту: ");
            foreach (var v in students) Console.WriteLine($"{v.firstName} {v.age}");
            //г)
            students.Sort(new Comparison<Student>(SortStudents.CourceAndAgeCompare)); Console.WriteLine("\nСортировка студентов по курсу и возрасту: ");
            foreach (var v in students) Console.WriteLine($"{v.firstName}, курс {v.course}, возраст {v.age}");
        }
    }
}