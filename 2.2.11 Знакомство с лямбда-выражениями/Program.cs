using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int Alpha(int n);
delegate void Bravo(string t);
class MyClass
{
    public int number;
    public MyClass(int n)
    {
       number = n;
    }
    public Alpha method;
}
namespace _2._2._11_Знакомство_с_лямбда_выражениями
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            MyClass B = new MyClass(200);
            //полю объекта значению присваивается 
            //лямбда-выражение
            A.method = n => A.number + n;
            //Полю объекта значением присваивается
            //лямбда-выражение
            B.method = (int n) =>
            {
                return B.number - n;
            };
            int x = 80;
            Console.WriteLine("A.method({0})={1}",x,A.method(x));
            A.number = 300;
            Console.WriteLine("A.method({0})={1}", x, A.method(x));
            Console.WriteLine("B.method({0})={1}", x, B.method(x));
            Bravo show;
            show = t =>
            {
                for (int k = 0; k < t.Length; k++)
                {
                    Console.Write("|" + t[k]);
                }
                Console.WriteLine("|");
            };
            show("Bravo");
        }
    }
}
