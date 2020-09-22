using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab1_v20_TiOPO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Часть 1
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("Наименование ЛР: Разработка консольного приложения");
            Console.WriteLine("");
            Console.WriteLine("Выполнил: Цыбань Илья Константинович");
            Console.WriteLine("Группа: ИНС-б-о-18-1");
            Console.WriteLine("Дата рождения: 06.08.2000");
            Console.WriteLine("Место жительства: с. Верхнерусское");
            Console.WriteLine("Любимый предмет в школе: история");
            Console.WriteLine("Хобби: чтение книг, игра на гитаре, волейбол");
            Console.WriteLine("");

            //Часть 2
            /*int a;
            int b = 7;

            string str = "Hello, World!!!";

            a = 123;

            Console.WriteLine("Значение переменной а равно {0}", a);
            Console.WriteLine("а значение переменной b равно {0}", b);
            Console.WriteLine("значение a+b = {0}+{1}={2}", a, b, a + b);
            Console.WriteLine(str);*/

            //Часть 3
            Console.WriteLine("Вариант 20");

            double a_1, x, y;
            int b;

            a_1 = 0.5;
            x = 4;
            y = 8.25;
            b = 3;

            /*a_1 = 0;
            x = 0;
            y = 0;
            b = 0;*/


#if DEBUG
            Debug.Assert((a_1 != 0) && (x != 0) && (y != 0) && (b != 0));
#endif


            try
            {
                if ((a_1 == 0) && (x == 0) && (y == 0) && (b == 0))
                    throw new Exception("all variables are equal to 0");
                
                Console.WriteLine("Значение переменной a_1 равно {0}", a_1);
                Console.WriteLine("Значение переменной b равно {0}", b);
                Console.WriteLine("Значение переменной x равно {0}", x);
                Console.WriteLine("Значение переменной y равно {0}", y);
                Console.WriteLine("значение Fy = {0}+{1}-{0}*({2}+{3})={4}", a_1, b, x, y, a_1 + b - a_1 * (x + y));
                Console.WriteLine("");
                Console.WriteLine("Для завершения работы программы нажмите любую клавишу...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

                Console.ReadKey();

        }
    }
}
