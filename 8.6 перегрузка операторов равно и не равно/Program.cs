using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6_перегрузка_операторов_равно_и_не_равно
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //обьекты класса Alpha
            Alpha A1 = new Alpha(100);
            Alpha A2 = new Alpha(100);
            Alpha A3 = new Alpha(200);
            //проверка обьектов на предмет равенства не равенства
            Console.WriteLine("A1==A2 дает {0}", A1==A2);
            Console.WriteLine("A1!=A2 дает {0}", A1 != A2);
            Console.WriteLine("A1==A3 дает {0}", A1 == A3);
            Console.WriteLine("A1!=A3 дает {0}", A1 != A3);

            //создание обьектов класса Bravo
            Bravo B1= new Bravo(100);
            Bravo B2= new Bravo(100);
            Bravo B3= new Bravo(200);
            //проверка обьектов на предмет
            //равенства или неравенства:
            Console.WriteLine("B1==B2 дает {0}",B1==B2);
            Console.WriteLine("B1!=B2 дает {0}", B1 != B2);
            Console.WriteLine("B1==B3 дает {0}", B1 == B3);
            Console.WriteLine("B1!=B3 дает {0}", B1 != B3);

        }
    }
    class Alpha
    {
        //целочисленное поле
        public int code;
        public Alpha(int n)
        {
            code = n;
        }
    }
    class Bravo
    {
        public int code;
        public Bravo(int n)
        {
            code = n;
        }
        //перегрузка оператора равно
        public static bool operator ==(Bravo a, Bravo b)
        {
            return a.code == b.code;
        }
        //перегрузка оператора не равно
        public static bool operator !=(Bravo a, Bravo b)
        {
            return !(a == b);
        }
    }
}
