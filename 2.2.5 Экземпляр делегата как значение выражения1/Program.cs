using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._5_Экземпляр_делегата_как_значение_выражения1
{
    //объявление делегата
    delegate int Method(int n);
    //класс с индексатором
    class MyClass
    {
        //закрытое целочисленное поле
        private int num;
        //конструктор с целочисленным аргументом
        public MyClass(int n)
        {
            num = n;
        }
        //первый закрытый метод
        private int first(int n)
        {
            return n + num;
        }
        //второй закрытый метод
        private int second(int n)
        {
            return n - num;
        }
        //третий закрытый метод
        private int third(int n)
        {
            return n * num;
        }
        //индексатор с целочисленным индексом.
        //Результат ссылка на экземпляр делегата
        public Method this[int k]
        {
            //акссесор для считывания значения
            get
            {
                switch (k)
                {
                    case 0:
                        return first;
                    case 1:
                        return second;
                    case 2:
                        return third;
                    default:
                        return third;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //переменная 
            int x = 12;
            //создание объекта
            MyClass obj = new MyClass(4);
            //индексирование объекта
            for(int k=0;k<=2;k++)
            {
                Console.WriteLine("obj[{0}]({1})={2}", k, x, obj[k](x));
            }
        }
    }
}
