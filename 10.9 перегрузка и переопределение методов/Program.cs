using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._9_перегрузка_и_переопределение_методов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha A = new Alpha();
            //вызов методов
            A.set();
            A.set(20);
            Console.WriteLine();
            //Создание объекта производного класса:
            Bravo B=new Bravo();
            //вызов методов
            B.set();
            B.set(30);
            B.set(40, 50);
        }
    }
    class Alpha
    {
        //целочисленное поле:
        public int alpha;
        //метод без аргументов:
        public void set()
        {
            //значение поля:
            alpha = 10;
            //отображение 
            Console.WriteLine("Alpha (без аргументов): {0}", alpha);
        }
        //метод (виртуальный) с одним аргументом:
        public virtual void set (int n)
        {
            //значение
            alpha = n;
            //отображение 
            Console.WriteLine("Alpha (один аргумент): {0}",alpha);
        }
    }
    class Bravo: Alpha
    {
        public int bravo;
        //переопределение виртуального метода
        public override void set(int n)
        {
            alpha = n;
            bravo = alpha;
            //отображение
            Console.WriteLine("Bravo (один аргумент): {0} и {1}",alpha,bravo);
        }
        //метод с двумя аргументами
        public void set(int m,int n)
        {
            alpha = m;
            bravo = n;
            Console.WriteLine("Bravo (два аргумента): {0} и {1}",alpha,bravo);
        }
    }
}
