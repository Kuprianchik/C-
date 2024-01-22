using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace закрытые_члены_класса_и_перегрузка_методов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass obj = new MyClass();
            //obj.set();
            //obj.show();
            //obj.set(200);
            //obj.show();
            //obj.set(300, 'C');
            //obj.show();
            Myclass2 A = new Myclass2();
            A.show();
            Myclass2 B = new Myclass2(200);
            B.show();
            Myclass2 C = new Myclass2(300, 'C');
            C.show();
            Myclass2 D = new Myclass2(400, 'D', "Синий");
            D.show();
            Myclass2 F = new Myclass2('A');
            F.show();
            Myclass2 G = new Myclass2("Серый");
            G.show();

        }
    }
    class MyClass
    {
        private int number;
        private char symbol;
        public void show()
        {
            Console.WriteLine("Поля объекта: " + number + " и " + symbol);
        }
        public void set(int n, char s)//перегрузка метода
        {
            number = n;
            symbol = s;
        }
        public void set(int n)//перегрузка метода
        {
            number = n;
            symbol = 'B';
        }
        public void set()//перегрузка метода
        {
            set(100, 'A');
        }
    }
    class Myclass2
    {
        private int num;
        private char symb;
        private string txt;
        public void show()
        {
            Console.WriteLine($"Поля {num},  {symb}, {txt}.");
        }
        public Myclass2()//Конструктор без аргументов:
        {
            num = 100;
            symb = 'A';
            txt = "Красный";
        }
        public Myclass2(int n)//Конструктор с 1 аргументом:
        {
            num = n;
            symb = 'A';
            txt = "Красный";
        }
        public Myclass2(int n, char s)//Конструктор с 2 аргументами:
        {
            num = n;
            symb = s;
            txt = "Красный";
        }
        public Myclass2(int n, char s, string t)//Конструктор с 3 аргументами:
        {
            num = n;
            symb = s;
            txt = t;
        }
        public Myclass2(string t)//Конструктор с 1 текстовым аргументом:
        {
            num = 0;
            symb = 'Z';
            txt = t;
        }
    }
}
