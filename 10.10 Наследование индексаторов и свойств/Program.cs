using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._10_Наследование_индексаторов_и_свойств
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            char s;
            Alpha A = new Alpha(100, "ABCD");
            Console.WriteLine("Объект A:");
            Console.WriteLine(A);
            Console.WriteLine("A.number="+A.number);
            //присваивание значений свойству number
            A.number = 150;
            Console.WriteLine("A.number="+A.number);
            //индексирование объекта
            for(k=0,s='a';k<A.Length;k++,s++)
            {
                Console.WriteLine("Символ \'{0}\' с кодом {1}", A[k], A[s]);
            }
            A[0] = 'E';
            A['b'] = 'A' + 10;
            //содержимое символьного массива объекта:
            Console.WriteLine(A);
            Bravo B = new Bravo(200, 300, "EFGHI");
            Console.WriteLine("Объект B:");
            Console.WriteLine(B);
            Console.WriteLine("B.number=" + B.number);
            B.number = 400;
            //значение свойства number
            Console.WriteLine("B.number=" + B.number);
            //индексирование объекта
            B['a'] = 10;
            B['d'] = 20;
            Console.WriteLine("B[\'a\']=" + B['a']);
            Console.WriteLine("B[\'b\']=" + B['b']);
            //проверка значения свойства number объекта:
            Console.WriteLine("B.number="+B.number);
            //индексирование объекта
            for(k=0;k<B.Length;k++)
            {
                Console.Write(B[k]+" ");
                B[k] = (char)('a' + k);
            }
            Console.WriteLine();
            Console.WriteLine(B);
        }
    }
    class Alpha
    {
        //защищенное поле
        protected int alpha;
        //закрытый массив
        private char[] symbs;
        //конструктор
        public Alpha(int a, string txt)
        {
            alpha = a;
            //создание массива на основе текстового аргумента:
            symbs = txt.ToCharArray();
        }
        //виртуальное свойство
        public virtual int number
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }
        public int Length
        {
            //аксессор
            get
            {
                return symbs.Length;
            }
        }
        //символьный индексатор с целочисленным индексом:
        public char this[int k]
        {
            get
            {
                return symbs[k];
            }
            set
            {
                symbs[k] = value;
            }
        }
        //виртуальный целочисленный индексатор с символьным индексом:
        public virtual int this[char s]
        {
            get
            {
                //используется индексирование объекта
                return this[s - 'a'];
            }
            set
            {
                this[s - 'a'] = (char)value;
            }
        }
        //переопределение метода ToString()
        public override string ToString()
        {
            string txt = "|";
            for (int k = 0; k < this.Length;k++)
            {
                txt += this[k] + "|";
            }
            return txt;
        }
    }
    class Bravo:Alpha
    {
        protected int bravo;
        public Bravo(int a,int b,string txt):base(a,txt)
        {
            bravo = b;
        }
        //переопределение свойства
        public override int number {
            get
            {
                return alpha + bravo;
            }
        }
        //переопределение индексатора с символьным индексом:
        public override int this[char s]
        {
            get
            {
                if (s == 'a') return alpha;
                else return bravo;
            }
            set
            {
                if (s == 'a') alpha = value;
                else bravo = value;
            }
        }
    }
}
