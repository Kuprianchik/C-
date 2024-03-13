using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_5
{
    interface First
    {

        int Show(string txt);
    }
    interface Second
    {
        string Show(int n);
    }
    class Alpha : First, Second
    {
        public int i;
        public string txt;

        public Alpha(int i, string txt)
        {
            this.i = i;
            this.txt = txt;
        }
        public int Show(string txt)
        {
            return i;
        }
        public string Show(int n)
        {
            return txt;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha obj = new Alpha(5, "Александра");
            First F;
            Console.WriteLine(obj.Show(1));
            Console.WriteLine(obj.Show("Александра"));
            Second S;
            F = obj;
            Console.WriteLine(F.Show("аа"));
            S = obj;
            Console.WriteLine(S.Show(5));

        }
    }
}
