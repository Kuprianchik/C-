using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//объявление делегата
delegate int MyDelegate(char s, string str);
namespace _2._2_домашнее_задание_1
{
    internal class Program
    {
        static int First(char s,string str)
        {
            int n=0;
            for(int i=0;i<str.Length;i++)
            {
                if (s == str[i])
                {
                    n++;
                }
            }
            return n;
        }
        static int Second(char s,string str)
        {
            int n=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (s == str[i])
                {
                    n=i+1;
                    break;
                }
            }
            if(n!=0)
            {
                return n;
            }
            else
            {
                return -1;
            }    
        }
        static void Main(string[] args)
        {
            MyDelegate md;
            md = Second;
            Console.WriteLine(md('ы',"Александра"));
            md = First;
            Console.WriteLine(md('е',"Александра"));
        }
    }
}
