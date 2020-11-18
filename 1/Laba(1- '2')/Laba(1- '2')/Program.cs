using System;
using System.Threading;

namespace Laba_1___2__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine(" ");


            double c = 0;
            double q = Math.Pow(8,3);
            int g = 10, b = 4, h = 2, x = 1, y = 3, w = 3;


            c = g * h + b * q - x + (y / w);

            Console.WriteLine("c = g*h+b*q^3-x+y/w");
            Console.WriteLine(" ");
            Console.WriteLine("Значение переменной: g = {0}", g);
            Console.WriteLine("Значение переменной: h = {0}", h);
            Console.WriteLine("Значение переменной: b = {0}", b);
            Console.WriteLine("Значение переменной: q = {0}", q);
            Console.WriteLine("Значение переменной: x = {0}", x);
            Console.WriteLine("Значение переменной: y = {0}", y);
            Console.WriteLine("Значение переменной: w = {0}", w);

            Console.WriteLine(" ");
            Console.WriteLine("Ответ: {0}", c);
            Console.ReadKey();

        }
    }
}
