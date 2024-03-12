using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_2
{
    abstract class Base
    {
        protected string pole;
        public  Base(string txt)
        {
         pole = txt;
        }
        abstract public int n
        {
            get;
        }
        abstract public void show(string t);
        abstract public void show();
        abstract public int this[int i]
        {
            get;
        }
    }
    class First:Base
    {
        public First(string txt):base(txt)
        {

        }
        public override int n
        {
            get
            {
                return pole.Length;
            }
        }
        public override void show()
        {
            Console.WriteLine(pole);
        }
        public override void show(string t)
        {
            pole = t;
        }
        public override int this[int i]
        {
            get { return (int)pole[i]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            First obj = new First("Александра");
            obj.show();
            Console.WriteLine(obj.n);
            Console.WriteLine(obj[1]);
            obj.show("Митрахович");
            obj.show();
        }
    }
}
