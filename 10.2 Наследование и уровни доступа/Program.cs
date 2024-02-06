using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_Наследование_и_уровни_доступа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha A = new Alpha();
            //вызов метода для присваивания значения
            //целочисленному полю
            A.SetNum(100);
            A.SetSymb('A');
            Console.WriteLine("Объект A: {0} и {1}",A.GetNum(),A.GetSymb());
            //создание объекта производного класса:
            Bravo B = new Bravo();
            //вызов метода для присваивания значения целочисленному полю:
            B.SetNum(200);
            B.SetSymb('B');
            Console.WriteLine("Объект B: {0} и {1}", B.GetNum(), B.GetSymb());
            B.number = 300;
            B.symbol = 'C';
            Console.WriteLine("Объект B: {0} и {1}", B.number, B.symbol);
        }
    }
    //Базовый класс с закрытым и защищенным полем:
    class Alpha
    {
        //закрытое поле
        private int num;
        //защищенное поле
        protected char symb;
        //Открытый метод для считывания значения
        //целочисленного поля:
        public int GetNum()
        {
            return num;
        }
        //Открытый метод для считывания значения
        //символьного поля:
        public char GetSymb()
        {
            return symb;
        }
        //Открытый метод для присваивания значения
        //целочисленному полю:
        public void SetNum(int n) 
        {
            num = n;
        }
        //Открытый метод для присваивания значения
        //символьному полю:
        public void SetSymb(char s)
        {
            symb = s;
        }
    }
    class Bravo:Alpha
    {
        public char symbol
        {
            get
            {
               //обращение с защищенному унаследованному полю:
                return symb;
            }
            set
            {
                //Обращение к защищенному унаследованному полю:
                symb = value;
            }
        }
        //открытое целочисленное свойство
        public int number
        {
            get
            {
                //вызов открытого унаследованного метода
                //возвращающего значение закрытого поля
                //из базового класса:
                return GetNum();
            }
            set
            {
                //вызов открытого унаследованного метода
                //присваения значения закрытому полю
                //из базового класса:
                SetNum(value);
            }
        }
    }
}
