using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._5_Наследование_интерфейсов
{
    //первый интерфейс
    interface First
    {
        //свойство
        int number
        {
            get;
            set;
        }
        //индексатор
        int this[int k]
        {
            get;
        }
    }
    //второй интерфейс
    interface Second
    {
        //методы
        void setNum(int n);
        int getNum();
    }
    //интерфейс наслудет другие интерфейсы
    interface MyInterface:First,Second
    {
        //метод
        void show();
    }
    //
    class MyClass:MyInterface
    {
        private int num;
        public void show()
        {
            Console.WriteLine("Свойство number="+num);
        }
        public void setNum(int n)
        {
            num = n;
        }
        public int getNum()
        {
            return num;
        }
        public int number
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
        public MyClass(int n)
        {
            number = n;
            show();
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
