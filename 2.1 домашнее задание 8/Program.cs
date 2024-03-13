using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_8
{
    internal class Program
    {
        interface First
        {
            string txt
            {
                get;
            }
        }
        interface Second
        {
            string txt
            {
                get;
            }
        }
        class Boss : First, Second
        {
            private string text;
            public Boss(string text)
            {
                this.text = text;
            }
            public string txt
            {
                get
                {
                    return this.text;
                }
            }
             string First.txt
            {
                get
                {
                    return "Александра";
                }
            }
            string Second.txt
            {
                get
                {
                    return "Митрахович";
                }
            }
        }
        static void Main(string[] args)
        {
            Boss obj = new Boss("Павловна");
            Console.WriteLine(obj.txt);
            First F;
            F = obj;
            Console.WriteLine(F.txt);
            Second S;
            S = obj;
            Console.WriteLine(S.txt);
        }
    }
}
