using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_10
{
    abstract class Base
    {
        abstract protected int sv
        {
            get;
            set;
        }
        abstract protected int this[int n]
        {
            get;
            set;
        }
        abstract protected void Show();

    }
    interface First
    {
        string sv
        {
            get;
            set;
        }

        int this[int n]
        {
            get;
            set;
        }
        void Show(int n, char c);
    }
    interface Second
    {
        string sv
        {
            get;
            set;
        }

        int this[int n]
        {
            get;
            set;
        }
        void Show(int n, char c);
    }


}
internal class Program
{
    static void Main(string[] args)
    {
    }
}

