using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//объявление делегата
delegate int Alpha(int n);
//объявление второго делегата
delegate void Bravo(string t);
//класс
class MyClass
{
    //открытое целочисленное поле
    public int number;
    //конструктор
    public MyClass(int n)
    {
        number = n;
    }
    //поле, являющееся ссылкой на экземпляр делегата
    public Alpha method;
}
namespace _2._2._7_Знакомство_с_анонимными_методами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объектов
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            //полю объекта значением присваивается 
            //анонимный метод
            A.method = delegate (int n)
            {          
                return A.number + n;
            };
            //полю объекта значением присваивается
            //анонимный метод
            B.method = delegate (int n)
            {
                return B.number - n;
            };
            //целочисленная переменная
            int x = 80;
            //вызов экземпляра делегата
            Console.WriteLine("A.method({0})={1}",x,A.method(x));
            //присваивание нового значения полю
            A.number = 300;
            //вызов экземпляра делегата
            Console.WriteLine("A.method({0})={1}", x, A.method(x));
            Console.WriteLine("A.method({0})={1}", x, B.method(x));
            //объявление переменной типа делегата
            Bravo show;
            //присваивание переменной анонимного метода
            show = delegate (string t)
            {
                Console.WriteLine("Текст: \"{0}\"", t);
            };
            //вызов экземпляра делегата
            show("Bravo");
            Console.WriteLine("");
            //присваивание переменной анонимного метода
            show = delegate (string t)
            {
                for (int k = 0; k < t.Length; k++)
                {
                    Console.Write("|" + t[k]);
                }
                Console.WriteLine("|");
            };
            //вызов экземпляра делегата
            show("Bravo");
        }
    }
}
