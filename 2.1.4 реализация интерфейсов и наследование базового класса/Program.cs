using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._4_реализация_интерфейсов_и_наследование_базового_класса
{
    //базовый абстрактный класс
    abstract class Base
    {
        //объявление абстрактного свойства
        public abstract int number
        {
            get;
            set;
        }
        //конструктор с одним аргументом
        public Base(int n)
        {
            number = n;
            show();
        }
        //описание обычного (НЕ АБСТРАКТНОГО)  метода
        public void show()
        {
            Console.WriteLine("Свойство number=" + number);
        }
    }
    //первый интерфейс
    interface First
    {
        //объявление методов
        void setNum(int n);
        int getNum();
    }
    //второй интерфейс
    interface Second
    {
        //объявление индексатора
        int this[int k]
        {
            get;
        }
    }
    //класс реализует интерфейс и класс
    class MyClass : Base, First, Second
    {
        //закрытое целочисленное поле
        private int num;
        //конструктор с одним аргументом
        public MyClass(int n) : base(n)
        {
        }
        //описание метода из интерфейса First:
        public void setNum(int n)
        {
            num = n;
        }
        //описание метода из интерфейса first
        public int getNum()
        {
            return num;
        }
        //описание свойства из класса Base:
        public override int number
        {
            get
            {
                return getNum();
            }
            set
            {
                setNum(value);
            }
        }
        //описание индексатора из интерфейса Second
        public int this[int k]
        {
            get
            {
                int r = number;

                for(int i=0;i<k;i++)
                {
                    r /= 10;
                }
                return r % 10;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 9;
            MyClass obj = new MyClass(12345);
            for(int i=0;i<=m;i++)
            {
                Console.Write("|" + obj[m-i]);
            }
            Console.WriteLine("|");
        }
    }
}
