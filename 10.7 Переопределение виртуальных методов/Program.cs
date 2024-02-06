using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._7_Переопределение_виртуальных_методов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha objA = new Alpha(10);
            //проверка
            objA.show();
            Console.WriteLine();
            //создание объекта класса Bravo
            Bravo objB = new Bravo(20, 30);
            //объектной переменной базового класса
            //присваивается ссылка
            //на объект производного класса:
            objA = objB;
            //проверка
            objA.show();
            objB.show();
            Console.WriteLine();
            //создание объекта класса Charlie:
            Charlie objC = new Charlie(40, 50, 60);
            //объектной переменной базового класса
            //присваивается ссылка на объект производного класса:
            objA = objC;
            objB=objC;
            //проверка
            objA.show();
            objB.show();
            objC.show();
        }
    }
    //базовый класс
    class Alpha
    {
        public int alpha;
        //виртуальный метод
        public virtual void show()
        {
            Console.WriteLine("Класс Alpha: {0}",alpha);
        }
        //Конструктор с одним аргументом
        public Alpha(int a)
        {
            alpha = a;
        }
    }
    //производный класс
    class Bravo: Alpha
    {
        public int bravo;
        //переопределение виртуального метода
        public override void show()
        {
            Console.WriteLine("Класс Bravo: {0} и {1}",alpha,bravo);
        }
        //конструктор с двумя аргументами
        public Bravo(int a,int b):base(a)
        {
            bravo = b;
        }
    }
    //производный класс
    class Charlie : Bravo
    {
        public int charlie;
        //переопределение виртуального метода
        public override void show()
        {
            Console.WriteLine("Класс Charlie: {0}, {1} и {2}",alpha,bravo,charlie);
        }
        //конструктор
        public Charlie(int a, int b,int c):base(a,b)
        {
            charlie = c;
        }
    }

    }
