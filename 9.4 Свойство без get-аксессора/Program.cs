using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4_Свойство_без_get_аксессора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);
            //бинарный код целого числа:
            Console.WriteLine("Бинарный код числа 5:\t"+obj);
            //присваивание значения свойству:
            obj.number = 45;
            //бинарный код целого числа:
            Console.WriteLine("Бинарный код числа 45:\t" + obj);
        }
    }
    class MyClass
    {
        //закрытое текстовое поле
        private string code;
        //свойство без get-аксессора:
        public uint number
        {
            //метод вызывается при присваивании значения свойству:
            set
            {
                //локальная переменная
                uint num = value;
                //начальное значение текстового поля
                code = "";
                do
                {
                    //значение последнего(младшего) бита
                    //дописывается слева к тексту:
                    code = (num % 2) + code;
                    //сдвиг кода числа на одну позицию вправо:
                    num >>= 1;
                }
                while(num != 0);
            }
        }
        //конструктор с одним аргументом:
        public MyClass(uint n)
        {
            number = n;
        }
        public override string ToString()
        {
            return code;//результат метода
        }
    }
}
