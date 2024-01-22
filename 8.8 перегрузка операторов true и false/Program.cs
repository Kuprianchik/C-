using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._8_перегрузка_операторов_true_и_false
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(10);
            //использование операторного метода для 
            //оператора true. Объект использован как условие:
            while (obj)
            {
                //отображение значения поля объекта
                Console.Write(obj.code + " ");
                //уменьшение значения поля объекта
                obj.code--;
            }
            Console.WriteLine();
        }
    }
    //класс с перегрузкой операторов true и false
    class MyClass
    {
        //целочисленное поле
        public int code;
        public MyClass(int n)
        {
            code = n;
        }
        //перегрузка оператора true
        public static bool operator true(MyClass obj)
        {
            //проверяется значение поля объекта
            if (obj.code >= 5) return true;
            else
            {
                return false;
            }
        }
        //перегрузка оператора false
        public static bool operator false(MyClass obj)
        {
            //используется операторный метод для оператора true
            //объект использован как условие
            if (obj) return false;
            else return true;
        }
    }
}
