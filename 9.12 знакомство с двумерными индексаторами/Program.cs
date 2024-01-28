using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._12_знакомство_с_двумерными_индексаторами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(2, 3);
            obj.show();
            //Индексирование объекта
            obj[0, 0] = 'A';
            obj[1, 2] = 'Z';
            obj.show();
            Console.WriteLine("Проверка");
            //иднексирование объекта
            Console.WriteLine("obj[0,0]={0}", obj[0, 0]);
            Console.WriteLine("obj[1,1]={0}", obj[1, 1]);
            Console.WriteLine("obj[1,2]={0}", obj[1, 2]);
           
        }
    }
    class MyClass
    {
        //закрытое поле
        private char[,] symbs;
        //конструктор
        public MyClass(int a, int b)
        {
            symbs = new char[a, b];
            //заполнение
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                //перебор столбцов
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    symbs[i, j] = 'О';
                }
            }
        }
        public void show()
        {
            Console.WriteLine("Двумерный массив:");
            //перебор строк:
            for (int i = 0; i < symbs.GetLength(0); i++)
            {
                //перебор столбцов
                for (int j = 0; j < symbs.GetLength(1); j++)
                {
                    Console.Write(symbs[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //двумерный индексатор
        public char this[int i, int j]
        {
            get
            {
                return symbs[i, j];
            }
            set
            {
                symbs[i, j] = value;
            }
        }
    }
}
