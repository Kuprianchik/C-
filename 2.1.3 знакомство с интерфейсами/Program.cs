using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._3_знакомство_с_интерфейсами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 9;
            MyClass obj = new MyClass(12345);
            //индексирование
            for(int i=0;i<=m;i++)
            {
                Console.Write("|" + obj[m-i]);
            }
            Console.WriteLine("|");

        }
    }
    //интерфейс
    interface MyInterface
    {
        //обьявление методов
        void show();
        void SetNum(int n);
        int GetNum();
        //объявление свойства
        int number
        {
            get;
            set;
        }
        //объявление индексатора
        int this[int k]
        {
            get;
        }
    }
    //класс который реализует интерфейс
    class MyClass:MyInterface
    {
        private int num;
        
        //описание метода из интерфейса
        public int number
        {
            get
            {
                return GetNum();
            }
            set
            {
                SetNum(value);
            }
        }
        //описание метода из интерфейса
        public void show()
        {
            Console.WriteLine("Свойство number="+number);
        }
        //описание метода из интерфейса
        public void SetNum(int n)
        {
            num = n;
        }
        public int GetNum()
        {
            return num;
        }
        public int this[int k]
        {
            get
            {
                int r = number;
                //Отбрасывание цифр в десятичном представлении числа;
                for(int i=0;i<k;i++)
                {
                    r /= 10;
                }
                return r % 10;
            }
        }
        //конструктор с одним аргументом
        public MyClass(int n)
        {
            number = n;
            show();
        }
    }
}
