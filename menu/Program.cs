using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, v;
            Console.WriteLine("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер операции: ");
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    v = a + b;
                    Console.WriteLine($"Ответ: {v}");
                    break;
                case 2:
                    v = b - c;
                    Console.WriteLine($"Ответ: {v}");
                    break;
                case 3:
                    v = a * c;
                    Console.WriteLine($"Ответ: {v}");
                    break;
                case 4:
                    v = b / c;
                    Console.WriteLine($"Ответ: {v}");
                    break;
                case 5:
                    v = b % c;
                    Console.WriteLine($"Ответ: {v}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
