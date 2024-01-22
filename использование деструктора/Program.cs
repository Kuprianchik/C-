using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace использование_деструктора
{
    internal class Program
    {
        static void maker(string txt)
        {
            new MyClass(txt);
        }
        static void Main(string[] args)
        {
            MyClass A = new MyClass("Первый");
           //создание анонимного объекта:
            new MyClass("Второй");
            A = new MyClass("Третий");
            maker("Четвертый");
            A = new MyClass("Пятый");
        }
    }
    class MyClass
    {
        private string name;
        public MyClass(string txt)
        {
            name = txt;
            Console.WriteLine($"Создан объект {name}");
        }
        ~MyClass() 
        {
            Console.WriteLine($"Удален объект {name}");
        }
    }
}
