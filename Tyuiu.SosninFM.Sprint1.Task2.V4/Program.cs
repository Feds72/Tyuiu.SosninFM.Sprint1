using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SosninFM.Sprint1.Task2.V4.Lib;


// ЗАДАНИЕ
// написать прошрамму, которая запрашивает у пользователя исходные данные,
// выполняет указанные рассчеты и печатает рещультат на экране.
//Расчеты - Известно число, найти него квадрат.
//Длина стороны квадарата(целое число)
//Площаддь квадрарта(целое число)



namespace Tyuiu.SosninFM.Sprint1.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Соснин Ф. М. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Соснин Фёдор Михайлович | АСОиУб-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 2*9+7*2                 *");
            Console.WriteLine("* и печатает результат на экране                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int x;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Квадрат числа Х = " + dataService.CalculateSquare(x));

            Console.ReadLine();


        }
    }
}
