using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate char MyDelegate(int n);
class MyClass
{
    public char symbol;
    public MyDelegate get;
    public MyClass(char s,MyDelegate md)
    {
        symbol = s;
        get = md;
    }
    public void set(MyDelegate md)
    {
        get = md;
    }
}
namespace _2._2._12_Лямбда_выражение_как_аргумент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта. Вторым аргументом является
            //лямбда-выражения
            MyClass obj = new MyClass('K', n => (char)('A' + n));
            Console.WriteLine("Символ: \'{0}\'", obj.get(3));
            //вызов метода, аргументом которому передано
            //лямбда-выражение
            obj.set(n => (char)(obj.symbol + n));
            Console.WriteLine("Символ: \'{0}\'",obj.get(3));
        }
    }
}
