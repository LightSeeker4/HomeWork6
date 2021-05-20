using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Functions
    {
        public delegate double Fun(double a, double x);

        /// <summary>Метод, принимающий делегат</summary>
        /// <param name="F">Метод с сигнатурой double, double, double</param>
        /// <param name="a">Параметр "а"</param>
        /// <param name="x">Параметр "х"</param>
        /// <param name="b">Количество строк в таблице</param>
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.0} | {1,8:0.0} | {2,8:0.0} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }
}
