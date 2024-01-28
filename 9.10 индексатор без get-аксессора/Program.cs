using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_индексатор_без_get_аксессора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString txt = "Муха";
            //проверка
            Console.WriteLine(txt);
            //попытка изменить символ в тексте:
            txt[-1] = 'Ы';
            //проверка
            Console.WriteLine(txt);
            //попытка изменить символ в тексте:
            txt[5] = 'Ъ';
            //проверка
            Console.WriteLine(txt);
            txt[0] = 'С';
            //проверка
            Console.WriteLine(txt);
            txt[1] = 'л';
            //проверка
            Console.WriteLine(txt);
            txt[2] = 'о';
            //проверка
            Console.WriteLine(txt);
            txt[3] = 'н';
            //проверка
            Console.WriteLine(txt);
        }
    }
    //класс
    class MyString
    {
        private string text;
        //конструктор
        public MyString(string t)
        {
            text = t;
        }
        //операторный метод для неявного преобразования
        //текстового значения в объект класса MyString
        public static implicit operator MyString(string t)
        {
            return new MyString(t);
        }
        //переопределение метода ToString()
        public override string ToString()
        {
            return text;
        }
        //символьный индексатор с целочисленным индексом
        public char this[int k]
        {
            set
            {
                //проверка
                if (k < 0 || k > text.Length) return;
                //переменная
                string t = "";
                //добавление символов
                for(int i=0;i<k;i++)
                {
                    t+= text[i];
                }
                t += value;
                for (int i=k+1; i < text.Length; i++)
                {
                    t+= text[i];
                }
                //новое значение текстового поля
                text = t;
            }
        }
    }
}
