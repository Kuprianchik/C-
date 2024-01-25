using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6_статическое_свойство
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //отображение значения статического свойства:
            for(int k=1;k<=10;k++) 
            {
                Console.Write("{0,4}",Fibs.number);
            }
            Console.WriteLine();
            //Присваивание значения статическому свойству:
            Fibs.number = 6;
            //отображение значения статического свойства:
            for (int k = 1; k <= 10; k++)
            {
                Console.Write("{0,4}", Fibs.number);
            }
            Console.WriteLine();
            //Присваивание значения статическому свойству:
            Fibs.number = 1;
            //отображение значения статического свойства:
            for (int k = 1; k <= 10; k++)
            {
                Console.Write("{0,4}", Fibs.number);
            }
            Console.WriteLine();

        }
    }
    //класс со статическим свойством:
    class Fibs
    {
        //закрытые целочисленные статические поля:
        private static int last = 1;
        private static int prev = 1;
        //статическое целочисленное свойство:
        public static int number
        {
            //метод вызывается при считывании значения свойства
            get
            {
                //локальная переменная:
                int res = prev;
                //изменение значения статических полей:
                last = last + prev;
                prev = last - prev;
                //значение свойства:
                return res;
            }
            set
            {
                // начальное значение статических полей:
                prev = 1;
                last = 1;
                //изменение значения статических полей:
                for(int k=2;k<=value;k++)
                {
                    last = last + prev;
                    prev = last - prev;
                }
            }
        }
    }
}
