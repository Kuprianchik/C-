using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate char MyDelegate();
class MyClass
{
    public string text;
    private MyDelegate my;
    public MyDelegate Get
    {
        get
        {
            //возвращение делегата
            return my;
        }
    }
    public MyClass(string text, bool log)
    {
        this.text = text;
        //если 2 аргумент true, то делегат my возвращает 1 символ 1 аргумента
        if (log == true)
        {
            my = delegate ()
            {

                return (char)(text[0]);
            };
            //A.method = n => A.number + n;
        }
        //если 2 аргумент false, то делегат my возвращает последний символ 1 аргумента
        else
        {
            my = delegate ()
            {

                return (char)(text[text.Length-1]);
            };
        }
    }
}
namespace _2._2_домашнее_задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass("Алекс", true);
            //вызов метода, который вызывает делегат, который возвращает char 
            Console.WriteLine(A.Get());
        }
    }
}
