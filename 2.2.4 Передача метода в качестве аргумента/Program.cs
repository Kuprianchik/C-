using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._4_Передача_метода_в_качестве_аргумента
{
    //объявление делегата
    delegate int MyDelegate(int n);

    internal class Program
    {
        //статический метод для вычисления нечетных чисел
        static int f(int n)
        {
            return 2 * n + 1;
        }
        //статический метод для вычисления четных чисел
        static int g(int n)
        {
            return 2 * n;
        }
        //статический метод для вычисления квадратов чисел
        static int h(int n)
        {
            return n * n;
        }
        //статический метод, которому аргументом
        //передается ссылка на метод
        static void display(MyDelegate F,int a,int b)
        {
            Console.WriteLine("{0,-4}|{1,4}","x"," F(x)");
            Console.WriteLine("------------");
            for(int k=a;k<=b;k++)
            {
                //команда с вызовом экземпляра делегата
                Console.WriteLine("{0,-4}|{1,4}",k,f(k));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //диапазон изменения аргумента
            int a = 0, b = 5;
            Console.WriteLine("Нечетный числа:");
            //передача аргументом ссылки на метод
            display(f,a,b);
            Console.WriteLine("Четные числа:");
            //передача аргументом ссылки на метод
            display(g, a, b);
            Console.WriteLine("Число в квадрате:");
            //передача аргументом ссылки на метод
            display(h, a, b);

        }
    }
}
