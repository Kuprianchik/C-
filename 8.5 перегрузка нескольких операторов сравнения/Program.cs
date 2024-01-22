using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5_перегрузка_нескольких_операторов_сравнения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            //проверка результата
            Console.WriteLine("Объект А: {0}", A.code);
            Console.WriteLine("Объект B: {0}", B.code);
            //использование операторов "меньше" и "больше"
            Console.WriteLine("A<B дает {0}", A < B);
            Console.WriteLine("A>B дает {0}", A > B);
            //объектная переменная
            MyClass C;
            //использование оператора "больше или равно"
            C = A >= B;
            //Новое значение поля
            C.code = 300;
            //Проверка результата"
            Console.WriteLine("Объект B: {0}", B.code);
            //использование оператора "меньше или равно"
            C = A <= B;
            //новое значение поля
            C.code = 150;
            Console.WriteLine("Объект A: {0}", A.code);
            //новое значение поля
            (B <= A).code = 500;
            //Проверка результата
            Console.WriteLine("Объект A: {0}", A.code);
            //Целочисленные переменные:
            int x = 400, y = 500, z = 600;
            //использование операторов "меньше или равно"
            //и "больше или равно"
            Console.WriteLine("A<={0} дает {1}",x,A<=x);
            Console.WriteLine("A>={0} дает {1}", x, A >= x);
            Console.WriteLine("A<={0} дает {1}", y, A <= y);
            Console.WriteLine("A>={0} дает {1}", y, A >= y);
            Console.WriteLine("A<={0} дает {1}", z, A <= z);
            Console.WriteLine("A>={0} дает {1}", z, A >= z);
            //Использование операторов "меньше" и "больше"
            Console.WriteLine("A<{0} дает {1}", z,A<z);
            Console.WriteLine("A>{0} дает {1}", z, A > z);
        }
    }
    class MyClass
    {
        public int code;
        public MyClass(int n)
        {
            code = n;
        }
        //перегрузка оператора "меньше или равно"
        public static MyClass operator <=(MyClass a, MyClass b)
        {
            if (a.code <= b.code) return a;
            else return b;
        }
        public static MyClass operator >=(MyClass a, MyClass b)
        {
            if (a.code >= b.code) return a;
            else return b;
        }
        //перегрузка оператора "больше или равно"
        public static bool operator <=(MyClass a, int x)
        {
            if (a.code <= x - 1) return true;
            else return false;
        }
        //перегрузка оператора "больше или равно"
        public static bool operator >=(MyClass a, int x)
        {
            if (a.code >= x + 1) return true;
            else return false;
        }
        //перегрузка оператора "меньше"
        public static bool operator <(MyClass a, MyClass b)
        {
            return a.code < b.code;
        }
        public static bool operator >(MyClass a, MyClass b)
        {
            return a.code > b.code;
        }

        //перегрузка оператора "меньше"
        public static int operator <(MyClass a, int x)
        {
            return x - a.code;
        }
        public static int operator >(MyClass a, int x)
        {
            return a.code - x;
        }
    }
}
