using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, я калькулятор!");
            int a = 0;
            int b = 0;
            char d;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выбирете действие: + - * /");
            d = Convert.ToChar(Console.ReadLine());
            if(d == '+')
            {
                Console.WriteLine(a + b);
            }
            else if(d == '-')
            {
                Console.WriteLine(a - b);
            }
            else if (d == '*')
            {
                Console.WriteLine(a * b);
            }
            else if (d == '/')
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
