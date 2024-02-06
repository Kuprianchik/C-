using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._15_перегрузка_индексаторов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            MyClass obj = new MyClass(6);
            Console.WriteLine(obj);
            //поэлементное отображение содержимого массива
            for (int k = 0; k < n + 3; k++)
            {
                //объект с целочисленным индексом
                Console.Write(obj[k] + " ");
            }
            Console.WriteLine("\n");
            //объект с целочисленным индексом:
            obj[1] = 7;
            obj[n + 3] = 8;
            Console.WriteLine(obj);
            //объект с символьным индексом:
            obj['a'] = 9;
            obj['k'] = 0;
            //проверка
            Console.WriteLine(obj);
            Console.WriteLine("Проверка:");
            //поэлементное отображение содержимого массива:
            for (char s = 'a'; s < 'a' + n + 3; s++)
            {
                //обьект с символьным индексом
                Console.Write(obj[s] + " ");
            }
            Console.WriteLine("\n");
            //Объект с целочисленным и текстовым индексом
            obj[4, "alpha"] = 0;
            obj["bravo", 0] = 6;
            //проверка
            Console.WriteLine(obj);
            //текстовая переменная
            string txt = "abc";
            Console.WriteLine("Проверка:");
            for(int k=0;k<txt.Length;k++)
            {
                //объект с двумя индексами
                Console.WriteLine(obj[k,txt]+": " + obj[txt,k]);
            }
        }
    }
    class MyClass
    {
        private int[] nums;
        //конструктор
        public MyClass(int size)
        {
            //создание массива
            nums = new int[size];
            //заполнение массива
            for (int k = 0; k < nums.Length; k++)
            {
                //использование индексатора
                this[k] = k + 1;
            }
        }
        public override string ToString()
        {
            string txt = "Содержимое объекта:\n";
            for (int k = 0; k < nums.Length; k++)
            {
                //используется индексатор с целочисленным
                //индексом
                txt += this[k] + (k == nums.Length - 1 ? "\n" : " ");

            }
            return txt;
        }
        //индексатор с целочисленным индексом:
        public int this[int k]
        {
            get
            {
                return nums[k % nums.Length];
            }
            set
            {
                nums[k % nums.Length] = value;
            }
        }
        //индексатор с символьным индексом:
        public int this[char s]
        {
            get
            {
                //используется индексатор с целочисленным индексом:
                return this[s - 'a'];
            }
            set
            {
                //используется индексатор с целочисленным 
                //индексом
                this[s - 'a'] = value;
            }
        }
        //индексатор с целочисленным и текстовым индексом
        public int this[int k, string t]
        {
            get
            {
                //используется индексатор с символьным индексом:
                return this[t[k]];
            }
            set
            {
                //используется индексатор с символьным индексом
                this[t[k]] = value;
            }
        }
        //индексатор с текстовым и целочисленным индексом
        public int this[string t, int k]
        {
            get
            {
                //использование индексатора с целочисленным и текстовым индексом:
                return this[k, t];
            }
            set
            {
                //использование индексатора с целочисленным и текстовым индексом:
                this[k, t] = value;
            }
        }
    }
}
