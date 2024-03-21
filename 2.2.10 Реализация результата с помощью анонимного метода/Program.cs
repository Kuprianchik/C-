using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//объявление делегата
delegate double Powers(double x);

namespace _2._2._10_Реализация_результата_с_помощью_анонимного_метода
{

    internal class Program
    {
        //статический метод результат возвращает ссылку
        //на экземпляр делегата
        static Powers maker(int n)
        {
            //локальная переменная типа делегата
            Powers meth;
            //значением переменной типа делегата присваивается
            //анонимный метод:
            meth = delegate (double x)
            {
                double s = 1;
                //вычисление произведения
                for (int i = 1; i <= n; i++)
                {
                    s *= x;
                }
                return s; //результат анонимного метода
            };
            return meth; // результат статического метода 
        }
        static void Main(string[] args)
        {
            //первый экземпляр делегата
            Powers sqr = maker(2);
            //второй экземпляр делегата
            Powers cube = maker(3);
            //вызов экземпляра делегата
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("{0,2}:{1,5}{2,5}{3,5}",i,sqr(i),cube(i),maker(4)(i));
            }
        
    }
}
}
