using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_3
{
    internal class Program
    {
        interface First
        {
            int Show();       
        }
        class Alpha:First
        {
            int n;
            public Alpha(int n)
            {
                this.n = n;
            }
            public int Show()
            {
                return n;
            }
        }
        class Beta : First
        {
            int n;
            public Beta(int n)
            {
                this.n = n;
            }
            public int Show()
            {
                return n+n;
            }
        }
        static void Main(string[] args)
        {
            Alpha obj = new Alpha(3);
            Beta obj2 = new Beta(3);
            Console.WriteLine(obj.Show());
            Console.WriteLine(obj2.Show());
            First A;
            A = new Alpha(1);
            First B;
            B = new Beta(1);
            Console.WriteLine(A.Show());
            Console.WriteLine(B.Show());
        }
    }
}
