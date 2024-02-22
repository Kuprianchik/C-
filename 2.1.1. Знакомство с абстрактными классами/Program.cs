using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1.Знакомство_с_абстрактными_классами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объектная переменная абстрактного класса:
            Base obj;
            //Создание объектов производных классов
            Alpha A = new Alpha(123);
            Bravo B = new Bravo(321);
            //объектной переменной базового класса присваивается 
            //ссылка на объект производного класса:
            obj = A;
            Console.WriteLine("После выполнения команды obj=A");
            //вызов методов через объектную переменную
            //базового класса:
            obj.set(456);
            obj.show();
            //
            obj = B;
            obj.set(654);
            obj.show();
        }
    }
    //абстрактный класс
    abstract class Base
    {
        //
        protected int num;
        public Base(int n)
        {
            set(n);
        }
        //абстрактные методы
        public abstract void show();
        public abstract void set(int n);
        public abstract int get();
    }
    //производный класс на основе абстрактного класса:
    class Alpha:Base
    {
        //защищенное целочисленное поле
        protected int val;
        //конструктор
        public Alpha(int n):base(n)
        {
            show();
        }
        //переопределение абстрактного метода
        public override void show()
        {
            //отображение сообщения
            Console.WriteLine("Alpha: {0}, {1} и {2}",num,val,get());
        }
        //переопределение абстрактного метода:
        public override void set(int n)
        {
            //присвоение значений полям
            num = n;
            val = n % 10;
        }
        //переопределение абстрактного метода: 
        public override int get()
        {
            return num / 10; 
        }
    }
    //производный класс на основе абстрактного класса:
    class Bravo : Base
    {
        //защищенное целочисленное поле:
        protected int val;
        //конструктор
        public Bravo(int n):base(n)
        {
            //вызов метода 
            show();
        }
        //переопределение
        public override void show()
        {
            //отображение 
            Console.WriteLine("Bravo: {0}, {1} и {2}",num,val,get());
        }
        //переопределение
        public override void set(int n)
        {
            //присваивание
            num = n;
            val = n % 100;
        }
        //переопределение
        public override int get()
        {
            return num / 100;
        }
    }
}
