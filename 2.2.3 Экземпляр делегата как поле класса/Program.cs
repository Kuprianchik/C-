using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._3_Экземпляр_делегата_как_поле_класса
{
    //объявление делегата
    delegate void MyDelegate(string txt);
    internal class Program
    {
        class MyClass
        {
        //поле являющимся ссылкой на экземпляр делегата
        public MyDelegate apply;
        public MyClass(MyDelegate md)
            {
                apply = md;
            }
        }
        class Alpha
        {
            //закрытое текстовое поле
            private string name;
            public void set(string t)
            {
                name = t;
            }
            //переопределение метода toString
            public override string ToString()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            Alpha A = new Alpha();
            //создание объекта
            //аргумент конструктора - ссылка на метод)
            MyClass obj=new MyClass(A.set);
            //вызов экземпляра делегата:
            obj.apply("Объект А");
            //проверка поля объекта
            Console.WriteLine(A);
            //создание объекта
            Alpha B = new Alpha();
            //полю значением присваивается ссылка на метод:
            obj.apply = B.set;
            //вызов экземпляра делегата
            obj.apply("Объект B");
            //проверка поля объекта
            Console.WriteLine(B);
            //Добавление метода в список вызовов экземпляра
            //делегата
            obj.apply += A.set;
            //вызов экземпляра делегата
            obj.apply("Объект X");
            //проверка полей объектов 
            Console.WriteLine(A+" и "+B);
            //удаление метода из списка вызовов экземпляпра
            //делегата
            obj.apply -= B.set;
            //вызов экземпляра делегата
            obj.apply("Объект A");
            Console.WriteLine(A+" и "+B);
        }
    }
}
