using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5_Использование_различных_свойств
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            //проверка содержимого массива из объекта:
            Console.WriteLine(obj.content);
            //присваивание Значения свойству element:
            obj.element = 10;
            //проверка содержимого массива из объекта:
            Console.WriteLine(obj.content);
            //присваивание Значения свойству element:
            obj.element = 5;
            //присваивание Значения свойству element:
            obj.element = 7;
            //проверка содержимого массива из объекта:
            Console.WriteLine(obj.content);
            //считывание значения свойства data:
            int[] A = obj.data;
            obj.element = 12;
            //Отображение содержимого массива A:
            for (int k = 0; k < A.Length; k++)
            {
                Console.Write(A[k] + " ");
            }
            Console.WriteLine();
            //Проверка содержимого массива из объекта:
            Console.WriteLine(obj.content);
            //Создание массива:
            int[] B = { 11, 3, 6 };
            //присваивание значения свойству data:
            obj.data = B;
            //Изменение значения элемента массива B:
            B[0] = 0;
            //Отображение массива B:
            for (int k = 0; k < B.Length; k++)
            {
                Console.Write(B[k] + " ");
            }
            Console.WriteLine();
            //проверка содержимого массива из объекта:
            Console.WriteLine(obj.content);
        }
    }
    class MyClass
    {
        //закрытое поле-массив:
        private int[] nums;
        //текстовое свойство без set-аксессора:
        public string content
        {
            //метод вызывается при считывании значения свойства:
            get
            {
                //если ссылка на массив пустая:
                if (nums == null) return "{}";
                //Формирование текстовой строки:
                string txt = "{" + nums[0];
                for (int k = 1; k < nums.Length; k++)
                {
                    txt += "," + nums[k];
                }
                txt += "}";
                return txt;
            }
        }
        //целочисленное свойство без get-аксессора:
        public int element
        {
            //метод вызывается при присваивании
            //значения свойству:
            set
            {
                //если ссылка на массив пустая:
                if (nums == null)
                {
                    //создание массива из одного элемента
                    nums = new int[1];
                    //значение единственного элемента массива:
                    nums[0] = value;
                }
                else // если ссылка не пустая
                {
                    //создание массива:
                    int[] n = new int[nums.Length + 1];
                    //Заполнение массива:
                    for (int k = 0; k < nums.Length; k++)
                    {
                        n[k] = nums[k];
                    }
                    //значение последнего элемента в массиве:
                    n[nums.Length] = value;
                    //ссылка на созданный массив записывается в 
                    //поле объекта:
                    nums = n;
                }
            }
        }
        //свойство является ссылкой на массив:
        public int[] data
        {
            //Метод вызывается при считывании значения свойства:
            get
            {
                //создание массива:
                int[] res = new int[nums.Length];
                //заполнение массива:
                for (int k = 0; k < nums.Length; k++)
                {
                    res[k] = nums[k];
                }
                //значение свойства:
                return res;
            }
            //метод вызывается при присваивании значения свойству:

            set
            {
                //создание массива:
                nums = new int[value.Length];
                //Заполнение массива:
                for (int k = 0; k < value.Length; k++)
                {
                    nums[k] = value[k];
                }
            }
        }
    }
}
