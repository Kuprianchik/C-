using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._2_Многократная_адресация_для_экземпляров_делегата
{
        delegate void MyDelegate();
        //класс
        class MyClass
        {
            //текстовое поле
            public string name;
            public MyClass(string txt)
            {
                name = txt;
            }
            //метод без аргументов
            public void show()
            {
                Console.WriteLine(name);
            }
        }
      
    internal class Program
    {
            //статический метод без аргументов
            static void makeLine()
            {
                Console.WriteLine("--------");
            }
        
        static void Main(string[] args)
        {
            MyClass A = new MyClass("Объект А");
            MyClass B = new MyClass("Объект Б");
            MyClass C = new MyClass("Объект С");
            //объявление переменной делегата
            MyDelegate meth;
            meth = A.show;
            //вызов 
            meth();
            //присваивание переменной делегата нового значения;
            meth = makeLine;
            //добавление методов в список вызова
            meth += A.show;
            meth += B.show;
            meth = meth + C.show;
            //вызов экземпляра делегата
            meth();
            Console.WriteLine("");
            meth -= B.show;
            //вызов 
            meth();
            //удаление метода из списка вызова:
            meth = meth - A.show;
            //вызов экземпляра делегата
            meth();
        }
    }
}
