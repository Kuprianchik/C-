using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_использование_свойства
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта
            MyClass obj = new MyClass(1, 9);
            Console.WriteLine(obj);
            //Проверка значения свойства:
            Console.WriteLine("Свойство number: {0}",obj.number);
            //проверка значений полей объекта:
            Console.WriteLine(obj);
            //присваивание значения свойству:
            obj.number = 5;
            //проверка значений полей объекта:
            Console.WriteLine(obj);
            //проверка значений свойства:
            Console.WriteLine("Свойство number: {0}", obj.number);
            //проверка значений полей объекта:
            Console.WriteLine(obj);
            //Присваивание значения свойству:
            obj.number = 3;
            Console.WriteLine(obj);


        }
    }
    class MyClass
    {
        //закрытые целочисленные поля
        private int first;
        private int last;
        public MyClass(int a,int b)
        {
            first = a; last = b;
        }
        public override string ToString()
        {
            //Формирование текстового значения:
            string txt = "Поля объекта: ";
            txt += first + " и " + last;
            //результат метода:
            return txt;
        }
        //целочисленное свойство
        public int number
        {
            get 
            {
                //запоминание значения второго поля:
                int t = last;
                //Новое значение второго поля:
                last=first;
                //новое значение первого поля
                first = t;
                //значение свойства
                return t;
            }
            //вызывается при присваивании значения свойству
            set 
            {
                //новое значение второго поля:
                last = first;
                first = value;
            }
        }
    }
}
