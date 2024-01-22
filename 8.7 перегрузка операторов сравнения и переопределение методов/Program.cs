using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._7_перегрузка_операторов_сравнения_и_переопределение_методов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100, 'A');
            MyClass B = new MyClass(100, 'B');
            MyClass C = new MyClass(200, 'A');
            MyClass D = new MyClass(100, 'A');
            //вычисление хэш-кодов
            Console.WriteLine("Хэш-код А: {0}", A.GetHashCode());
            Console.WriteLine("Хэш-код B: {0}", B.GetHashCode());
            Console.WriteLine("Хэш-код C: {0}", C.GetHashCode());
            Console.WriteLine("Хэш-код D: {0}", D.GetHashCode());
            //сравнение объектов на предмет
            //равенства и неравенства:
            Console.WriteLine("A==B дает {0}",A==B);
            Console.WriteLine("A!=B дает {0}", A != B);
            Console.WriteLine("A==C дает {0}", A == C);
            Console.WriteLine("A!=C дает {0}", A != C);
            Console.WriteLine("A==D дает {0}", A == D);
            Console.WriteLine("A!=D дает {0}", A != D);
        }
    }
    //Класс с перегрузкой операторов сравнения == и !=
    // и переопределением методов GetHashCode() и Equals():
    class MyClass
    {
        //целочисленное поле
        public int code;
        //символьное поле
        public char symb;
        public MyClass(int n, char s)
        {
            code = n;//значение целочисленного поля
            symb = s;//значение символьного поля
        }
        //переопределение метода GetHashCode()
        public override int GetHashCode()
        {
            //Вычисление хэш-кода
            return code ^ symb;
        }
        //переопределение метода Equals()
        public override bool Equals(Object obj)
        {
            //Локальная объектная переменная
            MyClass t = (MyClass)obj;
            //результат метода:
            if (code == t.code && symb == t.symb) return true;
            else return false;
        }
        //перегрузка оператора "равно"
        public static bool operator ==(MyClass a, MyClass b)
        {
            //Вызов метода Equals()
            return a.Equals(b);
        }
        //перегрузка оператора не равно
        public static bool operator !=(MyClass a, MyClass b)
        {
            return !(a == b);
        }
    }
}
