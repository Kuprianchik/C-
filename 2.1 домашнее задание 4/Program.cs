using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_4
{
    abstract class Base
    {
         protected int n,m;
        public Base(int n,int m) 
        {
            this.n = n;
            this.m = m;
        }
        abstract public int this[int i]
        {
            get;
 
        }
    }
    interface Alpha
    {
        int show(int n);
    }
    class First:Base,Alpha
    {
        public First(int n,int m):base(n,m)
        {
        }
        public override int this[int i]
        {
            get
            {
                if(i%2==0)
                {
                    return n;
                }
                else
                {
                    return m;
                }

            }
        }
        public int show(int g)
        {
            return (n + m) * g;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            First obj = new First(5, 3);
            Console.WriteLine(obj.show(2));
            Console.WriteLine(obj[4]);
        }
    }
}
