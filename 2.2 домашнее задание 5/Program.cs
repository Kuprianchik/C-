using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate int MyDelegate();
//объявление класса

namespace _2._2_домашнее_задание_5
{
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
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate next = calculate(1);
        }
    }
}
