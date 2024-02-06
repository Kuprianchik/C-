using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3_конструктор_производного_класса
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Конструктор без аргументов
            Alpha A1 = new Alpha();
            Console.WriteLine();
            //создание объекта базового класса
            //(конструктор с одним аргументом):
            Alpha A2 = new Alpha(100);
            Console.WriteLine();
            //создание объекта производного класса
            //Конструктор с двумя аргументами:
            Bravo B1 = new Bravo(200, 'B');
            Console.WriteLine();
            //Создание объекта производного класса
            //(конструктор с целочисленным аргументом)
            Bravo B2 = new Bravo(300);
            Console.WriteLine();
            //Создание объекта производного класса
            //(конструктор с символьным аргументом)
            Bravo B3 = new Bravo('C');
            Console.WriteLine();
            //Создание объекта производного класса
            //(конструктор без аргументов)
            Bravo B4 = new Bravo();

        }
    }
    class Alpha
    {
        public int code;
     //конструктор один агрумент
        public Alpha(int n)
        {
            code = n;
            Console.WriteLine("Alpha (один аргумент): {0}",code);
        }
        //конструктор без аргументов
        public Alpha()
        {
            code = 123;
            Console.WriteLine("Alpha (без аргументов): {0}",code);
        }
    }
    class Bravo: Alpha
    {
        //символьное поле
        public char symb;
        //Конструктор с двумя аргументами:
        public Bravo(int n,char s):base(n)
        {
            symb = s;
            Console.WriteLine("Bravo (два агрумента): {0} и \'{1}\'",code,symb);
        }
        //конструкто с целочисленным аргументом:
        public Bravo(int n):base(n)
        {
            symb = 'A';
            Console.WriteLine("Bravo (int-аргумент): {0} и \'{1}\'",code,symb);
        }
        //конструктор с символьным аргументом:
        public Bravo(char s):base(321)
        {
            symb = s;
            Console.WriteLine("Bravo (char-аргумент): {0} и \'{1}\'", code, symb);
        }
        //конструктор без агрументов
        public Bravo():base()
        {
            symb = 'O';
            Console.WriteLine("Bravo (без аргументов): {0} и \'{1}\'",code,symb);
        }
    }
}
