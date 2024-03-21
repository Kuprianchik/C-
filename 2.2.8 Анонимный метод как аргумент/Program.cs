using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate char MyDelegate(int n);
//класс
class MyClass
{
    //открытое символьное поле
    public char symbol;
    //поле являющееся ссылкой на экземпляр делегата
    public MyDelegate get;
    //конструктор, второй аргумент которого ссылка на
    //экземпляр делегата
    public MyClass(char s,MyDelegate md)
    {
        symbol = s;
        get = md;
    }
    //метод с аргументом, являющимся ссылкой на экземпляр 
    //делегата
    public void set(MyDelegate md)
    {
        //использование ссылки на экземпляр делегата
        get = md;
    }
}

namespace _2._2._8_Анонимный_метод_как_аргумент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта. Вторым аргументом является 
            //анонимный метод
            MyClass obj = new MyClass('K', //символьный аргумент
                delegate (int n) //анонимный метод
                {
                    return (char)('A' + n);
                });
            //вызов экземпляра делегата
            Console.WriteLine("Символ: \'{0}'",obj.get(3));
            //вызов метода, аргументом которому передан
            //анонимный метод
            obj.set(
                delegate(int n)
            {
                return (char)(obj.symbol + n);
            }
            );
            //вызов экземпляра делегата
            Console.WriteLine("Символ: \'{0}\'",obj.get(3));
        }
 
    }
}

