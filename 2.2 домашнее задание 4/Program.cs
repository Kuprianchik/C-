using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate int MyDelegate(int x);
//объявление класса
class MyClass
{
    //объявление переменной делегата
    private MyDelegate my;
    //индексатор, который возвращает тип MyDelegate
    public MyDelegate this[int x]
    {
        get
        {
            //проверка если x>=0 то делегат вычисляется число в степени индекса
            if(x>=0)
            { 
            return my=y=>(int)(Math.Pow((double)y,(double)x));
            }
            //если индекс меньше нуля то возвращает делегат с 0
            else
            {
                return my=y=>0;
            }
        }
    }
}
namespace _2._2_домашнее_задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            Console.WriteLine(A[-2](3));
        }
    }
}
