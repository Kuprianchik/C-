using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._11_идексатор_с_нечисловым_индексом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100);
            //Проверка значения поля объекта:
            Console.WriteLine("Объект А: {0}",A.code);
            //создание объекта
            MyClass B = new MyClass(150);
            //Проверка значения поля объекта:
            Console.WriteLine("Объект B: {0}", B.code);
            int num = A[B];
            Console.WriteLine("Выражение A[B]={0}", num);
            Console.WriteLine("Выражение B[A]={0}", B[A]);
            A[B] = 200;
            Console.WriteLine("Объект А: {0}", A.code);
        }
    }
    class MyClass
    {
        //целочисленные поле:
        public int code;
        public MyClass(int n) 
        {
            code = n;
        }
        //целочисленный индексатор с индексом, который является
        //объектом класса MyClass:
        public int this[MyClass obj]
        {
            get 
            {
                return code - obj.code;
            }
            set
            {
                code = obj.code + value;
            }
        }
    }
}
