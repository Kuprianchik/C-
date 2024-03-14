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
            mas = txt.ToArray();
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
        char this[int n] { get; set; }
    }
    class Boss : Base, First
    {
        char[] mas1;
        public Boss(string txt):base(txt)
        { }
        public override void Show(int n, char c)
        {
            mas[n] = c;
        }
        //создание нового массива 
        public void Show(string txt)
        {
            mas1 = txt.ToArray();
            mas = mas1;
        }
        //получение элемента, и установка нового
        public char this[int n]
        {
            get
            {
                return (char)mas[n];
            }
            set
            {
                Show(n, value);
            }
        }
        public string Show()
        {
            //преобразование в текстовую строку и возврат
            return string.Concat<char>(mas);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boss obj = new Boss("Александра");
            Console.WriteLine("Индексатор: " + obj[5]);
            Console.WriteLine(obj[5]='ы') ;
            Console.WriteLine(obj.Show());
            obj.Show("Митрахович-молодец");
            Console.WriteLine(obj.Show());


        }
    }
}
