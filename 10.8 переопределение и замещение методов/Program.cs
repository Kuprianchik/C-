using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._8_переопределение_и_замещение_методов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта
            Alpha A=new Alpha();
            Console.WriteLine("Выполнение команды A.show():");
            A.show();
            //создание объекта производного класса
            Bravo B = new Bravo();
            Console.WriteLine("Выполнение команды B.hello():");
            //вызов замещающего метода из производного класса
            B.hello();
            Console.WriteLine("Выполнение команды B.hi():");
            //вызов переопределенного метода
            B.hi();
            Console.WriteLine("Выполнение команды B.show():");
            //вызов унаследованного метода
            B.show();
            Console.WriteLine("После выполнения команды A=B");
            //Объектной переменной базового класса присваивается
            //ссылка на объект производного класса:
            A = B;
            Console.WriteLine("Выполнение команды A.hello():");
            //Вызов ззамещаемого метода
            A.hello();
            Console.WriteLine("Выполнение команды A.hi():");
            A.hi();
            Console.WriteLine("Выполнение команды A.show():");
            //Вызов унаследованного метода:
            A.show();

        }
    }
    //базовый класс
    class Alpha
    {
        //Обычный (не виртуальный) метод
        public void hello()
        {
            Console.WriteLine("Метод hello() из класса Alpha");
        }
        //виртуальный метод:
        public virtual void hi()
        {
            Console.WriteLine("Метод hi() из класса Alpha");
        }
        //обычный (не виртуальный) метод:
        public void show()
        {
            //вызов методов
            hello();
            hi();
            Console.WriteLine();
        }
    }
    //производный класс
    class Bravo : Alpha
    {
        //замещение метода
        new public void hello()
        {
            Console.WriteLine("Метод hello() из класса Bravo");
        }
        //переопределение виртуального метода
        public override void hi()
        {
            Console.WriteLine("Метод hi() из класса Bravo");
        }
    }
}
