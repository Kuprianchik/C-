using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._13_использование_двумерного_индексатора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj= new MyClass();
            //проверка содержимого объекта
            Console.WriteLine(obj);
            //проверка значений элемента
            Console.WriteLine("Значение элемента: " + obj['A',"Первый"]+"\n");
            //проверка содержимого оъекта
            Console.WriteLine(obj);
            obj['B', "Второй"] = 200;
            obj['C', "Третий"] = 300;
            //проверка
            Console.WriteLine(obj);
            Console.WriteLine("Значение элемента: " + obj['B', "Первый"] + "\n");
            Console.WriteLine("Значение элемента: " + obj['B',"Второй"]+"\n");
            Console.WriteLine("Значение элемента: " + obj['A', "Третий"] + "\n");
            //проверка
            Console.WriteLine(obj);
            obj['A', "Первый"] = 100;
            Console.WriteLine(obj);
            //проверка значения элемента
            Console.WriteLine("ЗНачение элемента: " + obj['A',"Первый"]+"\n");
        }
    }
    class MyClass
    {
        private int[] vals;
        private char[] ckey;
        private string[] skey;
        //закрытый метод для добавления новых элементов в массивы
        private void add(char a,string b,int n)
        {
            int size;
            char[] s;
            string[] t;
            int[] v;
            //определение размера новых массивов:
            if(vals==null)
            {
                size = 1;//если массива нет
            }
            else
            {
                size = vals.Length + 1;
                //если есть то добавляем
            }
            //создание текстового массива
            s = new char[size];
            //значение последнего элемента созданного массива
            s[s.Length - 1] = a;
            //создание текстового массива
            t=new string[size];
            t[t.Length - 1] = b;
            //создание целочисленного массива:
            v=new int[size];
            v[v.Length-1]= n;
            //заполнение созданных массивов:
            for(int k=0;k<size-1;k++)
            {
                s[k] = ckey[k];
                t[k] = skey[k];
                v[k] = vals[k];
            }
            //новые значения полей:
            ckey = s;
            skey = t;
            vals = v;
        }
        //переопределение метода ToString()
        public override string ToString()
        {
            //текстовая переменная:
            string txt = "Содержимое объекта:\n";
            //Если массив существует
            if(vals!=null)
            {
                //перебор
                for(int k=0;k<ckey.Length;k++)
                {
                    //добавление текста
                    txt += ckey[k] + ": " + skey[k] + ": " + vals[k] + "\n";

                }
            }
            else
            {
                //добавляем текст
                txt += "Пустой объект\n";
            }
            return txt;
        }
        public int this[char a,string b]
        {
            get
            {
                //если массив существует
                if(vals!=null)
                {
                    for(int k=0;k<ckey.Length;k++)
                    {
                        //если найден
                        if (a == ckey[k] && b == skey[k])
                        {
                            //значение
                            return vals[k];
                        }
                    }
                }
                //код выполняется если массив не существует или элемент не найден
                int res = 0;
                //добавление нового элемента
                add(a, b, res);
                return res;
            }
            set
            {
                //если массив существует
                if(vals!=null)
                {
                    for(int k=0;k<ckey.Length;k++)
                    {
                        if (a == ckey[k] && b == skey[k])
                        {
                            vals[k]=value;
                            return;
                        }
                    }
                }
                add(a, b, value); 
            }
        }
    }
}
