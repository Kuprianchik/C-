using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._8.Интерфейсы_и_явная_реализация_членов
{
    internal class Program
    {
        //базовый класс
        abstract class Base
        {
            //абстрактное свойство
            public abstract char symbol
            {
                get;
            }
            //абстрактный индексатор
            public abstract int this[int k]
            {
                get;
            }
            //абстрактный метод
            public abstract void show();
        }
        //первый интерфейс
        interface First
        {
            //свойство
            char symbol
            {
                get;
            }
            //индексатор
            int this[int k]
            {
                get;
            }
            //метод
            void show();
        }
        //второй интерфейс
        interface Second
        {
            //свойство
            char symbol
            {
                get;
            }
            //индексатор
            int this[int k]
            {
                get;
            }
            //метод 
            void show();
        }
        //производный класс наследует абстрактный 
        //и реализует интерфейсы:
        class Myclass:Base,First,Second
        {
            //закрытое символьное поле
            private char smb;
            //конструктор с символьным аргументом
            public Myclass(char smb):base()
            {
                this.smb = smb;
            }
            //описание свойства из абстрактного класса
            public override char symbol
            {
                get
                {
                    return smb;
                }
            }
            //явная реализация свойства из интерфейса First
            char First.symbol
            {
                get
                {
                    return (char)(smb + 1);
                }
            }
            //описание индексатора из базового класса
            public override int this[int k]
            {
                get
                {
                    return smb + k;
                }
            }
            //явная реализация индексатора из интерфейса Second
            int Second.this[int k]
            {
                get
                {
                    return smb - k;
                }
            }
            //описание метода из базового класса
            public override void show()
            {
                Console.WriteLine("Базовый класс Base:\t\'{0}\'",symbol);
            }
            //явная реализация метода из интерфейса First
            void First.show()
            {
                Console.WriteLine("Интерфейс First:\t\'{0}\'",symbol);
            }
            //явная реализация метода из интерфейса Second
            void Second.show()
            {
                Console.WriteLine("Интерфейс Second:\t\'{0}\'", symbol);
            }


        }
        static void Main(string[] args)
        {
            //создание объекта 
            Myclass obj = new Myclass('A');
            //интерфейсные переменные
            First A = obj;
            Second B = obj;
            //вызов метода через переменные 
            obj.show();
            A.show();
            B.show();
            //считывание значения свойства:
            Console.WriteLine("obj.symbol=\'{0}'",obj.symbol);
            Console.WriteLine("A.symbol=\'{0}'", A.symbol);
            Console.WriteLine("B.symbol=\'{0}'", B.symbol);
            //индексирование объекта
            Console.WriteLine("obj[10]={0}", obj[10]);
            Console.WriteLine("A[10]={0}", A[10]);
            Console.WriteLine("B[10]={0}", B[10]);
        }
    }
}
