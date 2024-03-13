using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_домашнее_задание_7
{
    interface First
    {
        int svoist
        {
            get;
            set;
        }
        void Show();
    }
    interface Second
    {
        string svoisto 
        { 
            get;
            set;
        }
        void Show();
    }
    class Boss:First,Second
    {
        private int i;
        private string txt;
        public Boss(int i, string txt)
        {
            this.i = i;
            this.txt = txt;
        }

        public int svoist
        {
            get
            {
                return i;
            }
            set
            {
                i=value;
            }
        }
        public string svoisto
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
            }
        }
        public void Show()
        {
            Console.WriteLine("Значение целочисленного свойства: "+svoist+", и значение текстового свойства: "+ svoisto);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boss obj = new Boss(1, "Александра");
            obj.Show();
        }
    }
}
