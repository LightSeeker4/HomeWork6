using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class GenerateStudentsList
    {
        static public List<Student> Generate(int count = 100)
        {
            List<Student> result = new List<Student>();
            Random r = new Random();

            for (int i = 0; i < count; i++)
            {
                result.Add(
                    new Student($"Фамилия_{i + 1}", $"Имя_{i + 1}", r.Next(1, 7), r.Next(16, 23))
                    );
            }
            return result;
        }
    }
}
