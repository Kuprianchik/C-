using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._6.Интерфейсные_переменные
{
    //интерфейс
    interface MyInterface
    {
        //метод
        char getChar(int n);
        //объявление индексатора
        char this[int k]
        {
            get;
        }
    }
    //первый класс реализующий интерфейс
    class Alpha:MyInterface
    {
        //закрытое символьное поле
        private char symb;
        //конструктор с одним аргументом
        public Alpha(char s)
        {
            symb = s;
        }
        //описание метода 
        public char getChar(int n)
        {
            //результат
            return (char)(symb + n);
        }
        //описание индексатора
        public char this[int k]
        {
            get
            {
                return getChar(k);
            }
        }
    }
    //второй класс, реализующий интерфейс
    class Bravo : MyInterface
    {
        private string text;
        public Bravo(string text)
        {
            this.text = text;
        }
        //описание метода
        public char getChar(int k)
        {
            return text[k % text.Length];
        }
        //описание индексатора
        public char this[int k]
        {
            get
            {
                return getChar(k);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 5;
            //интерфейсная переменная
            MyInterface R;
            //создается объект класса Alpha и ссылка на него 
            //записывается в интерфейсную переменную;
            R = new Alpha('F');
            //вызов метода через интерфейсную переменную:
            Console.WriteLine("Символы от \'{0}\' до \'{1}\':", R.getChar(-m),R.getChar(m));
            //индексирование объекта через
            //интерфейсную переменную:
            for(int i=-m;i<=m;i++)
            {
                Console.Write("|" + R[i]);
            }
            Console.WriteLine("|");
            //создается объект класса Bravo и ссылка на него 
            //записывается в интерфейсную переменную
            R = new Bravo("bravo");
            //вызов интерфейса через интерфейсную переменную:
            Console.WriteLine("Символы от \'{0}\' до \'{1}\':", R.getChar(0), R.getChar(2*m+1));
            //индексирование объекта через
            //интерфейсную переменную:
            for (int i = 0; i <= 2*m+1; i++)
            {
                Console.Write("|" + R[i]);
            }
            Console.WriteLine("|");
        }
    }
}
