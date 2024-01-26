using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7_знакомство_с_индексаторами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(5);
            //отображение содержимого массива из объекта
            Console.WriteLine(obj);
            //присваивание значений элементам массива из объекта
            //с использованием индексирование объекта:
            for(int k=0;k<obj.length;k++)
            {
                //используется индексирование объекта:
                obj[k] = 2 * k + 1;
            }
            //отображение содержимого массива из объекта:
            Console.WriteLine(obj);
            //поэлементное отображение массива из объекта
            //с использованием индексирование объекта:
            for(int k=0;k<obj.length; k++) 
            {
                //используется индексирование объекта:
                Console.Write(" " + obj[k]);
            }
            Console.WriteLine();
        }
    }
    //класс с индексатором
    class MyClass
    {
        //закрытое поле, являющееся ссылкой на массив:
        private int[] nums;
        //конструктор с целочисленным аргументом:
        public MyClass(int n)
        {
            //создание массива
            nums=new int[n];
            //заполнение массива
            for(int k=0;k<nums.Length;k++) 
            {
                nums[k]=0;
            }
        }
        public override string ToString() 
        {
            //формирование текстовой строки
            string txt = "{" + nums[0];
            for(int k=1;k<nums.Length;k++)
            {
                txt += "," + nums[k];
            }
            txt += "}";
            return txt;
        }
        //целочисленное свойство
        public int length 
        {
            get 
            {
                //значение выражения:
                return nums.Length;
            }
        }
        //целочисленные индексатор с целочисленным индексом:
        public int this[int k]
        {
            get
            {
                //значение выражения
                return nums[k];
            }
            set
            {
                nums[k] = value;
            }
        }
    }
}
