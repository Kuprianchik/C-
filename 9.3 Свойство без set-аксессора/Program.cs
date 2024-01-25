using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_Свойство_без_set_аксессора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(1, 9);
            //проверка значения свойства
            Console.WriteLine("Сумма полей: "+obj.sum);
            //присваивание значения полю:
            obj.first = 6;
            //проверка значений свойства
            Console.WriteLine("Сумма полей: "+obj.sum);
            //присваивание значения полю:
            obj.last = 2;
            //проверка значений свойства
            Console.WriteLine("Сумма полей: " + obj.sum);


        }
    }
    //класс со свойством
    class MyClass
    {
        //открытые целочисленные опля:
        public int first;
        public int last;
        public MyClass(int first, int last)
        {
            this.first = first;
            this.last = last;
        }
        //целочисленное свойство
        public int sum 
        {
            //метод вызывается при считывании значений свойства:
            get 
            {
                //значение свойства:
                return first + last;
            }
        }
    }
}
