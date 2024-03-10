using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._7.интерфейсы_и_неявная_реализация_членов
{
    //первый интерфейс
    interface First
    {
        void show();
    }
    //второй интерфейс
    interface Second
    {
        void show();
    }
    //класс реализует интерфейсы
    class MyClass:First,Second
    {
        //описание метода
        public void show()
        {
            Console.WriteLine("Объект класса MyClass");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта
            MyClass obj = new MyClass();
            //ссылка на объект записывается
            //в интерфейсные переменные:
            First A = obj;
            Second B = obj;
            //вызовы метода через разные переменные
            obj.show();
            A.show();
            B.show();
        }
    }
}
