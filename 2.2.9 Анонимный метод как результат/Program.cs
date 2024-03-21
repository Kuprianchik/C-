using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//объявление делегата
delegate int MyDelegate();

namespace _2._2._9_Анонимный_метод_как_результат
{
    internal class Program
    {
        //статический метод результатом возвращает ссылку на
        //экземпляр делегата:
        static MyDelegate calculate(int n)
        {
            //локальная переменная
            int count = 0;
            //результат реализован через анонимный метод:
            return delegate ()
            {
                count += n;
                return count;
            };
        }
        static void Main(string[] args)
        {
            //переменная типа делегата
            MyDelegate next = calculate(1);
            for(int i=1;i<=5;i++)
            {
                //вызов экземпляра делегата
                Console.Write(next()+" ");
            }
            Console.WriteLine();
            //новое значение переменной типа делегата
            next=calculate(3);
            for(int i=1;i<=5;i++)
            {
                //вызов экземпляра делегата
                Console.Write(next()+" ");
            }
            Console.WriteLine();
        }
    }
}
