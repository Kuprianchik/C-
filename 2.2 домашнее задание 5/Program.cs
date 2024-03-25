using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate int MyDelegate();
//объявление класса
class MyClass
{
    private static int sum;
    public int GetSum()
    {
        return sum;
    }
    public MyDelegate md;


}
namespace _2._2_домашнее_задание_5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            A.md = delegate ()
            {
                return A.GetSum();
            };
        }
    }
}
