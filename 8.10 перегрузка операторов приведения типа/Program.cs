using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._10_перегрузка_операторов_приведения_типа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объектов и проверка результата
            //Явное создание объекта
            MyClass A = new MyClass(100, 'A', "Alpha");
            //неявно вызывается метод toString()
            Console.WriteLine("Объект A. "+A);
            //создание объекта преобразованием из типа int
            MyClass B = 200;
            Console.WriteLine("Объект B. "+B);
            //Создание объекта преобразованием из типа char
            MyClass C = (MyClass)'C';
            Console.WriteLine("Объект C. "+C);
            //создание объекта преобразованием из текста
            MyClass D = "Delta";
            Console.WriteLine("Объект D. "+D);
            Console.WriteLine("Ещё раз поля объекта A:");
            //Явное преобразование в тип Int:
            Console.WriteLine("Число: "+(int)A);
            //явное преобразование в тип char:
            Console.WriteLine("Символ: "+(char)A);
            //явное преобразование в текст:
            Console.WriteLine("Текст: "+(String)A+"\n");
            Console.WriteLine("Разные операции:");
            int n;
            //неявное преобразование к типу int:
            n = A + B;
            Console.WriteLine("Значение A+B="+n);
            //неявное преобразование к типу char:
            char s = B;
            Console.WriteLine("Символ:"+s);
            //последовательное преобразование из текстового
            //типа к типу MyClass, а затем к типу int:
            Console.WriteLine("Число: "+(int)(MyClass)"Echo");
        }
    }
    class MyClass
    {
        public int code;
        public char symb;
        public String text;
        public MyClass(int n,char s,String t)
        {
            code = n;
            symb = s;
            text = t;
        }
        public override String ToString() 
        {
            //локальная текстовая строка
            String txt = "поля объекта:\n";
            txt += "Числовое поле: " + code + "\n";
            txt += "Символьное поле: " + symb + "\n";
            txt += "Текстовое поле: " + text + "\n";
            txt += "-------------------------";
            //результат метода
            return txt;
        }
        //метод для явного приведения к тестового типу:
        public static explicit operator String(MyClass obj)
        {
            return obj.text;
        }
        public static implicit operator char(MyClass obj)
        {
            return obj.symb;
        }
        //метод для неявного приведения к типу int:
        public static implicit operator int(MyClass obj)
        {
            return obj.code;
        }
        //Метод для неявного преобразования из типа int:
        public static implicit operator MyClass(int n)
        {
            MyClass t = new MyClass(n, 'B', "Bravo");
            return t;
        }
        //метод для явного преобразования из типа char
        public static explicit operator MyClass(char s)
        {
            return new MyClass(300, s, "Charlie");
        }
        //метод для неявного преобразования из текстового типа
        public static implicit operator MyClass(String t)
        {
            return new MyClass(t.Length, t[0], t);
        }
    }
}
