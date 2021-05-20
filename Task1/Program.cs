using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    //Алексей Сазонов
    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x)
    //Т е a*Sin(x)
    //x — это та самая переменная
    //А а — это какое-то фиксированное число
    //"Вы уже должны были заметить, что оператор ^, который обычно используется для обозначения возведения в степень в обычной математике,
    //не является таковым в языке C#. В языке С# это побитовая операция XOR.
    //А для возведения числа в степень в языке C# используется функция pow()"

    //Гуглим приоритет операций с#
//Проверяем опытным путем



        class Program
        {
            static void Main()
            {
                // Создаем новый делегат и передаем ссылку на него в метод Table
                Console.WriteLine("Таблица функции a*x^2:");
                // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
                Functions.Table(new Functions.Fun(Functions.MyFunc), -1.5, -2, 2);

                Console.WriteLine("Таблица функции a*sin(x):");
                Functions.Table(new Functions.Fun(Functions.MySin), 3, -2, 2);

                Console.ReadKey();
            }
        }
}