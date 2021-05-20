using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class SortStudents
    {
        static public void Print(List<Student> Db)
        {
            for (int i = 0; i < Db.Count; i++)
            {
                Console.WriteLine($"{i,3}. {Db[i]}");
            }
            Console.WriteLine();
        }

        static public int A(List<Student> Db)
        { int result = 0;
        foreach (var e in Db)
            {
                if (e.course == 5 || e.course == 6) result++;
            }
            return result;
        }

        static public Dictionary<int, int> B(List<Student> Db)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 1; i <= 6; i++)
            {
                result.Add(i, 0);
            }

            foreach (var e in Db)
            {
                if (e.age >= 18 && e.age <= 20) result[e.course]++;
            }
            return result;
        }

        static public int AgeCompare(Student st1, Student st2)         
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static public int CourceAndAgeCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }
    }
}
