using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_6
{
    internal class Program
    {
        interface First
        {
         int this[char i]
            {
                get;
            }
        }
        interface Second
        {
            char this[int i]
            {
                get;
            }
        }
        class Boss:First,Second
        {
            private int n;
            private char c;
            public Boss(int n, char c)
            {
                this.n = n;
                this.c = c;
            }

            public int this[char i]
            {
                get
                {
                    return n;
                }
            }
            public char this[int i]
            {
                get
                {
                    return c;
                }
            }
        }
        static void Main(string[] args)
        {
            Boss obj = new Boss(5, 'А');
            Console.WriteLine("Возврат целочисленного значения: "+obj['a']);
            Console.WriteLine("Возврат символьного значения: "+obj[3]);
        }
    }
}
