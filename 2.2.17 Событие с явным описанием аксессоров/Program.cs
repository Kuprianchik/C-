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
    //закрытое поле (ссылка на экземпляр делегата)
    //для реализации списка обработчиков события:
    private MyDelegate myevent;
    //объявление события (с описанием аксессоров)
    public event MyDelegate MyEvent
    {
        //аксессор для добавления
        add
        {
            //добавление ссылки на метод в список вызовов
            //экземпляра делегата
            myevent += value;
        }
        //аксессор для удаления метода из списка 
        //обработчиков события:
        remove
        {
            myevent -= value;
        }
    }
    //метод для генерирования события
    public void RaiseMyEvent(string txt)
    {
        //если для события предусмотрены обработчики
        if (myevent != null)
        {
            //генерирования события
            //(вызов экземпляра делегата):
            myevent(txt);
        }
    }
}
//класс
class Alpha
{
    public string name;
    public Alpha(string txt)
    {
        name = txt;
    }
    public void show(string msg)
    {
        Console.WriteLine("Объект " + name + ":");
        Console.WriteLine(msg);
    }
}
namespace _2._2._17_Событие_с_явным_описанием_аксессоров
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Alpha A = new Alpha("A");
            Alpha B = new Alpha("B");
            obj.RaiseMyEvent("1-е событие");
            obj.MyEvent += A.show;
            obj.RaiseMyEvent("2-е событие");
            Console.WriteLine();
            obj.MyEvent += B.show;
            obj.RaiseMyEvent("3-е событие");
            Console.WriteLine();
            obj.MyEvent -= A.show;
            obj.RaiseMyEvent("4-е событие");
            Console.WriteLine();
            obj.MyEvent -= A.show;
            obj.MyEvent -= B.show;
            obj.RaiseMyEvent("5-е событие");
            MyDelegate md = A.show;
            md += B.show;
            obj.MyEvent += md;
            obj.RaiseMyEvent("6-е событие");

        }
    }
}
