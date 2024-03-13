using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_9
{
    abstract class Base
    {
        protected char[] mas;
         public Base(string txt)
        {
            mas=txt.ToArray();
        }
        public char Show(int n)
        {
            return mas[n];
        }
        public abstract void Show(int n, char c);  
    }
    interface First
    {
        void Show(string txt);
        char this[int n,int g] { get; }
    }
    class Boss : Base, First
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
