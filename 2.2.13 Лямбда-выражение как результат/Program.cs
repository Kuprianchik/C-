using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int MyDelegate();
namespace _2._2._13_Лямбда_выражение_как_результат
{
    internal class Program
    {
        static MyDelegate calculate(int n)
        {
            int count = 0;
            //результат реализован через лямбда-выражение
            return () => { count += n; return count; };
        }
        static void Main(string[] args)
        {
            MyDelegate next = calculate(1);
            for(int i=1;i<=5;i++)
            {
                Console.Write(next()+" ");
            }
            Console.WriteLine();
            next=calculate(3);
            for(int i=1;i<=5; i++)
            {
                Console.Write(next()+" ");
            }
            Console.WriteLine();
        }
    }
}
