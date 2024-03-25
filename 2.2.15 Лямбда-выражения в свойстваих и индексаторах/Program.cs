using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyClass
{
    private string text;
    public MyClass(string t)
    {
        text = t;
    }
    //индексатор
    public char this[int k] => text[k];
    //свойство
    public int length=>text.Length;

}
namespace _2._2._15_Лямбда_выражения_в_свойства_и_и_индексаторах
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass("Alpha");
            //использование индексатора и свойства
            for(int k=0;k<obj.length;k++)
            {
                Console.Write("|" + obj[k]);
            }
            Console.WriteLine("|");
        }
    }
}
