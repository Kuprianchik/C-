
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate double Powers(double x);
namespace _2._2._14_Реализацтя_результата_с_помощью_лямбда_выражения
{
    internal class Program
    {
        static Powers maker(int n)
        {
            Powers meth;
            //значение применной типа делегата присваивается
            //лямбда-выражение
            meth = x =>
            {
                double s = 1;
                for (int i = 1; i <= n; i++)
                {
                    s *= x;
                }
                return s;
            };
            return meth;
        }
        static void Main(string[] args)
        {
            Powers sqr=maker(2);
            Powers cube= maker(3);
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("{0,2}:{1,5}{2,5}{3,5}",i,sqr(i),cube(i),maker(4)(i));
            }
        }
    }
}
