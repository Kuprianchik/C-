using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace статические_методы
{
    internal class Program
    {
        static void show(string txt)
        {
            Console.WriteLine(txt);
        }
        //Статический метод для вычисления факториала числа, переданного аргументом методу;
        static int factorial(int n)
        {
            int s = 1;
            //Вычисление произведения:
            for (int i = 1; i <= n; i++)
            {
                //Умножение произведения на число:
                s *= i;
            }
            return s;
        }
        static double power(double x, int n)
        {
            double s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= x;
            }
            return s;
        }
        static void Main(string[] args)
        {
            show("Начинаем вычисления:");
            int m = 5;
            double z = 3, num;

            show(m + "! =" + factorial(m));
            //Число в степени
            num = power(z, m);
            //отображение сообщения вызовом статического метода:
            show(z + " в степени " + m + ": " + num);

        }
    }
}
