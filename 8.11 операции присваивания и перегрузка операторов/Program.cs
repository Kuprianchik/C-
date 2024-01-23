using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._11_операции_присваивания_и_перегрузка_операторов
{
    //класс с перегрузкой операторов
    class MyClass
    {
        //целочисленное поле
        public int code;
        //конструктор с одним аргументом
        public MyClass(int n)
        {
            code = n;
        }
        //операторный метод для сложения объектов:
        public static MyClass operator+(MyClass a, MyClass b)
        {
            return new MyClass(a.code+ b.code);
        }
        //операторный метод для умножения объектов:
        public static int operator*(MyClass a, MyClass b)
        {
            return a.code*b.code;
        }
        //операторный метод для неявного приведения типа
        //(из типа int к типу MyClass)
        public static implicit operator MyClass(int n) 
        {
            return new MyClass(n);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(7);
            //Проверка результата:
            Console.WriteLine("Объект A: {0}",A.code);
            //создание объекта:
            MyClass B= new MyClass(8);
            //Проверка результата:
            Console.WriteLine("Объект B: {0}",B.code);
            //Вычисление суммы объектов с использованием
            //сокращенной формы оператора присваивания:
            A += B;
            //Проверка результата
            Console.WriteLine("Объект A: {0}",A.code);
            //Вычисление произведения объектов с использованием
            //сокращенной формы оператора присваивания:
            A *= B; //сначала произведение полей объекта а и б, после неявное приведение типа int к MyClass
            Console.WriteLine("Объект A: {0}", A.code);
        }
    }
}
