using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6_замещение_членов_при_наследовании
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(100, 200);
            obj.show();
            Console.WriteLine();
            //присваивание значения замещенному полю
            obj.set(300);
            //присваивание значения замещающему полю:
            obj.code = 400;
            //отображение значений полей объекта:
            obj.show();
        }
    }
    class Base
    {
        public int code;
        //метод для отображения
        public void show()
        {
            Console.WriteLine("Класс Base: "+code);
        }
        //конструктор
        public Base(int n)
        {
            code = n;
        }
    }
    //производный класс
    class MyClass: Base
    {
        //новое поле замещает одноименное поле,
        //унаследованное из базового класса:
        new public int code;
        new public void show()
        {
            //вызов версии метода из базового класса
            base.show();
            //обращение к полю производного класса
            Console.WriteLine("Класс MyClass: "+code);
        }
        //метод для присваивания значения полю, унаследованного
        //из базового класса и замещенному в производном классе
        public void set(int n)
        {
            base.code = n;
        }
        //конструктор с двумя аргументами
        public MyClass(int m,int n):base(m)
        {
            code = n;
        }
    }
}
