using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4_знакомство_с_перегрузкой_операторов_сравнения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание обьектов
            MyClass A = new MyClass('A');
            MyClass B = new MyClass('B');
            MyClass C = new MyClass('A');
            //использование операторов сравнения
            Console.WriteLine("A<=B дает {0}",A<=B);
            Console.WriteLine("A>=B дает {0}", A >= B);
            Console.WriteLine("A<=C дает {0}", A <= C);
            Console.WriteLine("A>=C дает {0}", A >= C);
        }
    }
    //класс с перегрузкой операторов сравнения
    class MyClass
    {
        //сим поле
        public char symb;
        public MyClass(char s)
        {
            symb = s;
        }
        //перегрузка оператора меньше или равно
        public static bool operator<=(MyClass a, MyClass b) 
        {
            if (a.symb <= b.symb) return true;
            else return false;
        }
        public static bool operator>=(MyClass a, MyClass b)
        {
            if(a.symb>=b.symb) return true;
            else return false;
        }
    }
}
