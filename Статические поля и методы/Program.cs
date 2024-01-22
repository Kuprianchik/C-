using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Статические_поля_и_методы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass.show();
            //MyClass.code = 200;
            //MyClass.show();
            //Аргумент для статических методов:
            double z = 1;
            Console.WriteLine($"exp{z} = {MyMath.exp(z)}");
            //контрольное значение 
            Console.WriteLine($"Контрольное значение: {Math.Exp(z)}");
            //новое значение аргкумента:
            z = MyMath.Pi / 4;
            //Вычисление синуса:
            Console.WriteLine($"sin({z}) = {MyMath.sin(z)}");
            //контрольное значение 
            Console.WriteLine($"Контрольное значение: {Math.Sin(z)}");
        }
    }
    class MyMath
    {
        //Константное поле число "пи"
        public const double Pi = 3.141592;
        //закрытое статическое поле (граница суммы):
        private static int N = 100;
       //Статический метод для вычисления экспоненты:
        public static double exp(double x)
        {
            //Сумма и добавка к сумме:
            double s = 0, q = 1;
            //Вычисление суммы
            for(int k=0;k<=N;k++) 
            {
                s += q;//Прибавление добавки к сумме
                q*=x/(k+1);//Добавка для следующей итерации
            }
            return s;
        }
        public static double sin(double x) 
        {
            //Сумма и добавка к сумме:
            double s = 0, q = x;
            //Вычисление суммы:
            for(int k=0;k<= N;k++)
            {
                s+= q;//Прибавление добавки к сумме
                //Добавка для следующей итерации:
                q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
            }
            //Результат:
            return s;
        }
    }
    class MyClass
    {
        //статическое поле
        public static int code = 100;
        public static void show()
        {
            Console.WriteLine("Статическое поле: "+code);
        }
    }
}
