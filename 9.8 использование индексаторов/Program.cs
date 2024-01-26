using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8_использование_индексаторов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass('A');
            //индексирование объекта для считывания значения:
            for(int k=0;k<10;k++)
            {
                Console.Write(obj[k]+" ");
            }
            Console.WriteLine();
            obj[5] = 'Q';
            //индексирование объекта для считывания значения:
            for(int k=0;k<10;k++)
            {
                Console.Write(obj[k]+" ");
            }
            Console.WriteLine();
            //индексирование объекта для считывания значения:
            //использование отрицательного индекса
            for (int k = 0; k < 10; k++)
            {
                Console.Write(obj[-k] + " ");
            }
            Console.WriteLine();
        }
    }
    class MyClass
    {
        //Закрытое целочисленное поле
        private int code;
        //Конструктор с символьным аргументом
        public MyClass(char s)
        {
            //присваивание значения полю
            code = s;
        }
        //символьный индексатор с целочисленным индексом:
        public char this[int k]
        {
            //вызывается
            get
            {
                //значение свойства:
                return (char)(code + k);
            }
            set
            {
                code = value - k;
            }
        }
    }
}
