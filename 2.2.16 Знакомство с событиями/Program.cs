using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate void MyDelegate(string txt);
//класс с событием
class MyClass
{
    //объявление события
    public event MyDelegate MyEvent;
    //метод для генерирования события:
    public void RaiseMyEvent(string txt)
    {
        //если для события предусмотрены обработчики:
        if(MyEvent!=null)
        {
            //генерирование события
            MyEvent(txt);
        }
    }
}
//класс
class Alpha
{
    public string name;
    //конструктор
    public Alpha(string txt)
    {
        name = txt;
    }
    //метод отображает сообщение
    public void show(string msg)
    {
        Console.WriteLine("Объект "+name+":");
        Console.WriteLine(msg);
    }
}
namespace _2._2._16_Знакомство_с_событиями
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            //создание объектов
            Alpha A = new Alpha("A");
            Alpha B = new Alpha("B");
            //попытка сгенерировать событие
            obj.RaiseMyEvent("1-е событие");
            //Добавление обработчика для события
            obj.MyEvent += A.show;
            //Генерирование события
            obj.RaiseMyEvent("2-е событие");
            Console.WriteLine();
            //добавление обработчика для события
            obj.MyEvent += B.show;
            //генерирование события
            obj.RaiseMyEvent("3-е событие");
            Console.WriteLine();
            //Удаление метода из списка обработчиков события
            obj.MyEvent -= A.show;
            //генерирование события
            obj.RaiseMyEvent("4-е событие");
            Console.WriteLine();
            //удаление методов из списка обработчиков события
            obj.MyEvent -= A.show;
            obj.MyEvent -= B.show;
            //попытка сгенерировать событие
            obj.RaiseMyEvent("5-е событие");
            //создание экземпляра делегата
            MyDelegate md = A.show;
            //добавление метода в список вызовов
            //экземпляра делегата
            md += B.show;
            //добавление экземпляра делегата в список 
            //обработчиков события
            obj.MyEvent += md;
            //генерирование события
            obj.RaiseMyEvent("6-е событие");
        }
    }
}
