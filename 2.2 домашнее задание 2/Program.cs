using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate void MyDelegate(char s);
//объявление класса
class Alpha
{
    private char s;
    public void Set(char s)
    {
        this.s = s;
        Console.WriteLine("Присвоили значение: "+s);
    }
}
namespace _2._2_домашнее_задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha[] alpha = new Alpha[5];
            MyDelegate md;
         
            for (int i = 0; i < alpha.Length; i++)
            {
                alpha[i]= new Alpha();
            }
            md = alpha[0].Set;
            for(int i=1; i < alpha.Length; i++)
            {
                md += alpha[i].Set;
                md((char)('a' + i));
            }

        }

    }
}
