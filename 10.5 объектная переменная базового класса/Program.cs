using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_объектная_переменная_базового_класса
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(100, 'A');
            //объектная переменная базового класса
            Base obj;
            //Объектной переменной базового класса
            //присваивается ссылка на объект производного класса
            obj = A;
            Console.WriteLine("Используем переменную obj:");
            //вызов метода чере объектную переменную базового класса
            obj.show();
            //Используемя явное приведение типа
            ((MyClass)obj).display();
            //обращение к полю через объектную переменную 
            //базового класса:
            obj.code = 200;
            //использованоя явное приведение типа:
            ((MyClass)obj).symb = 'B';
            Console.WriteLine("Используем переменную A:");
            //Вызов методов через объектную переменную
            //производного класса
            A.show();
            A.display();
            MyClass B = new MyClass(A);
            //изменение значений полей исходного объекта
            A.code = 0;
            A.symb = 'O';
            Console.WriteLine("Используем переменную B:");
            //проверка значений полей объекта-копии
            B.show();
            B.display();
        }
    }
    //базовый класс
    class Base
    {
        public int code;
        //открытый метод
        public void show()
        {
            Console.WriteLine("Поле code: "+code);
        }
        //конструктор с целочисленным аргументом
        public Base(int n)
        {
            code = n;
        }
        //конструктор создания копии
        public Base(Base obj)
        {
            code = obj.code;
        }
    }
    //производный класс
    class MyClass : Base
    {
        public char symb;
        //открытый метода
        public void display()
        {
            Console.WriteLine("Поле symb: "+symb);
        }
        //конструкто с двумя аргументами
        public MyClass(int n,char s): base(n)
        {
            symb = s;
        }
        //конструктор создания копии
        public MyClass(MyClass obj): base(obj)
        {
            symb = obj.symb;
        }
    }
}
