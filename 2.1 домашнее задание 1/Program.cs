using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _2._1_домашнее_задание_1
{
    abstract class Base
    {
        protected int[] mas;
        public Base(int R)
        {
           // mas = new int[R];
        }
        abstract public int R
        {
            set;
            get;
        }
        public abstract void show();
        abstract public int this[int i] { get; set; }
    }
    class First:Base
    {
        public First(int n):base(n)
        {
            R = n;
            mas= new int[R];
        }

        public override int R
        {
            set
            {
                R = value;
            }
            get
            {
                return R;
            }
        }
        public override void show()
        {
            for(int i=0;i<R;i++)
            {
                Console.Write("| " + mas[i]+" |");
            }
        }
        public override int this[int i]
        {
            set
            {
                mas[i] = value;
            }
            get
            {
                return mas[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            First obj = new First(5);
           
            for(int i=0;i<5;i++)
            {
                obj[i] = 2 * i;
            }
            obj.show();
        }
    }
}
