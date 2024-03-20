using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1_Знакомство_с_делегатами
{
    internal class Program
    {
        //объявление делегата
        delegate char MyDelegate(int k, string txt);
        //класс
        class MyClass
        {

            //целочисленное поле
            public int code;
            public MyClass(int n)
            {
                code = n;
            }
            //нестатический метод с двумя аргументами
            public char getChar(int k,string txt)
            {
                return (char)(txt[k]+code);
            }
            //статический метод с двумя аргументами
          public static char getFirst(int k,string txt)
            {
                return txt[k];
            }
        }
       
        static char getLast(int k, string txt)
        {
            return txt[txt.Length - k - 1];
        }
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);
            MyDelegate meth = new MyDelegate(obj.getChar);
            //вызов экземпляра делегата
            Console.WriteLine("Символ \'{0}\'",meth(4,"Alpha"));
            //присваивание значения полю объекта
            obj.code = 1;
            //вызов экземпляра делегата
            Console.WriteLine("Символ \'{0}\'", meth(4, "Alpha"));
            //присваивание нового значения переменной делегата
            meth = MyClass.getFirst;
            Console.WriteLine("Символ \'{0}\'", meth(2, "Alpha"));
            //присваивание нового значения переменной делегата
            meth = getLast;
            Console.WriteLine("Символ \'{0}\'", meth(1, "Alpha"));
        }
    }
}
