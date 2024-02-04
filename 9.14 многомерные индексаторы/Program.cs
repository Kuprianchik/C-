using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._14_многомерные_индексаторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass('A');
            Console.WriteLine(obj);
            //текстовые переменные
            string a = "Alpha", b = "Bravo";
            int i = 2, j = 4;
            //использование индексатора
            Console.WriteLine("obj[\"{0}\",{1},\"{2}\",{3}]={4}", a, i, b, j, obj[a, i, b, j]);
            obj[a, i, b, j] = 'F';
            Console.WriteLine(obj);
            Console.WriteLine("obj[\"{0}\",{1},\"{2}\",{3}]={4}", a, i, b, j, obj[a, i, b, j]);
            a = "Charle";
            i = 1;
            j = 2;
            Console.WriteLine("obj[\"{0}\",{1},\"{2}\",{3}]={4}", a, i, b, j, obj[a, i, b, j]);
        }
    }
    class MyClass
    {
        private int code;
        public MyClass(int n)
        {
            code = n;
        }
        public override string ToString()
        {
            return "Поле code объекта: " + code;
        }
        //многомерный индексатор:
        public char this[string a, int i, string b, int j]
        {
            get
            {
                return (char)(a[i] - b[j] + code);
            }
            set
            {
                //значение поля:
                code = value - (a[i] - b[j]);
            }
        }
    }
}
