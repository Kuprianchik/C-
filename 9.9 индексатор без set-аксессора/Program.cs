using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._9_индексатор_без_set_аксессора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(1234599);
            //цифры в десятичном представлении числа:
            for(int k = 1;k<9;k++)
            {
                Console.Write(" | " + obj[k]);
            }
            Console.WriteLine(" |");
        }
    }
    class MyClass
    {
        //Закрытое целочисленное поле:
        private int number;
        public MyClass(int n)
        {
            number = n;
        }
        //целочисленные индексатор с целочисленным индексом:
        public int this[int k]
        {
            get
            {
                int n = number;
                //отбрасывание цифр из младших разрядов:
                for(int i=1;i<k;i++) 
                {
                    n /= 10;
                }
                //значение свойства
                return n % 10;
            }
        }
    }
}
