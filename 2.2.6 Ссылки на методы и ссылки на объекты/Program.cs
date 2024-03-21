using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//объявление делегата
delegate void MyDelegate(int n);
class MyClass
{
    //закрытое целочисленное поле
    private int number;
    //конструктор с одним аргументом
    public MyClass(int n)
    {
        set(n);
    }
    //метод для присваивания значения полю
   public void set(int n)
    {
        //присваивание значения полю
        number = n;
    }
    //переопределение метода ToString
    public override string ToString()
    {
        return "Поле number=" + number;
    }
}
namespace _2._2._6_Ссылки_на_методы_и_ссылки_на_объекты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта
            MyClass A = new MyClass(100);
            //объектная переменная ссылается
            //на ранее созданный объект
            MyClass B = A;
            //переменной типа делегата значением присваивается 
            //ссылка на метод объекта
            MyDelegate apply = A.set;
            //переменной присваивается ссылка на новый объект
            A = new MyClass(200);
            //проверка значений полей объектов
            Console.WriteLine(A);
            Console.WriteLine(B);
            //вызов экземпляра делегата
            apply(300);
            Console.WriteLine();
            //проверка значений полей объектов
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }
}
