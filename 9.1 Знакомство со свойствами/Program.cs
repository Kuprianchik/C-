using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Знакомство_со_свойствами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта 
            MyClass obj = new MyClass(1, 9);
            //проверка значения свойства:
            Console.WriteLine("Свойство code: " + obj.code);
            //присваивание значения свойству:
            obj.code = 7;
            //проверка значения свойства:
            Console.WriteLine("Свойство code: " + obj.code);
            //присваивание значения свойству:
            obj.code = 20;
            //проверка значения свойства:
            Console.WriteLine("Свойство code: " + obj.code);
            //присваивание значения свойству:
            obj.code = -10;
            //проверка значения свойства:
            Console.WriteLine("Свойство code: " + obj.code);

        }
    }
    class MyClass
    {
        //закрытые целочисленные поля
        private int num;
        private int min;
        private int max;
        public MyClass(int a, int b)
        {
            //присваивание значения полям:
            min = a;
            max = b;
            //присваивание значения свойству:
            code = (max + min) / 2;
        }
        //описание целочисленного свойства:
        public int code
        {
            //метод вызывается при считывании свойства:
            get
            {
                //значение свойства
                return num;
            }
            set
            {
                //Если присваиваемое значение меньше минимально
                //допустимого
                if (value < min)
                    num = min;
                //если присваиваемое значение больше максимально допустимого
                else if (value > max)
                    num = max;
                else num = value;
            }
        }
    }
}
