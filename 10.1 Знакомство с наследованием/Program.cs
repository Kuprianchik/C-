using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Знакомство_с_наследованием
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.code = 100;
            obj.symb = 'A';
            obj.display();
            //использование свойства
            obj.number = 200;
            Console.WriteLine("Свойство number: "+obj.number);
            obj.show();
        }
    }
    //Базовый класс
    class Base
    {
        public int code;
        public void show()
        {
            Console.WriteLine("Поле code: "+code);
        }
    }
    class MyClass:Base 
    {
        public char symb;
        public void display()
        {
            Console.WriteLine("Поле symb: "+symb);
            //вызов уснаследованного метода 
            show();
        }
        public int number
        {
            get 
            { 
                //обращение к унаследованному полю:
                return code;  
            }
            set
            {
                code = value;
            }
        }
    }
}
